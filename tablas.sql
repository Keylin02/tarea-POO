create table libros (
isbn nvarchar(13) primary key,
titulo nvarchar(255),
autor nvarchar(255),
annoPublicacion int,
numeroPaginas int,
);

create table usuarios (
numeroSocio nvarchar(10) primary key,
nombre nvarchar(255),
apellido nvarchar(255),
);

create table prestamos (
id int identity(1,1) primary key,
isbn nvarchar(13),
numeroSocio nvarchar(10),
fechaPrestamo date,
fechaDevolucion date,
foreign key (isbn) references libros(isbn),
foreign key (numeroSocio) references usuarios(numeroSocio),
);


