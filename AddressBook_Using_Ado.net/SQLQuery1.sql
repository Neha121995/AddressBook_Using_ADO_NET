--UC1 : create a new db for address book----
create database addressBook;

--use db for address book----
use addressBook;

--UC2 : Create table for address book----
create table addressBook
(
first_name varchar(50) not null,
last_name varchar(50) not null,
address varchar(100) not null,
city varchar(20) not null,
state varchar(50) not null,
zip varchar(6) not null,
phone_number varchar(11) not null,
email varchar(50) not null,
bookname varchar(100) ,
addressbooktype varchar(50)
);

--Display table for address book----
select * from addressBook;

CREATE PROCEDURE addressBookProcedure
@first_name varchar(50) ,
@last_name varchar(50) ,
@address varchar(100),
@city varchar(20),
@state varchar(50),
@zip varchar(6),
@phone_number varchar(11),
@email varchar(50),
@bookname varchar(100) ,
@addressbooktype varchar(50)
as
insert into addressBook values(@first_name,@last_name,@address,@city,@state,@zip,@phone_number,
    @email,@bookname,@addressbooktype);
go

select * from addressBook;

