Create database ArchivosPlanos

use ArchivosPlanos

create table tbl_Usuario(
IDUser int primary key,
strNombre varchar(80) not null,
strApellido varchar(80) not null,
strCorreo varchar(250) not null,
strUsuario varchar(20) not null,
strPassword varchar(100) not null
)

create table tbl_Registro(
strIdentificacion varchar(15) primary key,
strNombre varchar(80) not null,
strApellido varchar(80) not null,
strTelefono varchar(15) not null,
strCorreo varchar(250) not null,
datFechaNacimiento date
)

Insert into tbl_Usuario (IDUser,strNombre,strApellido,strCorreo,strUsuario,strPassword) values (1000402723,'Santiago','Gomez','santig0703@gmail.com','Santi123','12345')

Select * from  tbl_Usuario
Select * from  tbl_Registro	

--Delete from tbl_Registro where strIdentificacion = '1000302456'
--Delete from tbl_Registro where strIdentificacion = '1232323322'