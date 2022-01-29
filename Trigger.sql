create Trigger kontenjan_azalt on Students
after insert
as
begin
	declare @EduId int
	select EducationId=@EduId from inserted
	update Educations set Capacity=Capacity-1 where ID=@EduId
end
