/*create table dapanes(buildingID varchar(3), theMonth varchar(15), theYear int, costCategory varchar(20), costDescription varchar(40), cost smallmoney);
*/
/*create table costPreDefinedItems(costCategory varchar(20) not null check (costCategory != ''), costDescription varchar(40),
constraint unique_combination unique(costCategory, costDescription));*/

select * from costPreDefinedItems;