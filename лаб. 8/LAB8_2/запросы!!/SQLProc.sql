use lab8oop

create procedure Find_Surname @proizvoditel nvarchar(15)
as
begin
set @proizvoditel = @proizvoditel + '%'
SELECT * from 
Computer inner join Processor on Computer.ownerId = Processor.id
where Processor.proizvoditel like @proizvoditel
end;


create procedure  Find_type @razmerkesha nvarchar(15)
as
begin
set @razmerkesha = @razmerkesha + '%'
SELECT * from 
Computer inner join Processor on Computer.ownerId = Processor.id
where Processor.razmerkesha like @razmerkesha
end;

drop procedure  Find_Surname;
drop procedure  Find_type;

