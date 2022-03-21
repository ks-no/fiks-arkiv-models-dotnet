pipeline {
    agent any
        parameters {
        booleanParam(defaultValue: false, description: 'Skal branch deployes til dev?', name: 'deployBranchToDev')
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
          steps{
          dir('KS.Fiks.Arkiv.Models') {
            git branch: 'main',
            url: 'https://github.com/ks-no/fiks-arkiv-specification.git'
            
          }
        }
      }
        stage('List'){
        steps {
            sh 'ls -l'
          
          dir("${MODELS_FOLDER}") {
            sh 'ls -l'
          }
          dir("${GENERATOR_FOLDER}"){
            sh 'ls -l'
          }
        }
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
