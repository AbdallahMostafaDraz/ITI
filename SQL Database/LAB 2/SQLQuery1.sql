-- LAB 2 Part2
use company_sd

-- 1 
select * from Employee

-- 2 
select fname, lname, salary, dno from Employee

-- 3
select pname, plocation, Dnum from Project

-- 4 
select fname + ' ' + lname as [Full Name], 
Salary * 0.1 as [Annual Salary]
from Employee

-- 5 
select ssn, fname + ' ' + lname as [Full Name] 
from Employee where Salary > 1000

-- 6
select ssn, fname + ' ' + lname as [Full Name] 
from Employee where Salary > 10000

-- 7 
select fname + ' ' + lname as [Full Name], Salary
from Employee where sex = 'F'

-- 8
select dnum, dname from Departments
where MGRSSN = 968574

-- 9
select Pnumber, Pname, Plocation 
from Project
where Dnum = 10