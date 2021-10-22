/****** Note: You will need to create a database called "CheapLoans" ********/
USE [CheapLoans]
GO

/****** Object: Table [dbo].[Loans] Script Date: 3/9/2021 11:14:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/**** You can comment out the line below if you don't have the table yet ***/
DROP TABLE [dbo].[Loans];


GO
CREATE TABLE [dbo].[Loans] (
    [LoanNum]       INT            IDENTITY (1, 1) NOT NULL,
    [CustName]      VARCHAR (50)   NULL,
    [LoanAmount]    DECIMAL (9, 2) NULL,
    [AnnualIntRate] DECIMAL (3, 3) NULL,
    [NumPayments]   INT            NULL
);


