SET IDENTITY_INSERT [dbo].[Employees] ON
INSERT INTO [dbo].[Employees] ([EmployeeID], [Name], [Surname], [DateOfEmployment], [Salary]) VALUES (1002, N'asdf', N'fsadf', N'2004-04-25 00:00:00', CAST(123.0000 AS Money))
SET IDENTITY_INSERT [dbo].[Employees] OFF
