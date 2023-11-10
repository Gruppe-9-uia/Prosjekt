#!/bin/bash

docker kill prosjekt

docker image build -t prosjekt .

docker container run --rm -it -d --name Prosjekt --publish 80:80 Prosjekt

echo.
echo "Link: http://localhost:80/"
echo.

pause