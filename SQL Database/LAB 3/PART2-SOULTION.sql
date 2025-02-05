-- LAB 3 - PART 2
create database LAB3_DB

USE LAB3_DB

-- Table 1 
create table Instructor
( 
ID int primary key identity(1, 1),
Fname varchar(25),
Lname varchar(25),
BDate date, 
Age as  year(getdate()) - year(BDate), 
Salary decimal(18, 2) check (salary >= 1000 and salary <= 5000) default 3000,
Overtime decimal(18, 2) unique, 
NetSalary as Salary + Overtime,
HireDate date default getdate(), 
Address varchar(100) check (address in ('Cairo', 'Alex'))
)

-- Table 2 
create table Course
( 
CID int primary key identity(1, 1),
Cname varchar(25),
Duration int unique,
)

-- Table 3
create table Lab
(
LID int primary key identity(1, 1),
Location varchar(25),
Capacity int check (capacity < 20),
CID int foreign key references Course(CID) on delete cascade on update cascade
)

-- Table 3
create table Course_Teach
(
Course_ID int, 
Instructor_ID int,
constraint PK primary key (Course_ID, Instructor_ID),
constraint FK1 foreign key (Course_ID)  references Course(CID)
on delete cascade on update cascade,
constraint FK2 foreign key (Instructor_ID) references Instructor(ID)
on delete cascade on update cascade
)
