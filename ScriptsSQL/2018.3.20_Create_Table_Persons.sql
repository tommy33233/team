IF (OBJECT_ID('[dbo].[PersonBases]') IS NULL)
BEGIN
CREATE TABLE [dbo].[PersonBases]
(
    [PersonId]  INT IDENTITY (1, 1) NOT NULL,
    [FirstName]         nvarchar(100)    NOT NULL,
    [SecondName]     nvarchar(100)    NOT NULL,
    [Patronymic]  nvarchar(100) NULL,
    [DateOfBirth] DATETIME NULL, 
	Constraint PK_PersonBase Primary key (PersonId)
);
end

if(OBJECT_ID('[dbo].[PersonBases]') is not null)
begin
insert into PersonBases(FirstName,SecondName,Patronymic,DateOfBirth)
values ('Ivan', 'Ronaldo','Petrovic', '11.03.1992')
end

