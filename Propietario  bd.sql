use db_aad183_vetmanager
go

CREATE TABLE Propietarios
(
IdCliente INT,
Nombre VARCHAR(100),
Apellido VARCHAR(100),
Telefono VARCHAR(50)
)
GO




select * from Propietario
go


Delete from Propietario where IdCliente = 1
Insert  into Propietario (IDCliente,Nombre, Apellido,Telefono)values(1, 'Fernando', 'Escobar', '39473489')

update Propietario set  Nombre = 'Jose' , Apellido = 'Perez', Telefono = '10302040' where IdCliente = 1