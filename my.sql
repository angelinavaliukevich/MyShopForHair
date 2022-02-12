USE [DbHair]
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [BrandId], [GroupId]) VALUES (2, N'Shampoo', N' Шампунь для абсолютной красоты волос', 30.0000, 1, 3)
GO
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [BrandId], [GroupId]) VALUES (3, N'Shampoo', N'Шампунь для глубокого очищения кожи головы', 30.0000, 2, 5)
GO
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [BrandId], [GroupId]) VALUES (4, N'Shampoo', N'Шампунь для глубокого очищения кожи головы', 30.0000, 11, 9)
GO
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [BrandId], [GroupId]) VALUES (5, N'Mask', N'Маска для глубокой реконструкции волос', 40.0000, 5, 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [BrandId], [GroupId]) VALUES (6, N'Conditioner', N'Кондиционер для осветленных волос', 25.0000, 8, 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [BrandId], [GroupId]) VALUES (7, N'Mask', N'Маска для кудрявых волос', 50.0000, 6, 2)
GO
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [BrandId], [GroupId]) VALUES (8, N'Cream', N'Крем для придания блеска волосам', 50.0000, 4, 4)
GO
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [BrandId], [GroupId]) VALUES (9, N'Shampoo', N'Шампунь с протеинами шелка', 15.0000, 13, 3)
GO
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [BrandId], [GroupId]) VALUES (10, N'Mask', N'Маска для чувствительной кожи головы', 22.0000, 11, 7)
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Criterias] ON 
GO
