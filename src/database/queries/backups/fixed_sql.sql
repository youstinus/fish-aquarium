#@(#) script.ddl
SET FOREIGN_KEY_CHECKS=0;

DROP TABLE IF EXISTS Parameters;
DROP TABLE IF EXISTS Tasks;
DROP TABLE IF EXISTS Food_mixed_in_portion;
DROP TABLE IF EXISTS Fish;
DROP TABLE IF EXISTS Equipment_put_in_aquarium;
DROP TABLE IF EXISTS Aquarium_inside_has_decoration;
DROP TABLE IF EXISTS User;
DROP TABLE IF EXISTS Supplement_part_of_portion;
DROP TABLE IF EXISTS Food;
DROP TABLE IF EXISTS Equipment;
DROP TABLE IF EXISTS Decoration;
DROP TABLE IF EXISTS Aquarium;
DROP TABLE IF EXISTS UserTypes;
DROP TABLE IF EXISTS TaskStates;
DROP TABLE IF EXISTS ParametersTypes;
DROP TABLE IF EXISTS FishGenderTypes;
DROP TABLE IF EXISTS EquipmentTypes;
DROP TABLE IF EXISTS DecorationTypes;
DROP TABLE IF EXISTS Allergens;
DROP TABLE IF EXISTS Supplement;
DROP TABLE IF EXISTS Portion;
SET FOREIGN_KEY_CHECKS=1;
CREATE TABLE Portion
(
	PreparationDate date,
	Id integer,
	PRIMARY KEY(Id)
);

CREATE TABLE Supplement
(
	Name varchar (255),
	Mass double,
	Manual varchar (255),
	FoodComposition varchar (255),
	ExpirationDate date,
	Id integer,
	PRIMARY KEY(Id)
);

CREATE TABLE Allergens
(
	Id integer,
	name char (7) NOT NULL,
	PRIMARY KEY(Id)
);
INSERT INTO Allergens(Id, name) VALUES(1, 'Lactose');
INSERT INTO Allergens(Id, name) VALUES(2, 'Gluten');
INSERT INTO Allergens(Id, name) VALUES(3, 'Nuts');

CREATE TABLE DecorationTypes
(
	Id integer,
	name char (14) NOT NULL,
	PRIMARY KEY(Id)
);
INSERT INTO DecorationTypes(Id, name) VALUES(1, 'Soil');
INSERT INTO DecorationTypes(Id, name) VALUES(2, 'Rubble');
INSERT INTO DecorationTypes(Id, name) VALUES(3, 'Shell');
INSERT INTO DecorationTypes(Id, name) VALUES(4, 'Coral');
INSERT INTO DecorationTypes(Id, name) VALUES(5, 'LivingCreature');

CREATE TABLE EquipmentTypes
(
	Id integer,
	name char (11) NOT NULL,
	PRIMARY KEY(Id)
);
INSERT INTO EquipmentTypes(Id, name) VALUES(1, 'Filter');
INSERT INTO EquipmentTypes(Id, name) VALUES(2, 'Illuminator');
INSERT INTO EquipmentTypes(Id, name) VALUES(3, 'Bubbler');
INSERT INTO EquipmentTypes(Id, name) VALUES(4, 'Thermostat');
INSERT INTO EquipmentTypes(Id, name) VALUES(5, 'Heater');

CREATE TABLE FishGenderTypes
(
	Male varchar (255),
	Id integer,
	name char (12) NOT NULL,
	PRIMARY KEY(Id)
);
INSERT INTO FishGenderTypes(Id, name) VALUES(1, 'Male');
INSERT INTO FishGenderTypes(Id, name) VALUES(2, 'Female');
INSERT INTO FishGenderTypes(Id, name) VALUES(3, 'Hermafrodita');

CREATE TABLE ParametersTypes
(
	Id integer,
	name char (15) NOT NULL,
	PRIMARY KEY(Id)
);
INSERT INTO ParametersTypes(Id, name) VALUES(1, 'Temperature');
INSERT INTO ParametersTypes(Id, name) VALUES(2, 'O2Concentration');
INSERT INTO ParametersTypes(Id, name) VALUES(3, 'Ph');
INSERT INTO ParametersTypes(Id, name) VALUES(4, 'WaterColor');

CREATE TABLE TaskStates
(
	Id integer,
	name char (9) NOT NULL,
	PRIMARY KEY(Id)
);
INSERT INTO TaskStates(Id, name) VALUES(1, 'Active');
INSERT INTO TaskStates(Id, name) VALUES(2, 'Canceled');
INSERT INTO TaskStates(Id, name) VALUES(3, 'Completed');

CREATE TABLE UserTypes
(
	Id integer,
	name char (7) NOT NULL,
	PRIMARY KEY(Id)
);
INSERT INTO UserTypes(Id, name) VALUES(1, 'Admin');
INSERT INTO UserTypes(Id, name) VALUES(2, 'Worker');
INSERT INTO UserTypes(Id, name) VALUES(3, 'Visitor');

CREATE TABLE Aquarium
(
	Capacity double,
	Mass double,
	Length double,
	Width double,
	Heigth double,
	GlassThickness int,
	Id integer,
	Fk_Portion integer,
	PRIMARY KEY(Id),
	CONSTRAINT Fkc_Portion FOREIGN KEY(Fk_Portion) REFERENCES Portion (Id)
);

CREATE TABLE Decoration
(
	Manufacturer varchar (255),
	Name varchar (255),
	Color varchar (255),
	Mass double,
	Description varchar (255),
	Material varchar (255),
	Type integer,
	Id integer,
	PRIMARY KEY(Id),
	FOREIGN KEY(Type) REFERENCES DecorationTypes (Id)
);

CREATE TABLE Equipment
(
	Manufacturer varchar (255),
	Name varchar (255),
	Type integer,
	Id integer,
	PRIMARY KEY(Id),
	FOREIGN KEY(Type) REFERENCES EquipmentTypes (Id)
);

CREATE TABLE Food
(
	Name varchar (255),
	Mass double,
	Calories double,
	Carbs double,
	Proten double,
	Fat double,
	PrepManual varchar (255),
	ExpirationDate date,
	Allergen integer,
	Id integer,
	PRIMARY KEY(Id),
	FOREIGN KEY(Allergen) REFERENCES Allergens (Id)
);

CREATE TABLE Supplement_part_of_portion
(
	Fk_portion integer,
	Fk_supplement integer,
	PRIMARY KEY(Fk_portion, Fk_supplement),
	CONSTRAINT Fkc_Portion FOREIGN KEY(Fk_portion) REFERENCES Portion (Id),
	CONSTRAINT Fkc_Supplement FOREIGN KEY(Fk_supplement) REFERENCES Supplement (Id)
);

CREATE TABLE User
(
	FirstName varchar (255),
	LastName varchar (255),
	BirthDate date,
	RegistrationDate date,
	Email varchar (255),
	Password varchar (255),
	Code varchar (255),
	Type integer,
	Id integer,
	PRIMARY KEY(Id),
	FOREIGN KEY(Type) REFERENCES UserTypes (Id)
);

CREATE TABLE Aquarium_inside_has_decoration
(
	Fk_decoration integer,
	Fk_aquarium integer,
	PRIMARY KEY(Fk_decoration, Fk_aquarium),
	CONSTRAINT Fkc_Decoration FOREIGN KEY(Fk_decoration) REFERENCES Decoration (Id),
	CONSTRAINT Fkc_Aquarium FOREIGN KEY(Fk_aquarium) REFERENCES Aquarium (Id)
);

CREATE TABLE Equipment_put_in_aquarium
(
	Fk_aquarium integer,
	Fk_equipment integer,
	PRIMARY KEY(Fk_aquarium, Fk_equipment),
	CONSTRAINT Fkc_Aquarium FOREIGN KEY(Fk_aquarium) REFERENCES Aquarium (Id),
	CONSTRAINT Fkc_Equipment FOREIGN KEY(Fk_equipment) REFERENCES Equipment (Id)
);

CREATE TABLE Fish
(
	Species varchar (255),
	Mass double,
	Size double,
	Origin varchar (255),
	ArrivalDate date,
	LifeExpectancy int,
	Description varchar (255),
	Gender integer,
	Id integer,
	Fk_Aquarium integer,
	PRIMARY KEY(Id),
	FOREIGN KEY(Gender) REFERENCES FishGenderTypes (Id),
	CONSTRAINT Fkc_Aquarium FOREIGN KEY(Fk_Aquarium) REFERENCES Aquarium (Id)
);

CREATE TABLE Food_mixed_in_portion
(
	Fk_portion integer,
	Fk_food integer,
	PRIMARY KEY(Fk_portion, Fk_food),
	CONSTRAINT Fkc_Portion FOREIGN KEY(Fk_portion) REFERENCES Portion (Id),
	CONSTRAINT Fkc_Food FOREIGN KEY(Fk_food) REFERENCES Food (Id)
);

CREATE TABLE Tasks
(
	Name varchar (255),
	Duration double,
	StartTime date,
	Description varchar (255),
	State integer,
	Id integer,
	Fk_Aquarium integer,
	Fk_User integer,
	PRIMARY KEY(Id),
	FOREIGN KEY(State) REFERENCES TaskStates (Id),
	CONSTRAINT Fkc_Aquarium FOREIGN KEY(Fk_Aquarium) REFERENCES Aquarium (Id),
	CONSTRAINT Fkc_User FOREIGN KEY(Fk_User) REFERENCES User (Id)
);

CREATE TABLE Parameters
(
	Name varchar (255),
	Value varchar (255),
	Type integer,
	Id integer,
	Fk_Fish integer,
	Fk_Aquarium integer,
	PRIMARY KEY(Id),
	UNIQUE(Fk_Fish),
	FOREIGN KEY(Type) REFERENCES ParametersTypes (Id),
	CONSTRAINT Fkc_Fish FOREIGN KEY(Fk_Fish) REFERENCES Fish (Id),
	CONSTRAINT Fkc_Aquarium FOREIGN KEY(Fk_Aquarium) REFERENCES Aquarium (Id)
);
