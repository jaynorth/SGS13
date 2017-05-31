INSERT INTO [dbo].[tbEtudiants] ( [Nom], [Prenom], [Rue], [RueNum], [Npa], [Localite] )
Values ('Newton', 'Isaac', 'Gravity street', '25', '1042', 'London'),
	('Holmes', 'Sherlock', 'Baker street', '121b', '1000', 'London'),
    ('Babbage', 'Charles', 'Analytical street', '26', '1019', 'Oxford'),
	('Lovelace', 'Ada', 'Argorithm street', '20', '1015', 'Oxford'),
	('Turing', 'Alan', 'Bletchley Park', '68', '1900', 'Londres'),
	('Zuse', 'Conrad', 'Plankalkül Strasse', '21', '6547', 'Berlin'),
	('Bool', 'Gearges', 'Binary Street', '0101', '1001', 'Lincoln');
GO

INSERT INTO [dbo].[tbEnseignants] ( [Nom], [Prenom], [Titre], [Bio], [Rue], [Npa], [Localité] )
Values ('Duck', 'Daffy', 'Canard', 'Et bla bla bla, et bla bla bla', 'Rue du Couac', '1042', 'Canardville'),
	('Bip', 'Bip', 'Roadrunner', null, 'Desert Road', '6546', 'Wroum'),
	('Mouse', 'Mickey', null, null, 'Steamboat Canal', '2345', 'Mickeyville');

GO

INSERT INTO [dbo].[tbCours] ( [Titre], [Description] )
Values ('Cha Cha', 'Cha cha cha!'),
	('Tango', 'Et Cash'),
	('Valse', 'ä trois temps, au moins'),
	('Charleston', null);

GO

SET IDENTITY_INSERT [dbo].[tbSessions] ON
INSERT INTO [dbo].[tbSessions] ([Id], [SessionId], [MaxInscription], [AnneeAcademique], [JoursCours], [DateDebutCours], [DateFinCours], [Session_Cours], [Session_Enseignant]) VALUES (1, N'Test', 4, 2017, N'Lundi', N'2017-01-21', N'2017-12-23', 1, 1)
INSERT INTO [dbo].[tbSessions] ([Id], [SessionId], [MaxInscription], [AnneeAcademique], [JoursCours], [DateDebutCours], [DateFinCours], [Session_Cours], [Session_Enseignant]) VALUES (2, N'Test2', 576, 2017, N'mardi', N'2017-03-21', N'2017-07-23', 3, 3)
INSERT INTO [dbo].[tbSessions] ([Id], [SessionId], [MaxInscription], [AnneeAcademique], [JoursCours], [DateDebutCours], [DateFinCours], [Session_Cours], [Session_Enseignant]) VALUES (3, N'3eme session', 8, 2017, N'mercredi', N'2017-01-11', N'2017-07-31', 2, 2)
SET IDENTITY_INSERT [dbo].[tbSessions] OFF


INSERT INTO [dbo].[tbInscriptions] ([Inscription_Session], [Inscription_Etudiant]) VALUES (1, 1)
INSERT INTO [dbo].[tbInscriptions] ([Inscription_Session], [Inscription_Etudiant]) VALUES (1, 2)
INSERT INTO [dbo].[tbInscriptions] ([Inscription_Session], [Inscription_Etudiant]) VALUES (1, 3)
INSERT INTO [dbo].[tbInscriptions] ([Inscription_Session], [Inscription_Etudiant]) VALUES (2, 1)
INSERT INTO [dbo].[tbInscriptions] ([Inscription_Session], [Inscription_Etudiant]) VALUES (1, 5)
INSERT INTO [dbo].[tbInscriptions] ([Inscription_Session], [Inscription_Etudiant]) VALUES (2, 2)
INSERT INTO [dbo].[tbInscriptions] ([Inscription_Session], [Inscription_Etudiant]) VALUES (2, 3)
INSERT INTO [dbo].[tbInscriptions] ([Inscription_Session], [Inscription_Etudiant]) VALUES (2, 7)
INSERT INTO [dbo].[tbInscriptions] ([Inscription_Session], [Inscription_Etudiant]) VALUES (2, 4)
INSERT INTO [dbo].[tbInscriptions] ([Inscription_Session], [Inscription_Etudiant]) VALUES (2, 5)
INSERT INTO [dbo].[tbInscriptions] ([Inscription_Session], [Inscription_Etudiant]) VALUES (2, 6)
INSERT INTO [dbo].[tbInscriptions] ([Inscription_Session], [Inscription_Etudiant]) VALUES (3, 4)
INSERT INTO [dbo].[tbInscriptions] ([Inscription_Session], [Inscription_Etudiant]) VALUES (3, 5)
INSERT INTO [dbo].[tbInscriptions] ([Inscription_Session], [Inscription_Etudiant]) VALUES (3, 6)
INSERT INTO [dbo].[tbInscriptions] ([Inscription_Session], [Inscription_Etudiant]) VALUES (3, 1)
