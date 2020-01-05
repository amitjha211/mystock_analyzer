use mystock
GO
create table mStock
(
	id int primary key identity(1,1)
	, symbol varchar(40) not null 
	,series varchar(2) not null
	, company_name varchar(150) not null
	, band varchar(100)
	, remarks varchar(1000)
)
go
alter table mStock
	add constraint uc_mStock_symbol_series unique (Symbol,id)
	
go

create table mIndex
(
	id int primary key identity(1,1)
	,indexName varchar(100) unique not null
	, remarks varchar(500)
)
go
create table mIndexStock
(
	id int primary key identity(1,1)
	,mIndexID int references mIndex not null
	,mStockID int references mStock not  null
)


GO

