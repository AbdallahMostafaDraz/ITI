--  1.Retrieve number of students who have a value in their age.
Select count(st_age) as numberOfStduentsHasAge from student

-- 2.Get all instructors Names without repetition
select distinct Ins_Name from Instructor

-- 3.Display student with the following Format (use isNull function)
select s.St_Id as 'Stduent ID', 
isnull(s.St_Fname, ' ') + ' ' + isnull(s.St_Lname,' ') as 'Student Name' ,
isnull(d.Dept_Name, 'No Department') as 'Department Name'
from Student s
inner join 
Department d
on s.Dept_Id = d.Dept_Id

-- 4.Display instructor Name and Department Name 
select inst.ins_name, dept.Dept_Name from 
instructor inst
left join Department dept
on inst.Dept_Id = dept.Dept_Id


-- 5.Display student full name and the name of the course he is taking
-- For only courses which have a grade
select 
IsNull(s.St_Fname , '') + ' ' + isnull(s.St_Lname, '') as 'Stduent Name',
stuCrs.Crs_Id, stuCrs.Grade
from Student s
inner join Stud_Course stuCrs
on s.St_Id = stuCrs.St_Id and stuCrs.Grade is not null
inner join Course c
on stuCrs.Crs_Id = c.Crs_Id

-- 6.Display number of courses for each topic name
select T.Top_Name, count(c.top_id) as numberOfCourse
from Topic t
inner join
Course c
on t.Top_Id = c.Top_Id
group by t.Top_Name

-- 7.Display max and min salary for instructors
select min(salary) as minimum,
max(salary) as maximum
from Instructor

-- 8.Display instructors who have salaries less than the average salary of all instructors.
select * from Instructor
where salary < (select avg(salary) from Instructor)

-- 9.Display the Department name that contains the instructor who receives the minimum salary.
select d.Dept_Name from 
Department d
inner join 
Instructor i 
on i.Dept_Id = d.Dept_Id and i.Salary = (select min(salary) from Instructor)


-- 10.Select max two salaries in instructor table
Select top 2 salary from Instructor
order by Salary desc

-- 11.Select instructor name and his salary but if there is no salary display instructor bonus. “use one of coalesce Function”
select COALESCE(salary, 100) AS salaryOrBonus
from Instructor

-- 12.Select Student first name and the data of his supervisor
select s.St_Fname, i.* 
from Student s
inner join instructor i
on s.st_super = i.ins_id


-- 13.Write a query to select the highest two salaries in Each Department 
-- for instructors who have salaries. “using one of Ranking Functions”
select dept_id, Salary from (select *, ROW_NUMBER()
over (partition by dept_id order by salary desc) as rn
from Instructor where Salary is not null) newTable where rn <= 2

-- 14.Write a query to select a random  student from each department.  “using one of Ranking Functions”
select * from 
(select * , 
ROW_NUMBER() over (partition by dept_id order by newId()) as rn
from Student
)  newTablee
where rn=1

-- 15.Delete all grades for the students whose Located in SD Department
delete from Stud_Course where 
st_id IN
(select Student.St_Id from Student 
INNER JOIN 
Department 
ON Student.Dept_Id = Department.Dept_Id
where Department.Dept_Name = 'SD')

-- 16.Using Merge statement between the following two tables [User ID, Transaction Amount]
create table dailyTarnsaction
(userId int, 
amount decimal(18,2)
);
create table lastTarnsaction
(userId int, 
amount decimal(18,2)
);

insert into dailyTarnsaction
values(1, 1000),
(2, 2000),
(3, 1000)


insert into lastTarnsaction
values(1, 4000),
(4, 2000),
(2, 10000)

merge into lastTarnsaction as T
using dailyTarnsaction as S
on T.userId = S.userId
when matched then 
update set T.amount = S.amount
when not matched then 
insert values(s.userId, s.amount);

-----------------------------------------
-- task 2

-- 1.Display the SalesOrderID, ShipDate of the SalesOrderHeader table 
--(Sales schema) to designate 
-- SalesOrders that occurred within the period ‘7/28/2002’ and ‘7/29/2014’
select SalesOrderID, ShipDate from Sales.SalesOrderHeader
where OrderDate between '7/28/2002' and '7/29/2014'

-- 2.Display only Products(Production schema) 
-- with a StandardCost below $110.00 (show ProductID, Name only)
select ProductID, Name from Production.Product
where StandardCost < 110

-- 3. Display ProductID, Name if its weight is unknown
select ProductID, Name from Production.Product 
where weight is null

-- 4. Display all Products with a Silver, Black, or Red Color
select ProductID, Name, Color from Production.Product 
where Color in ('Silver', 'Black', 'Red')

-- 5. Display any Product with a Name starting with the letter B
select ProductID, Name from Production.Product
WHERE Name Like 'B%'

-- 6.6.Run the following Query
-- Then write a query that displays any Product description with underscore value in its description.
UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

select  Description
from Production.ProductDescription
where Description like'%[_]%'

-- 7. Calculate sum of TotalDue for
-- each OrderDate in Sales.SalesOrderHeader table for
-- the period between  '7/1/2001' and '7/31/2014'

select OrderDate ,SUM(TotalDue) as total from Sales.SalesOrderHeader
where OrderDate between '7/1/2001' and '7/31/2014'
group by OrderDate

-- 8. Display the Employees HireDate (note no repeated values are allowed)
select distinct  HireDate from HumanResources.Employee

-- 9.Calculate the average of the unique ListPrices in the Product table
select avg(distinct ListPrice) as average from Production.Product

--  10.Display the Product Name and its ListPrice within 
-- the values of 100 and 120 the list should has the following 
-- format "The [product name] is only! [List price]"
-- (the list will be sorted according to its ListPrice value)
select 'The [' + Name + ']  is only! [' + CAST(ListPrice AS VARCHAR) +']'
from Production.Product
where ListPrice between 100 and 120
order by ListPrice

-- 11 
-- a.  Transfer the rowguid ,Name,
-- SalesPersonID, Demographics from Sales.Store table 
-- in a newly created table named [store_Archive]
select  
rowguid ,Name,
SalesPersonID, Demographics
into store_Archive
from Sales.Store
-- b.
select  
rowguid ,Name,
SalesPersonID, Demographics
into store_Archive2
from Sales.Store
where 1 = 2


-- 12.Using union statement, retrieve the today’s date in different styles
SELECT CONVERT(VARCHAR, GETDATE(), 101)  
UNION
SELECT CONVERT(VARCHAR, GETDATE(), 103)
UNION
SELECT CONVERT(VARCHAR, GETDATE(), 104) 
UNION
SELECT CONVERT(VARCHAR, GETDATE(), 105) 
UNION
SELECT CONVERT(VARCHAR, GETDATE(), 110) 
UNION
SELECT CONVERT(VARCHAR, GETDATE(), 120) 
UNION
SELECT FORMAT(GETDATE(), 'dddd, MMMM dd, yyyy') 
UNION
SELECT FORMAT(GETDATE(), 'yyyy/MM/dd');
