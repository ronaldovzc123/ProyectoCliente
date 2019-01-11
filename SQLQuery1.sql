----creacion de base de datos
create database bd_Cliente
-------creacion de tabla
create table tb_cliente 
(
    ruc numeric(11) not null,
	razonSocial char(100) not null,
	enviar char(200) not null,
	conCopia char(200) not null,
	dias numeric(3) not null,
	agregarGlosa char(100) not null,
	observaciones char(100) not null,
)
------ asignacion de primari key
alter table tb_cliente add primary key (ruc)

-------select de tabla

select * from tb_cliente

