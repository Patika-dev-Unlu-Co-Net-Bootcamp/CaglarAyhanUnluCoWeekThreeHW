create Trigger kontenjan_azalt on Students
after insert
as
begin
	update Educations set Capacity=Capacity-1
end