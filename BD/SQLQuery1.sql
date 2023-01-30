create database gva1
use gva1
 

create table login
(idadministrador int primary key, 
nombre varchar (25), 
apellido varchar (25), 
contraseña varchar (30),
 rol varchar (15))


insert into login values (1,'jose','sandoval','mostaza2020', 'administrador');
insert into login values (3,'Daniel','Say','fargua', 'cliente');
insert into login values (4,'Javier','Sulecio','say', 'secretaria');
create table datos
( id int primary key,
nombre varchar (30),
apellido varchar(30),
edad int,
telefono varchar (30)) 

select *from login