/*insert into dapanes values('751', N'Απρίλιος', 2014, 'αβγ', 'fix', 78);*/
/*create table dapanes2(
buildingID varchar(3) not null, 
theMonth nvarchar(15) not null, 
theYear int not null, 
costCategory nvarchar(20) not null, 
costDescription nvarchar(40) not null, 
cost smallmoney not null,
check(len(buildingID) != 0),
check(len(theMonth) != 0),
check(len(theYear) = 4),
check(len(costCategory) != 0),
check(len(costDescription) != 0),
check(len(cost) != 0),
check(cost > 0),
unique(buildingID, theMonth, theYear, costCategory, costDescription)
);*/
insert into dapanes values('751', N'Απρίλιος', 2014, N'Γενικά κοινόχρηστα', 
N'ΔΕΗ', 139.50);
select * from dapanes;
