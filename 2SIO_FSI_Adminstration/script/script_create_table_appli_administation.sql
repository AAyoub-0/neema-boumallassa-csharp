CREATE TABLE CLASSES(
   id_cla serial,
   lib_cla VARCHAR(50),
   CONSTRAINT classe_PK PRIMARY KEY(id_cla)
);

CREATE TABLE COURS(
   id_cour serial,
   lib_cour VARCHAR(20) NOT NULL,
   desc_cour VARCHAR(100) NOT NULL,
   id_cla INT NOT NULL,
   CONSTRAINT cours_PK PRIMARY KEY(id_cour),
   CONSTRAINT cours_classe_FK FOREIGN KEY(id_cla) REFERENCES CLASSES(id_cla)
);

CREATE TABLE ETUDIANTS(
   id_etu serial,
   nom_etu VARCHAR(50) NOT NULL,
   pre_etu VARCHAR(50) NOT NULL,
   tel_etu VARCHAR(12) NOT NULL,
   mai_etu VARCHAR(50) NOT NULL,
   id_cla INT NOT NULL,
   CONSTRAINT eleve_PK PRIMARY KEY(id_etu),
   CONSTRAINT eleve_classe_FK FOREIGN KEY(id_cla) REFERENCES CLASSES(id_cla)
);

CREATE TABLE UTILISATEURS(
   id_uti serial,
   log_uti VARCHAR(50) NOT NULL,
   mdp_uti VARCHAR(255) NOT NULL,
   CONSTRAINT utilisateur_PK PRIMARY KEY(id_uti)
);


drop table COURS;
drop table ETUDIANTS;
drop table UTILISATEURS;
drop table CLASSES;

ALTER TABLE COURS drop CONSTRAINT cours_classe_FK,
add CONSTRAINT cours_classe_FK FOREIGN KEY(id_cla) REFERENCES CLASSES(id_cla) ON DELETE SET NULL; //ou cascade

ALTER TABLE ETUDIANTS drop CONSTRAINT eleve_classe_FK,
add CONSTRAINT eleve_classe_FK FOREIGN KEY(id_cla) REFERENCES CLASSES(id_cla) ON DELETE SET NULL;



Alter table COURS ALTER COLUMN id_cla DROP NOT NULL;

Alter table ETUDIANTS ALTER COLUMN id_cla DROP NOT NULL;