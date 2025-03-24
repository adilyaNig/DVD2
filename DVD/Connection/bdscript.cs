using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace DVD.Connection
{
    internal class bdscript
    {

    }
//    USE[Cinema]
//GO
///****** Object:  Table [dbo].[Age]    Script Date: 24.03.2025 17:08:44 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE[dbo].[Age]
//    (

//    [id][int] IDENTITY(1,1) NOT NULL,

//    [Title] [nvarchar] (50) NOT NULL,
// CONSTRAINT[PK_Age] PRIMARY KEY CLUSTERED
//(
//    [id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[Authorization]    Script Date: 24.03.2025 17:08:44 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE[dbo].[Authorization]
//    (

//    [id][int] IDENTITY(1,1) NOT NULL,

//    [Login] [nvarchar] (50) NOT NULL,

//    [Password] [nvarchar] (50) NOT NULL,

//    [id_role] [int]
//    NOT NULL,
// CONSTRAINT[PK_Authorization] PRIMARY KEY CLUSTERED
//(
//    [id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[Cheque]    Script Date: 24.03.2025 17:08:44 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE[dbo].[Cheque]
//    (

//    [id_cheque][int] IDENTITY(1,1) NOT NULL,

//    [id_rent] [int]
//    NOT NULL,

//    [id_film] [int]
//    NOT NULL,
// CONSTRAINT[PK_Cheque] PRIMARY KEY CLUSTERED
//(
//    [id_cheque] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[Client]    Script Date: 24.03.2025 17:08:44 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE[dbo].[Client]
//    (

//    [id_client][int] IDENTITY(1,1) NOT NULL,

//    [Lastname] [varchar] (50) NOT NULL,

//    [Name] [varchar] (50) NOT NULL,

//    [Surname] [varchar] (50) NOT NULL,

//    [Phone] [nchar] (50) NOT NULL,

//    [IsDelete] [bit] NULL,
// CONSTRAINT[PK_Client] PRIMARY KEY CLUSTERED
//(
//    [id_client] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[Employee]    Script Date: 24.03.2025 17:08:44 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE[dbo].[Employee]
//    (

//    [id_employee][int] IDENTITY(1,1) NOT NULL,

//    [Lastname] [varchar] (50) NOT NULL,

//    [Name] [varchar] (50) NOT NULL,

//    [Surname] [varchar] (50) NOT NULL,

//    [Phone] [nchar] (20) NOT NULL,

//    [id_role] [int]
//    NOT NULL,

//    [Salary] [float]
//    NOT NULL,
// CONSTRAINT[PK_Employee] PRIMARY KEY CLUSTERED
//(
//    [id_employee] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[Film]    Script Date: 24.03.2025 17:08:44 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE[dbo].[Film]
//    (

//    [id_film][int] IDENTITY(1,1) NOT NULL,

//    [Title] [nvarchar] (50) NOT NULL,

//    [id_genre] [int]
//    NOT NULL,

//    [id_age] [int]
//    NOT NULL,

//    [Price] [float]
//    NOT NULL,

//    [IsDelete] [bit] NULL,
// CONSTRAINT[PK_Film] PRIMARY KEY CLUSTERED
//(
//    [id_film] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[Genre]    Script Date: 24.03.2025 17:08:44 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE[dbo].[Genre]
//    (

//    [id_genre][int] IDENTITY(1,1) NOT NULL,

//    [Title] [nvarchar] (50) NOT NULL,
// CONSTRAINT[PK_Genre] PRIMARY KEY CLUSTERED
//(
//    [id_genre] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[Rent]    Script Date: 24.03.2025 17:08:44 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE[dbo].[Rent]
//    (

//    [id_rent][int] IDENTITY(3,1) NOT NULL,

//    [DateOfIssue] [date]
//    NOT NULL,

//    [id_client] [int]
//    NOT NULL,

//    [id_employee] [int]
//    NOT NULL,

//    [DateOfDelivery] [date]
//    NOT NULL,
// CONSTRAINT[PK_Rent] PRIMARY KEY CLUSTERED
//(
//    [id_rent] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO
///****** Object:  Table [dbo].[Role]    Script Date: 24.03.2025 17:08:44 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE[dbo].[Role]
//    (

//    [id_role][int] IDENTITY(1,1) NOT NULL,

//    [Title] [nvarchar] (50) NOT NULL,
// CONSTRAINT[PK_Role] PRIMARY KEY CLUSTERED
//(
//    [id_role] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
//) ON[PRIMARY]
//GO
//ALTER TABLE[dbo].[Authorization] WITH CHECK ADD CONSTRAINT[FK_Authorization_Employee] FOREIGN KEY([id_role])
//REFERENCES[dbo].[Employee]
//    ([id_employee])
//GO
//ALTER TABLE[dbo].[Authorization]
//    CHECK CONSTRAINT[FK_Authorization_Employee]
//GO
//ALTER TABLE[dbo].[Cheque] WITH CHECK ADD CONSTRAINT[FK_Cheque_Film] FOREIGN KEY([id_film])
//REFERENCES[dbo].[Film]
//    ([id_film])
//GO
//ALTER TABLE[dbo].[Cheque]
//    CHECK CONSTRAINT[FK_Cheque_Film]
//GO
//ALTER TABLE[dbo].[Cheque] WITH CHECK ADD CONSTRAINT[FK_Cheque_Rent] FOREIGN KEY([id_rent])
//REFERENCES[dbo].[Rent]
//    ([id_rent])
//GO
//ALTER TABLE[dbo].[Cheque]
//    CHECK CONSTRAINT[FK_Cheque_Rent]
//GO
//ALTER TABLE[dbo].[Employee] WITH CHECK ADD CONSTRAINT[FK_Employee_Role] FOREIGN KEY([id_role])
//REFERENCES[dbo].[Role]
//    ([id_role])
//GO
//ALTER TABLE[dbo].[Employee]
//    CHECK CONSTRAINT[FK_Employee_Role]
//GO
//ALTER TABLE[dbo].[Film] WITH CHECK ADD CONSTRAINT[FK_Film_Age] FOREIGN KEY([id_age])
//REFERENCES[dbo].[Age]
//    ([id])
//GO
//ALTER TABLE[dbo].[Film]
//    CHECK CONSTRAINT[FK_Film_Age]
//GO
//ALTER TABLE[dbo].[Film] WITH CHECK ADD CONSTRAINT[FK_Film_Genre] FOREIGN KEY([id_genre])
//REFERENCES[dbo].[Genre]
//    ([id_genre])
//GO
//ALTER TABLE[dbo].[Film]
//    CHECK CONSTRAINT[FK_Film_Genre]
//GO
//ALTER TABLE[dbo].[Rent] WITH CHECK ADD CONSTRAINT[FK_Rent_Client] FOREIGN KEY([id_client])
//REFERENCES[dbo].[Client]
//    ([id_client])
//GO
//ALTER TABLE[dbo].[Rent]
//    CHECK CONSTRAINT[FK_Rent_Client]
//GO
//ALTER TABLE[dbo].[Rent] WITH CHECK ADD CONSTRAINT[FK_Rent_Employee] FOREIGN KEY([id_employee])
//REFERENCES[dbo].[Employee]
//    ([id_employee])
//GO
//ALTER TABLE[dbo].[Rent]
//    CHECK CONSTRAINT[FK_Rent_Employee]
//GO

}
