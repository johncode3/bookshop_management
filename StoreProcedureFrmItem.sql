-- StoreProcedure
-- 1. ItemGet
Create Or Replace Procedure ItemGet(
    P_ItemId Item.ItemId%Type Default 0
)
As
    C_Item Sys_RefCursor;
Begin
    If (P_ItemId = 0) Then
        Open C_Item For Select * From Item Where IsDeleted = 0;
    Else
        Open C_Item For Select * From Item Where ItemId = P_ItemId AND IsDeleted = 0;
    End If;
    DBMS_SQL.return_result(C_Item);
End;
/
-- 2. ItemAdd
Create Or Replace Procedure ItemAdd(
    P_ItemName          Item.ItemName%Type,
    P_Category          Item.Category%Type,
    P_Author            Item.Author%Type,
    P_Rating            Item.Rating%Type,
    P_ItemDescription   Item.ItemDescription%Type,
    P_Quantity          Item.Quantity%Type,
    P_SalePrice         Item.SalePrice%Type,
    P_Thumbnail         Item.Thumbnail%Type,
    P_ItemId            OUT Item.ItemId%Type
)
As
Begin
    Insert Into Item(ItemName, Category, Author, Rating, ItemDescription, Quantity, SalePrice, Thumbnail, IsDeleted)
    Values (P_ItemName, P_Category, P_Author, P_Rating, P_ItemDescription, P_Quantity, P_SalePrice, P_Thumbnail, 0)
    Returning ItemId Into P_ItemId;
    Commit;
End;
/
-- 3. ItemUpdate
Create Or Replace Procedure ItemUpdate(
    P_ItemId            Item.ItemId%Type,
    P_ItemName          Item.ItemName%Type,
    P_Category          Item.Category%Type,
    P_Author            Item.Author%Type,
    P_Rating            Item.Rating%Type,
    P_ItemDescription   Item.ItemDescription%Type,
    P_Quantity          Item.Quantity%Type,
    P_SalePrice         Item.SalePrice%Type,
    P_Thumbnail         Item.Thumbnail%Type
)
As
Begin
    Update Item Set
        ItemName = P_ItemName,
        Category = P_Category,
        Author = P_Author,
        Rating = P_Rating,
        ItemDescription = P_ItemDescription,
        Quantity = P_Quantity,
        SalePrice = P_SalePrice,
        Thumbnail = P_Thumbnail
    Where ItemId = P_ItemId;
    Commit;
End;
/
-- 4. ItemDelete (Soft Delete)
Create Or Replace Procedure ItemDelete(
    P_ItemId IN Item.ItemId%Type
)
As
Begin
    Update Item 
    Set IsDeleted = 1 
    Where ItemId = P_ItemId;
    Commit;
End;
/