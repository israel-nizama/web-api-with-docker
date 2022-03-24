# web-api-with-docker
Demo to deploy a web API in a local development environment

Este repositorio contiene una aplicación backend en .Net Core 5.0 de ejemplo con conección a una base de datos MSSQL 2019 que simula un microservicio que expone un Web API con un solo endpoint en la ruta **/WeatherForecast** y su documentación swagger en la ruta **/swagger**.

## Dockerfiles

### /WebAPIWithDocker/Dockerfile
Contiene las instrucciones para generar la imagen para la aplicación backend .Net Core 5.0. Este dockerfile es usado por el archivo docker-compose.yml para desplegar la aplicación backend en un ambiente de desarrollo local.

### /dbDockerfile
Contiene las instrucciones para generar la imagen de la base de datos MSSQL 2019. Este dockerfile es usado por el archivo docker.compose.yml para desplegar la base de datos en un ambiente de desarrollo local.

### /docker-compose.yml
Archivo en formato YAML que describe la solución que despliega los contenedores para la aplicación backend y la base de datos que usa. Para ejecuar este archivo usar las siguientes instrucciones.

Para construir la imagenes ejecutar los contenedores:
> $ docker-compose up -d

Para detener los contenedore:
> $ docker-compose down
