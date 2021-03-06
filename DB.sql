USE [markssytem]
GO
/****** Object:  Table [dbo].[Component]    Script Date: 5/26/2016 6:19:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Component](
	[ComponentID] [varchar](50) NOT NULL,
	[ModuleID] [varchar](50) NOT NULL,
	[ComponentName] [varchar](100) NOT NULL,
	[Weightage] [int] NOT NULL,
	[Marks] [int] NULL,
 CONSTRAINT [PK_Component] PRIMARY KEY CLUSTERED 
(
	[ComponentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Level]    Script Date: 5/26/2016 6:19:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Level](
	[LevelID] [varchar](50) NOT NULL,
	[LevelName] [varchar](100) NULL,
 CONSTRAINT [PK_Level] PRIMARY KEY CLUSTERED 
(
	[LevelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Module]    Script Date: 5/26/2016 6:19:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Module](
	[ModuleID] [varchar](50) NOT NULL,
	[ModuleName] [varchar](100) NULL,
	[LevelID] [varchar](50) NULL,
	[Credits] [int] NULL,
 CONSTRAINT [PK_Module] PRIMARY KEY CLUSTERED 
(
	[ModuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'CW1ACSD', N'ECWI502', N'CourseWork1', 60, 67)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'CW1ALG', N'ECSI504', N'CourseWork1', 50, 56)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'CW1AM', N'ECSI606', N'CourseWork1', 40, 85)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'CW1ASP', N'ECSI604', N'CourseWork1', 40, 45)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'CW1CS', N'ECSI400', N'CourseWork1', 60, 83)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'CW1CSP', N'ECSI601', N'CourseWork1', 70, 76)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'CW1IS', N'ECSI411', N'Course Work1', 60, 76)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'CW1MNAD', N'ECSI607', N'CourseWork1', 60, 76)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'CW1OOP1', N' ECII501', N'Course Work', 60, 77)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'CW1OOP2', N'ECII502', N'CourseWork1', 50, 64)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'CW1PP', N'ECSI505', N'CourseWork1', 60, 88)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'CW1WEB', N'ECSI407', N'Course Work', 40, 55)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'CW2CS', N'ECSI400', N'CourseWork2', 40, 66)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'CW2OOP1', N' ECII501', N'Course Work2', 40, 49)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'CW2OOP2', N'ECII502', N'CourseWork2', 50, 87)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'FEXALG', N'ECSI504', N'FinalExam', 50, 53)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'FEXWEB', N'ECSI407', N'FinalExam', 60, 70)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT1ASP', N'ECSI604', N'InClassTest2', 60, 88)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT1CP', N'ECSI605', N'InClassTest1', 50, 67)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT1CSF', N'ECSI404', N'InClassTest1', 70, 56)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT1MAT', N'ECSI408', N'InClass Test1', 60, 76)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT1RP', N'ECSI603', N'InClass Test1', 50, 87)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT1SDGP', N'ECSI503', N'InClassTest1', 30, 67)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT1SDP1', N'ECSC405', N'InClass Test1', 50, 22)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT1SDP2', N'ECSI405', N'InClassTest1', 60, 67)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT1SF', N'ECSI602', N'InClassTest1', 60, 43)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT1WSSP', N'ECWI512', N'InClassTest1', 50, 88)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT2MAT', N'ECSI408', N'InClass Test2', 30, 76)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT2SDGP', N'ECSI503', N'InClassTest2', 30, 76)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT2SDP1', N'ECSC405', N'InClass Test2', 20, 56)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT2SF', N'ECSI602', N'InClassTest2', 40, 87)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT2WSSP', N'ECWI512', N'InClassTest2', 50, 64)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT3MAT', N'ECSI408', N'InClass Test3', 30, 65)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'ICT3SDP1', N'ECSC405', N'InClass Test3', 20, 47)
INSERT [dbo].[Component] ([ComponentID], [ModuleID], [ComponentName], [Weightage], [Marks]) VALUES (N'SDP001', N'ECSC405', N'Test', 70, 90)
INSERT [dbo].[Level] ([LevelID], [LevelName]) VALUES (N'4', N'Level4')
INSERT [dbo].[Level] ([LevelID], [LevelName]) VALUES (N'5', N'Level5')
INSERT [dbo].[Level] ([LevelID], [LevelName]) VALUES (N'6', N'Level6')
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'', NULL, NULL, NULL)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N' ECII501', N'Object Oriented Programming 1', N'5', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECII502', N'Object Oriented Programming 2', N'5', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSC405', N'Software Development Principles1', N'4', 30)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI123', N'TEstqw', NULL, NULL)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI400', N'Communication and Learning Skills in Computer Science ', N'4', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI404', N'Computer Systems Fundamentals', N'4', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI405', N'Software Development Principles II', N'4', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI407', N'Web Technology', N'4', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI408', N'Mathematics for Computing', N'4', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI411', N'Information Systems ', N'4', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI503', N'Software Development Group Project', N'5', 30)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI504', N'Algorithms and Complexity', N'5', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI505', N'Professional Practice', N'5', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI601', N'Computer Science Project', N'6', 30)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI602', N'Security and Forensics', N'6', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI603', N'Reasoning About Programs', N'6', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI604', N'Advanced Server-side Web Programming', N'6', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI605', N'Concurrent Programming', N'6', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI606', N'Advanced Maths & Game AI', N'6', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI607', N'Mobile Native Application Development', N'6', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI890', N'abcererer', NULL, NULL)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECSI899', N'AOD', NULL, 23)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECWI502', N'Advanced Client-side Web Development ', N'5', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ECWI512', N'Web Server-Side Programming', N'5', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'EDSI123', N'SDP2', NULL, 30)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ESC200', NULL, NULL, NULL)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [LevelID], [Credits]) VALUES (N'ESCI500', N'Testing', NULL, 30)
ALTER TABLE [dbo].[Component]  WITH CHECK ADD  CONSTRAINT [FK_Component_Module] FOREIGN KEY([ModuleID])
REFERENCES [dbo].[Module] ([ModuleID])
GO
ALTER TABLE [dbo].[Component] CHECK CONSTRAINT [FK_Component_Module]
GO
ALTER TABLE [dbo].[Module]  WITH CHECK ADD  CONSTRAINT [FK_Module_Level] FOREIGN KEY([LevelID])
REFERENCES [dbo].[Level] ([LevelID])
GO
ALTER TABLE [dbo].[Module] CHECK CONSTRAINT [FK_Module_Level]
GO
