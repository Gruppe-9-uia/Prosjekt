docker run --rm --env "TZ=Europe/Oslo" --name mariadb -p 3308:3306/tcp -v "%cd%\database":/var/lib/mysql -e MYSQL_ROOT_PASSWORD=12345 -d mariadb:10.5.11
docker run --rm --env "TZ=Europe/Oslo"  --name mariadb -e MYSQL_ROOT_PASSWORD=12345 -p 3306:3306  -d docker.io/library/mariadb:10.5.11
GRANT ALL PRIVILEGES ON *.* TO 'root'@'%' IDENTIFIED BY 'root' WITH GRANT OPTION;