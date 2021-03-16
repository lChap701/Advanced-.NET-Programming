/**************** Note: You will need to create a database called "CheapLoans" ****************/
USE [CheapLoans]
GO

/****** Object: SqlProcedure [dbo].[InsertProcedure] Script Date: 3/15/2021 10:25:01 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE [dbo].[InsertProcedure];


GO
CREATE PROCEDURE [dbo].[InsertProcedure]
	@CustName VARCHAR(50),
	@LoanAmount DECIMAL(9, 2),
	@AnnualIntRate DECIMAL(3, 3),
	@NumPayments INT
AS
	INSERT Loans (CustName, LoanAmount, AnnualIntRate, NumPayments) VALUES (@CustName, @LoanAmount, @AnnualIntRate, @NumPayments);
RETURN 0
