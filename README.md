# Prosjekt

## Hvordan man starter prosjektet

### Windows

1. kjører build.cmd
2. kjører startdb.cmd
3. Åpne terminalen og kjører "docker exec -it mariadb /bin/bash"
4. skriv apt-get update
5. skriv apt-get install mysql-client -y
6. dermed skriv exit
7. Skriv og kjør "docker exec -it mariadb mysql -p -uroot"
8. Skriv passord of da har man til gang for å danne database
9. Connect database i jetbrains med følge informasjon:
   1.Database=ProsjektDB
   2.Port=3308
11. Tilsutt kjører dockerfile i jetbrains

### Mac

1. kjører build.csh 
2. kjører startdb.sh
7. Skriv og kjør "docker exec -it mariadb mysql -p -uroot" i terminalen
8. Skriv passord of da har man til gang for å danne database
9. Connect database i jetbrains med følge informasjon:
   1.Database=ProsjektDB
   2.Port=3308
11. Tilsutt kjører dockerfile i jetbrains

