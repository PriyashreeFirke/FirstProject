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
select * from book1;

