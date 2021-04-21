

DROP DATABASE IF EXISTS ppeVilliers;
CREATE DATABASE ppeVilliers;
use ppeVilliers;

CREATE TABLE participant (
  idp int(11) NOT NULL,
  nom varchar(128) NOT NULL,
  prenom varchar(128) NOT NULL,
  departement varchar(11) NOT NULL,
  email varchar(128) NOT NULL,
  primary key(idp)
);



INSERT INTO participant VALUES
(1, 'Lopez', 'Dana', '92', 'dana@g.com'),
(2, 'Gonzales', 'Paola', '56', 'paola@gmail.com'),
(7, 'Perez', 'Roy', '78', 'roy.k@moniris.com'),
(8, 'Sanchez', 'Otilia', '92', 'sanchez@moniris.com');

CREATE TABLE salon (
  ids int(11) NOT NULL,
  nom varchar(128) NOT NULL,
  date_debut date NOT NULL,
  date_fin date NOT NULL,
  lieu varchar(128) NOT NULL,
  primary key(ids)
);



INSERT INTO  salon VALUES
(4, 'Salon de la culture', '2021-04-10', '2021-04-11', 'Centre culturelle du centre ville'),
(5, 'Salon de la jeunesse', '2021-05-17', '2021-05-23', 'Versailles'),
(7, 'Exposition de la Barbacane', '2021-06-08', '2021-06-15', 'Mairie de Villiers '),
(8, 'Salon des beaux arts ', '2021-04-18', '2021-04-25', 'Place de Villiers-sur-Marne');


CREATE TABLE users (
  idu int not null,
  username varchar(128) NOT NULL,
  pass varchar(128) NOT NULL,
  Role int(1) NOT NULL, 
  primary key(idu)
);

INSERT INTO users  VALUES
(1,'admin', 'admin', 1),
(2,'operateur', 'operateur', 0);

CREATE TABLE participer (
  idp int,
  ids int,
  primary key(idp,ids),
  foreign key(idp) references participant(idp),
  foreign key(ids) references salon(ids)
);

INSERT INTO participer VALUES
(1, 5);

