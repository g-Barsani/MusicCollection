CREATE TABLE Albums (
	ID int IDENTITY(1,1) PRIMARY KEY,
	Album varchar(255),
	Artist varchar(255),
	Genre varchar(255),
	YearOfRelease varchar(255),
	Category varchar(3),
);