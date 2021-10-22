/**************** Note: You will need to create a database called "CheapLoans" ****************/
USE [CheapLoans]
GO

/****** Object: SqlProcedure [dbo].[SelectProcedure] Script Date: 3/16/2021 12:37:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE [dbo].[SelectProcedure];


GO
CREATE PROCEDURE [dbo].[SelectProcedure]
AS
	SELECT * FROM [Loans]
RETURN 0
