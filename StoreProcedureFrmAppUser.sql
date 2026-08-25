-- StoreProcedure
-- 1. AppUserGet
Create Or Replace Procedure AppUserGet
(
 P_AppUserId AppUser.AppUserId%Type Default 0
)
As
 C_AppUser Sys_RefCursor;
Begin
 If P_AppUserId = 0 Then
    Open C_AppUser For Select * From AppUser;
 Else
    Open C_AppUser For Select * From AppUser Where AppUserId = P_AppUserId;
 End If;
 DBMS_SQL.return_result(C_AppUser);
End;
/

-- 2. AppUserAdd
Create Or Replace Procedure AppUserAdd
(
 P_EmployeeId AppUser.EmployeeId%Type,
 P_UserName   AppUser.UserName%Type,
 P_Password   AppUser.Password%Type,
 P_Avatar     AppUser.Avatar%Type,
 P_IsActive   AppUser.IsActive%Type Default 1,
 P_IsAdmin    AppUser.IsAdmin%Type Default 0,
 P_AppUserId  OUT AppUser.AppUserId%Type
)
As
Begin
 Insert Into AppUser(EmployeeId, Username, Password, Avatar, IsActive, IsAdmin) 
 Values(P_EmployeeId, P_UserName, P_Password, P_Avatar, P_IsActive, P_IsAdmin)
 Returning AppUserId Into P_AppUserId;
 Commit;
End;
/

-- 3. AppUserUpdate
Create Or Replace Procedure AppUserUpdate
(
 P_AppUserId  AppUser.AppUserId%Type,
 P_EmployeeId AppUser.EmployeeId%Type,
 P_UserName   AppUser.UserName%Type,
 P_Password   AppUser.Password%Type,
 P_Avatar     AppUser.Avatar%Type,
 P_IsActive   AppUser.IsActive%Type,
 P_IsAdmin    AppUser.IsAdmin%Type
)
As
Begin
 Update AppUser
 Set EmployeeId = P_EmployeeId,
     Username = P_UserName,
     Password = P_Password,
     Avatar = P_Avatar,
     IsActive = P_IsActive,
     IsAdmin = P_IsAdmin
 Where AppUserId = P_AppUserId;
 Commit;
End;
/

-- 4. AppUserDelete (Soft Delete / Deactivate)
Create or replace Procedure AppUserDelete
(
 P_AppUserId AppUser.AppUserId%Type
)
As
Begin
 Update AppUser
 Set IsActive = 0
 Where AppUserId = P_AppUserId;
 Commit;
End;
/

-- 5. AppUserLogin
Create Or Replace Procedure AppUserLogin
(
 P_Username AppUser.Username%Type,
 P_Password AppUser.Password%Type
)
As
 C_AppUser Sys_RefCursor;
Begin
 Open C_AppUser For Select * From AppUser Where Upper(Username) = Upper(P_Username) And Password = P_Password And IsActive = 1;
 DBMS_SQL.return_result(C_AppUser);
End;
/

-- 6. AppUserPermissionGet
Create Or Replace Procedure AppUserPermissionGet
(
 P_AppUserId AppUserPermission.AppUserId%Type Default 0
)
As
 C_AppUserPermission Sys_RefCursor;
Begin
 If P_AppUserId = 0 Then
    Open C_AppUserPermission For Select * From AppUserPermission;
 Else
    Open C_AppUserPermission For Select * From AppUserPermission Where AppUserId = P_AppUserId;
 End If;
 DBMS_SQL.return_result(C_AppUserPermission);
End;
/

-- 7. AppUserPermissionAdd
Create Or Replace Procedure AppUserPermissionAdd
(
 P_AppUserId      AppUserPermission.AppUserId%Type,
 P_PermissionName AppUserPermission.PermissionName%Type
)
As
Begin
 Insert Into AppUserPermission(AppUserId, PermissionName, IsAllowed) 
 Values(P_AppUserId, P_PermissionName, 1);
 Commit;
End;
/

-- 8. AppUserPermissionDelete
Create Or Replace Procedure AppUserPermissionDelete
(
 P_AppUserId AppUserPermission.AppUserId%Type
)
As
Begin
 Delete From AppUserPermission Where AppUserId = P_AppUserId;
 Commit;
End;
/