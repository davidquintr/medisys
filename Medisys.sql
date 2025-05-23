USE [master]
GO
/****** Object:  Database [Medisys]    Script Date: 10/4/2025 21:26:16 ******/
CREATE DATABASE [Medisys]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Medisys', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Medisys.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Medisys_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Medisys_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Medisys] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Medisys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Medisys] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Medisys] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Medisys] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Medisys] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Medisys] SET ARITHABORT OFF 
GO
ALTER DATABASE [Medisys] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Medisys] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Medisys] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Medisys] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Medisys] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Medisys] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Medisys] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Medisys] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Medisys] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Medisys] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Medisys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Medisys] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Medisys] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Medisys] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Medisys] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Medisys] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Medisys] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Medisys] SET RECOVERY FULL 
GO
ALTER DATABASE [Medisys] SET  MULTI_USER 
GO
ALTER DATABASE [Medisys] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Medisys] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Medisys] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Medisys] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Medisys] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Medisys] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Medisys', N'ON'
GO
ALTER DATABASE [Medisys] SET QUERY_STORE = ON
GO
ALTER DATABASE [Medisys] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Medisys]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 10/4/2025 21:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[LastName] [varchar](255) NOT NULL,
	[Address] [varchar](255) NULL,
	[Sex] [varchar](10) NOT NULL,
	[State] [int] NOT NULL,
	[IDUser] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 10/4/2025 21:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [uniqueidentifier] NOT NULL,
	[Username] [varchar](255) NOT NULL,
	[Password] [varchar](255) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Role] [varchar](20) NOT NULL,
	[State] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewEmployeeUser]    Script Date: 10/4/2025 21:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[ViewEmployeeUser]
as
SELECT        
    dbo.Employee.ID, 
    dbo.Employee.Name, 
    dbo.Employee.LastName, 
    dbo.Employee.Address, 
    dbo.Employee.Sex, 
    dbo.Employee.State,
    dbo.[User].Username
FROM            
    dbo.Employee 
LEFT JOIN
    dbo.[User] ON dbo.Employee.IDUser = dbo.[User].ID
GO
/****** Object:  Table [dbo].[Checkup]    Script Date: 10/4/2025 21:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Checkup](
	[ID] [uniqueidentifier] NOT NULL,
	[IDPatient] [uniqueidentifier] NOT NULL,
	[IDEmployee] [uniqueidentifier] NOT NULL,
	[CheckupDate] [datetime] NOT NULL,
	[State] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Condition]    Script Date: 10/4/2025 21:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Condition](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Description] [varchar](255) NULL,
	[State] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeSpecialty]    Script Date: 10/4/2025 21:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeSpecialty](
	[ID] [uniqueidentifier] NOT NULL,
	[IDEmployee] [uniqueidentifier] NOT NULL,
	[IDSpecialty] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 10/4/2025 21:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[LastName] [varchar](255) NOT NULL,
	[Address] [varchar](255) NULL,
	[Sex] [varchar](10) NOT NULL,
	[IdentityCard] [varchar](100) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[RegisterDate] [datetime] NOT NULL,
	[State] [int] NOT NULL,
	[AvatarURI] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Patient] UNIQUE NONCLUSTERED 
(
	[IdentityCard] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientCondition]    Script Date: 10/4/2025 21:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientCondition](
	[ID] [uniqueidentifier] NOT NULL,
	[IDPatient] [uniqueidentifier] NOT NULL,
	[IDCondition] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prescription]    Script Date: 10/4/2025 21:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prescription](
	[ID] [uniqueidentifier] NOT NULL,
	[IDCheckup] [uniqueidentifier] NOT NULL,
	[Description] [varchar](255) NULL,
	[RegisterDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specialty]    Script Date: 10/4/2025 21:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialty](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[State] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Checkup] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[Checkup] ADD  DEFAULT ((0)) FOR [State]
GO
ALTER TABLE [dbo].[Condition] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[Condition] ADD  DEFAULT ((0)) FOR [State]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT ((0)) FOR [State]
GO
ALTER TABLE [dbo].[EmployeeSpecialty] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[Patient] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[Patient] ADD  DEFAULT ((0)) FOR [State]
GO
ALTER TABLE [dbo].[PatientCondition] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[Prescription] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[Specialty] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[Specialty] ADD  DEFAULT ((0)) FOR [State]
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT ((0)) FOR [State]
GO
ALTER TABLE [dbo].[Checkup]  WITH CHECK ADD  CONSTRAINT [FK_Checkup_Employee] FOREIGN KEY([IDEmployee])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Checkup] CHECK CONSTRAINT [FK_Checkup_Employee]
GO
ALTER TABLE [dbo].[Checkup]  WITH CHECK ADD  CONSTRAINT [FK_Checkup_Patient] FOREIGN KEY([IDPatient])
REFERENCES [dbo].[Patient] ([ID])
GO
ALTER TABLE [dbo].[Checkup] CHECK CONSTRAINT [FK_Checkup_Patient]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_User] FOREIGN KEY([IDUser])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_User]
GO
ALTER TABLE [dbo].[EmployeeSpecialty]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSpecialty_Employee] FOREIGN KEY([IDEmployee])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[EmployeeSpecialty] CHECK CONSTRAINT [FK_EmployeeSpecialty_Employee]
GO
ALTER TABLE [dbo].[EmployeeSpecialty]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSpecialty_Specialty] FOREIGN KEY([IDSpecialty])
REFERENCES [dbo].[Specialty] ([ID])
GO
ALTER TABLE [dbo].[EmployeeSpecialty] CHECK CONSTRAINT [FK_EmployeeSpecialty_Specialty]
GO
ALTER TABLE [dbo].[PatientCondition]  WITH CHECK ADD  CONSTRAINT [FK_PatientCondition_Condition] FOREIGN KEY([IDCondition])
REFERENCES [dbo].[Condition] ([ID])
GO
ALTER TABLE [dbo].[PatientCondition] CHECK CONSTRAINT [FK_PatientCondition_Condition]
GO
ALTER TABLE [dbo].[PatientCondition]  WITH CHECK ADD  CONSTRAINT [FK_PatientCondition_Patient] FOREIGN KEY([IDPatient])
REFERENCES [dbo].[Patient] ([ID])
GO
ALTER TABLE [dbo].[PatientCondition] CHECK CONSTRAINT [FK_PatientCondition_Patient]
GO
ALTER TABLE [dbo].[Prescription]  WITH CHECK ADD  CONSTRAINT [FK_Prescription_Checkup] FOREIGN KEY([IDCheckup])
REFERENCES [dbo].[Checkup] ([ID])
GO
ALTER TABLE [dbo].[Prescription] CHECK CONSTRAINT [FK_Prescription_Checkup]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD CHECK  (([Sex]='male' OR [Sex]='female'))
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD CHECK  (([Sex]='male' OR [Sex]='female'))
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD CHECK  (([Role]='admin' OR [Role]='doctor'))
GO
USE [master]
GO
ALTER DATABASE [Medisys] SET  READ_WRITE 
GO
