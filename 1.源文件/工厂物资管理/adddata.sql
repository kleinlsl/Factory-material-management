declare @i1 int  --定义变量@i
set @i1=90000     --初始化@i
while @i1<=100000
	begin
		insert into Component(ComponentID,ComponentName,ComponentFormat,ComponentUnitprice,ComponentDescribe)
		values(CONVERT(varchar(50),@i1),'Name'+CONVERT(varchar(43),@i1),'Format'+CONVERT(varchar(40),@i1),@i1,'Describe '+CONVERT(varchar(40),@i1));
		set @i1=@i1+1;
	end


select COUNT(ComponentID)
from Component
