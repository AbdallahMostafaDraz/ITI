-- 1.Create a stored procedure without parameters to show 
-- the number of students per department name.[use ITI DB] 
create proc NumberOfStudent
as
select Dept_Name, count(st_id) as numberOfStudent 
from Student 
inner join Department  
on Student.Dept_Id = Department.Dept_Id
group by Dept_Name

NumberOfStudent

-- 2.Create a stored procedure that will check for
-- the # of employees in the project p1 
-- if they are more than 3 print message to the user 
-- “'The number of employees in the project p1 is 3 or more'”
-- if they are less display a message to 
-- the user “'The following employees work for 
-- the project p1'” in addition to the first name
-- and last name of each one. [Company DB] 
use Company_SD

create proc checkEmpsOfProject @pName varchar(20)
as
	declare @numberOfEmp int
	select @numberOfEmp = 
	 COUNT(essn) from Works_for
	inner join Company.Project
	on pno = Pnumber
	where Pname = @pName

	if @numberOfEmp > 3
		select 'The number of employees in the project ' + @pName + ' is 3 or more'
	else
	begin 
		select 'The following employees work for the project' +  @pName 
		select  fname + ' ' + lname as fullName  from 
		Works_for
		inner join
		HumanResource.Employee
		on Works_for.essn = SSN
		inner join Company.Project
		on Works_for.Pno = Pnumber and Pname = @pName
		
	end

checkEmpsOfProject 'AL Solimaniah'


-- 3.Create a stored procedure that will be used
-- in case there is an old employee has left the project 
-- and a new one become instead of him. 
-- The procedure should take 3 parameters 
-- (old Emp. number, new Emp. number and the project number) 
-- and it will be used to update works_on table. [Company DB]
create procedure OnUpdateWorks_for (@oldEmp int, @newEmp int, @projNO int)
as
	if exists (select * from Works_for where ESSn = @oldEmp and Pno = @projNO)
	begin 
		update Works_for set ESSn = @newEmp
		where ESSn = @oldEmp and Pno = @projNO

		select CONCAT('Project No: ', @projNO,
				  ', Old Emp.No: ', @oldEmp, 
				 ', New Emp.No: ', @newEmp)
	end
	else
		select 'Project Number or Old Employee Number Not Exist!'
	
OnUpdateWorks_for 102672, 521634, 100 


-- 4.add column budget in project table and insert any
-- draft values in it then 
-- then Create an Audit table with the following structure 
alter table  Company.Project
add budget int;

create Table AuditTable
(projectNo int primary key, 
UserName varchar(25),
ModifiedDate Date, 
budget_Old int,
budget_New int)

SELECT * FROM Company.Project

alter trigger t1
on company.Project 
after update
as
	if UPDATE(budget)
	begin
		insert into AuditTable (projectNo, UserName, ModifiedDate, budget_Old, budget_New)
		select inserted.Pnumber,
		SYSTEM_USER,
		getdate(),
		deleted.budget, 
		inserted.budget
		from inserted 
		inner join deleted
		on inserted.Pnumber = deleted.Pnumber	
	end


update Company.Project set budget = 66000 where Pnumber = 100

select * from auditTable

-- 5.Create a trigger to prevent anyone from inserting 
-- a new record in the Department table [ITI DB]
-- “Print a message for user to tell him that he can’t insert a new record in that table”
use iti
create trigger t2
on department
instead of insert
as 
select 'Print a message for user to tell him that he can’t insert a new record in that table'

insert into Department(Dept_Name)
values('.net')

-- 6. Create a trigger that prevents the insertion Process 
-- for Employee table in March [Company DB].
use Company_SD
create trigger t3
ON HumanResource.Employee
after insert
as
 if format(getdate(), 'MMMM') = 'March'
	begin 
		delete from HumanResource.Employee 
		where SSN = (select top 1 SSN from inserted)
		
		select 'cannot insert in march'
	end


-- 7.Create a trigger on student table after insert to 
-- add Row in Student Audit table 
-- (Server User Name , Date, Note) where note will be
-- “[username] Insert New Row with Key=[Key Value]
-- in table [table name]”
use ITI
create table AuditStudent
(ServerUserName varchar(20),
InsertDate Date, 
Note Varchar(100))

create trigger  t5
on Student
after insert
as
begin
	declare @stu_id int
	select @stu_id =  St_Id from inserted

    INSERT INTO Student_Audit (ServerUserName, AuditDate, Note)
    SELECT 
        SYSTEM_USER ,          
        GETDATE() ,                 
        '[ ' + SYSTEM_USER + '] Inserted a new row with Key=[' + CAST(@stu_id AS NVARCHAR) + 
        '] in table [Student]'            
END


-- 8. Create a trigger on student table instead of 
-- delete to add Row in Student Audit table 
-- (Server User Name, Date, Note) 
-- where note will be“ try to delete Row with Key=[Key Value]”

create trigger T6
on Student
instead of delete
as
begin
	declare @stu_id int
	select @stu_id =  St_Id from inserted

    INSERT INTO Student_Audit (ServerUserName, AuditDate, Note)
    SELECT 
        SYSTEM_USER ,          
        GETDATE() ,                 
        'Try To Delete Row With Key=[' + CAST(@stu_id AS NVARCHAR) + ']'           
END

