/*select * from dapanes where buildingID = '034';*/
/*select apartmentID from apartments where buildingID = '034';*/
select apartmentID as 'Apartment ID', 
	generalProportion as 'General Proportion',
	(select sum(cost) * ( a1.generalProportion / 1000 )
	from dapanes A2 
	where theMonth = N'Ιούνιος' 
	and theYear = 2014 
	and A2.buildingID = A1.buildingID 
	and costCategory = N'Γενικά κοινόχρηστα') Cost
from Apartments A1
where A1.buildingID = '034';