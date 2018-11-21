Select * from userRoles
Select * from users
Insert into userRoles(UserRole, userID) values('Admin',4)
Insert into userRoles(UserRole, userID) values('Admin',2)
Insert into userRoles(UserRole, userID) values('Employee',1)
Insert into userRoles(UserRole, userID) values('Users',3)
Insert into userRoles(UserRole, userID) values('Employee',4)
Insert into userRoles(UserRole, userID) values('Employee',2)
update users set Password = 'employee123' where ID = 1
update users set Password = 'Admin101' where ID = 2
update users set Password = 'Users1001' where ID = 3
update users set Password = 'Admin102' where ID = 4