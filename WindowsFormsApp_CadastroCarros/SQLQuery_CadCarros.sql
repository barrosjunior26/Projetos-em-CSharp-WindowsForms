create database CadCarros

use CadCarros

create table Cadastro
(
Codigo int primary key identity,
Marca varchar (50),
Modelo varchar (70),
Cor varchar (50),
Potencia varchar (20)
)

insert into Cadastro (Marca, Modelo, Cor, Potencia) values ('Hyundai','Azera 2015','Prata','250 cavalos')
insert into Cadastro (Marca, Modelo, Cor, Potencia) values ('Hyundai','Vera Cruz 2010','Prata','280 cavalos')

select * from Cadastro
