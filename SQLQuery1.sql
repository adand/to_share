/*create table dapanes(buildingID varchar(3), theMonth varchar(15), theYear int, costCategory varchar(20), costDescription varchar(40), cost smallmoney);
*/
/*create table costPreDefinedItems(costCategory varchar(20) not null check (costCategory != ''), costDescription varchar(40),
constraint unique_combination unique(costCategory, costDescription));*/

/*create table test(a int, b varchar(10));*/

/*insert into test values(123, 'abc');
insert into test values(124, 'bcd');
insert into test values(125, 'efg');
insert into test values(123, 'wxy');
insert into test values(123, 'abc');
*/

select * from costPredefinedItems;