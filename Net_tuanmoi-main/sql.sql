USE [QL_NV]
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 01/11/2023 16:09:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[TenHH] [nvarchar](50) NOT NULL,
	[NuocSX] [nvarchar](50) NULL,
	[GiaTien] [money] NULL,
	[SoLuong] [int] NULL,
	[ThanhToan] [money] NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[TenHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
