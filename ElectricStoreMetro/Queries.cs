using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricStoreMetro
{
   public class Queries
    {
       public static string CategoryClassCreate = @"INSERT INTO [dbo].[Categories]
           ([Name]
           ,[Description]
           ,[Date])
         VALUES(@name,@desc,@date)";

       public static string CategoryClassSelect = @"SELECT [CatID]
      ,[Name]
      ,[Description]
      ,[Date]
  FROM [dbo].[Categories]";

       public static string CategoryClassDelete = @"DELETE FROM [dbo].[Categories]
      WHERE CatID=@id";

       public static string CategoryClassEdit = @"UPDATE [dbo].[Categories]
   SET [Name] = @name
      ,[Description] = @desc
      ,[Date] = @date
        WHERE CatID=@id";

       public static string AccountClassCreate =
           @"INSERT INTO [dbo].[Users]
           ([Name]
           ,[Password]
           ,[Cell]
           ,[Address])
     VALUES
           (@name
           ,@pass
           ,@cell
           ,@address)";

       public static string AccountClassSelect = @"SELECT [UserID]
      ,[Name]
      ,[Password]
      ,[Cell]
      ,[Address]
  FROM [dbo].[Users]
GO";

       public static string AccountClassEdit = @"UPDATE [dbo].[Users]
   SET [Name] = @name
      ,[Password]=@pass
      ,[Cell] = @cell
      ,[Address] = @address
 WHERE userID=@id";

       public static string AccountClassDelete = "Delete from [dbo].[Users] WHERE userID=@id";

//       public static string ProductClassSelect = @"SELECT [ItemID]
//      ,[Categories].[Name] AS Category
//      ,[Items].[Name]
//      ,[Qty]
//      ,[PurchasePrice]
//      ,[Saleprice]
//      ,[DiscountPercent]
//      ,[Items].[Description]
//      ,[DateCreated]
//      ,[DateUpdated]
//      ,[UsedQty]
//      ,[RemQty]
//  FROM [dbo].[Items]
//  LEFT JOIN Categories ON Items.CatID = Categories.CatID
//  LEFT JOIN Users ON Items.UserID = Users.UserID
//WHERE Items.RemQty > @qty";

       public static string ProductClassSelect = @"SELECT [ItemID]
      ,[Items].[Name]
      ,[Categories].[Name] AS Category
      ,[Items].[MeasurementID] AS 'UnitID'
      ,[Measurements].Name AS 'UnitName'
     ,[Items].[PurchasePrice] AS 'PurchasePrice'
      ,[RemQty]
      ,[Items].[Description]

  FROM [dbo].[Items]
  LEFT JOIN Categories ON Items.CatID = Categories.CatID
  LEFT JOIN Measurements ON Items.MeasurementID=Measurements.MeasurementID

WHERE Items.RemQty >@qty;";

       public static string ProductClassSelectReport = @"SELECT 
      [Categories].[Name] AS Category
      ,[Items].[Name]
      ,[Qty]
      ,[PurchasePrice]
      ,[Saleprice]
      ,[UsedQty]
      ,[RemQty]
  FROM [dbo].[Items]
  LEFT JOIN Categories ON Items.CatID = Categories.CatID
  LEFT JOIN Users ON Items.UserID = Users.UserID
WHERE Items.DateCreated BETWEEN @from AND @to";

       public static string ViewSalesReport =
           @"SELECT (SELECT COUNT(DISTINCT OrderItems.ProductID)
FROM OrderItems WHERE OrderItems.OrderDate BETWEEN @from AND @to) AS 'TotalSoldItemsDistinct', 

(SELECT COUNT(OrderItems.ProductID)
FROM OrderItems WHERE OrderItems.OrderDate BETWEEN @from AND @to) AS 'TotalSoldItemsInDistinct'
 
 ,
(SELECT COUNT(Orders.OrderID)
FROM Orders WHERE Orders.TransactionDate BETWEEN @from AND @to) AS 'TotalOrders'
, 

(SELECT COUNT(Orders.OrderID)
FROM Orders
WHERE Orders.OrderStatusID=@CompleteOStatusID AND Orders.TransactionDate BETWEEN @from AND @to) AS 'CompleteOrders'
, 
(SELECT COUNT(Orders.OrderID)
FROM Orders
WHERE Orders.OrderStatusID=@PendingOStatusID AND Orders.TransactionDate BETWEEN @from AND @to) AS 'PendingOrders'
, 

(SELECT COUNT(Orders.ClientID)
FROM Orders
WHERE Orders.ClientID != @WalkingCustID AND Orders.TransactionDate BETWEEN @from AND @to) AS 'namedcustomers'
,

(SELECT COUNT(Orders.ClientID)
FROM Orders
WHERE Orders.ClientID = @WalkingCustID AND Orders.TransactionDate BETWEEN @from AND @to) AS 'WalkingCustomers'
,

(SELECT ISNULL(SUM(OrderItems.TotalAmtPurchase), 0)
FROM OrderItems WHERE OrderItems.OrderDate BETWEEN @from AND @to) AS 'TotalPurchasePrice'
,

(SELECT ISNULL(SUM(OrderItems.TotalAmtSale), 0) FROM OrderItems WHERE OrderItems.OrderDate BETWEEN @from AND @to) AS 'TotalSalePrice'
,
(SELECT ISNULL(SUM(Orders.Discount), 0)
FROM Orders
WHERE Orders.TransactionDate BETWEEN @from AND @to) AS 'TotalDiscount'
,
(SELECT ISNULL(SUM(OrderItems.Profit), 0) FROM OrderItems WHERE OrderItems.OrderDate BETWEEN @from AND @to) AS 'TotalProfit'";

       public static string ViewSalesForReport =
          @"SELECT OrderNo ,Customers.Name AS 'Customer', TotalAmount, TotalPayment, TotalToPay, PaymentDue, OrderStatus.Name AS'Order Status', TransactionDate
FROM Orders
LEFT JOIN OrderStatus ON Orders.OrderStatusID=OrderStatus.OrderStatusID
LEFT JOIN Customers ON Orders.ClientID=Customers.CustID
WHERE orders.TransactionDate BETWEEN @from AND @to";

       public static string ProductClassPopulateDropDown = @"SELECT CatID,Name FROM Categories";

       public static string ProductClassPopulateMeasurement = @"
SELECT [MeasurementID]
      ,[Name]
      ,[Value]
  FROM [dbo].[Measurements]";
       public static string SelectProducts = @"SELECT [ItemID]
      ,[Items].[CatID]
      ,[UserID]
      ,Categories.Name 'Category'
      ,Measurements.Name AS 'Unit'
      ,[Items].[Name] 'Item Name'
      ,[Qty]
      ,[PurchasePrice]
      ,[Saleprice]
      ,[Items].[Description]
      ,[DateCreated]
      ,[DateUpdated]
      ,[UsedQty]
      ,[RemQty]
      ,Items.[MeasurementID]
  FROM [dbo].[Items]
  LEFT JOIN Categories ON Items.CatID = Categories.CatID
  LEFT JOIN Measurements ON Items.MeasurementID = Measurements.MeasurementID";

       public static string ProductClassCreate = @"INSERT INTO [dbo].[Items]
           ([CatID]
           ,[UserID]
           ,[Name]
           ,[Qty]
           ,[Description]
           ,[DateCreated]
           ,[DateUpdated]
           ,[UsedQty])
     VALUES
           (@catID
           ,@userID
           ,@name
           ,@qty
           ,@desc
           ,@dtCreated
           ,@dtUpdated
           ,@usedQty)";
    }

}
