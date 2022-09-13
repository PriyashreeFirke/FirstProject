use hcl;
--tinyint,smallint,int,bigint,float,decimal,char,varchar(20),binary,date,datetime,time
create table student
(
sid int,
student varchar(20),
city varchar(20));


--query

insert into student values (1,'priya','pune');
insert into student values (2,'riya','MP');
insert into student values (1,'ira','Up');

select sid,student name,city from student;
select * from student;
