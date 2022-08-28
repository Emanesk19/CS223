create database c#Database
use c#Database

Create table Product
(
	ProNumber int,
	Proname varchar(30),
	Quantity int,
	price Money,
	EntryDate varchar(30),
	inventoryNumber int,
	isAvailable bit
)
select *from Product
delete Product