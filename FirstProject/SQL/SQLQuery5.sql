use master;
select * from trainer;
select * from student1;


use hcl;
create table author
(aid int primary key identity(1,1),
aname varchar(30));

create table book1
(
book1id int primary key,
book1name varchar(30),
authorid int,
constraint fid foreign key (authorid) references author(aid));

insert into author(aname) values('kantekar'),('balgiuruswamy'),('kathy');

insert into book1 values(102,'java',2);
select * from author;

create table trainer
(tid  int primary key,
tname varchar(30),
texp int);

create table batch
(batchid int primary key,
batchname varchar(30),
traineerid int,
constraint keyid Foreign key(traineerid) references trainer(tid));

create table student1
(std int primary key,
sname varchar(30),
batchid int,
constraint fkid Foreign key(batchid) references batch(batchid));

insert into trainer values(1,'deepamam',2);
insert into trainer values(2,'kalyanimam',3);
insert into trainer values(3,'meghamam',4);

insert into batch values(1,'hcl',2);
insert into batch values(2,'wipro',3);
insert into batch values(3,'funda',1);

insert into student1 values(111,'priya',1);
insert into student1 values(112,'ria',2);
insert into student1 values(113,'ovi',3);

select * from batch;
select * from trainer;
select * from student1;


alter table book1
drop constraint fid;

alter table book1
add foreign key(authorid) references author(aid)
on delete set null on update cascade;
select * from book1;

delete from author where aid=2;
create table Stud_attendence
(sid int,
att_date date,
present char(1),
primary key(sid,att_date),
foreign key(sid) references student1(std));

insert into Stud_attendence values(111,'2022-09-07','p');
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











