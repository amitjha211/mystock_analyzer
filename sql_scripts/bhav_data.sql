use mystock
go
DROP TABLE trDaily_Price

create table trDaily_Price
(
	 id					int identity(1,1)
	,mStockID           int not null references mStock
	,symbol				varchar(30)		
	,series				varchar(30)
	,date1				date
	,prev_close			numeric(18,2) not null default(0.00)
	,open_price			numeric(18,2) not null default(0.00)
	,high_price			numeric(18,2) not null default(0.00)
	,low_price			numeric(18,2) not null default(0.00)
	,last_price			numeric(18,2) not null default(0.00)
	,close_price		numeric(18,2) not null default(0.00)
	,avg_price			numeric(18,2) not null default(0.00)
	,ttl_trd_qnty		numeric(18,2) not null default(0.00)
	,turnover_lacs		numeric(18,2) not null default(0.00)
	,no_of_trades		numeric(18,2) not null default(0.00)
	,deliv_qty			numeric(18,2) not null default(0.00)
	,deliv_per			numeric(18,2) not null default(0.00)
	,remarks			varchar(500) 
)


create view vtrDaily_Price
as
select 
	trDaily_Price.* 
	,mStock.company_name
from trDaily_Price left join mStock on trDaily_Price.mStockID = mStock.id



