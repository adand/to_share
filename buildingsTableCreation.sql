/*create table Buildings(buildingID varchar(3) primary key, bAddress nvarchar(20) not null, bArea nvarchar(20) not null, constraint location unique(bAddress, bArea),
check(len(buildingID) > 0), check(len(bAddress) > 0), check(len(bArea) > 0));*/

/*insert into buildings values('001','addr1','ar1');
insert into buildings values('002','addr2','ar2');*/

delete from Buildings where buildingID != '034' and buildingID != '035';

