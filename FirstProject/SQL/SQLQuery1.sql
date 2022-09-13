




use Hr;
select * from employees where salary>=1000 or job_id=9;

select first_name,salary,email from employees
where department_id=3 or department_id=6 or department_id=9;

select * from employees where department_id in(3,6,9);

select * from employees where department_id not in(3,6,9);

select * from employees where salary>=10000 and salary <=20000;

select * from employees where salary between 10000 and 20000;

select * from employees where phone_number is null;


select * from employees order by salary desc;
select * from employees order by salary;

select * from employees order by salary ,first_name ;
select * from employees order by salary desc, first_name desc;

use hcl;
use Hr;
select * from employees order by salary ,first_name ;
select * from employees order by salary desc, first_name desc;

--like operator
--wild character %(zero or more) and _(single) (underscore) for pattern matching

select * from employees where first_name like 'j%n';
select * from employees where first_name like 'j__';
select * from employees where first_name like 'j%';
select * from employees where first_name like 'j%a%n';

select distinct department_id from employees;

--aggregate avg,max,min,sum,count

select max (salary) 'Maxsal' from employees;
select min (salary) 'minsal' from employees;
select sum (salary) 'sum' from employees;
select avg (salary)'avg' from employees;

select count(salary) from employees;

select count (phone_number) from employees;
--count record
select count (*) from employees;
---departmentn0= 6 find max salary
select max (salary)'maxsal' from employees where department_id=6;

select department_id, max (salary) from employees group by department_id;

--count department_id
select department_id, count(*) from employees group by department_id;











