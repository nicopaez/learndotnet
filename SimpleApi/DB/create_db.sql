CREATE DATABASE simple;
GO

CREATE LOGIN [appuser] WITH PASSWORD = 'Passw@rd1';
GO

CREATE USER [appuser] FOR LOGIN [appuser] WITH DEFAULT_SCHEMA=[dbo]
GO

GRANT ALL ON simple TO [appuser];
GO