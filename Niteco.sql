USE [Niteco]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 3/13/2023 10:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](255) NULL,
	[CreatedDate] [datetime] NULL,
	[Desc] [nvarchar](255) NULL,
 CONSTRAINT [PK__Category__3214EC07F776FBCE] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 3/13/2023 10:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[CreatedDate] [datetime] NULL,
	[Desc] [nvarchar](255) NULL,
 CONSTRAINT [PK__Customer__3214EC0785E54A88] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 3/13/2023 10:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[CustomerId] [int] NULL,
	[Amount] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[Desc] [nvarchar](255) NULL,
	[Title] [nvarchar](255) NULL,
 CONSTRAINT [PK__Order__3214EC07928DE018] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 3/13/2023 10:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NULL,
	[Image] [nvarchar](255) NULL,
	[Price] [int] NULL,
	[Amount] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[Desc] [nvarchar](255) NULL,
	[Name] [nvarchar](255) NULL,
 CONSTRAINT [PK__Product__3214EC074B44676C] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Title], [CreatedDate], [Desc]) VALUES (1, N'tesst', NULL, N'tesst')
INSERT [dbo].[Category] ([Id], [Title], [CreatedDate], [Desc]) VALUES (2, N'Chứng khoán', NULL, NULL)
INSERT [dbo].[Category] ([Id], [Title], [CreatedDate], [Desc]) VALUES (3, N'Quỹ', NULL, NULL)
INSERT [dbo].[Category] ([Id], [Title], [CreatedDate], [Desc]) VALUES (4, N'Bảo hiểm', NULL, NULL)
INSERT [dbo].[Category] ([Id], [Title], [CreatedDate], [Desc]) VALUES (5, N'Ngân hàng', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [Name], [Address], [CreatedDate], [Desc]) VALUES (1, N'tess', N'rrr', NULL, N'ffff')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [CreatedDate], [Desc]) VALUES (2, N'Đức', N'Hải Phòng', NULL, NULL)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [CreatedDate], [Desc]) VALUES (3, N'Nguyễn Đức', N'Hải Phòng', NULL, NULL)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [CreatedDate], [Desc]) VALUES (4, N'Duc Nguyen Huynh', N'hải phòng', CAST(N'2023-03-15T00:00:00.000' AS DateTime), N'OKOK')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [CreatedDate], [Desc]) VALUES (5, N'Người sói', N'rrrr', CAST(N'2023-03-12T23:27:02.163' AS DateTime), N'rrr')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([Id], [ProductId], [CustomerId], [Amount], [CreatedDate], [Desc], [Title]) VALUES (1, 1, 1, 14, NULL, N'ggg', NULL)
INSERT [dbo].[Order] ([Id], [ProductId], [CustomerId], [Amount], [CreatedDate], [Desc], [Title]) VALUES (2, 1, 1, 222, CAST(N'2023-03-22T00:00:00.000' AS DateTime), N'dasdasd', NULL)
INSERT [dbo].[Order] ([Id], [ProductId], [CustomerId], [Amount], [CreatedDate], [Desc], [Title]) VALUES (3, 1, 1, 144, CAST(N'2023-03-23T00:00:00.000' AS DateTime), N'sâd', NULL)
INSERT [dbo].[Order] ([Id], [ProductId], [CustomerId], [Amount], [CreatedDate], [Desc], [Title]) VALUES (4, 1, 1, 43, CAST(N'2023-03-10T00:00:00.000' AS DateTime), N'fad', NULL)
INSERT [dbo].[Order] ([Id], [ProductId], [CustomerId], [Amount], [CreatedDate], [Desc], [Title]) VALUES (5, 1, 1, 12, CAST(N'2023-03-09T00:00:00.000' AS DateTime), N'111', N'te')
INSERT [dbo].[Order] ([Id], [ProductId], [CustomerId], [Amount], [CreatedDate], [Desc], [Title]) VALUES (6, 2, 4, 10000, CAST(N'2023-03-09T00:00:00.000' AS DateTime), N'okok', N'')
INSERT [dbo].[Order] ([Id], [ProductId], [CustomerId], [Amount], [CreatedDate], [Desc], [Title]) VALUES (7, 2, 4, 100, CAST(N'2023-03-09T00:00:00.000' AS DateTime), N'okok', N'test')
INSERT [dbo].[Order] ([Id], [ProductId], [CustomerId], [Amount], [CreatedDate], [Desc], [Title]) VALUES (8, 2, 3, 4444, CAST(N'2023-03-15T00:00:00.000' AS DateTime), N'addad', N'test')
INSERT [dbo].[Order] ([Id], [ProductId], [CustomerId], [Amount], [CreatedDate], [Desc], [Title]) VALUES (9, 2, 3, 4444, CAST(N'2023-03-15T00:00:00.000' AS DateTime), N'addad', N'test')
INSERT [dbo].[Order] ([Id], [ProductId], [CustomerId], [Amount], [CreatedDate], [Desc], [Title]) VALUES (10, 2, 2, 55, CAST(N'2023-03-09T00:00:00.000' AS DateTime), N'1000', N'test3')
INSERT [dbo].[Order] ([Id], [ProductId], [CustomerId], [Amount], [CreatedDate], [Desc], [Title]) VALUES (11, 2, 2, 55, CAST(N'2023-03-09T00:00:00.000' AS DateTime), N'1000', N'test3')
INSERT [dbo].[Order] ([Id], [ProductId], [CustomerId], [Amount], [CreatedDate], [Desc], [Title]) VALUES (12, 2, 2, 55, CAST(N'2023-03-09T00:00:00.000' AS DateTime), N'1000', N'test3')
INSERT [dbo].[Order] ([Id], [ProductId], [CustomerId], [Amount], [CreatedDate], [Desc], [Title]) VALUES (13, 2, 2, 55, CAST(N'2023-03-09T00:00:00.000' AS DateTime), N'1000', N'test3')
INSERT [dbo].[Order] ([Id], [ProductId], [CustomerId], [Amount], [CreatedDate], [Desc], [Title]) VALUES (14, 2, 4, 55, CAST(N'2023-03-03T00:00:00.000' AS DateTime), N'ttt', N'uuu')
INSERT [dbo].[Order] ([Id], [ProductId], [CustomerId], [Amount], [CreatedDate], [Desc], [Title]) VALUES (15, 2, 1, 44, CAST(N'2023-03-12T23:22:24.397' AS DateTime), N't', N'e')
SET IDENTITY_INSERT [dbo].[Order] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [CategoryId], [Image], [Price], [Amount], [CreatedDate], [Desc], [Name]) VALUES (1, 1, NULL, 12, 12, NULL, N'r', NULL)
INSERT [dbo].[Product] ([Id], [CategoryId], [Image], [Price], [Amount], [CreatedDate], [Desc], [Name]) VALUES (2, 2, NULL, 5000, 99901, CAST(N'2023-03-14T00:00:00.000' AS DateTime), N'kok', N'AOE')
INSERT [dbo].[Product] ([Id], [CategoryId], [Image], [Price], [Amount], [CreatedDate], [Desc], [Name]) VALUES (3, 1, NULL, 555, 333333, CAST(N'2023-03-12T23:26:49.920' AS DateTime), N'', N'Liên Minh Huyền Thoại')
SET IDENTITY_INSERT [dbo].[Product] OFF
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_OrderCustomer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_OrderCustomer]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_OrderProduct] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_OrderProduct]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_ProductCategory] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_ProductCategory]
GO
