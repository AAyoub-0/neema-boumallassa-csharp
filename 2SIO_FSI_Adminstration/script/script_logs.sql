CREATE TABLE log_classes (
    log_id SERIAL PRIMARY KEY,
    log_timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    log_action TEXT NOT NULL,
    class_id INTEGER NOT NULL,
    class_name TEXT NOT NULL
);

CREATE TABLE log_cours (
    log_id SERIAL PRIMARY KEY,
    log_timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    log_action TEXT NOT NULL,
    cours_id INTEGER NOT NULL,
    cours_name TEXT NOT NULL,
    class_id INTEGER,
    old_values JSONB,
    new_values JSONB
);

CREATE TABLE log_etudiants (
    log_id SERIAL PRIMARY KEY,
    log_timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    log_action TEXT NOT NULL,
    etudiant_id INTEGER NOT NULL,
    etudiant_nom TEXT NOT NULL,
    etudiant_prenom TEXT NOT NULL,
    telephone_etudiant TEXT,
    old_values JSONB,
    new_values JSONB
);

CREATE TABLE log_utilisateurs (
    log_id SERIAL PRIMARY KEY,
    log_timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    log_action TEXT NOT NULL,
    utilisateur_id INTEGER NOT NULL,
    utilisateur_nom TEXT NOT NULL,
    utilisateur_mot_de_passe TEXT NOT NULL
);


//fonctions 

CREATE OR REPLACE FUNCTION log_classes_changes()
RETURNS TRIGGER AS $$
BEGIN
    IF (TG_OP = 'INSERT') THEN
        INSERT INTO log_classes (log_action, class_id, class_name)
        VALUES ('INSERT', NEW.id_cla, NEW.lib_cla);
        RETURN NEW;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO log_classes (log_action, class_id, class_name)
        VALUES ('UPDATE', NEW.id_cla, NEW.lib_cla);
        RETURN NEW;
    ELSIF (TG_OP = 'DELETE') THEN
        INSERT INTO log_classes (log_action, class_id, class_name)
        VALUES ('DELETE', OLD.id_cla, OLD.lib_cla);
        RETURN OLD;
    END IF;
    RETURN NULL;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE TRIGGER log_classes_trigger
AFTER INSERT OR UPDATE OR DELETE ON classes
FOR EACH ROW
EXECUTE FUNCTION log_classes_changes();


CREATE OR REPLACE FUNCTION log_cours_changes()
RETURNS TRIGGER AS $$
BEGIN
    IF (TG_OP = 'INSERT') THEN
        INSERT INTO log_cours (log_action, cours_id, cours_name, class_id)
        VALUES ('INSERT', NEW.id_cour, NEW.lib_cour, NEW.id_cla);
        RETURN NEW;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO log_cours (log_action, cours_id, cours_name, class_id, old_values, new_values)
        VALUES ('UPDATE', NEW.id_cour, NEW.lib_cour, NEW.id_cla, 
                row_to_json(OLD), row_to_json(NEW));
        RETURN NEW;
    ELSIF (TG_OP = 'DELETE') THEN
        INSERT INTO log_cours (log_action, cours_id, cours_name, class_id, old_values)
        VALUES ('DELETE', OLD.id_cour, OLD.lib_cour, OLD.id_cla, row_to_json(OLD));
        RETURN OLD;
    END IF;
    RETURN NULL;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE TRIGGER log_cours_trigger
AFTER INSERT OR UPDATE OR DELETE ON cours
FOR EACH ROW
EXECUTE FUNCTION log_cours_changes();


CREATE OR REPLACE FUNCTION log_etudiants_changes()
RETURNS TRIGGER AS $$
BEGIN
    IF (TG_OP = 'INSERT') THEN
        INSERT INTO log_etudiants (log_action, etudiant_id, etudiant_nom, etudiant_prenom, telephone_etudiant)
        VALUES ('INSERT', NEW.id_etu, NEW.nom_etu, NEW.pre_etu, NEW.tel_etu);
        RETURN NEW;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO log_etudiants (log_action, etudiant_id, etudiant_nom, etudiant_prenom, telephone_etudiant, old_values, new_values)
        VALUES ('UPDATE', NEW.id_etu, NEW.nom_etu, NEW.pre_etu, NEW.tel_etu,
                row_to_json(OLD), row_to_json(NEW));
        RETURN NEW;
    ELSIF (TG_OP = 'DELETE') THEN
        INSERT INTO log_etudiants (log_action, etudiant_id, etudiant_nom, etudiant_prenom, telephone_etudiant, old_values)
        VALUES ('DELETE', OLD.id_etu, OLD.nom_etu, OLD.pre_etu, OLD.tel_etu, row_to_json(OLD));
        RETURN OLD;
    END IF;
    RETURN NULL;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE TRIGGER log_etudiants_trigger
AFTER INSERT OR UPDATE OR DELETE ON etudiants
FOR EACH ROW EXECUTE FUNCTION log_etudiants_changes();

CREATE OR REPLACE FUNCTION log_utilisateurs_changes()
RETURNS TRIGGER AS $$
BEGIN
    IF (TG_OP = 'INSERT') THEN
        INSERT INTO log_utilisateurs (log_action, user_id, user_nom, user_password)
        VALUES ('INSERT', NEW.id_uti, NEW.log_uti, NEW.mdp_uti);
        RETURN NEW;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO log_utilisateurs (log_action, user_id, user_nom, user_password, old_values, new_values)
        VALUES ('UPDATE', NEW.id_uti, NEW.log_uti, NEW.mdp_uti, 
                row_to_json(OLD), row_to_json(NEW));
        RETURN NEW;
    ELSIF (TG_OP = 'DELETE') THEN
        INSERT INTO log_utilisateurs (log_action, user_id, user_nom, user_password, old_values)
        VALUES ('DELETE', OLD.id_uti, OLD.log_uti, OLD.mdp_uti, row_to_json(OLD));
        RETURN OLD;
    END IF;
    RETURN NULL;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE TRIGGER log_utilisateurs_trigger
AFTER INSERT OR UPDATE OR DELETE ON utilisateurs
FOR EACH ROW
EXECUTE FUNCTION log_utilisateurs_changes();