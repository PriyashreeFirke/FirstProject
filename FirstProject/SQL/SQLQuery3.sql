alter table book1
drop constraint fid;

alter table book1
add foreign key(authorid) references author(aid)
on delete set null on update cascade;
select * from book1;

insert into book1 values(103,'c++',1);

select * from author;

delete from author where aid=2;
