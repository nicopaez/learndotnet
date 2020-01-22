#wait for the SQL Server to come up
sleep 30s

#run the setup script to create the DB
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Passw@rd1 -d master -i /usr/app/create_db.sql

