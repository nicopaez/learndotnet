FROM mcr.microsoft.com/mssql/server:2017-latest

# Create app directory
RUN mkdir -p /usr/app
WORKDIR /usr/app

# copy scripts
COPY . /usr/app/

# Grant permissions for the script to be executable
RUN chmod +x /usr/app/create_db.sh

EXPOSE 1433

ENTRYPOINT ["/bin/bash", "/usr/app/entrypoint.sh"]
