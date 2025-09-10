CREATE TABLE Nacionalidad (
	id int not null primary key,
	descripcion nvarchar(100) not null,
	status nvarchar(20) not null default 'Active'
);

CREATE TABLE Profesion (
	id int not null primary key,
	descripcion nvarchar(100) not null,
	status nvarchar(20) not null default 'Active'
);

CREATE TABLE Persona (
	nro_persona int not null primary key,
	nombre nvarchar(50) not null,
	apellido nvarchar(50) not null,
	fecha_nacimiento datetime not null,
	sexo nvarchar(10) not null,
	id_profesion int not null,
	id_nacionalidad int not null,
	status nvarchar(20) not null default 'Active',
	foreign key (id_profesion) references Profesion(id),
	foreign key (id_nacionalidad) references Nacionalidad(id)
)

CREATE UNIQUE INDEX idx_profesion_descripcion ON Profesion(descripcion);
CREATE UNIQUE INDEX idx_nacionalidad_descripcion ON Nacionalidad(descripcion);