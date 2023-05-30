#!/usr/bin/env bash
MS=`cat /dev/urandom | tr -dc 'a-zA-Z0-9' | fold -w 32 | head -n 1`
TOKEN=`cat /dev/urandom | tr -dc 'a-zA-Z0-9' | fold -w 64 | head -n 1|base64 -w 0`
sed -i "s/MSPASS/${MS}/g;s/TOKEN/${TOKEN}/g" Docker/docker-compose.yml
sed "s/MSPASS/${MS}/g;s/TOKEN/${TOKEN}/g" appsettings.json > Docker/appsettings.mssql.json
cd Docker && docker compose up -d