-- StoreProcedure
-- 1.InventoryAdjustmentGet
Create Or Replace Procedure InventoryAdjustmentGet (
    P_InvAdjId InventoryAdjustment.InventoryAdjustmentId%Type Default 0
)
As
    C_InvAdj Sys_RefCursor; 
Begin
    IF P_InvAdjId = 0 Then
        Open C_InvAdj For
          Select
            IA.InventoryAdjustmentId,
            IA.AdjustmentDate,
            IA.RefNumber,
            IA.EmployeeId,
            E.EmployeeName,
            IA.Note
          From InventoryAdjustment IA 
          Left Outer Join Employee E On IA.EmployeeId = E.EmployeeId;
    Else
        Open C_InvAdj For
          Select
            IA.InventoryAdjustmentId,
            IA.AdjustmentDate,
            IA.RefNumber,
            IA.EmployeeId,
            E.EmployeeName,
            IA.Note
          From InventoryAdjustment IA 
          Left Outer Join Employee E On IA.EmployeeId = E.EmployeeId
          Where IA.InventoryAdjustmentId = P_InvAdjId;
    End If;
    DBMS_SQL.return_result(C_InvAdj);
End;
/

-- 2. InventoryAdjustmentAdd
Create Or Replace Procedure InventoryAdjustmentAdd (
  P_AdjustmentDate  InventoryAdjustment.AdjustmentDate%Type,
  P_RefNumber       InventoryAdjustment.RefNumber%Type,
  P_EmployeeId      InventoryAdjustment.EmployeeId%Type,
  P_Note            InventoryAdjustment.Note%Type,
  P_InvAdjId        OUT InventoryAdjustment.InventoryAdjustmentId%Type 
)
As
Begin
    Insert Into InventoryAdjustment(AdjustmentDate, RefNumber, EmployeeId, Note) 
    Values(P_AdjustmentDate, P_RefNumber, P_EmployeeId, P_Note)
    Returning InventoryAdjustmentId Into P_InvAdjId;
    Commit;
End;
/

-- 3. InventoryAdjustmentUpdate
Create Or Replace Procedure InventoryAdjustmentUpdate (
  P_InvAdjId        InventoryAdjustment.InventoryAdjustmentId%Type,
  P_AdjustmentDate  InventoryAdjustment.AdjustmentDate%Type,
  P_RefNumber       InventoryAdjustment.RefNumber%Type,
  P_EmployeeId      InventoryAdjustment.EmployeeId%Type,
  P_Note            InventoryAdjustment.Note%Type
)
As 
Begin
    Update InventoryAdjustment 
    Set AdjustmentDate = P_AdjustmentDate,
        RefNumber = P_RefNumber,
        EmployeeId = P_EmployeeId,
        Note = P_Note
    Where InventoryAdjustmentId = P_InvAdjId;
    Commit;
End;
/

-- 1. InvAdjDetailGet
Create Or Replace Procedure InvAdjDetailGet ( 
  P_InvAdjId InventoryAdjustment.InventoryAdjustmentId%Type
) 
As 
  C_InvAdjDetail Sys_RefCursor; 
Begin
  Open C_InvAdjDetail For 
    Select 
      InvAdjDetailId,
      InventoryAdjustmentId,
      ItemId,
      Description,
      Quantity,
      UnitPrice,
      TotalAmount
    From InventoryAdjustmentDetail Where InventoryAdjustmentId = P_InvAdjId;
  DBMS_SQL.return_result(C_InvAdjDetail); 
End;
/

-- 2. InvAdjDetailAdd
Create Or Replace Procedure InvAdjDetailAdd ( 
  P_InvAdjId          InventoryAdjustmentDetail.InventoryAdjustmentId%Type, 
  P_ItemId            InventoryAdjustmentDetail.ItemId%Type,
  P_Description       InventoryAdjustmentDetail.Description%Type,
  P_Quantity          InventoryAdjustmentDetail.Quantity%Type,
  P_UnitPrice         InventoryAdjustmentDetail.UnitPrice%Type,
  P_TotalAmount       InventoryAdjustmentDetail.TotalAmount%Type
) 
As 
Begin 
  Insert Into InventoryAdjustmentDetail(InventoryAdjustmentId, ItemId, Description, Quantity, UnitPrice, TotalAmount) 
  Values(P_InvAdjId, P_ItemId, P_Description, P_Quantity, P_UnitPrice, P_TotalAmount);
  Commit; 
End;
/
-- Trigger
Create Or Replace Trigger trgInvAdjInsert 
    After Insert On InventoryAdjustmentDetail
    For Each Row
Begin
    Update Item 
    Set Quantity = Quantity + :New.Quantity 
    Where ItemId = :New.ItemId; 
End;
/