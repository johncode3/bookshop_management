-- Store Procedure
-- 1. CustomerAdd 
Create Or Replace Procedure CustomerAdd(
    P_CustomerName   Customer.CustomerName%Type,
    P_CompanyName    Customer.CompanyName%Type,
    P_Phone          Customer.Phone%Type,
    P_Email          Customer.Email%Type,
    P_Address        Customer.Address%Type,
    P_CustomerType   Customer.CustomerType%Type,
    P_MemberDiscount Customer.MemberDiscount%Type
)
As 
Begin
    Insert Into Customer(CustomerName, CompanyName, Phone, Email, Address, CustomerType, MemberDiscount, IsDeleted) 
    Values(P_CustomerName, P_CompanyName, P_Phone, P_Email, P_Address, P_CustomerType, P_MemberDiscount, 0); 
    Commit;
End;
/
-- 2. CustomerDelete (Performs Soft Delete)
Create Or Replace Procedure CustomerDelete(
    P_CustomerId IN Customer.CustomerId%Type
)
As
Begin
    Update Customer 
    Set IsDeleted = 1 
    Where CustomerId = P_CustomerId;
    Commit;
End;
/
-- 3. CustomerGet
Create Or Replace Procedure CustomerGet(
    P_CustomerId Customer.CustomerId%Type Default 0
)
As
    C_Customer Sys_RefCursor;
Begin
    If(P_CustomerId = 0) Then
        Open C_Customer For Select * From Customer Where IsDeleted = 0;
    Else
        Open C_Customer For Select * From Customer Where CustomerId = P_CustomerId AND IsDeleted = 0;
    End If;
    DBMS_SQL.return_result(C_Customer);
End;
/
-- 4. CustomerUpdate 
Create Or Replace Procedure CustomerUpdate(
    P_CustomerId     Customer.CustomerId%Type,
    P_CustomerName   Customer.CustomerName%Type,
    P_CompanyName    Customer.CompanyName%Type,
    P_Phone          Customer.Phone%Type,
    P_Email          Customer.Email%Type,
    P_Address        Customer.Address%Type,
    P_CustomerType   Customer.CustomerType%Type,
    P_MemberDiscount Customer.MemberDiscount%Type
)
As
Begin
    Update Customer
    Set 
        CustomerName   = P_CustomerName,
        CompanyName    = P_CompanyName,
        Phone          = P_Phone,
        Email          = P_Email,
        Address        = P_Address,
        CustomerType   = P_CustomerType,
        MemberDiscount = P_MemberDiscount
    Where CustomerId = P_CustomerId;
    Commit;
End;
Commit;
