@echo off

:: Kill running instance of container
docker kill prosjekt

:: Builds image specified in Dockerfile
docker image build -t prosjekt .

:: Starts container with web application and maps port 443 (ext) to 80 (internal)
docker container run --rm -it -d --name Prosjekt --publish 80:80 Prosjekt

echo.
echo "Link: http://localhost:80/"
echo.

pause
