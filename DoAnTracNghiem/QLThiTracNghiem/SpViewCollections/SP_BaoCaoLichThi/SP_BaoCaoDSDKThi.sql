USE [DB_THI_TN]
GO
/****** Object:  StoredProcedure [dbo].[SP_Bao_Cao_DS_Dk_Thi]    Script Date: 6/13/2023 3:45:07 PM ******/
ALTER PROCEDURE [dbo].[SP_Bao_Cao_DS_Dk_Thi] @TuNgay Date,
@DenNgay Date
as
begin
	Set xact_abort on
	begin distributed transaction
	Declare @commandstr nvarchar(4000)

	if OBJECT_ID('tempdb..##LocalTable') is null
	begin
	Create Table ##LocalTable
	(
		[TENLOP] [nvarchar](40) NULL,
		[TENMH] [nvarchar](50) NULL,
		[TENGV] [nvarchar](100) NULL,
		[SOCAUTHI] [smallint] NULL,
		[NGAYTHI] [nvarchar](50) NULL,
		[DATHI] [bit] NULL,
		[GHICHU] [ntext] NULL,
		[TENCS] nvarchar(10) NULL
	)
	end

	if OBJECT_ID('tempdb..##RemoteTable') is null
	begin
	Create Table ##RemoteTable
	(
		[TENLOP] [nvarchar](40) NULL,
		[TENMH] [nvarchar](50) NULL,
		[TENGV] [nvarchar](100) NULL,
		[SOCAUTHI] [smallint] NULL,
		[NGAYTHI] [nvarchar](50) NULL,
		[DATHI] [bit] NULL,
		[GHICHU] [ntext] NULL,
		[TENCS] nvarchar(10) NULL
	)
	end

	Truncate table ##LocalTable
	Truncate table ##RemoteTable
	set @commandstr =  'Insert into ##LocalTable Exec SP_DS_Loc_DK_Thi ''' + Format(@TuNgay, 'yyyy-MM-dd') + ''',' + '''' + 
	Format(@DenNgay, 'yyyy-MM-dd') + '''';
	
	IF  EXISTS (SELECT job_id FROM msdb.dbo.sysjobs_view WHERE name = N'Job_1')
        EXEC msdb.dbo.sp_delete_job @job_name=N'Job_1' 

	execute msdb.dbo.sp_add_job @job_name = N'Job_1', @start_step_id = 1
    EXECUTE msdb.dbo.sp_add_jobserver  @job_name = N'Job_1', @server_name =  @@SERVERNAME
    execute msdb.dbo.sp_add_jobstep  @job_name =  N'Job_1' , @step_id = 1, @step_name = 'DS_DK', 
					@command =  @commandstr ,   @server = @@SERVERNAME, @database_name = 'DB_THI_TN'
	execute msdb.dbo.sp_start_job  @job_name =  N'Job_1'

	INSERT INTO ##RemoteTable
	EXEC LINK1.DB_THI_TN.dbo.SP_DS_Loc_DK_Thi @TuNgay, @DenNgay
	commit transaction;
	
	Declare  @jobStatus int;
	While 1=1
	begin
	SELECT TOP 1 @jobStatus = run_status 
		FROM msdb.dbo.sysjobhistory 
		WHERE job_id = (SELECT job_id FROM msdb.dbo.sysjobs WHERE step_name='DS_DK' and name = 'Job_1') 
    --ORDER BY run_date DESC, run_time DESC;
    IF @jobStatus IN (1, 0, 3) -- job completed (succeeded, failed, or canceled)
        BREAK;
    ELSE -- job still running
        WAITFOR DELAY '00:00:02'; -- wait for 2 seconds before checking again
	end

	Select TENLOP, TENMH, TENGV, SOCAUTHI, NGAYTHI, DATHI, GHICHU, TENCS from ##LocalTable

	Select TENLOP, TENMH, TENGV, SOCAUTHI, NGAYTHI, DATHI, GHICHU, TENCS from ##RemoteTable

	IF  EXISTS (SELECT job_id FROM msdb.dbo.sysjobs_view WHERE name = N'Job_1')
        EXEC msdb.dbo.sp_delete_job @job_name=N'Job_1' 
end
