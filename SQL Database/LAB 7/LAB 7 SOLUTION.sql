-- 1. Create a view that displays student full name,
-- course name if the student has a grade more than 50. 
create view StudentCourseInfo (Fullname, CourseName)
as
select St_Fname + ' ' + st_lname, Crs_Name from Student 
inner join Stud_Course  
on Student.St_Id = Stud_Course.St_Id and Stud_Course.Grade > 50
inner join Course
on Stud_Course.Crs_Id = Course.Crs_Id

select * from StudentCourseInfo

-- Create an Encrypted view that displays
-- manager names and the topics they teach.
create view managersTopic
with encryption
as 
select distinct Ins_Name, Top_Name from Instructor
inner join Ins_Course 
on Instructor.Ins_Id = Ins_Course.Ins_Id
inner join Course
on Ins_Course.Crs_Id = Course.Crs_Id
inner join Topic 
on Course.Top_Id = Topic.Top_Id

sp_helptext 'managersTopic'

-- 3.Create a view that will display Instructor Name,
-- Department Name for the ‘SD’ or ‘Java’ Department 
create view InstructorAndDepartment
as
	select Ins_Name, dept_name 
	from Instructor
	inner join Department
	on Instructor.Dept_Id = Department.Dept_Id and dept_name in ('SD', 'Java')

-- 4. Create a view “V1” that displays student data for student who lives in Alex or Cairo. 
-- Note: Prevent the users to run the following query 
-- Update V1 set st_address=’tanta’
-- Wehre st_address=’alex’;
create view V1
with encryption
as
select * from Student 
where St_Address in ('Alex', 'Cairo')
with check option

Update V1 set st_address='tanta'
Where st_address='alex'

-- 5.Create a view that will display the project name and
-- the number of employees work on it. “Use Company DB”
use Company_SD
create view ProjectAndEmployeesNumber(projectName, numberOfEmployees)
as
select  pname, count(essn) 
from Works_for
inner join Project 
on Works_for.Pno = Project.Pnumber
group by (pname)

select * from ProjectAndEmployeesNumber

-- 6.Create the following schema and transfer the following tables to it 
create schema Company
alter schema Company transfer dbo.departments

create schema HumanResource
alter schema HumanResource transfer dbo.employee

-- 7.Create index on column (manager_Hiredate)
-- that allow u to cluster the data in table Department.
-- What will happen?   Use ITI DB
create clustered index hiredDateIndex
on Department(Manager_hiredate)

-- What Happend => will not create because there is a clusterd
-- index on primary key(Dept_id), The Table can contains
-- only one cluster index

-- 8 8.Create index that allow u to enter 
-- unique ages in student table.
-- What will happen?  - Use ITI DB
create unique index ageUniqueIndex
on Student(st_Age)

-- will not created because the current data in age column
-- not unqiue. unique constraints apply on current data in 
-- column

-- 9.Create a cursor for Employee table that increases 
-- Employee salary by 10% if Salary <3000 and increases
-- it by 20% if Salary >=3000. Use company DB
use Company_SD;
declare c1 cursor
for 
select salary from HumanResource.Employee where salary is not null
for update 
declare @salary int 
open c1 
fetch c1  into @salary
while @@FETCH_STATUS  = 0
	begin
		if @salary < 3000
			update HumanResource.Employee
			set Salary = Salary  + @salary * 0.1
			where current of c1
		else
			update HumanResource.Employee
			set Salary = Salary  + @salary * 0.2
			where current of c1			
		fetch c1  into @salary
	end
close c1
deallocate c1


-- 10.Display Department name with its 
-- manager name using cursor. Use ITI DB
use iti;
declare c1 cursor  
for 
	select Dept_Name, ins_name from Department
	inner join Instructor 
	on Department.Dept_Manager = Instructor.Ins_Id
for read only
declare @deptName varchar(20), @managerName varchar(20)
open c1
fetch c1 into @deptName, @managerName
while @@FETCH_STATUS = 0
	begin 
		select @deptName, @managerName
		fetch c1 into @deptName, @managerName
	end
close c1
deallocate c1

--11.Try to display all instructor names in one cell
-- separated by comma. Using Cursor . Use ITI DB

declare c1 cursor 
for select ins_name from Instructor
for read only
declare @insName varchar(20), @allNames varchar(500)
open c1
fetch c1 into @insName
while @@FETCH_STATUS = 0
	begin
		set @allNames = Concat(@allNames, @insName, ',')
		fetch c1 into @insName
	end
select SUBSTRING(@allNames, 1, len(@allNames) -1)
close c1
deallocate c1


-- 12.Try to generate script from DB ITI that describes all tables and views in this DB