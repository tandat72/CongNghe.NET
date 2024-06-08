create database QLTHUVIEN
go 
use QLTHUVIEN
go
create table SACH
(Masach varchar(5) not null primary key,
Tensach nvarchar(50),
Namxb int,
Nhaxb nvarchar(50))
go
create table SINHVIEN
(MaSV varchar(5) not null primary key,
Hoten nvarchar(50),
Ngaysinh datetime,
Gioitinh bit,
Diachi nvarchar(100))
go
create table MUONSACH
(MaSach varchar(5) not null references SACH(MaSach),
MaSV varchar(5) not null references SINHVIEN(MaSV),
Ngaymuon datetime not null,
Ngaytra datetime,
Quanlythuvien nvarchar(50), 
constraint  pk_Muonsach primary key (MaSach,MaSV ))
go
Insert into SACH values ('MS01',N'Tin học đại cương',2013,N'Đại học Bách Khoa Hà Nội')
Insert into SACH values ('MS02',N'Đại số tuyến tính',2010,N'Đại học Sư Phạm')
Insert into SACH values ('MS03',N'Quản lý nhân lực',2000,N'Đại học Kinh tế quốc dân')
Insert into SACH values ('MS04',N'Triết học',2000,N'Học viện chính trị quốc gia')
Insert into SACH values ('MS05',N'Nhập môn Tin học',2008,N'Học viện Bưu chính viễn thông')
Insert into SACH values ('MS06',N'Xác suất thống kê',2008,N'Đại học Kinh tế quốc dân')
Insert into SACH values ('MS07',N'Toán cao cấp',2008,N'Đại học Sư Phạm')
go
Insert into SINHVIEN values ('SV01',N'Phạm Quỳnh Như','12/12/1996',0,N'Văn Lâm - Hưng Yên')
Insert into SINHVIEN values ('SV02',N'Trần Tiến Đạt','2/11/1997',1,N'Hoàn Kiếm - Hà Nội')
Insert into SINHVIEN values ('SV03',N'Phan Trọng Nghĩa','2/4/1997',1,N'Ba Đình - Hà Nội')
Insert into SINHVIEN values ('SV04',N'Nguyễn Thị Nga','6/5/1997',0,N'Đống Đa - Hà Nội')
Insert into SINHVIEN values ('SV05',N'Nguyễn Thị Nụ','4/5/1995',0,N'Mỹ Hào - Hưng Yên')
Insert into SINHVIEN values ('SV06',N'Trương Thị Ngân','5/3/1996',0,N'Quỳnh Phụ - Thái Bình')
Insert into SINHVIEN values ('SV07',N'Phan Huy Tùng','11/2/1998',1,N'Gia Lâm - Hà Nội')
go
Insert into MUONSACH values ('MS01','SV02','12/12/2015','12/30/2015',N'Phạm Hồng Thái')
Insert into MUONSACH values ('MS03','SV02','11/12/2015','12/12/2015',N'Phạm Hồng Thái')
Insert into MUONSACH values ('MS01','SV01','11/12/2015','1/2/2016',N'Trương Quỳnh Anh')
Insert into MUONSACH values ('MS01','SV05','10/12/2015','12/12/2015',N'Phạm Hồng Thái')
Insert into MUONSACH values ('MS03','SV07','1/1/2016','3/2/2016',N'Trương Quỳnh Anh')
Insert into MUONSACH values ('MS04','SV07','12/12/2015','1/30/2016',N'Trương Quỳnh Anh')
Insert into MUONSACH values ('MS07','SV07','1/12/2015','3/2/2016',N'Trương Quỳnh Anh')
Insert into MUONSACH values ('MS01','SV03','2/2/2016','1/3/2016',N'Phạm Hữu Nghĩa')
Insert into MUONSACH values ('MS05','SV06','9/12/2015','12/12/2015',N'Phạm Hồng Thái')
Insert into MUONSACH values ('MS05','SV07','9/12/2015', null, N'Phạm Hồng Thái')
Insert into MUONSACH values ('MS04','SV02','9/12/2015', null ,N'Phạm Hồng Thái')
Insert into MUONSACH values ('MS07','SV06','9/12/2015', null ,N'Phạm Hồng Thái')



Select MaSach, TenSach, Namxb,Nhaxb From SACH where Tensach like N'%'

Select Hoten, Ngaymuon, Ngaytra,Quanlythuvien From MUONSACH M, SINHVIEN S where M.MaSV=S.maSV and Masach like N'MS04%'
Select MaSach, TenSach, Namxb,Nhaxb From SACH
Select * from SINHVIEN
Select * from MUONSACH
Select * FROM MUONSACH where  Ngaytra is null
Select Hoten, Ngaymuon, Ngaytra,Quanlythuvien From MUONSACH M, SINHVIEN S where M.MaSV=S.maSV and Ngaytra is null
Select Hoten, Ngaymuon, Ngaytra, Quanlythuvien From SINHVIEN S, MUONSACH V where S.MaSV = V.MaSV and Ngaytra is null 
Select Hoten, Ngaymuon, Ngaytra, Quanlythuvien From SINHVIEN S, MUONSACH V where S.MaSV = V.MaSV order by Ngaymuon desc
Update SACH set TenSach='Nguồn mở',Namxb='2025' ,Nhaxb='Đại đại tài' where Masach='MS01'
