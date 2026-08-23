--Store Procedure
-- 1. VendorGet
Create Or Replace Procedure VendorGet (
    P_VendorId Vendor.VendorId%Type Default 0
) 
As
    C_Vendor Sys_RefCursor;
Begin
    If P_VendorId = 0 Then
        Open C_Vendor For Select * From Vendor Where IsDeleted = 0;
    Else
        Open C_Vendor For Select * From Vendor Where VendorId = P_VendorId AND IsDeleted = 0;
    End If;
    DBMS_SQL.return_result(C_Vendor);
End;
/

-- 2. VendorAdd
Create Or Replace Procedure VendorAdd (
    P_VendorName  Vendor.VendorName%Type,
    P_CompanyName Vendor.CompanyName%Type,
    P_Phone       Vendor.Phone%Type,
    P_Email       Vendor.Email%Type,
    P_Address     Vendor.Address%Type,
    P_VendorId    OUT Vendor.VendorId%Type
) 
As
Begin
    Insert Into Vendor (VendorName, CompanyName, Phone, Email, Address, IsDeleted)
    Values (P_VendorName, P_CompanyName, P_Phone, P_Email, P_Address, 0)
    Returning VendorId Into P_VendorId;
    Commit;
End;
/

-- 3. VendorUpdate
Create Or Replace Procedure VendorUpdate (
    P_VendorId    Vendor.VendorId%Type,
    P_VendorName  Vendor.VendorName%Type,
    P_CompanyName Vendor.CompanyName%Type,
    P_Phone       Vendor.Phone%Type,
    P_Email       Vendor.Email%Type,
    P_Address     Vendor.Address%Type
) 
As
Begin
    Update Vendor 
    Set VendorName = P_VendorName,
        CompanyName = P_CompanyName,
        Phone = P_Phone,
        Email = P_Email,
        Address = P_Address
    Where VendorId = P_VendorId;
    Commit;
End;
/

-- 4. VendorDelete (Soft Delete)
Create Or Replace Procedure VendorDelete (
    P_VendorId Vendor.VendorId%Type
) 
As
Begin
    Update Vendor 
    Set IsDeleted = 1 
    Where VendorId = P_VendorId;
    Commit;
End;
/