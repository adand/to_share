create table Apartments(buildingID varchar(3) foreign key references Buildings(buildingID) not null, owner nvarchar(20) not null, apartmentID nvarchar(3) not null,
	generalProportion decimal(8,2) not null, elevatorProportion decimal(8,2) not null,
	constraint uniqueDepartmentOnBuilding unique(buildingID, apartmentID),
	check(len(buildingID) > 0), check(len(owner) > 0), check(len(apartmentID) > 0), check(len(generalProportion) > 0), check(len(elevatorProportion) > 0),
		check(generalProportion > 0), check(elevatorProportion > 0));