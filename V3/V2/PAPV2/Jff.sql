use master
go
drop database Jff
go
create database Jff
go
use Jff
go


create table utilizador( 
id_utilizador int identity(1,1) primary key, 
nome varchar(100), 
username varchar(100), 
pass varchar(100),
Numtelemovel varchar(9),
Morada varchar (100),

) 

create table firstrun( 
estado int,

) 
insert into firstrun values(0) 

CREATE TABLE Nome_Categorias(
id_categoria int  not null identity(1,1) primary key,
nome_categoria varchar(12)
)

CREATE TABLE Compo_Categorias(
id_categoria int primary key,
Compo_categoria varchar(255)
)
create table amigo ( 

id_amigo int identity(1,1) primary key, 

foto_amigo varchar(250), 

nome_amigo varchar(100), 

nif_amigo varchar (11), 

data_nasc_amigo varchar(12), 

telemovel_amigo varchar(11), 

email_amigo varchar(100), 

nick_amigo varchar(100)) 

 

--------------------------------------------------------------------------------- 

create table Marca( 

id_marca int not null identity(1,1) primary key, 

designacao varchar(200)) 

---------------------------------------------------------------------------------------- 

 

create table Componente( 

id_componente int not null identity(1,1) primary key, 

descricao varchar(200)) 

 

---------------------------------------------------------------------------------------- 

 

create table Estado( 

id_estado int not null identity(1,1) primary key, 

denominacao varchar(200)) 

---------------------------------------------------------------------------------------- 

 

create table Equipamento( 

id_equipamento int Not Null identity(1,1)primary key, 

nome_ varchar(100), 

descricao_equipamento varchar(500), 

data_lancamento varchar(15), 

data_aquisicao varchar(15), 

cod_componente int foreign key references Componente(id_componente), 

cod_marca int foreign key references Marca(id_marca), 

cod_estado int foreign key references Estado(id_estado), 

preco decimal(6,2)) 

--------------------------------------------------------------------------------- 

 

create table emprestimo( 

id_emprestimo int Not Null identity(1,1)primary key, 

cod_equipamento int foreign key references Equipamento(id_equipamento), 

cod_amigo int foreign key references amigo(id_amigo), 

data_emprestimo varchar(15)) 

 

--------------------------------------------------------------------------------- 

 



--INSERT INTO Compo_Categorias Values(1,'Caixas'),
--(2,'Fontes de Alimentação'),
--(3,'Placas de Captura'),
--(4,'placas de Som'),
--(5,'Drives Ópticas'),
--(6,'Processadores'),
--(7,'Discos'),
--(8,'Memórias '),
--(9,'Motherboards'),
--(10,'Placas Gráficas')
--
--select *from utilizador