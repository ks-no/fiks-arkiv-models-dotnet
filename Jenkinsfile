pipeline {
    agent any
    parameters {
        booleanParam(defaultValue: false, description: 'Skal prosjektet releases?', name: 'isRelease')
        string(name: "specifiedVersion", defaultValue: "", description: "Hva er det nye versjonsnummeret (X.X.X)? Som default releases snapshot-versjonen")
        text(name: "releaseNotes", defaultValue: "Ingen endringer utført", description: "Hva er endret i denne releasen?")
        text(name: "securityReview", defaultValue: "Endringene har ingen sikkerhetskonsekvenser", description: "Har endringene sikkerhetsmessige konsekvenser, og hvilke tiltak er i så fall iverksatt?")
        string(name: "reviewer", defaultValue: "Endringene krever ikke review", description: "Hvem har gjort review?")
    }
    environment {
        MODELS_FOLDER = 'KS.Fiks.Arkiv.Models'
        GENERATOR_FOLDER = 'KS.Fiks.Arkiv.XsdModelGenerator'
    }
    stages {
        stage('Initialize') {
            steps {
                script {
                    env.GIT_SHA = sh(returnStdout: true, script: 'git rev-parse HEAD').substring(0, 7)
                    env.REPO_NAME = scm.getUserRemoteConfigs()[0].getUrl().tokenize('/').last().split("\\.")[0]
                    env.CURRENT_VERSION = findVersionSuffix()
                    env.NEXT_VERSION = params.specifiedVersion == "" ? incrementVersion(env.CURRENT_VERSION) : params.specifiedVersion
                    if(params.isRelease) {
                      env.VERSION_SUFFIX = ""
                      env.BUILD_SUFFIX = ""
                      env.FULL_VERSION = env.CURRENT_VERSION
                    } else {
                      def timestamp = getTimestamp()
                      env.VERSION_SUFFIX = "build.${timestamp}"
                      env.BUILD_SUFFIX = "--version-suffix ${env.VERSION_SUFFIX}"
                      env.FULL_VERSION = "${CURRENT_VERSION}-${env.VERSION_SUFFIX}"
                    }
                    print("Listing all environment variables:")
                    sh 'printenv'
                }
            }
        }
        stage('Fetch specification') {
          steps { 
            dir('temp') {
              git branch: 'main',
              url: 'https://github.com/ks-no/fiks-arkiv-specification.git'
              stash(name: 'xsd', includes: 'Schema/V1/*')
            }
          }
          post {
            always {
              deleteDir()
            }
          }
        }
        stage('Generate models') {
          agent {
            docker {
              image "docker-all.artifactory.fiks.ks.no/dotnet/sdk:6.0"
              args '-v $HOME/.nuget:/.nuget -v $HOME/.dotnet:/.dotnet'  
            }
          }
          steps {
            dir("${GENERATOR_FOLDER}") {
              unstash 'xsd'
              sh 'dotnet run Schema/V1 output'
              stash(name: 'generated', includes: 'output/**')
            }
          }
          post {
            always {
              deleteDir()
             }
          }     
        }
        stage('Unfold artifacts') {
          steps {
            dir("unfold") {
              unstash 'generated'
              sh 'mv output/* .'
              sh 'rm -r output'
              stash(name: 'models', includes: '**')
            }
          }
          post {
            always {
              deleteDir()
             }
          }  
        }
        stage('Build') {
          environment {
            NUGET_HTTP_CACHE_PATH = "${env.WORKSPACE + '@tmp/cache'}"
            NUGET_CONF = credentials('nuget-config')
          }
          agent {
            docker {
              image "docker-all.artifactory.fiks.ks.no/dotnet/sdk:6.0"
              args '-v $HOME/.nuget:/.nuget -v $HOME/.dotnet:/.dotnet'     
            }
          }
          steps {
            dir("${MODELS_FOLDER}") {
              sh 'mkdir -p /.nuget/NuGet'
              sh 'cp -f $NUGET_CONF ~/.nuget/NuGet/NuGet.Config'
              unstash 'xsd'
              unstash 'models'
              sh 'dotnet restore --configfile ${NUGET_CONF}'
              sh 'dotnet build --no-restore -c Release ${BUILD_SUFFIX}'
              sh 'mv **/Release/*.nupkg .'
              sh 'mv **/Release/*.snupkg .'
              stash(name: 'builtnupkg', includes: '*.nupkg')
              stash(name: 'builtsnupkg', includes: '*.snupkg')
            }
          }
          post {
            always {
              deleteDir()
            }
          }
        }
        stage('Sign package') {
          environment {
            NUGET_HTTP_CACHE_PATH = "${env.WORKSPACE + '@tmp/cache'}"
            CODE_SIGN_CERT = credentials('ks-codesign-combo')
            CODE_SIGN_KEY = credentials('ks-codesign-combo-passwd')
            TIMESTAMP_URL = 'http://timestamp.digicert.com'
          }
          agent {
            docker {
              image "docker-all.artifactory.fiks.ks.no/dotnet/sdk:6.0"
              args '-v $HOME/.nuget:/.nuget -v $HOME/.dotnet:/.dotnet'     
            }
          }          
          steps {
            dir("tmpsign") {
              unstash 'builtnupkg'
              sh 'dotnet nuget sign *.nupkg --timestamper ${TIMESTAMP_URL} --certificate-path ${CODE_SIGN_CERT} --certificate-password ${CODE_SIGN_KEY}'
              stash(name: 'signednupkg', includes: '*.nupkg')
            }
          }
          post {
            always {
              deleteDir()
            }     
          }
        }
        stage('Push to Artifactory') {
          environment {
            NUGET_HTTP_CACHE_PATH = "${env.WORKSPACE + '@tmp/cache'}"
            NUGET_ACCESS_KEY = credentials('artifactory-token-based')
            NUGET_PUSH_REPO = 'https://artifactory.fiks.ks.no/artifactory/api/nuget/nuget-all'
          }
          agent {
            docker {
              image "docker-all.artifactory.fiks.ks.no/dotnet/sdk:6.0"
              args '-v $HOME/.nuget:/.nuget -v $HOME/.dotnet:/.dotnet'     
            }
          }          
          steps {
            dir("tmppush") {
              unstash 'signednupkg'
              unstash 'builtsnupkg'
              sh 'dotnet nuget push *.nupkg -k ${NUGET_ACCESS_KEY} -s ${NUGET_PUSH_REPO}'
            }
          }
          post {
            always {
              deleteDir()
            }
          }                      
        }
        stage('Push to nuget.org') {
          when {
            anyOf {
              expression { params.isRelease }
            }
          }
          environment {
            NUGET_ACCESS_KEY = credentials('ks-nuget-api-key')
            NUGET_PUSH_REPO = 'https://api.nuget.org/v3/index.json'
          }
          steps {
            dir("tmpnuget") {
              unstash 'signednupkg'
              unstash 'builtsnupkg'
              sh 'dotnet nuget push *.nupkg -k ${NUGET_ACCESS_KEY} -s ${NUGET_PUSH_REPO}'
            }
          }
          post {
            always {
              deleteDir()
            }
          }
        }
        stage('Set next version and push') {
          when {
            allOf {
              expression { params.isRelease }
              expression { return env.NEXT_VERSION }
              expression { return env.CURRENT_VERSION }
            }
          }
          steps {
            gitCheckout(env.BRANCH_NAME)
            gitTag(isRelease, env.CURRENT_VERSION)
            prepareDotNetNoBuild(env.NEXT_VERSION)
            gitPush()
            script {
              currentBuild.description = "${env.user} released version ${env.CURRENT_VERSION}"
            }
            withCredentials([usernamePassword(credentialsId: 'Github-token-login', passwordVariable: 'GITHUB_KEY', usernameVariable: 'USERNAME')]) {
                sh "~/.local/bin/http --ignore-stdin -a ${USERNAME}:${GITHUB_KEY} POST https://api.github.com/repos/ks-no/${env.REPO_NAME}/releases tag_name=\"${env.CURRENT_VERSION}\" body=\"Release utført av ${env.user}\n\n## Endringer:\n${params.releaseNotes}\n\n ## Sikkerhetsvurdering: \n${params.securityReview} \n\n ## Review: \n${params.reviewer == 'Endringene krever ikke review' ? params.reviewer : "Review gjort av ${params.reviewer}"}\""
            }
          }
        }
    } 
  post {
    always {
      deleteDir()
      }
    }
}

def findVersionSuffix() {
  def findCommand = $/find -name "**\KS.Fiks.Arkiv.Models.csproj" -exec xpath '{}' '/Project/PropertyGroup/VersionPrefix/text()' \;/$

  def version = sh(script: findCommand, returnStdout: true, label: 'Lookup current version from csproj files').trim().split('\n').find {
    return it.trim().matches(versionPattern())
  }
  println("Version found: ${version}")
  return version
}

def incrementVersion(versionString) {
    def p = versionPattern()
    def m = p.matcher(versionString)
    if(m.find()) {
        def major = m.group(1) as Integer
        def minor = m.group(2) as Integer
        def patch = m.group(3) as Integer
        return "${major}.${minor}.${++patch}"
    } else {
        return null
    }
}

def versionPattern() {
  println('version pattern')
  return java.util.regex.Pattern.compile("^(\\d+)\\.(\\d+)\\.(\\d+)(.*)?")
}

def getTimestamp() {
  println('timestamp')
  return java.time.OffsetDateTime.now().format(java.time.format.DateTimeFormatter.ofPattern("yyyyMMddHHmmssSSS"))
}