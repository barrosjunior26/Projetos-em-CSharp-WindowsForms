create database CadastroAlunos

use CadastroAlunos

create table Alunos
(
Id int primary key identity,
Nome varchar(200) not null,
CPF varchar (11) not null,
RG varchar (7) not null,
Ano int not null,
Curso varchar(50) not null,
Cadastramento datetime2,
Observacoes varchar(5000) null,
Protocolo varchar(150) null,
)

select * from Alunos

insert into Alunos (Nome, CPF, RG, Ano, Curso, Cadastramento, Observacoes, Protocolo) values ('Diniz Ribeiro de Barros Júnior',09246969405,8429131,2024,'Analise e Desenvolvimento de Software','02-03-2024 16:43:46','Não há observações até o momento','4e2f94fe4f2ef4eq9fq2')

drop table Alunos