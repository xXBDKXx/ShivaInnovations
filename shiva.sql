create database ShivaInnovations;
use ShivaInnovations;

create table Eventos(
	codigo int auto_increment primary key not null,
    nome varchar(100) not null,
    artistas varchar(100) not null,
    dT date not null,
    hora varchar(45) not null
)Engine=InnoDB;
create table Cliente(
	CPF bigint auto_increment primary key not null,
    Nome varchar(100) not null,
    email varchar(100) not null,
    telefone varchar(14) not null,
	ingressos varchar(100) not null
)Engine=InnoDB;

select * from Cliente;
-- relacionameto
CREATE TABLE EventoCliente(
  idEventoCliente INT NOT NULL AUTO_INCREMENT primary key
)ENGINE = InnoDB;

alter table EventoCliente add cliente_codigo bigint not null;
alter table EventoCliente add codigo_evento int not null;

alter table EventoCliente add constraint evCliente 
foreign key(codigo_evento) references Eventos(codigo);

alter table EventoCliente add constraint clien 
foreign key(cliente_codigo) references Cliente(CPF);
