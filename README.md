# pds-luana2


create database bd_sistEscola;
use  bd_sistEscola;

create table Escola(
id_esc int primary key auto_increment,
nomeFantasia_esc varchar (300) not null,
razaoSocial_esc varchar (255) not null,
cnpj_esc varchar (500) not null,
incs_esc varchar (500) not null,
tipo_esc varchar (100)  not null,
dataCriacao_esc date not null,
resposavel_esc varchar (500) not null,
resposavelTelefone_esc varchar (500) not null,
email_esc varchar (500) not null,
telefone_esc varchar (500) not null,
rua_esc varchar (300) not null,
numero_esc varchar (300) not null,
bairro_esc varchar (300) not null,
complemento_esc varchar (500) not null,
cep_esc varchar (300) not null,
cidade_esc varchar (300) not null,
estado_esc varchar (300) not null
);

select * from Escola;