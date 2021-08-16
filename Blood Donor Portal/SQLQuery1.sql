select * from Users
insert into Users values ('demo1@mail.com','demo1','123')
select Username,Password from  Users where (Username='demo1' And Password='123')
truncate table Users