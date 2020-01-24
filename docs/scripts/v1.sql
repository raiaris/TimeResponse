create table Pessoa (
	Id int not null auto_increment,
	Nome varchar(100) not null,
	Cpf varchar(14) not null,
	primary key (Id)
);

insert into Pessoa (Nome, Cpf) values ("João das Neves", "111.222.333-44");
insert into Pessoa (Nome, Cpf) values ("Daniela Tangerina", "555.666.777-88");
insert into Pessoa Values (3, "Larissa Silva", "131.5295.96-21");

create table Usuario (
	Id int not null auto_increment,
	Nome varchar(40) not null,
	Email varchar(120) not null,
	Senha varchar(200) not null,
	primary key(Id)
);

create table pessoa_usuario(
	pes_id int not null,
	usu_id int not null,
	primary key (pes_id, usu_id)
);

delete from Pessoa;

alter table pessoa_usuario add constraint fk_r_01 foreign key(pes_id)
	references Pessoa(id) on delete restrict on update restrict;

alter table pessoa_usuario add constraint fk_r_02 foreign key(usu_id)
	references Usuario(id) on delete restrict on update restrict;

select * from Pessoa;

insert into pessoa_usuario values (10, 3);

insert into usuario (Nome, Email, Senha) values ("cmdrlias", "cmdrlias@gmail.com", "@CC159*0cc");
insert into usuario (Nome, Email, Senha) values ("joaodasneves", "jonsnow@gmail.com", "knowsnothing123");
insert into usuario (Nome, Email, Senha) values ("danytan", "daenerys@gmail.com", "dracarys0");


SELECT pu.usu_id, u.Nome, u.Email FROM pessoa_usuario as pu JOIN Pessoa as p ON p.Id = pu.pes_id JOIN Usuario as u ON u.Id = pu.usu_id; 

SELECT pu.usu_id, u.Nome, u.Email FROM pessoa_usuario as pu JOIN Pessoa as p ON p.Id = pu.pes_id JOIN Usuario as u ON u.Id = pu.usu_id WHERE pu.pes_id = 3;
