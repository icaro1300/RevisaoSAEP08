use master
go 
create database AulaScaffoldDB
go
use AulaScaffoldDB
go
create table Pessoa
(
id int identity(1,1) primary key,
nome varchar (200) not null,
idade int not null
) 