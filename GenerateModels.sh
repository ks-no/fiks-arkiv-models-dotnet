#!/bin/bash

GENERATOR_PATH=KS.Fiks.Arkiv.XsdModelGenerator
MODELS_PATH=../KS.Fiks.Arkiv.Models.V1
SCHEMA_PATH=../Schema/V1

cd $GENERATOR_PATH

dotnet run $SCHEMA_PATH $MODELS_PATH