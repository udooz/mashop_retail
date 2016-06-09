FROM fsharp/fsharp:latest

COPY ./bin/Debug /app

EXPOSE 8083

WORKDIR /app

CMD ["mono", "CatalogAPI.exe"]
