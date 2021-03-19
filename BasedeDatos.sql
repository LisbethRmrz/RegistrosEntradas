create database entradas;
use entradas;

create table datos (
id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
exp_año varchar(50) unique not null,
fechain date,
nombre varchar(50) not null,
apellido varchar(50) not null,
infracciones varchar(30) not null,
ofendidos varchar(200),
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

select id as [No.], usuario as [Usuario], nombres as [Nombre], apellidos  as [Apellidos], correo as [Correo], cargo as [Cargo], contra as [Contraseña] from usuarios
select exp_año as [Expediente y Año], fechain as [Fecha Entrada], nombre as [Nombre], apellido as [Apellido], infracciones as [Infracciones], ofendidos as [Ofendidos], audienciainicial as [Audiencia Inicial], observaciones as [Observaciones] from datos