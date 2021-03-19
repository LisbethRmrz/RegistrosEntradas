
create database entradas;
use entradas;

create table datos (
id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
exp_año varchar(50) not null,
fechain date,
nombre varchar(1000) not null,
apellido varchar(1000) not null,
infracciones varchar(300) not null,
ofendidos varchar(1000),
audienciainicial date,
numpag varchar(10),
observaciones varchar(200)
);

create table usuarios (
id int IDENTITY(1,1) not null,
usuario varchar(50) unique not null,
nombres varchar(50) not null,
apellidos varchar(50) not null,
correo varchar(100) not null,
cargo varchar(50) not null,
contra varchar(50) not null
);


use entradas
create table violencia 
(
id int not null identity(1,1) primary key,
fechain date not null,
n_exp varchar(100) not null,
nombre_victima varchar(1000) not null,
nombre_victimario varchar(1000) not null,
audiencia varchar(50),
fecha_audiencia varchar(1000),
resolucion varchar(1000),
observaciones varchar(1000),
folio varchar(10)
)


select id as [No.], fechain as [Fecha], n_exp as [Expediente], nombre_victima as [Víctima], nombre_victimario as [Victimario], audiencia as [Audiencia], fecha_audiencia as [Fecha Audiencia], resolucion as [Resolución], observaciones as [Observaciones], folio as [Folio] from violencia

insert into violencia (fechain, n_exp, nombre_victima, nombre_victimario, audiencia, fecha_audiencia, resolucion, observaciones, folio)
values ()