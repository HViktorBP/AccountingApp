USE [master]
GO
/****** Object:  Table [dbo].[AccountingApp]    Script Date: 9/15/2023 3:29:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountingApp](
	[WorkerName] [varchar](20) NOT NULL,
	[WorkerTask] [varchar](20) NOT NULL,
	[WorkerComments] [varchar](50) NULL,
	[WorkerDate] [date] NOT NULL,
	[WorkerStartTime] [time](7) NOT NULL,
	[WorkerFinishTime] [time](7) NOT NULL
) ON [PRIMARY]
GO
