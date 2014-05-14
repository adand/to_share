create table Apartments(buildingID varchar(3) foreign key references Buildings(buildingID) not null, owner nvarchar(20) not null, apartmentID varchar(3) unique not null,
	generalProportion decimal not null, elevatorProportion decimal not null,
	check(len(buildingID) > 0), check(len(owner) > 0), check(len(apartmentID) > 0), check(len(generalProportion) > 0), check(len(elevatorProportion) > 0),
		check(generalProportion > 0), check(elevatorProportion > 0));
