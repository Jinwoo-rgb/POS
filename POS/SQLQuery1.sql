

create table tblMain
(
MainID int primary key identity,
aDate date,
aTime varchar(15),
TableName varchar(10),
WaiterName varchar(15),
status varchar(15),
ordertype varchar(15),
total float,
recieved float,
change float
)

create table tblDetails
(
DetailID int primary key identity,
MainID int,
proID  int,
qty int,
price float,
amount float
)

truncate table tblDetails;
truncate table tblMain;

select * from tblMain m
inner join tblDetails d on m.MainID = d.MainID