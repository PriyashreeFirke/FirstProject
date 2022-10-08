use hcl;
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



create table Stud_attendence
(sid int,
att_date date,
present char(1),
primary key(sid,att_date),
foreign key(sid) references student1(std));

insert into Stud_attendence values(111,'2022-09-07','p');
select * from Stud_attendence;
