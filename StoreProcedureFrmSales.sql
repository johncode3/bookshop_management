-- Store Procedure Sale
-- 1. SaleGet
Create Or Replace Procedure SaleGet (
    P_SaleId Sale.SaleId%Type Default 0
)
As 
    C_Sale Sys_RefCursor; 
Begin
    IF P_SaleId = 0 Then
    Open C_Sale For
      Select
        Sale.SaleId,
        Sale.SaleDate,
        Sale.RefNumber,
        Sale.CustomerId,
        Customer.CustomerName,
        Sale.EmployeeId,
        Employee.EmployeeName,
        Sale.TotalAmount,
        Sale.Status,
        Sale.Note
      From Sale Left Outer Join Customer
        On Sale.CustomerId = Customer.CustomerId
      Left Outer Join Employee
        On Sale.EmployeeId = Employee.EmployeeId;
  Else
    Open C_Sale For
      Select
        Sale.SaleId,
        Sale.SaleDate,
        Sale.RefNumber,
        Sale.CustomerId,
        Customer.CustomerName,
        Sale.EmployeeId,
        Employee.EmployeeName,
        Sale.TotalAmount,
        Sale.Status,
        Sale.Note
      From Sale Left Outer Join Customer
        On Sale.CustomerId = Customer.CustomerId
      Left Outer Join Employee
        On Sale.EmployeeId = Employee.EmployeeId
      Where Sale.SaleId = P_SaleId;
  End If;
  DBMS_SQL.return_result(C_Sale);
End;
/

-- 2. SaleAdd
Create Or Replace Procedure SaleAdd (
  P_SaleDate      Sale.SaleDate%Type,
  P_RefNumber     Sale.RefNumber%Type,
  P_CustomerId    Sale.CustomerId%Type,
  P_EmployeeId    Sale.EmployeeId%Type,
  P_TotalAmount   Sale.TotalAmount%Type,
  P_Status        Sale.Status%Type,
  P_Note          Sale.Note%Type,
  P_SaleId        OUT Sale.SaleId%Type 
)
As 
Begin
    Insert Into Sale(SaleDate, RefNumber, CustomerId, EmployeeId, TotalAmount, Status, Note) 
    Values(P_SaleDate, P_RefNumber, P_CustomerId, P_EmployeeId, P_TotalAmount, P_Status, P_Note)
    Returning SaleId Into P_SaleId;
    Commit;
End;
/

-- 3. SaleUpdate
Create or Replace Procedure SaleUpdate (
  P_SaleId        Sale.SaleId%Type,
  P_SaleDate      Sale.SaleDate%Type,
  P_RefNumber     Sale.RefNumber%Type,
  P_CustomerId    Sale.CustomerId%Type,
  P_EmployeeId    Sale.EmployeeId%Type, 
  P_TotalAmount   Sale.TotalAmount%Type,
  P_Status        Sale.Status%Type,
  P_Note          Sale.Note%Type
)
AS
Begin
  Update Sale Set 
    SaleDate = P_SaleDate,
    RefNumber = P_RefNumber,
    CustomerId = P_CustomerId,
    EmployeeId = P_EmployeeId,
    TotalAmount = P_TotalAmount,
    Status = P_Status,
    Note = P_Note
  Where SaleId = P_SaleId;
  Commit;
End;
/

-- 4. SaleDelete(SoftDelete)
Create Or Replace Procedure SaleDelete (
  P_SaleId Sale.SaleId%Type 
)
AS
Begin
  Update Sale 
  Set Status = 'Cancelled' 
  Where SaleId = P_SaleId;
  
  Commit;
End;
/

-- Store Procedure SaleDetail
-- 1. SaleDetailGet
Create Or Replace Procedure SaleDetailGet ( 
  P_SaleId Sale.SaleId%Type
) 
As 
  C_SaleDetail Sys_RefCursor; 
Begin
  Open C_SaleDetail For 
    Select 
      SaleDetailId,
      SaleId,
      ItemId,
      Description,
      Quantity,
      UnitPriceAtSale,
      DiscountAmount,
      Price
    From SaleDetail Where SaleId = P_SaleId;
  DBMS_SQL.return_result(C_SaleDetail); 
End;
/
-- 2. SaleDetailAdd
Create Or Replace Procedure SaleDetailAdd ( 
  P_SaleId            SaleDetail.SaleId%Type, 
  P_ItemId            SaleDetail.ItemId%Type,
  P_Description       SaleDetail.Description%Type,
  P_Quantity          SaleDetail.Quantity%Type,
  P_UnitPriceAtSale   SaleDetail.UnitPriceAtSale%Type,
  P_DiscountAmount    SaleDetail.DiscountAmount%Type,
  P_Price             SaleDetail.Price%Type
) 
As 
Begin 
  Insert Into SaleDetail(SaleId, ItemId, Description, Quantity, UnitPriceAtSale, DiscountAmount, Price) 
  Values(P_SaleId, P_ItemId, P_Description, P_Quantity, P_UnitPriceAtSale, P_DiscountAmount, P_Price);
  Commit; 
End;
/

-- 3. SaleDetailDelete
Create Or Replace Procedure SaleDetailDelete ( 
  P_SaleId  SaleDetail.SaleId%Type 
) 
As 
Begin 
  Delete From SaleDetail Where SaleId = P_SaleId;
  Commit; 
End;
/

-- 1. CustomerGet
Create Or Replace Procedure CustomerGet (P_CustomerId Customer.CustomerId%Type Default 0) As
  C_Customer Sys_RefCursor; 
Begin 
  If(P_CustomerId = 0) Then 
    Open C_Customer For Select * From Customer; 
  Else 
    Open C_Customer For Select * From Customer Where CustomerId = P_CustomerId; 
  End If; 
  DBMS_SQL.return_result(C_Customer); 
End;
/

-- 1.EmployeeGet
Create Or Replace Procedure EmployeeGet (P_EmployeeId Employee.EmployeeId%Type Default 0) As 
  C_Employee Sys_RefCursor; 
Begin 
  If(P_EmployeeId = 0) Then 
    Open C_Employee For Select * From Employee; 
  Else 
    Open C_Employee For Select * From Employee Where EmployeeId = P_EmployeeId; 
  End If; 
  DBMS_SQL.return_result(C_Employee); 
End;
/

-- 1.ItemGet
Create Or Replace Procedure ItemGet (P_ItemId Item.ItemId%Type Default 0) As
  C_Item Sys_RefCursor; 
Begin 
  If(P_ItemId = 0) Then 
    Open C_Item For Select * From Item; 
  Else 
    Open C_Item For Select * From Item Where ItemId = P_ItemId; 
  End If; 
  DBMS_SQL.return_result(C_Item); 
End;
/

-- Triggers
Create Or Replace Trigger trgSaleInsert 
    After Insert On SaleDetail
    For Each Row
Begin
    Update Item Set Quantity = Quantity - :New.Quantity 
    Where ItemId = :New.ItemId; 
End;
/

Create Or Replace Trigger trgSaleDelete 
    After Delete On SaleDetail
    For Each Row
Begin
    Update Item Set Quantity = Quantity + :Old.Quantity 
    Where ItemId = :Old.ItemId; 
End;
/
Create Or Replace Trigger trgSaleCancelStatus
    After Update Of Status On Sale
    For Each Row
    When (Old.Status != 'Cancelled' AND New.Status = 'Cancelled')
Begin
    For r In (Select ItemId, Quantity From SaleDetail Where SaleId = :New.SaleId) Loop
        Update Item 
        Set Quantity = Quantity + r.Quantity 
        Where ItemId = r.ItemId;
    End Loop;
End;