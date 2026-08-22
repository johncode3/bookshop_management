-- 1. PurchaseGet (Fetches all purchases with Vendor and Employee joins)
Create Or Replace Procedure PurchaseGet (
    P_PurchaseId Purchase.PurchaseId%Type Default 0
)
As
    C_Purchase Sys_RefCursor; 
Begin
    IF P_PurchaseId = 0 Then
        Open C_Purchase For
          Select
            Purchase.PurchaseId,
            Purchase.PurchaseDate,
            Purchase.RefNumber,
            Purchase.VendorId,
            Vendor.VendorName,
            Purchase.EmployeeId,
            Employee.EmployeeName,
            Purchase.TotalAmount,
            Purchase.Status,
            Purchase.Note
          From Purchase Left Outer Join Vendor
            On Purchase.VendorId = Vendor.VendorId
          Left Outer Join Employee
            On Purchase.EmployeeId = Employee.EmployeeId;
    Else
        Open C_Purchase For
          Select
            Purchase.PurchaseId,
            Purchase.PurchaseDate,
            Purchase.RefNumber,
            Purchase.VendorId,
            Vendor.VendorName,
            Purchase.EmployeeId,
            Employee.EmployeeName,
            Purchase.TotalAmount,
            Purchase.Status,
            Purchase.Note
          From Purchase Left Outer Join Vendor
            On Purchase.VendorId = Vendor.VendorId
          Left Outer Join Employee
            On Purchase.EmployeeId = Employee.EmployeeId
          Where Purchase.PurchaseId = P_PurchaseId;
    End If;
    DBMS_SQL.return_result(C_Purchase);
End;
/

-- 2. PurchaseAdd
Create Or Replace Procedure PurchaseAdd (
  P_PurchaseDate  Purchase.PurchaseDate%Type,
  P_RefNumber     Purchase.RefNumber%Type,
  P_VendorId      Purchase.VendorId%Type,
  P_EmployeeId    Purchase.EmployeeId%Type,
  P_TotalAmount   Purchase.TotalAmount%Type, 
  P_Status        Purchase.Status%Type,
  P_Note          Purchase.Note%Type,
  P_PurchaseId    OUT Purchase.PurchaseId%Type 
)
As 
Begin
    Insert Into Purchase(PurchaseDate, RefNumber, VendorId, EmployeeId, TotalAmount, Status, Note) 
    Values(P_PurchaseDate, P_RefNumber, P_VendorId, P_EmployeeId, P_TotalAmount, P_Status, P_Note)
    Returning PurchaseId Into P_PurchaseId;
    Commit;
End;
/
-- 3. PurchaseUpdate
Create Or Replace Procedure PurchaseUpdate (
    P_PurchaseId   Purchase.PurchaseId%Type,
    P_PurchaseDate Purchase.PurchaseDate%Type,
    P_RefNumber    Purchase.RefNumber%Type,
    P_VendorId     Purchase.VendorId%Type,
    P_EmployeeId   Purchase.EmployeeId%Type,
    P_TotalAmount  Purchase.TotalAmount%Type,
    P_Status       Purchase.Status%Type,
    P_Note         Purchase.Note%Type
) 
As
Begin
    Update Purchase 
    Set PurchaseDate = P_PurchaseDate,
        RefNumber = P_RefNumber,
        VendorId = P_VendorId,
        EmployeeId = P_EmployeeId,
        TotalAmount = P_TotalAmount,
        Status = P_Status,
        Note = P_Note
    Where PurchaseId = P_PurchaseId;
    Commit;
End;
/
-- 4. PurchaseDelete(SoftDelete Cancelled)
Create Or Replace Procedure PurchaseDelete (
  P_PurchaseId Purchase.PurchaseId%Type 
)
AS
Begin
  Update Purchase 
  Set Status = 'Cancelled' 
  Where PurchaseId = P_PurchaseId;
  
  Commit;
End;
/
-- Store Procedure PurchaseDetail
-- 1. PurchaseDetailGet
Create Or Replace Procedure PurchaseDetailGet ( 
  P_PurchaseId Purchase.PurchaseId%Type
) 
As 
  C_PurDetail Sys_RefCursor; 
Begin
  Open C_PurDetail For 
    Select 
      PurchaseDetailId,
      PurchaseId,
      ItemId,
      Description,
      Quantity,
      UnitPrice,
	  TotalAmount
    From PurchaseDetail Where PurchaseId = P_PurchaseId;
  DBMS_SQL.return_result(C_PurDetail); 
End;
/

-- 2. PurchaseDetailAdd
Create Or Replace Procedure PurchaseDetailAdd ( 
  P_PurchaseId  PurchaseDetail.PurchaseId%Type, 
  P_ItemId      PurchaseDetail.ItemId%Type,
  P_Description PurchaseDetail.Description%Type,
  P_Quantity    PurchaseDetail.Quantity%Type,
  P_UnitPrice   PurchaseDetail.UnitPrice%Type,
  P_TotalAmount PurchaseDetail.TotalAmount%Type
) 
As 
Begin 
  Insert Into PurchaseDetail(PurchaseId, ItemId, Description, Quantity, UnitPrice, TotalAmount) 
  Values(P_PurchaseId, P_ItemId, P_Description, P_Quantity, P_UnitPrice, P_TotalAmount);
  Commit; 
End;
/

-- 3. PurchaseDetailDelete
Create Or Replace Procedure PurchaseDetailDelete ( 
  P_PurchaseId PurchaseDetail.PurchaseId%Type 
) 
As 
Begin 
  Delete From PurchaseDetail Where PurchaseId = P_PurchaseId;
  Commit; 
End;
/

-- TRIGGER: 
Create Or Replace Trigger trgPurchaseInsert 
    After Insert On PurchaseDetail
    For Each Row
Begin
    Update Item Set Quantity = Quantity + :New.Quantity 
    Where ItemId = :New.ItemId; 
End;
/
Create Or Replace Trigger trgPurchaseDelete 
    After Delete On PurchaseDetail
    For Each Row
Begin
    Update Item Set Quantity = Quantity - :Old.Quantity 
    Where ItemId = :Old.ItemId; 
End;
/
Create Or Replace Trigger trgPurchaseCancelStatus
    After Update Of Status On Purchase
    For Each Row
    When (Old.Status != 'Cancelled' AND New.Status = 'Cancelled')
Begin
    For r In (Select ItemId, Quantity From PurchaseDetail Where PurchaseId = :New.PurchaseId) Loop
        Update Item 
        Set Quantity = Quantity - r.Quantity
        Where ItemId = r.ItemId;
    End Loop;
End;
/