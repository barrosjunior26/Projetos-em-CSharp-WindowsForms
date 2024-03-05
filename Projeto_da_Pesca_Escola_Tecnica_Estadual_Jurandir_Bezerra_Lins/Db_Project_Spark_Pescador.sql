--Criando o banco de dados do projeto Pesca
create database Spark

--Criando as tabelas do banco de dados
--Tabela usuário e senha
create table Usuarios_login
(
id int primary key identity,
NOME varchar(100) not null,
CPF varchar(30) not null,
DATA_DE_NASCIMENTO varchar(10) not null,
RG varchar(20) not null,
NACIONALIDADE varchar(60) not null,
RESULTADOSEXO varchar(21) not null,
LOGIN_Funcionario varchar(100) not null,
SENHA_Funcionario char(8)
)

--Tabela Libety_Financiamento
create table Libety_Financiamentos
(
RESUMO_DO_FINANCIAMENTO varchar(2000)
)

--Criando a tabela clientes
create table Cadastro_de_clientes
(
--DADOS DO CLIENTE
CODIGO int primary key identity,
NOME varchar(100) not null,
CPF varchar (20) not null,
NASCIMENTO varchar(20) not null,
RG varchar(15) not null,
EMISSAO_RG varchar(20) not null,
UF_RG varchar(60),
NACIONALIDADE varchar(30),
SEXO varchar (20),
CAPITAL varchar(30),
SIGLA char(2),
REGIAO varchar(30),
DEPENDENTES varchar(30),
LOGRADOURO varchar(60),
NUMERO varchar(5),
COMPLEMENTO varchar(60),
BAIRRO varchar(60),
CEP varchar(20),
ESTADO varchar(60),
UF char(2),
MUNICIPIO varchar(60),
TELEFONE varchar(15),
CELULAR varchar(15),
FAX varchar(60),
EMAIL varchar(100),
RENDA_PRINCIPAL varchar (30),
MEDIA_KG_PRODUTO decimal(7,2),
MEDIA_QTDKG_PESCADO int,
RENDA_BRUTA decimal(7,2),
RENDA_LIQUIDA decimal(7,2),
OUTRAS_FONTES_RENDA varchar(100),
VALOR_OUTRAS_RENDAS decimal(7,2),
DESPESAS_DEPENDENTES varchar(10),
STATUS_FINANCIAMENTO varchar(3000)
)


insert into Usuarios_login (NOME,CPF,DATA_DE_NASCIMENTO,RG,NACIONALIDADE,RESULTADOSEXO, LOGIN_Funcionario, SENHA_Funcionario) values ('Júlio Campos','09246969405','10071992','8429131','Brasil','Feminino','juli12','12345678')

select * from Cadastro_de_clientes
select * from Libety_Financiamentos
select * from Usuarios_login

drop table Libety_Financiamentos


--Adicionando uma coluna do tipo bit e setado todos os funcionários como ativos no sistema
alter table Usuarios_login add StatusFuncionario bit not null default (1)

update Usuarios_login set StatusFuncionario = 0 where id = 5