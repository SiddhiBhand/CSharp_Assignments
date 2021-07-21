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

SELECT COUNT(EmpId), Addresss
FROM Employee
GROUP BY Addresss
ORDER BY COUNT(EmpId) DESC;
-------------------joins---------------------

SELECT * FROM Employee
INNER JOIN Department
ON Employee.EmpId=Department.EmpId; --inner join

SELECT * FROM Employee
LEFT JOIN Department
ON Employee.EmpId=Department.EmpId; --left join

SELECT * FROM Employee
RIGHT JOIN Department
ON Employee.EmpId=Department.EmpId; --right join

SELECT * FROM Employee
FULL JOIN Department
ON Employee.EmpId=Department.EmpId; --full join

----------------------------------------------

create table student(Id int,Name varchar(20),Marks int);
insert into student values(10,'Siddhi',44);
insert into student values(11,'Sayali',46);
insert into student values(12,'trupti',40);
insert into student values(14,'trupti',48);
select * from student;  

-- ******************19 July Assignment********************************

delete from student; --Delete without where delete all the row from table but structure of table not deleted
                     --Delete is deliting the row 
update student set Marks=40; --update without where update the all values of marks column

truncate table student where name="Siddhi";--we use where with truncate

--Alter constraint ,Alter the columns with datatype and also range
ALTER TABLE student      
ADD department varchar;--alter for add column

ALTER TABLE student      
ALTER COLUMN department varchar(20);--alter for change the datatype of column

ALTER TABLE student     
DROP COLUMN department;--alter for drop column

ALTER TABLE student    
ADD CONSTRAINT MyUniqueConstraint UNIQUE(Id);--add unique constraint

ALTER TABLE student 
DROP CONSTRAINT MyUniqueConstraint; --drop unique constraint

ALTER TABLE student      
ALTER COLUMN Id int not null

-- aggregate function---

SELECT AVG(Marks) FROM student

SELECT COUNT(*) FROM student
SELECT COUNT(Id) FROM student
SELECT COUNT(DISTINCT Name) AS NumberOfStudent FROM student  --count unique name in student table

SELECT Last(Id) FROM student--(not executed)
SELECT FIRST(Id) FROM student--(not executed)

SELECT MAX(Marks) FROM student
SELECT MIN(Marks) FROM student
SELECT SUM(Marks) FROM student

SELECT Name,SUM(Marks) FROM student
GROUP BY Name  --group by name and addition of marks perform
               --Sayali	46
			   --Siddhi	44
               --trupti	88

SELECT Name,SUM(Marks) FROM student
GROUP BY Name
HAVING SUM(Marks)>44  --having clause

SELECT * FROM student
ORDER BY Name Desc  --order by

SELECT * FROM student
WHERE Name LIKE 's%'  --like

------Scalar function-------
SELECT UCASE(Name) FROM student --(not executed)
SELECT LCASE(Name) FROM student --(not executed)
SELECT MID(Name,1,3) as SmallName FROM student --(not executed)

SELECT LEN(Name) as LengthOfName FROM student
