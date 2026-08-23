--Store Procedure
-- 1. EmployeeGet
Create Or Replace Procedure EmployeeGet (
    P_EmployeeId Employee.EmployeeId%Type Default 0
) 
As
    C_Employee Sys_RefCursor;
Begin
    If P_EmployeeId = 0 Then
        Open C_Employee For
            Select * From Employee Where IsActive = 1;
    Else
        Open C_Employee For
            Select * From Employee Where EmployeeId = P_EmployeeId;
    End If;
    DBMS_SQL.return_result(C_Employee);
End;
/
-- 2. EmployeeAdd
Create Or Replace Procedure EmployeeAdd (
    P_EmployeeName     Employee.EmployeeName%Type,
    P_Sex              Employee.Sex%Type,
    P_DOB              Employee.DOB%Type,
    P_Address          Employee.Address%Type,
    P_MaritalStatus    Employee.MaritalStatus%Type,
    P_HaveSpouse       Employee.HaveSpouse%Type,
    P_NumberOfChildren Employee.NumberOfChildren%Type,
    P_HiredDate        Employee.HiredDate%Type,
    P_Position         Employee.Position%Type,
    P_Department       Employee.Department%Type,
    P_Salary           Employee.Salary%Type,
	P_IsActive         Employee.IsActive%Type
    P_EmployeeId       OUT Employee.EmployeeId%Type
) 
As
Begin
    Insert Into Employee (EmployeeName, Sex, DOB, Address, MaritalStatus, HaveSpouse, NumberOfChildren, HiredDate, Position, Department, Salary, IsActive)
    Values (P_EmployeeName, P_Sex, P_DOB, P_Address, P_MaritalStatus, P_HaveSpouse, P_NumberOfChildren, P_HiredDate, P_Position, P_Department, P_Salary, 1)
    Returning EmployeeId Into P_EmployeeId;
    Commit;
End;
/
-- 3. EmployeeUpdate
Create Or Replace Procedure EmployeeUpdate (
    P_EmployeeId       Employee.EmployeeId%Type,
    P_EmployeeName     Employee.EmployeeName%Type,
    P_Sex              Employee.Sex%Type,
    P_DOB              Employee.DOB%Type,
    P_Address          Employee.Address%Type,
    P_MaritalStatus    Employee.MaritalStatus%Type,
    P_HaveSpouse       Employee.HaveSpouse%Type,
    P_NumberOfChildren Employee.NumberOfChildren%Type,
    P_HiredDate        Employee.HiredDate%Type,
    P_Position         Employee.Position%Type,
    P_Department       Employee.Department%Type,
    P_Salary           Employee.Salary%Type,
    P_IsActive         Employee.IsActive%Type 
) 
As
Begin
    Update Employee 
    Set EmployeeName = P_EmployeeName,
        Sex = P_Sex,
        DOB = P_DOB,
        Address = P_Address,
        MaritalStatus = P_MaritalStatus,
        HaveSpouse = P_HaveSpouse,
        NumberOfChildren = P_NumberOfChildren,
        HiredDate = P_HiredDate,
        Position = P_Position,
        Department = P_Department,
        Salary = P_Salary,
        IsActive = P_IsActive
    Where EmployeeId = P_EmployeeId;
    Commit;
End;
/
-- 4. EmployeeDelete (Soft Delete / Deactivate)
Create Or Replace Procedure EmployeeDelete (
    P_EmployeeId Employee.EmployeeId%Type
) 
As
Begin
    Update Employee 
    Set IsActive = 0 
    Where EmployeeId = P_EmployeeId;
    Commit;
End;
/