create database Rainbow_School
use Rainbow_School
create table Students
(
	StuId int primary key identity(1,1),
	StuName nvarchar(50) not null,
	StuClass nvarchar(50) not null
)
create table Subjects
(
	SubCode int primary key identity(100,1),
	SubName nvarchar(50) not null
)
create table Class
(
ClassId int primary key identity(11,1),
ClassName nvarchar(50)
)
INSERT INTO Students (StuName, StuClass) VALUES    ('Alice Johnson', 'Class A'),
    ('Bob Smith', 'Class 7'),
    ('Catherine Davis', 'Class 6'),
    ('David Brown', 'Class 8'),
    ('Eleanor Martinez', 'Class 7'),
    ('Frank Anderson', 'Class 6'),
    ('Grace Wilson', 'Class 8'),
    ('Henry Miller', 'Class 6'),
    ('Isabella White', 'Class 7'),
    ('Jack Taylor', 'Class 8')
INSERT INTO Subjects (SubName) VALUES    ('Mathematics'),
    ('Science'),
    ('History'),
    ('English'),
    ('Physics'),
    ('Biology'),
    ('Geography'),
    ('Computer Science'),
    ('Art'),
    ('Music')
INSERT INTO Class (ClassName)
VALUES
    ('Class 6'),
    ('Class 7'),
    ('Class 8')
 select * from Students
 select * from Subjects
 select * from Class
 --we can retirve based on id or name or any specific way we need
 --for example i need to display students present iin class 6 only
 select * from Students where StuClass='Class 6'