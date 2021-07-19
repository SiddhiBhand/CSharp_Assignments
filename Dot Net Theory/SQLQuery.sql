drop table table1;

Create table Employee(EmpId int primary key, EmpName varchar(20),Addresss varchar(30));

Alter table Employee add MobileNo varchar(10);  	

alter table Employee add Age int;



insert into Employee values (01,'Siddhi','Pune','7058112233',22);
insert into Employee values (02,'Sayali','Mumbai','9558112233',21);
insert into Employee values (03,'Trupti','Pune','9558112873',23);
insert into Employee values (04,'Jay','Mumbai','990412233',22);
insert into Employee values (05,'Akash','Satara','9558102533',21);
insert into Employee values (06,'Revati','Baramati','9558112354',21);
insert into Employee values (07,'Ranjit','Sangli','9558704569',21);
insert into Employee values (08,'Utkarsha','Mumbai','9558112415',21);
insert into Employee values (09,'Vikas','solapur','9654341774',21);

alter table Employee add constraint uni unique(MobileNo);

delete from Employee where EmpId=9;

select * from Employee;

create table Department (DeptId int not null,DeptName varchar(20),EmpId int foreign key references Employee(EmpId));
drop table Department;

insert into Department values(101,'Computer',01);
insert into Department values(102,'Civil',02);
insert into Department values(103,'IT',04);
insert into Department values(104,'E & TC',06);
insert into Department values(105,'Computer',08);

update Department set EmpID=09 where EmpId=08;

delete from Department where DeptId=101;
truncate table Department;
select * from Department;