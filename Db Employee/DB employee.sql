use master 
create database GestEmp




use GestEmp
--============= Creation des tables =============--

create table Employee(
ID_EMP int identity(1,1) constraint PK_Employee Primary key,
Nom varchar(20),
Prenom varchar(20),
Tel varchar(17) unique ,
Email varchar(100),
DateN date,
Date_Emb date,
sexe char(1),
Salaire Money default 0,
Adress varchar(100) default null,
Id_pays int constraint FK_Employee_pays Foreign key references Pays(ID_PAYS),
id_region int constraint FK_Employee_Region Foreign key references Region (ID_Region) on delete  cascade on update  cascade,
id_ville int constraint FK_Employee_Ville Foreign key references Ville (ID_VILLE) ,
id_dept int constraint FK_Employee_Dpt Foreign key references Departement (ID_DEPT) on delete cascade on update cascade,
id_poste int constraint FK_Employee_poste Foreign key references Poste(ID_POSTE) ,
Photo image ,
Age int constraint ck_age_EMP check(Age > 18 )
)

--id_post varchar(10) constraint FK_Employee_poste Foreign key references poste (ID_POST)on delete cascade on update cascade,

GO
create table Pays(
ID_PAYS int identity(1,1) constraint PK_Pays Primary key,
Nom_pays nvarchar(50)
)
GO
create table Region (
ID_Region int identity (1,1) constraint PK_region Primary key,
Nom_region nvarchar(50),
id_pays int constraint FK_region foreign key references pays (ID_PAYS)
)
GO

create table Ville (

ID_VILLE int identity (1,1)constraint Pk_ville Primary key,
Nom_ville varchar(50),
id_region int constraint FK_ville Foreign key references Region(ID_Region) on delete cascade on update cascade
)

create table Departement (

ID_DEPT int identity(1,1) constraint Pk_Departement Primary key,
Dept_Nom varchar(20),

)


create table Poste (
ID_POSTE int identity(1,1) constraint Pk_poste primary key,
Post_nom varchar(50),
id_dept int  constraint id_dept_departement foreign key references Departement (ID_DEPT) on delete cascade on update cascade
)


create table Compte(

ID_COMPT int identity constraint PK_compte Primary key,
Username varchar(30),
[password] varchar(30)

)

Alter table Compte
Add constraint Ck_Username Check(Username not like '%['']%' and Username not like '%["]%'),
constraint Ck_Password Check ([Password] not like '%['']%' and [Password]not like '%["]%')


--============= Secutier =============--

create login L_Elmansari
with password = '123'

create login L_Kasmi
with password = '456'

Create user u_zakaria for login L_Kasmi
Create user u_Usef for login L_Elmansari

sp_addrolemember 'db_owner','u_zakaria';
sp_addrolemember 'db_owner','u_Usef';


--============= Insertion =============-- 
insert into Poste values ('Chef comptable',1),
						('Comptable unique',1),
						('Secrétaire comptable',1),
						('Assistant marketing',2),
						('Webmarketeur',2),
						('E-reputation manager',2),
						('Responsable merchandising',2),
						('Responsable promotion des ventes',2),
						('Traffic Manager',2),
						('Directeur De Communication',3),
						('Responsable communication en line',3),
						('Attaché Commercial',4),
						('CONSEILLER COMMERCIAL',4),
						('Chef commercial',4),
						('Web Designer',5),
						('Développeur web',5),
						('Développeur d’applications',5),
						('Ingénieur Web',5)
						







						
insert into Pays values 
('Morroco')
GO
SET IDENTITY_INSERT [dbo].[pays] ON 

INSERT [dbo].[pays] ([ID_PAYS], [Nom_pays]) VALUES (3, N'france')
SET IDENTITY_INSERT [dbo].[pays] OFF
SET IDENTITY_INSERT [dbo].[region] ON 
INSERT [dbo].[region] ( [Nom_region], [id_pays]) VALUES ( N'region Lile', 3)
INSERT [dbo].[region] ( [Nom_region], [id_pays]) VALUES ( N'region nice', 3)
INSERT [dbo].[region] ( [Nom_region], [id_pays]) VALUES ( N'region Paris', 3)

SET IDENTITY_INSERT [dbo].[region] OFF
SET IDENTITY_INSERT [dbo].[ville] ON 
INSERT [dbo].[ville] ([Nom_ville], [id_region]) VALUES ( N'Nica', 17)
INSERT [dbo].[ville] ( [Nom_ville], [id_region]) VALUES (N'Nice', 17)
INSERT [dbo].[ville] ( [Nom_ville], [id_region]) VALUES ( N'eiffel', 18)
INSERT [dbo].[ville] ( [Nom_ville], [id_region]) VALUES ( N'Paris', 18)
INSERT [dbo].[ville] ([Nom_ville], [id_region]) VALUES ( N'Lile', 19)
INSERT [dbo].[ville] ( [Nom_ville], [id_region]) VALUES ( N'Loula', 19)
SET IDENTITY_INSERT [dbo].[ville] OFF




insert into Region values 
('Oued Ed-Dahab - Lagouira',1),
('Laâyoune - Boujdour - Sakia El Hamra',1),
('Guelmim - Es-Semara',1),
('Souss - Massa - Daraa',1),
('Gharb - Chrarda - Béni Hssen',1),
('Chaouia - Ouardigha',1),
('Marrakech - Tensift - Al Haouz',1),
('Oriental',1),
('Grand Casablanca',1),
('Rabat - Salé - Zemmour - Zaer',1),
('Doukala - Abda',1),
('Tadla Azilal',1),
('Meknès - Tafilalet',1),
('Fès - Boulmane',1),
('Taza - Al Hoceima - Taounate',1),
('Tanger - Tétouan',1)
 
insert into Ville values 
--region 1
('Aousserd',1),
('oued Eddahab',1),
--region 2
('Boujdour',2),
('lamssid',2),
('Jraifia',2),
('Gueltat Zemmour',2),
('Laayoun',2),
('Dcheira',2),
('Boukrra',2),
('foum el Oued',2),
('El Hagounia',2),
('Daoura',2),
('Tah',2),
('Tarfaya',2),
('Akhfennir',2),
--region 3
('Akka',3),
('Assa',3),
('Fam El Hisn',3),
('Foum Zguid',3),
('El Ouatia',3),
('Es-Semara',3),
('Bouizakarne',3),
('Guelmim',3),
('Taghjijt',3),
('Tan-Tan',3),
('Zag',3),
--region 4
('Agni Izimmer',4),
('Aït Baha',4),
('Aït Hani',4),
('Aït Iaâza',4),
('Aït Melloul',4),
('Aït Yalla',4),
('Alnif',4),
('Anzi',4),
('Aoulouz',4),
('Aourir',4),
('Arazane',4),
('Bengammoud',4),
('Biougra',4),
('Boumalne-Dadès',4),
('Dcheira El Jihadia',4),
('Drargua',4),
('El Guerdane',4),
('Harte Lyamine',4),
('Ida Ougnidif',4),
('Ifri',4),
('Igdamen',4),
('Ighil nOumgoun',4),
('Inezgane',4),
('Irherm',4),
('Kelaat-M Gouna',4),
('Lakhsas',4),
('Lqliâa',4),
('M semrir',4),
('Megousse',4),
('Oulad Berhil',4),
('Oulad Teïma',4),
('Sidi Ifni',4),
('Tabounte',4),
('Tafraout',4),
('Taghzout',4),
('Taliouine',4),
('Tamegroute',4),
('Tamraght',4),
('Tanoumrite Nkob Zagora',4),
('Taourirt Ait Zaghar',4),
('Tifnit',4),
('Tinfou',4),
('Tinghir',4),
('Tisgdal',4),
('Tiznit',4),
('Toumliline',4),
('Zagora',4),
-- region 5
('Aïn Dorij',5),
('Dar Gueddari',5),
('Had Kourt',5),
('Jorf El Melha',5),
('Khenichet ',5),
('Mechra Bel Ksiri',5),
('Mehdia',5),
('Moulay Bousselham',5),
('Sidi Allal Tazi',5),
('Sidi Kacem',5),
('Sidi Slimane',5),
('Sidi Taïbi',5),
('Sidi Yahya El Gharb',5),
-- region 6
('Ben Ahmed',6),
('Benslimane',6),
('Berrechid',6),
('Boujniba',6),
('Boulanouare',6),
('Bouznika',6),
('Bouznika',6),
('El Borouj',6),
('El Gara',6),
('El Gara',6),
('Hattane',6),
('Loulad',6),
('Oued Zem',6),
('Oulad Abbou',6),
('Oulad H Riz Sahel',6),
('Oulad M rah',6),
('Oulad Saïd',6),
('Oulad Sidi Ben Daoud',6),
('Ras El Aïn',6),
('Settat',6),
('Sidi Hajjaj',6),
('Sidi Rahhal Chataï',6),
-- region 7
('Aït Ourir',7),
('Amizmiz',7),
('Assahrij',7),
('Ben Guerir',7),
('Bouchane',7),
('Chichaoua',7),
('El Hanchane',7),
('El Kelaâ des Sraghna',7),
('Essaouira',7),
('Essaouira',7),
('Ghmate ',7),
('Ighounane',7),
('Imintanoute',7),
('Imintanoute',7),
('Moulay Brahim',7),
('Sid L Mokhtar',7),
('Sidi Bou Othmane',7),
('Sidi Rahhal',7),
('Tahannaout',7),
('Talmest',7),
('Tamallalt',7),
('Tamanar',7),
('Tamansourt',7),
('Tameslouht',7),
-- region 8
('Ahfir',8),
('Aïn Beni Mathar',8),
('Aïn Chaïr',8),
('Aïn Erreggada',8),
('Aïn Erreggada',8),
('Al Aroui',8),
('Ben Taïeb',8),
('Beni Chiker',8),
('Beni Ensar',8),
('Berkane',8),
('Bni Drar',8),
('Bni Tadjite',8),
('Bni Tadjite',8),
('Bouarfa ',8),
('Bouarfa ',8),
('Dar El Kebdani',8),
('Debdou',8),
('Douar Kannine',8),
('Driouch',8),
('El Aïoun Sidi Mellouk',8),
('Farkhana',8),
('Figuig',8),
('Ihddaden',8),
('Jaâdar',8),
('Jerada',8),
('Kariat Arekmane',8),
('Kassita',8),
('Kerouna',8),
('Laâtamna ',8),
('Madagh ',8),
('Midar',8),
('Nador ',8),
('Naïma ',8),
('Oued Heimer',8),
('Oujda',8),
('Ras El Ma ',8),
('Saïdia',8),
('Selouane',8),
('Sidi Boubker',8),
('Sidi Lahsen',8),
('Sidi Slimane Echcharaa',8),
('Talsint',8),
('Taourirt ',8),
('Tendrara',8),
('Tiztoutine',8),
('Touima',8),
('Touissit',8),
('Zaïo',8),
('Zeghanghane',8),
-- region 9
('Aïn Harrouda',9),
('Bni Yakhlef',9),
('Bouskoura',9),
('El Mansouria',9),
('Médiouna ',9),
('Nouaceur',9),
('Tit Mellil',9),

-- region 10
('Ain El Aouda',10),
('Khémisset',10),
('Oulmès',10),
('Sala Al Jadida',10),
('Sidi Allal El Bahraoui',10),
('Sidi Bouknadel',10),
('Skhirat',10),
('Tamesna',10),
('Tiddas',10),
('Tiflet',10),

-- region 11
('Azemmour',11),
('Bir Jdid',11),
('Bouguedra',11),
('Echemmaia',11),
('El Jadida',11),
('Hrara',11),
('Ighoud',11),
('Jamâat Shaim',11),
('Khemis Zemamra',11),
('Laakarta',11),
('Laâounate',11),
('Oualidia',11),
('Oulad Amrane',11),
('Oulad Frej',11),
('Oulad Ghadbane',11),
('Ras El Ain ',11),
('Safi ',11),
('Sebt El Maârif',11),
('Sebt Gzoula',11),
('Sidi Ahmed',11),
('Sidi Ali Ben Hamdouche',11),
('Sidi Bennour',11),
('Sidi Bouzid ',11),
('Sidi Smaïl ',11),
('Youssoufia  ',11),
--region 12
insert into Ville values
('Afourar ',12),
('Aït Majden ',12),
('Azilal ',12),
('Beni Ayat ',12),
('Béni Mellal ',12),
('Bradia ',12),
('Bzou ',12),
('Dar Oulad Zidouh ',12),
('Demnate ',12),
('Dra a ',12),
('El Ksiba ',12),
('Foum Jemaâ ',12),
('Ouaouizeght ',12),
('Oulad Ayad ',12),
('Oulad Yaïch ',12),
('Ouled M barek ',12),
('Sidi Jaber ',12),
('Souk Sebt Oulad Nemma ',12),
('Zaouïat Cheikh ',12),

-- region 13
('Aghbalou  ',13),
('Aghbalou  ',13),
('Aïn Jemaa ',13),
('Aïn Karma ',13),
('Aïn Leuh ',13),
('Ain Taoujdate ',13),
('Aït Boubidmane ',13),
('Aoufous ',13),
('Arfoud ',13),
('Azrou  ',13),
('Boudnib ',13),
('Boufakrane ',13),
('Boumia  ',13),
('Er-Rich ',13),
('Errachidia ',13),
('Gardmit ',13),
('Goulmima ',13),
('Gourrama ',13),
('Had Bouhssoussen ',13),
('Haj Kaddour ',13),
('Ifrane ',13),
('Itzer ',13),
('Jorf  ',13),
('Kehf Nsour ',13),
('Kerrouchen ',13),
('M haya ',13),
('Midelt ',13),
('Midelt ',13),
('Oued Ifrane ',13),
('Sabaâ Aïyoun ',13),
('Sebt Jahjouh ',13),
('Sidi Addi ',13),
('Tichoute ',13),
('Tighza ',13),
('Timahdite ',13),
('Tinejdad ',13),
('Tizguite ',13),
('Tounfite ',13),
('Zaïda ',13),
('Zaouia d Ifrane ',13),
-- region 14

('Aderj ',14),
('Aïn Cheggag ',14),
('Bhalil ',14),
('Boulemane ',14),
('El Menzel ',14),
('Guigou ',14),
('Imouzzer Kandar ',14),
('Imouzzer Marmoucha ',14),
('Imouzzer Marmoucha ',14),
('Moulay Yaâcoub ',14),
('Ouled Tayeb ',14),
('Outat El Haj ',14),
('Ribate El Kheir ',14),
('Séfrou ',14),
('Sidi Youssef Ben Ahmed ',14),
('Skhinate ',14),
('Tafajight ',14),

-- region 15
('Ajdir  ',15),
('Aknoul ',15),
('Al Hoceïma ',15),
('Beni Bouayach ',15),
('Bni Hadifa ',15),
('Ghafsai ',15),
('Guercif ',15),
('Imzouren ',15),
('Inahnahen ',15),
('Karia ',15),
('Karia Ba Mohamed ',15),
('Oued Amlil ',15),
('Oulad Zbaïr ',15),
('Tahla ',15),
('Taïnaste ',15),
('Tala Tazegwaght ',15),
('Tamassint ',15),
('Targuist ',15),
('Taza ',15),
('Thar Es-Souk ',15),
('Tissa ',15),
('Tizi Ouasli ',15),
('Zerarda ',15),

--region 16

('Akchour ',16),
('Assilah ',16),
('Bab Berred ',16),
('Bab Taza ',16),
('Brikcha ',16),
('Chefchaouen ',16),
('Dar Bni Karrich ',16),
('Dar Chaoui ',16),
('Fnideq ',16),
('Gueznaia ',16),
('Jebha ',16),
('Karia  ',16),
('Khémis Sahel ',16),
('Ksar El Kébir ',16),
('Larache ',16),
('M diq ',16),
('Martil ',16),
('Mellousa ',16),
('Mohamed ben Abdallah el-Raisuni ',16),
('Moqrisset ',16),
('Oued Laou ',16),
('Oued Rmel ',16),
('Ouezzane ',16),
('Point Cires ',16),
('Sidi Lyamani ',16),
('Zinat ',16)

insert into Departement values
('science','Oujda'),
('Physique','Berkan'),
('sport','Nador'),
('mechanique','Taourirt')
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([ID_EMP], [Nom], [Prenom], [Tel], [Email], [DateN], [Date_Emb], [sexe], [Salaire], [Adress], [Id_pays], [id_region], [id_ville], [id_dept], [id_poste], [Photo], [Age]) VALUES (1, N'Kasmi', N'Zakaria', N'0600000000', N'zakaria_kasmi@hotmail.fr', CAST(N'2017-01-12' AS Date), CAST(N'2017-01-10' AS Date), N'M', 500000.0000, N'lazaret oujda', 1, 8, 288, 2, 15, NULL, NULL)
INSERT [dbo].[Employee] ([ID_EMP], [Nom], [Prenom], [Tel], [Email], [DateN], [Date_Emb], [sexe], [Salaire], [Adress], [Id_pays], [id_region], [id_ville], [id_dept], [id_poste], [Photo], [Age]) VALUES (2, N'Hamid', N'Jilali', N'0611', N'Hamid@hotmail.fr', CAST(N'2017-01-02' AS Date), CAST(N'2017-01-10' AS Date), N'M', 34444.0000, N'tanger ', 1, 3, 143, 3, 12, NULL, NULL)
INSERT [dbo].[Employee] ([ID_EMP], [Nom], [Prenom], [Tel], [Email], [DateN], [Date_Emb], [sexe], [Salaire], [Adress], [Id_pays], [id_region], [id_ville], [id_dept], [id_poste], [Photo], [Age]) VALUES (3, N'oujdi', N'samir', N'0622334455', N'Samir@hotmail.fr', CAST(N'2017-01-05' AS Date), CAST(N'2017-01-12' AS Date), N'M', 34444.0000, N'Nador', 1, 5, 205, 4, 11, NULL, NULL)
INSERT [dbo].[Employee] ([ID_EMP], [Nom], [Prenom], [Tel], [Email], [DateN], [Date_Emb], [sexe], [Salaire], [Adress], [Id_pays], [id_region], [id_ville], [id_dept], [id_poste], [Photo], [Age]) VALUES (4, N'Fathi', N'Hamid', N'06334455', N'Fathi@hotmail.fr', CAST(N'2017-01-18' AS Date), CAST(N'2017-01-17' AS Date), N'M', 34444.0000, N'Fes', 1, 5, 207, 4, 8, NULL, NULL)
INSERT [dbo].[Employee] ([ID_EMP], [Nom], [Prenom], [Tel], [Email], [DateN], [Date_Emb], [sexe], [Salaire], [Adress], [Id_pays], [id_region], [id_ville], [id_dept], [id_poste], [Photo], [Age]) VALUES (5, N'Remy', N'Gaillard', N'003311', N'Remy@hotmail.fr', CAST(N'2017-01-18' AS Date), CAST(N'2017-01-17' AS Date), N'M', 34444.0000, N'Fes', 3, 19, 353, 3, 10, NULL, NULL)
INSERT [dbo].[Employee] ([ID_EMP], [Nom], [Prenom], [Tel], [Email], [DateN], [Date_Emb], [sexe], [Salaire], [Adress], [Id_pays], [id_region], [id_ville], [id_dept], [id_poste], [Photo], [Age]) VALUES (6, N'mark', N'jack', N'1022030', N'mark@hotmail.com', CAST(N'2010-02-10' AS Date), CAST(N'2017-01-18' AS Date), N'M', 67000.0000, N'Rabat', 1, 4, 153, 1, 1, NULL, NULL)
INSERT [dbo].[Employee] ([ID_EMP], [Nom], [Prenom], [Tel], [Email], [DateN], [Date_Emb], [sexe], [Salaire], [Adress], [Id_pays], [id_region], [id_ville], [id_dept], [id_poste], [Photo], [Age]) VALUES (7, N'Roz', N'Dennis', N'123456', N'Dennis@hotmail.com', CAST(N'2010-02-03' AS Date), CAST(N'2017-01-18' AS Date), N'M', 3000.0000, N'Rabat', 3, 17, 353, 4, 14, NULL, NULL)
INSERT [dbo].[Employee] ([ID_EMP], [Nom], [Prenom], [Tel], [Email], [DateN], [Date_Emb], [sexe], [Salaire], [Adress], [Id_pays], [id_region], [id_ville], [id_dept], [id_poste], [Photo], [Age]) VALUES (8, N'roza', N'andy', N'000111', N'Roza@hotmail.com', CAST(N'2010-02-03' AS Date), CAST(N'2017-01-18' AS Date), N'F', 12000.0000, N'Tetouan rue 5903', 1, 4, 153, 2, 16, NULL, NULL)
INSERT [dbo].[Employee] ([ID_EMP], [Nom], [Prenom], [Tel], [Email], [DateN], [Date_Emb], [sexe], [Salaire], [Adress], [Id_pays], [id_region], [id_ville], [id_dept], [id_poste], [Photo], [Age]) VALUES (9, N'lisa', N'braun', N'0022334', N'Lisa@hotmail.com', CAST(N'2010-02-03' AS Date), CAST(N'2017-01-18' AS Date), N'F', 1500.0000, N'Lile BV 343', 3, 17, 353, 3, 8, NULL, NULL)
INSERT [dbo].[Employee] ([ID_EMP], [Nom], [Prenom], [Tel], [Email], [DateN], [Date_Emb], [sexe], [Salaire], [Adress], [Id_pays], [id_region], [id_ville], [id_dept], [id_poste], [Photo], [Age]) VALUES (10, N'Majid', N'Hamid', N'00123', N'Majjid@hotmail.com', CAST(N'2010-02-05' AS Date), CAST(N'2017-01-18' AS Date), N'M', 25000.0000, N'Meknes BV 347', 1, 6, 215, 2, 14, NULL, NULL)
INSERT [dbo].[Employee] ([ID_EMP], [Nom], [Prenom], [Tel], [Email], [DateN], [Date_Emb], [sexe], [Salaire], [Adress], [Id_pays], [id_region], [id_ville], [id_dept], [id_poste], [Photo], [Age]) VALUES (11, N'Amine', N'Jalal', N'001235', N'Jalal@hotmail.com', CAST(N'2010-02-05' AS Date), CAST(N'2017-01-18' AS Date), N'M', 255000.0000, N'FES BV 347', 1, 6, 220, 2, 7, NULL, NULL)
INSERT [dbo].[Employee] ([ID_EMP], [Nom], [Prenom], [Tel], [Email], [DateN], [Date_Emb], [sexe], [Salaire], [Adress], [Id_pays], [id_region], [id_ville], [id_dept], [id_poste], [Photo], [Age]) VALUES (12, N'khaldi', N'Aymen', N'0012351', N'Aymen@hotmail.com', CAST(N'2010-02-05' AS Date), CAST(N'2017-01-18' AS Date), N'M', 255000.0000, N'casa BV 506', 1, 9, 309, 1, 2, NULL, NULL)
INSERT [dbo].[Employee] ([ID_EMP], [Nom], [Prenom], [Tel], [Email], [DateN], [Date_Emb], [sexe], [Salaire], [Adress], [Id_pays], [id_region], [id_ville], [id_dept], [id_poste], [Photo], [Age]) VALUES (13, N'rajae', N'falla', N'05661', N'rajae@gmail.om', CAST(N'2017-01-11' AS Date), CAST(N'2017-01-11' AS Date), N'F', 400000.0000, N'oujda lazaret', 1, 8, 292, 2, 11, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Employee] OFF
























