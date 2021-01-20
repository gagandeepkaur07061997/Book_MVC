SET IDENTITY_INSERT [dbo].[Authors] ON
INSERT INTO [dbo].[Authors] ([Id], [Name], [Email_Id], [Address], [Mobile_Number]) VALUES (1, N'Gagandeep kaur', N'gagandeepkaur07061997@gmail.com', N'1/42 coronation road, papatoetoe', N'0220765433')
INSERT INTO [dbo].[Authors] ([Id], [Name], [Email_Id], [Address], [Mobile_Number]) VALUES (2, N'Sukhjeet Kaur', N'Sukhjeet1999kaur@gmail.com', N'1/11 Birdwood, Papatoetoe, Manukau', N'0229980811')
INSERT INTO [dbo].[Authors] ([Id], [Name], [Email_Id], [Address], [Mobile_Number]) VALUES (3, N'Simranjeet Kaur', N'Simran12jeet@gmail.com', N'23/2 Birdwood Avenew, Papatoetoe', N'0227793645')
INSERT INTO [dbo].[Authors] ([Id], [Name], [Email_Id], [Address], [Mobile_Number]) VALUES (4, N'Rajdeep kaur', N'Rajdeepkaur09@gmail.com', N'3/23 Glen Avenew, papatoetoe', N'02290980811')
INSERT INTO [dbo].[Authors] ([Id], [Name], [Email_Id], [Address], [Mobile_Number]) VALUES (5, N'Ritika', N'Ritika1231@gmail.com', N'29 Rangitoto road, Papatoetoe', N'02253479801')
SET IDENTITY_INSERT [dbo].[Authors] OFF
SET IDENTITY_INSERT [dbo].[Publisher] ON
INSERT INTO [dbo].[Publisher] ([Id], [Publisher_Name], [Mobile_Number], [Email_Id]) VALUES (1, N'Harpreet Singh', N'0220887768', N'Harpreet123@gmail.com')
INSERT INTO [dbo].[Publisher] ([Id], [Publisher_Name], [Mobile_Number], [Email_Id]) VALUES (2, N'Varinder singh', N'0220955059', N'varinder909@gmail.com')
INSERT INTO [dbo].[Publisher] ([Id], [Publisher_Name], [Mobile_Number], [Email_Id]) VALUES (3, N'Manveer Singh', N'022348873', N'Manveer56singh@gmail.com')
INSERT INTO [dbo].[Publisher] ([Id], [Publisher_Name], [Mobile_Number], [Email_Id]) VALUES (4, N'Karan ', N'02207710188', N'Karan101@gmail.com')
INSERT INTO [dbo].[Publisher] ([Id], [Publisher_Name], [Mobile_Number], [Email_Id]) VALUES (5, N'Joban Singh', N'022309687', N'Joban0@gmail.com')
SET IDENTITY_INSERT [dbo].[Publisher] OFF
SET IDENTITY_INSERT [dbo].[Books] ON
INSERT INTO [dbo].[Books] ([Id], [Tittle], [Discription], [Price], [AuthorId]) VALUES (1, N'Heart of darkness', N'It is based on a true story', CAST(20.00 AS Decimal(18, 2)), 1)
INSERT INTO [dbo].[Books] ([Id], [Tittle], [Discription], [Price], [AuthorId]) VALUES (2, N'Sole of heart', N'An interesting Story', CAST(10.00 AS Decimal(18, 2)), 2)
INSERT INTO [dbo].[Books] ([Id], [Tittle], [Discription], [Price], [AuthorId]) VALUES (3, N'Jane Eyre', N'It is an English novel', CAST(50.00 AS Decimal(18, 2)), 3)
INSERT INTO [dbo].[Books] ([Id], [Tittle], [Discription], [Price], [AuthorId]) VALUES (4, N'The old man and the Sea ', N'It is a short novel, written in 1951.', CAST(25.00 AS Decimal(18, 2)), 4)
INSERT INTO [dbo].[Books] ([Id], [Tittle], [Discription], [Price], [AuthorId]) VALUES (5, N'A Promised Land', N'A famous novel', CAST(15.00 AS Decimal(18, 2)), 5)
SET IDENTITY_INSERT [dbo].[Books] OFF
SET IDENTITY_INSERT [dbo].[Publication] ON
INSERT INTO [dbo].[Publication] ([Id], [Books_Copies], [Publisher_detailId], [Books_detailId]) VALUES (1, N'6', 1, 1)
INSERT INTO [dbo].[Publication] ([Id], [Books_Copies], [Publisher_detailId], [Books_detailId]) VALUES (2, N'20', 2, 2)
INSERT INTO [dbo].[Publication] ([Id], [Books_Copies], [Publisher_detailId], [Books_detailId]) VALUES (3, N'50', 4, 5)
INSERT INTO [dbo].[Publication] ([Id], [Books_Copies], [Publisher_detailId], [Books_detailId]) VALUES (4, N'60', 5, 3)
INSERT INTO [dbo].[Publication] ([Id], [Books_Copies], [Publisher_detailId], [Books_detailId]) VALUES (5, N'78', 3, 4)
SET IDENTITY_INSERT [dbo].[Publication] OFF
