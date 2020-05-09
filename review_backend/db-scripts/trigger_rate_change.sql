alter trigger [dbo].[update-thing-rate]
	on [dbo].[ThingRateInfos]
	after INSERT, UPDATE, DELETE
as 
begin
	set nocount on;
	update
		Things
	set
		
end
