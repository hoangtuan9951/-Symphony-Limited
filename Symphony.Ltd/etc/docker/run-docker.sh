#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p de47ff55-d243-4d2f-8d1f-93269b3636be -t
    fi
    cd ../
fi

docker-compose up -d
