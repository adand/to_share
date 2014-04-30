/*create table dapanes(buildingID varchar(3), theMonth varchar(15), theYear int, costCategory varchar(20), costDescription varchar(40), cost smallmoney);
*/
/*create table costPreDefinedItems(costCategory varchar(20) not null check (costCategory != ''), costDescription varchar(40),
constraint unique_combination unique(costCategory, costDescription));*/

/*insert into costPreDefinedItems values('c1','d1');
insert into costPreDefinedItems values('c1','');
insert into costPreDefinedItems values('c1','d1');
insert into costPreDefinedItems values('','d2');*/

/*select * from costPreDefinedItems;

create table test(notnull varchar(10) check (notnull != ''));*/

/*drop table costPreDefinedItems;*/

/*select * from costPreDefinedItems;
update costPreDefinedItems
set costDescription = null
where costDescription = 'cd3';*/

select * from buildings;
/*insert into buildings values('503', 'addr503', 'ar301');*/