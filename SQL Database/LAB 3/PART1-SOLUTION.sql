-- LAB 3 - Part 1

-- 1 dept and its manager
select d.dnum, d.dname, e.SSN, e.fname + ' ' + e.Lname as  'manager name'  
from departments d 
inner join Employee e
on d.MGRSSN = e.SSN

-- 2 detp and its project
select d.dname, p.pname
from Departments d 
inner join Project p
on p.Dnum = d.dnum

-- 3 employee and dependens
select e.Fname + ' ' + e.Lname as 'Employee Name', d.*
from Employee e
inner join Dependent d
on d.ESSN = e.SSN

-- 4 prjects in alex and cairo
select Pnumber, Pname, Plocation 
from Project
where City in('alex', 'cairo')

-- 5 projects start with 'a'
select * from Project 
where Pname like 'a%'

-- 6 emps in dept 3 and salary 1000 - 2000
select * from Employee
where Dno = 30 and Salary between 1000 and 2000

-- 7 emps in dept 10 and work > 10 hrs in Al Rabwah
select e.fname + ' ' + e.lname as 'Employee Name'
from Employee e
inner join Works_for w 
on e.SSN = w.ESSn and w.Hours >= 10
inner join Project p
on w.Pno = p.Pnumber and p.Pname = 'AL Rabwah'

-- 8 supervisor on kamel mohamed
select s.fname + ' ' + s.lname 
from Employee e , Employee s
where s.SSN = e.Superssn
and e.fname + ' ' + e.lname = 'Kamel Mohamed'

-- 9 emps and their projects order by pname
select e.fname + ' ' + e.lname as 'Employee Name', p.pname
from Employee e 
inner join Works_for w
on w.ESSn = e.SSN
inner join Project p 
on w.Pno = p.Pnumber
order by p.pname

-- 10 prject and its dept, and manager of dept
select p.pname , d.Dname, e.Lname, e.address, e.bdate
from Project p 
inner join Departments d
on p.Dnum = d.Dnum and p.City = 'cairo'
inner join Employee e
on d.MGRSSN = e.SSN

-- 11 
-- all supervisors
select distinct m.* 
from Employee e, Employee m
where e.Superssn = m.SSN

-- all department manager
select m.* 
from Employee m
inner join Departments d
on d.MGRSSN = m.SSN

-- 12 employees and their dependents
select e.*, d.Dependent_name, d.Sex, d.Bdate from Employee e
left outer join Dependent d
on d.ESSN = e.SSN

-- 13 insert data to employee
insert into Employee 
values ('Abdallah', 'Mostafa', 102672, 
		'8/29/2000', 'Cairo', 'M', 3000, 
		112233, 30)

-- 14  
insert into Employee (Fname, Lname, SSN, Bdate, Address, Sex, Dno)
values ('Mohamed', 'Essam', 102660, '6/3/2000', 'Giza', 'M', 30)

-- 15 
update Employee set Salary += Salary * 0.2 
where SSN = 102672
