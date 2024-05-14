use master;
go
drop database if exists testWP4;
go
create database testWP4;
go

use testWP4;


create table test(
sifra int not null primary key identity(1,1),
ime varchar(20) not null,
prezime varchar(20) not null,
oib char(11) not null
);