-- Crear la base de datos
CREATE DATABASE escuela;

-- Seleccionar la base de datos
USE escuela;

-- Crear la tabla de usuarios
CREATE TABLE usuarios (
id INT NOT NULL IDENTITY(1,1),
nombre VARCHAR(50) NOT NULL,
correo VARCHAR(50) NOT NULL,
contraseña VARCHAR(50) NOT NULL,
tipo VARCHAR(50) NOT NULL CHECK (tipo IN ('admin', 'usuario', 'maestro')),
PRIMARY KEY (id)
);


-- Insertar usuarios administradores
INSERT INTO usuarios (nombre, correo, contraseña, tipo)
VALUES ('Juan Rodriguez', 'admin1@example.com', 'password1', 'admin');

INSERT INTO usuarios (nombre, correo, contraseña, tipo)
VALUES ('Danny Martinez', 'admin2@example.com', 'password2', 'admin');

INSERT INTO usuarios (nombre, correo, contraseña, tipo)
VALUES ('Emily Palacio', 'admin3@example.com', 'password3', 'admin');

-- Insertar usuarios normales
INSERT INTO usuarios (nombre, correo, contraseña, tipo)
VALUES ('Jaime Altozano', 'jaime_al@example.com', 'password4', 'usuario');

INSERT INTO usuarios (nombre, correo, contraseña, tipo)
VALUES ('Fernando Aguilar', 'fercho@example.com', 'password5', 'usuario');

INSERT INTO usuarios (nombre, correo, contraseña, tipo)
VALUES ('Christian Ramirez', 'ramirezcris@example.com', 'password6', 'usuario');

-- Insertar maestros normales
INSERT INTO usuarios (nombre, correo, contraseña, tipo)
VALUES ('Nodal cantante', 'maestro1@example.com', 'password7', 'maestro');

INSERT INTO usuarios (nombre, correo, contraseña, tipo)
VALUES ('El Magico', 'maestro2@example.com', 'password8', 'maestro');


-- Agregar una columna de usuario_id a las tablas de alumnos y profesores
ALTER TABLE alumnos ADD usuario_id INT;
ALTER TABLE profesores ADD usuario_id INT;

-- Agregar una clave foranea a la columna usuario_id en las tablas de alumnos y profesores
ALTER TABLE alumnos ADD FOREIGN KEY (usuario_id) REFERENCES usuarios(id);
ALTER TABLE profesores ADD FOREIGN KEY (usuario_id) REFERENCES usuarios(id);

-- Crear la tabla de alumnos
CREATE TABLE alumnos (
id INT NOT NULL IDENTITY(1,1),
nombre VARCHAR(50) NOT NULL,
correo VARCHAR(50) NOT NULL,
carrera VARCHAR(50) NOT NULL,
PRIMARY KEY (id)
);

-- Crear la tabla de profesores
CREATE TABLE profesores (
id INT NOT NULL IDENTITY(1,1),
nombre VARCHAR(50) NOT NULL,
correo VARCHAR(50) NOT NULL,
departamento VARCHAR(50) NOT NULL,
PRIMARY KEY (id)
);

-- Crear la tabla de inscripciones
CREATE TABLE inscripciones (
id INT NOT NULL IDENTITY(1,1),
alumno_id INT NOT NULL,
profesor_id INT NOT NULL,
fecha_inscripcion DATE NOT NULL,
PRIMARY KEY (id),
FOREIGN KEY (alumno_id) REFERENCES alumnos(id),
FOREIGN KEY (profesor_id) REFERENCES profesores(id)
);

-- Crear la tabla de notas
CREATE TABLE notas (
id INT NOT NULL IDENTITY(1,1),
inscripcion_id INT NOT NULL,
nota FLOAT NOT NULL,
PRIMARY KEY (id),
FOREIGN KEY (inscripcion_id) REFERENCES inscripciones(id)
);

CREATE PROCEDURE sp_login
    @correo VARCHAR(50),
    @contrasena VARCHAR(50)
AS
BEGIN
    SELECT id, nombre, tipo
    FROM usuarios
    WHERE correo = @correo AND contraseña = @contrasena
END

SELECT * FROM alumnos

INSERT INTO inscripciones (alumno_id, profesor_id, fecha_inscripcion) VALUES
(1, 1, '2023-05-01'),
(2, 3, '2023-05-02'),
(3, 2, '2023-05-03'),
(4, 4, '2023-05-04'),
(5, 1, '2023-05-05'),
(6, 5, '2023-05-06'),
(7, 4, '2023-05-07'),
(8, 3, '2023-05-08'),
(9, 2, '2023-05-09'),
(10, 1, '2023-05-10');

INSERT INTO notas (inscripcion_id, nota) VALUES
(1, 90),
(2, 85),
(3, 78),
(4, 92),
(5, 88),
(6, 95),
(7, 83),
(8, 79),
(9, 87),
(10, 91);

SELECT n.id AS nota_id, n.inscripcion_id, n.nota, i.fecha_inscripcion
FROM notas n
INNER JOIN inscripciones i ON n.inscripcion_id = i.id
INNER JOIN alumnos a ON i.alumno_id = a.id
WHERE a.nombre = 'Juan Perez';
