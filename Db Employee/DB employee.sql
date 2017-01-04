use master 
create database GestEmp02

use GestEmp02
create table Employee(
No_emp varchar(4) constraint PK_Employee Primary key,
Nom varchar(20),
Prenom varchar(20),
DateN date,
Gendre char(2),
Adress varchar(50),
Date_Emb date,
Salaire Money,
Dept_Num varchar(4) constraint FK_Employee_Dpt Foreign key references Departement (Dept_Num) on delete cascade on update cascade,
Post_num varchar(4) constraint FK_Employee_poste Foreign key references poste (Post_num)on delete cascade on update cascade,
Id_pays int constraint FK_Employee_pays Foreign key references Pays(Id_pays)
)

create table pays(

Id_pays int constraint PK_Pays Primary key,
Nom_pay nvarchar(20)

)

create table region (

id_region int constraint PK_region Primary key,
nom_region nvarchar(20),
Id_pays int constraint FK_region foreign key references pays (Id_pays)

)

create table ville (

Id_ville int constraint Pk_ville Primary key,
Nom_ville varchar(50),
id_region int constraint FK_ville Foreign key references region(id_region) on delete cascade on update cascade
)


create table Departement (

Dept_Num varchar(4)constraint Pk_Departement Primary key,
Dept_Nom varchar(20),
Lieu varchar(10)

)

create table poste (

Post_num varchar(4) constraint Pk_poste primary key,
Post_nom varchar(30)
)



use GestEmp01
select * from employee 


create login L_Elmansari
with password = '123'

create login L_Kasmi
with password = '456'

Create user u_zakaria for login L_Kasmi
Create user u_Usef for login L_Elmansari

sp_addrolemember 'db_owner','u_zakaria';
sp_addrolemember 'db_owner','u_Usef';































