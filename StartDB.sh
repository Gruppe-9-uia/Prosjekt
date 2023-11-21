#!/bin/bash

#Run MariaDB container with specified timezone and root password, and map the ports.
#The first container is mapped to port 3308, and the second to the default port 3306.
docker run --rm --env "TZ=Europe/Oslo" --name mariadb -p 3308:3306/tcp -v "$(pwd)/database":/var/lib/mysql -e MYSQL_ROOT_PASSWORD=12345 -d mariadb:latest

#Wait for a few seconds to ensure MariaDB is up and ready to accept connections.
echo "Waiting for MariaDB to initialize..."
sleep 15

#Execute the GRANT statement inside the MariaDB container. Adjust as necessary for your use case.
#Note that this command is run against the first container (mariadb_custom_port), you can change it to mariadb_default_port if needed.
docker exec mariadb mysql -uroot -p 12345 -e "GRANT ALL PRIVILEGES ON . TO 'root'@'%' IDENTIFIED BY '12345' WITH GRANT OPTION;"

echo "MariaDB containers are running, and privileges have been granted."