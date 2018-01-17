use ashton

CREATE Table person
(
	PersonID BIGINT PRIMARY KEY IDENTITY,
	LastName VARCHAR(50) NOT NULL,
	FirstName VARCHAR(50) NOT NULL,
	Nickname VARCHAR(25) NOT NULL UNIQUE,
	EmailAdress VARCHAR(255) NOT NULL UNIQUE,
	KarmaPoints INTEGER NOT NULL
)

CREATE Table assignment
(
	AssignmentID BIGINT PRIMARY KEY IDENTITY,
	AssignmentName VARCHAR(100) NOT NULL,
	CreatorPersonID BIGINT NOT NULL,
	ExecutorPersonID BIGINT NOT NULL,
	Specifications VARCHAR(255) NOT NULL,
	KarmaValue INTEGER NOT NULL,

	FOREIGN KEY (CreatorPersonID) REFERENCES person(PersonID),
	FOREIGN KEY (ExecutorPersonID) REFERENCES person(PersonID)
)


CREATE Table exercise
(
	ExerciseID BIGINT PRIMARY KEY IDENTITY,
	AssignmentID BIGINT,
	ExerciseDescription VARCHAR(255) NOT NULL,
	KarmaUnitValue INTEGER NOT NULL,

	FOREIGN KEY (AssignmentID) REFERENCES assignment(AssignmentID)
)

INSERT INTO person (LastName, FirstName, Nickname, EmailAdress, KarmaPoints) VALUES ('Meier', 'Hans', 'meHa667', 'meier.hans@gmail.ch', 20);
INSERT INTO person (LastName, FirstName, Nickname, EmailAdress, KarmaPoints) VALUES ('Mandrel', 'Christoph', 'chMan502', 'christoph.Mandrel@gmail.ch', 45);
INSERT INTO assignment (AssignmentName, CreatorPersonID, ExecutorPersonID, Specifications, KarmaValue) VALUES ('Word Dokument auf Fehler prüfen', 1, 2, 'Ein von mir erstelltes Word-Dokument muss auf Rechtschreibfehler geprüft und anschliessend sauber eingerückt werden.', 15);
INSERT INTO assignment (AssignmentName, CreatorPersonID, ExecutorPersonID, Specifications, KarmaValue) VALUES ('Excel Dokument auf Spanisch übersetzen', 1, 2, 'Ein von mir erstelltes Excel-Dokument muss auf Spanisch übersetzt.', 15);

SELECT * FROM person

SELECT * FROM assignment