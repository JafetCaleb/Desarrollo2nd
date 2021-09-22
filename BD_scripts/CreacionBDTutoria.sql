-- Docente
create table Tutor(
	CodTutor			char(3),
	Nombres				varchar(30) not null,
	Apellido_Paterno	varchar(30) not null,
	Apellido_Materno	varchar(30) not null,
	Situacion			varchar(10) check (Situacion in('Contratado','Nombrado')),
	Contraseña			varbinary(50) not null,
	Pregunta			varchar(max),
	Respuesta			varchar(max),
	Estado				varchar(10) check (Estado in('Activo','Inactivo')),
	PRIMARY KEY (CodTutor)
);
go
create table Alumno(
	CodAlumno			char(6),
	Nombres				varchar(30) not null,
	Apellido_Paterno	varchar(30) not null,
	Apellido_Materno	varchar(30) not null,
	Situacion			varchar(10) check (Situacion in('Riesgo','No Riesgo')),
	CodTutor			char(3),
	Contraseña			varbinary(50)not null,
	Pregunta			varchar(max),
	Respuesta			varchar(max),
	Estado				varchar(10) check (Estado in('Activo','Inactivo')),
	PRIMARY KEY (CodAlumno),
	foreign key (CodTutor) references Tutor(CodTutor)
);
go
create table Administrador(
	CodAdministrador	char(8),
	Nombres				varchar(30) not null,
	Apellido_Paterno	varchar(30) not null,
	Apellido_Materno	varchar(30) not null,
	Contraseña			varbinary(50) not null,
	Pregunta			varchar(max),
	Respuesta			varchar(max),
	PRIMARY KEY (CodAdministrador)
);
insert into Administrador
values ('77173513','Jafet Caleb','Rojas','Garay',convert(varbinary,'77173513'),null,null)
go
create table FichaTutoria(
	CodTutor			char(3)not null,
	CodAlumno			char(6)not null,
	CodFicha			as CodTutor+CodAlumno PERSISTED NOT NULL,
	Celular				varchar(9),	
	Direccion			varchar(max),	
	Email				varchar(max),
	PRIMARY KEY (CodFicha),
	foreign key (CodTutor) references Tutor(CodTutor),
	foreign key (CodAlumno) references Alumno(CodAlumno)
);
go
create table ActividadTutoria(
	CodFicha			char(9) not null,
	Numero				int not null,
	CodActividad		as CodFicha+'-'+convert(varchar,Numero) PERSISTED NOT NULL,
	Fecha				datetime not null,
	Tipo_Tutoria		varchar(50),
	Descripcion			varchar(max),
	Referencia			varchar(max),
	Observaciones		varchar(max),
	
	PRIMARY KEY (CodActividad),
	foreign key (CodFicha) references FichaTutoria(CodFicha)
);
go