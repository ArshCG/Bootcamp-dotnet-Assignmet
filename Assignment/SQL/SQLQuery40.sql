use office;
go

create table employee(emp_id int primary key identity(1,1),emp_name varchar(30) not null,emp_gender varchar(10) check(emp_gender in ('Male', 'Female')),emp_pos varchar(30) not null,emp_project varchar(30));  

select * from employee;