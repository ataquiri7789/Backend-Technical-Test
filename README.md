# Backend-Technical-Test
Reto

Para poder probar la solución,  deben tener las siguientes consideraciones:

# 1. CLONE GIT

- Clonar desde la rama master
- git clone -b master https://github.com/ataquiri7789/Backend-Technical-Test.git

# 2. INSTALL DOCKER

- Instalar docker
- Descargar SQLServer: docker pull mcr.microsoft.com/mssql/server:2019-latest
- Crear una carpeta en el disco C: "C:\docker".
- Guardar con volumen: docker run -e "ACCEPT_EULA=Y" --network bridge -v c:/docker/sqlserver/data:/var/opt/mssql/data -v c:/docker/sqlserver/log:/var/opt/mssql/log -v c:/docker/sqlserver/secrets:/var/opt/mssql/secrets -e "SA_PASSWORD=Testing34#" -p 1433:1433 --name sql-database -d mcr.microsoft.com/mssql/server:2019-latest


# 3. Restore BD and Tables

- Restaurar el archivo dbo.sql


# 4. Solutions

- SOLUCIÓN ManagePromotions: API Desarrollada en NET Core 5 - Arquitectura N Capas

- SOLUCIÓN Promotions.Web: Desarrollada en NET MVC Core 5 - Arquitectura N Capas


# 5. Considerations

- Primero ejecutar el proyecto API "ManagePromotions".
- Finalmente ejecutar el proyecto "Promotions.Web".





Muchas gracias por su tiempo.

Saludos.

