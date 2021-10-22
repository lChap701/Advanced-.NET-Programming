<<<<<<< HEAD
/************* Note: You will need to create a database called "TAL_Distributors" ************/
/******** Note: Run a script called "CreateTAL" which is found in the Handouts folder ********/
USE [TAL_Distributors]
GO

/****** Object: SqlProcedure [dbo].[ProcOrderSummary] Script Date: 3/29/2021 8:21:56 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE [dbo].[ProcOrderSummary];


GO
CREATE PROCEDURE [dbo].[ProcOrderSummary]
	@pItem CHAR(4)
AS
	IF @pItem IS NULL 
		BEGIN
			SELECT ol.[ITEM_NUM], [DESCRIPTION], SUM([NUM_ORDERED]) AS TotalQuantity, SUM([NUM_ORDERED] * [QUOTED_PRICE]) AS TotalCost 
			FROM [TAL_ITEM] i JOIN [TAL_ORDER_LINE] ol ON i.[ITEM_NUM] = ol.[ITEM_NUM]
			GROUP BY ol.[ITEM_NUM], [DESCRIPTION]
		END
	ELSE
		BEGIN
			SELECT ol.[ITEM_NUM], [DESCRIPTION], SUM([NUM_ORDERED]) AS TotalQuantity, SUM([NUM_ORDERED] * [QUOTED_PRICE]) AS TotalCost 
			FROM [TAL_ITEM] i JOIN [TAL_ORDER_LINE] ol ON i.[ITEM_NUM] = ol.[ITEM_NUM]
			WHERE ol.[ITEM_NUM] = @pItem
			GROUP BY ol.[ITEM_NUM], [DESCRIPTION]
		END
RETURN 0
=======
/************* Note: You will need to create a database called "TAL_Distributors" ************/
/******** Note: Run a script called "CreateTAL" which is found in the Handouts folder ********/
USE [TAL_Distributors]
GO

/****** Object: SqlProcedure [dbo].[ProcOrderSummary] Script Date: 3/29/2021 8:21:56 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE [dbo].[ProcOrderSummary];


GO
CREATE PROCEDURE [dbo].[ProcOrderSummary]
	@pItem CHAR(4)
AS
	IF @pItem IS NULL 
		BEGIN
			SELECT ol.[ITEM_NUM], [DESCRIPTION], SUM([NUM_ORDERED]) AS TotalQuantity, SUM([NUM_ORDERED] * [QUOTED_PRICE]) AS TotalCost 
			FROM [TAL_ITEM] i JOIN [TAL_ORDER_LINE] ol ON i.[ITEM_NUM] = ol.[ITEM_NUM]
			GROUP BY ol.[ITEM_NUM], [DESCRIPTION]
		END
	ELSE
		BEGIN
			SELECT ol.[ITEM_NUM], [DESCRIPTION], SUM([NUM_ORDERED]) AS TotalQuantity, SUM([NUM_ORDERED] * [QUOTED_PRICE]) AS TotalCost 
			FROM [TAL_ITEM] i JOIN [TAL_ORDER_LINE] ol ON i.[ITEM_NUM] = ol.[ITEM_NUM]
			WHERE ol.[ITEM_NUM] = @pItem
			GROUP BY ol.[ITEM_NUM], [DESCRIPTION]
		END
RETURN 0
>>>>>>> parent of d4ec916 (Reorganized)
