CREATE DATABASE TRUNGTAMANHVAN
GO

USE TRUNGTAMANHVAN
GO
CREATE TABLE ACCOUNT
(USERNAME CHAR(100) NOT NULL UNIQUE,
	PASS_WORD CHAR(100) NOT NULL,
)

SELECT *FROM ACCOUNT 
where USERNAME='admin' and PASS_WORD='admin'

CREATE TABLE GIAOVIEN (
	GVID INT IDENTITY (1, 1) PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	CMND CHAR(20) NOT NULL,
	GIOITINH NVARCHAR(20) NOT NULL,
	NGAYSINH DATE NOT NULL,
	SDT CHAR(20)NOT NULL,
	DIACHI NVARCHAR(4000) NOT NULL,
	TRINHDO NVARCHAR(4000) NOT NULL,
	EMAIL NVARCHAR(50) NOT NULL,
	UUDIEM NVARCHAR(4000),
	)
	
INSERT INTO GIAOVIEN( HOTEN,CMND,GIOITINH,NGAYSINH,SDT,DIACHI,TRINHDO,EMAIL,UUDIEM) VALUES 
	(N'Nguyễn Văn N','284562364512','Nam','1998/04/04','0329018291',N'Tp Hồ chí Minh','Cử nhân','VanN@gmail.com','Chuyên môn cao, thích giao tiếp'),
	(N'Trần Thị K','28423623645','Nữ','1996/07/05','0392817266',N'Tp Hồ chí Minh','Thạc sĩ','ThiK@gmail.com','Chuyên môn cao, có khả năng thấu hiểu học sinh'),
	(N'Nguyễn Bá C','284534623645','Nam','1997/12/08','0392818277',N'Tp Hồ chí Minh','Cao đẳng','BaC@gmail.com','Chuyên môn cao, tạo được không khí trong lớp học'),
	(N'Đặng Kim D','284125623645','Nữ','1989/11/09','0987738271',N'Tp Hồ chí Minh','Cử nhân','KimD@gmail.com','Chuyên môn cao, kinh nghiệm 3 năm'),
	(N'Bùi Đặng E','284562343645','Nam','1993/12/12','0928371827',N'Tp Hồ chí Minh','Cao đẳng','DangE@gmail.com','Chuyên môn cao, kinh nghiệm 5 năm'),
	(N'Kim Thảo Hà T','284598623645','Nữ','1990/02/04','0897817263',N'Tp Hồ chí Minh','Cử nhân','HaT@gmail.com','Chuyên môn cao, giao tiếp tốt'),
	(N'Trần Văn G','284562369645','Nam','1980/09/29','0152637181',N'Tp Hồ chí Minh','Cử nhân','VanG@gmail.com','Chuyên môn cao, kinh nghiệm 4 năm'),
	(N'Phạm Thi H','284564623645','Nữ','1999/05/17','0982782711',N'Tp Hồ chí Minh','Thạc sĩ','ThiH@gmail.com','Chuyên môn cao, thường xuyên sáng tạo nội dung học tập'),
	(N'Nguyễn Thị Xuân L','289545623645','Nữ','1987/06/06','0392817261',N'Tp Hồ chí Minh','Cử nhân','XuanL@gmail.com','Chuyên môn cao, kinh nghiệm 2 năm'),
	(N'Nguyễn Thị Hạ M','284562313645','Nữ','1999/09/09','0392817281',N'Tp Hồ chí Minh','Cao đẳng','HaM@gmail.com','Chuyên môn cao, hiểu tâm lý học sinh'),
	(N'Nguyễn Tấn L','284562362445','Nam','1985/07/12','0392818172',N'Tp Hồ chí Minh','Cử nhân','TanL@gmail.com','Chuyên môn cao, kinh nghiệm 4 năm'),
	(N'Trịnh Thị Ngọc T','284565623645','Nữ','1890/05/23','0988291828',N'Tp Hồ chí Minh','Cử nhân','NgocT@gmail.com','Chuyên môn cao, kinh nghiệm 2 năm')
	GO

	CREATE TABLE HOCSINH(
	HSID INT IDENTITY (1, 1) PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	GIOITINH NVARCHAR(20) NOT NULL,
	NGAYSINH DATE NOT NULL,
	DIACHI NVARCHAR(4000) NOT NULL,
	SDT CHAR(20) NOT NULL,
	CMND CHAR(20) NULL,
	EMAIL char(100) not null,)
	select * from HOCSINH

	INSERT INTO HOCSINH(HOTEN, GIOITINH, NGAYSINH, DIACHI, SDT, CMND, EMAIL) VALUES 
	(N'Nguyễn Văn A','Nam','2002/09/08',N'Tp Hồ chí Minh','0392728716','098918176527','VanA@gmail.com'),
	(N'Nguyễn Thi B','Nữ','2002/09/08',N'Tp Hồ chí Minh','0989827162','078671615141','ThiB@gmail.com'),
	(N'Trinh Thi Ngọc C','Nữ','2002/09/08',N'Tp Hồ chí Minh','0928172617','049728172612','NgocC@gmail.com'),
	(N'Pham Kim D','Nữ','2002/09/08',N'Tp Hồ chí Minh','0392817281','048928371827','KimD@gmail.com'),
	(N'Vo Trong E','Nam','2002/09/08',N'Tp Hồ chí Minh','0897261271','098678372612','BTrongE@gmail.com'),
	(N'Nguyễn Thi Ngoc F','Nữ','2002/09/08',N'Tp Hồ chí Minh','0177212917','046728171627','NgocF@gmail.com'),
	(N'Doan Chau G','Nữ','2002/09/08',N'Tp Hồ chí Minh','0967564251','097832787162','ChauG@gmail.com'),
	(N'Luong Thi H','Nữ','2002/09/08',N'Tp Hồ chí Minh','0392182716','012738928192','ThiH@gmail.com'),
	(N'Vo Minh I','Nam','2002/09/08',N'Tp Hồ chí Minh','0978675652','098786726716','MinhI@gmail.com'),
	(N'Tran Van J','Nam','2002/09/08',N'Tp Hồ chí Minh','0321829182','092827615423','VanJ@gmail.com'),
	(N'Ton Tan K','Nam','2002/09/08',N'Tp Hồ chí Minh','0182738291','012837928732','TanK@gmail.com'),
	(N'Nguyễn Thi Hong N','Nữ','2002/09/08',N'Tp Hồ chí Minh','0978627182','095627152123','BHongN@gmail.com')
	GO


CREATE TABLE ACCOUNT
(
	ACCID INT IDENTITY (1, 1) PRIMARY KEY,
	PHANQUYEN NVARCHAR(30),
	USERNAME CHAR(100) NOT NULL UNIQUE,
	PASS_WORD CHAR(100) NOT NULL,
	EMAIL CHAR(100) NOT NULL,
	NGANSACH INT NOT NULL,
	HOTEN NVARCHAR(100) NOT NULL,
	CMND CHAR(20) NOT NULL,
	GIOITINH NVARCHAR(20) NOT NULL,
	NGAYSINH DATE NOT NULL,
	SDT CHAR(20) NOT NULL,
	DIACHI NVARCHAR(4000) NOT NULL,
	TRINHDO NVARCHAR(4000) NULL,
	UUDIEM NVARCHAR(4000) NULL,
	AVARTAR IMAGE NULL
)
	
GO
CREATE TABLE GIAOVIEN (
	GVID INT IDENTITY (1, 1) PRIMARY KEY,
	ACCID INT FOREIGN KEY(ACCID) REFERENCES ACCOUNT(ACCID) NOT NULL UNIQUE,
	HOTEN NVARCHAR(100) NOT NULL,
	CMND CHAR(20) NOT NULL,
	GIOITINH NVARCHAR(20) NOT NULL,
	NGAYSINH DATE NOT NULL,
	SDT CHAR(20)NOT NULL,
	QUEQUAN NVARCHAR(500) NOT NULL,
	DIACHI NVARCHAR(4000) NOT NULL,
	TRUONGDAOTAO NVARCHAR(500) NOT NULL,
	TRINHDO NVARCHAR(4000) NOT NULL,
	EMAIL NVARCHAR(50) NOT NULL,
	UUDIEM NVARCHAR(4000),
	AVARTAR IMAGE,)

	--INSERT INTO GIAOVIEN(GVID , ACCID, HOTEN,CMND,GIOITINH,NGAYSINH,SDT,QUEQUAN,DIACHI,TRUONGDAOTAO,TRINHDO,UUDIEM,AVARTAR) VALUES ('1', '20', N'Nguyễn Văn A','2845623645','Nam','4/4/1988','0155555555',N'Đồng Tháp',N'Tp Hồ chí Minh',N'Đại học Sư phạm kỹ thuật TP HCM','Cử nhân','Chuyên môn cao','ninh.jpg')
	GO
	CREATE TABLE HOCSINH(
	HSID INT IDENTITY (1, 1) PRIMARY KEY,
	ACCID INT FOREIGN KEY(ACCID) REFERENCES ACCOUNT(ACCID) NOT NULL UNIQUE,
	HOTEN NVARCHAR(100) NOT NULL,
	GIOITINH NVARCHAR(20) NOT NULL,
	NGAYSINH DATE NOT NULL,
	DIACHI NVARCHAR(4000) NOT NULL,
	SDT CHAR(20) NOT NULL,
	CMND CHAR(20) NOT NULL,
	EMAIL char(100) not null,)

	
	SET IDENTITY_INSERT ACCOUNT ON
	INSERT INTO ACCOUNT(ACCID,PHANQUYEN,USERNAME,PASSWORD,EMAIL,NGANSACH) VALUES
	('1','ADMIN','ADMIN1','ADMIN1','admin1@gmail.com','0'),
	('2','ADMIN','ADMIN2','ADMIN2','admin2@gmail.com','0'),
	('3','GIAOVIEN','GIAOVIEN1','GIAOVIEN1','giaovien1@gmail.com','100'),
	('4','GIAOVIEN','GIAOVIEN2','GIAOVIEN2','giaovien2@gmail.com','200'),
	('5','HOCSINH','HOCSINH1','HOCSINH1','hocsinh1@gmail.com','350'),
	('6','HOCSINH','HOCSINH2','HOCSINH2','hocsinh2@gmail.com','350')
	SET IDENTITY_INSERT ACCOUNT OFF

	SET IDENTITY_INSERT GIAOVIEN ON
	INSERT INTO GIAOVIEN(GVID, ACCID, HOTEN,CMND,GIOITINH,NGAYSINH,SDT,QUEQUAN,DIACHI,TRUONGDAOTAO,TRINHDO,EMAIL,UUDIEM,AVARTAR) VALUES 
	('1', '3', N'Nguyễn Văn A','2845623645','Nam','4/4/1988','0155555555',N'Đồng Tháp',N'Tp Hồ chí Minh',N'Đại học Sư phạm kỹ thuật TP HCM','Cử nhân','AC@gmail.com','Chuyên môn cao','ninh.jpg'),
	('2', '2', N'Nguyễn Văn B','5555556664','Nam','9/4/1988','0155545555',N'Đồng Nai',N'Tp Hồ chí Minh',N'Đại học Sư phạm kỹ thuật TP HCM','Cử nhân','aw@gmail.com','Chuyên môn cao','ninh.jpg'),
	('3', '1', N'Nguyễn Thị C','2845313645','Nam','4/4/1988','0155555555',N'Đồng Tháp',N'Tp Hồ chí Minh',N'Đại học Sư phạm kỹ thuật TP HCM','Cử nhân','AC@gmail.com','Chuyên môn cao','ninh.jpg'),
	('4', '4', N'Nguyễn Văn D','2845623645','Nam','4/4/1988','0155555555',N'Đồng Tháp',N'Tp Hồ chí Minh',N'Đại học Sư phạm kỹ thuật TP HCM','Cử nhân','AC@gmail.com','Chuyên môn cao','ninh.jpg'),
	('5', '6', N'Nguyễn Văn E','2845623645','Nam','4/4/1988','0155555555',N'Đồng Tháp',N'Tp Hồ chí Minh',N'Đại học Sư phạm kỹ thuật TP HCM','Cử nhân','AC@gmail.com','Chuyên môn cao','ninh.jpg'),
	('6', '5', N'Nguyễn Văn F','2845623645','Nam','4/4/1988','0155555555',N'Đồng Tháp',N'Tp Hồ chí Minh',N'Đại học Sư phạm kỹ thuật TP HCM','Cử nhân','AC@gmail.com','Chuyên môn cao','ninh.jpg'),
	('7', '9', N'Nguyễn Văn A','2845623645','Nam','4/4/1988','0155555555',N'Đồng Tháp',N'Tp Hồ chí Minh',N'Đại học Sư phạm kỹ thuật TP HCM','Cử nhân','AC@gmail.com','Chuyên môn cao','ninh.jpg')

	SET IDENTITY_INSERT HOCSINH ON
	INSERT INTO HOCSINH(HSID, ACCID, HOTEN, GIOITINH, NGAYSINH, NGHENGHIEP, DIACHI, SDT, CMND, EMAIL) VALUES 
	('1', '3', N'Nguyễn Văn A','2845623645','Nam','4/4/1988','0155555555',N'Đồng Tháp',N'Tp Hồ chí Minh',N'Đại học Sư phạm kỹ thuật TP HCM','Cử nhân','AC@gmail.com','Chuyên môn cao','ninh.jpg'),
	('2', '2', N'Nguyễn Văn B','5555556664','Nam','9/4/1988','0155545555',N'Đồng Nai',N'Tp Hồ chí Minh',N'Đại học Sư phạm kỹ thuật TP HCM','Cử nhân','aw@gmail.com','Chuyên môn cao','ninh.jpg'),
	('3', '1', N'Nguyễn Thị C','2845313645','Nam','4/4/1988','0155555555',N'Đồng Tháp',N'Tp Hồ chí Minh',N'Đại học Sư phạm kỹ thuật TP HCM','Cử nhân','AC@gmail.com','Chuyên môn cao','ninh.jpg'),
	('4', '4', N'Nguyễn Văn D','2845623645','Nam','4/4/1988','0155555555',N'Đồng Tháp',N'Tp Hồ chí Minh',N'Đại học Sư phạm kỹ thuật TP HCM','Cử nhân','AC@gmail.com','Chuyên môn cao','ninh.jpg'),
	('5', '6', N'Nguyễn Văn E','2845623645','Nam','4/4/1988','0155555555',N'Đồng Tháp',N'Tp Hồ chí Minh',N'Đại học Sư phạm kỹ thuật TP HCM','Cử nhân','AC@gmail.com','Chuyên môn cao','ninh.jpg'),
	('6', '5', N'Nguyễn Văn F','2845623645','Nam','4/4/1988','0155555555',N'Đồng Tháp',N'Tp Hồ chí Minh',N'Đại học Sư phạm kỹ thuật TP HCM','Cử nhân','AC@gmail.com','Chuyên môn cao','ninh.jpg')
	GO
	GO


	CREATE TABLE LICHSUGIAODICH(
	GDID INT IDENTITY (1, 1) PRIMARY KEY,
	ACCID INT FOREIGN KEY(ACCID) REFERENCES ACCOUNT(ACCID) NOT NULL,
	LMID INT FOREIGN KEY(LMID) REFERENCES DANHSACHMOLOP(LMID) NOT NULL,
	SOTIEN INT NOT NULL,
	THOIGIANGIAODICH DATETIME,)
	GO

	CREATE TABLE DANHSACHMOLOP(
	LMID INT IDENTITY (1, 1) PRIMARY KEY,--LỚP MỚI ID 
	LHID INT REFERENCES LOPHOC(ID) NOT NULL,
	ACCID INT REFERENCES ACCOUNT(ACCID) NOT NULL,
	DIACHI NVARCHAR(500) NOT NULL,
	MUCLUONG INT NOT NULL,
	SDTLIENHE CHAR(20) NOT NULL,
	THOIGIANDANGKY DATETIME NOT NULL,
	SOBUOI INT NOT NULL,
	HINHTHUCDAY NVARCHAR(50) NOT NULL,
	THOIGIANHOC NVARCHAR(50) NOT NULL,
	THONGTINHOCVIEN NVARCHAR(500),
	YEUCAUGIAOVIEN NVARCHAR(500),
	TRANGTHAI NVARCHAR(50) NOT NULL,)

	GO
	CREATE TABLE LOPHOC
(
	ID INT IDENTITY (1, 1) PRIMARY KEY,
	TENLOP NVARCHAR(50) NOT NULL UNIQUE
)
	
	
	SELECT *FROM GIAOVIEN

	DROP DATABASE TRUNGTAMANHVAN;
GO
USE QLSV