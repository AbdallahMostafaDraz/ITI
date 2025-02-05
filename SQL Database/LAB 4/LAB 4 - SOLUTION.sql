-- LAB 4
use Company_SD

-- 1 1.Display (Using Union Function)
select d.Dependent_name, d.sex 
from Dependent d
inner join employee e
on d.ESSN = e.SSN and d.Sex = 'f' and e.Sex = 'f'
union 
select d.Dependent_name, d.sex 
from Dependent d
inner join employee e
on d.ESSN = e.SSN and d.Sex = 'm' and e.Sex = 'm'


-- 2 
select p.pname, sum(hours) from Project p
inner join works_for w
on p.Pnumber = w.Pno
group by p.Pname

-- 3
select d.*, e.SSN from Departments d
inner join Employee e 
on d.dnum = e.Dno and e.SSN = (select min(SSN) from Employee)

-- 4 
select d.dname, max(e.salary) as 'Maximum Salary',
min(e.salary) as 'Minmum Salary'
from Departments d
inner join employee e
on e.Dno = d.Dnum
group by d.dname

-- 5 
select distinct fname + ' ' + lname as 'Full Name'
from Employee e
inner join Departments d
on d.MGRSSN = e.SSN and d.MGRSSN not in (select ESSN from Dependent)

-- 6
select d.dnum, d.dname, count(e.ssn)
from Departments d 
inner join Employee e
on e.Dno = d.Dnum 
group by d.dnum, d.dname
having avg(e.Salary) < (select avg(Salary) from Employee)

-- 7
select e.fname + ' ' + e.lname as 'full name', p.pname 
from Employee e
inner join Works_for w
on w.ESSn = e.SSN
inner join Project p
on w.Pno = p.Pnumber
order by p.Dnum, e.Fname, e.Lname

-- 8 

select max(salary) from Employee
union all
select max(salary) from Employee where Salary < (select MAX(salary) from Employee)


-- 9 
select distinct e.fname + ' ' + e.lname 
from Employee e 
inner join Dependent d
on d.Dependent_name like CONCAT('%', e.Fname + ' ' + e.Lname, '%') 

-- 10
select distinct ssn, fname + ' ' + lname as 'Full Name'
from Employee e
where exists (select * from Dependent d where e.SSN = d.ESSN)

-- 11
insert into Departments 
values ('DEPT IT', 100, 112233 , '1/11/2006')

-- 12
update Departments set MGRSSN = 968574
where Dnum = 100

update Departments set MGRSSN = 102672
where Dnum = 20

update Employee set Superssn = 102672
where SSN = 102660 

-- 13
begin transaction
update Dependent set ESSN = 102672 where ESSN = 223344
update Employee set  Superssn = 102672 where Superssn = 223344 
update Departments set MGRSSN = 102672 where MGRSSN = 223344
update Works_for set ESSn = 102672 where ESSn = 223344
delete from Employee where ssn = 223344
commit;

-- 14
update Employee set Salary += Salary * 0.3
where SSN = (
select essn from Works_for
inner join Project 
on Pno = Pnumber and Pname = 'Al Rabwah')

