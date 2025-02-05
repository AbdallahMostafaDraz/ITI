-- 1 scalr function takes date and return month name
create function GetMonthName(@date date)
returns varchar(10)
begin
	return format(@date,'MMMM')
end

select dbo.GetMonthName('1/9/2025')

-- 2. Create a multi-statements table-valued function that takes 2 integers
-- and returns the values between them
create function GetRange(@num1 int, @num2 int)
returns @t table (numbers int)
as 
begin 
	declare @currentNum int
	set @currentNum = @num1
	while @currentNum <= @num2
	begin 
		insert into @t select @currentNum

		set @currentNum = @currentNum + 1
	end
	return
end

select * from GetRange(10, 20)

-- 3.reate inline function that takes Student No and 
-- returns Department Name with Student full name.
create function GetStuInfo(@stuId int)
returns table
as 
return 
(
select st_fname + ' ' + st_lname as fullName, dept_name  
from Student s
inner join 
Department d
on s.Dept_Id = d.Dept_Id and s.St_Id = @stuId
)

select * from GetStuInfo(1)

-- 4 Create a scalar function that takes Student ID
-- and returns a message to user
create function GetStuName(@stuId int)
returns nvarchar(50)
begin 
	declare @fname nvarchar(10)
	declare @lname nvarchar(10)
	
	select @fname = st_fname, @lname = St_lname
	from Student where St_Id = @stuId

	if @fname is null and @lname is null
		return 'First name & last name are null'
	else if @fname is null
		return 'First name is null'
	else if @lname is null
		return 'Last name is null'
		
	return 'First name & last name are not null'		
end

select dbo.GetStuName(1)
select dbo.GetStuName(14)
select dbo.GetStuName(13)

--  5.Create inline function that takes integer which represents manager ID 
-- and displays department name, Manager Name and hiring date 

create function GetManagerInfo(@mngrId int)
returns table
as
return 
(
select dept_name, ins_name as managerName, Manager_hiredate 
from Department d
inner join Instructor i
on d.Dept_Manager = i.Ins_Id and d.Dept_Manager = @mngrId
)

select * from GetManagerInfo(2)

-- 6 6.Create multi-statements table-valued function that takes a string
-- If string='first name' returns student first name
-- If string='last name' returns student last name 
-- If string='full name' returns Full Name from student table 
-- Note: Use “ISNULL” function

create function getByColumnName(@columnName nvarchar(20))
returns @t table (name varchar(25))
as
begin 
	if @columnName = 'first name'
		insert into @t select isNull(st_fname, 'No First Name') from Student
	else if @columnName = 'last name'
		insert into @t select ISNULL(st_lname, 'No Last Name') from Student 
	else 
		insert into @t values('No Values')
	return
end
select * from getByColumnName('first name')
select * from getByColumnName('last name')
select * from getByColumnName('no')

-- 7 Write a query that returns
-- the Student No and Student first name without the last char
select st_id, SUBSTRING(st_fname, 1, len(st_fname) - 1) 
from Student

-- 8Wirte query to delete all grades for the students Located in SD Department 
delete from Stud_Course where 
st_id IN
(select Student.St_Id from Student 
INNER JOIN 
Department 
ON Student.Dept_Id = Department.Dept_Id
where Department.Dept_Name = 'SD')


-- 9. merge into lastTarnsaction as T
merge into lastTarnsaction as T
using dailyTarnsaction as S
on T.userId = S.userId
when matched then 
update set T.amount = S.amount
when not matched then 
insert values(s.userId, s.amount);

-- 10 login
