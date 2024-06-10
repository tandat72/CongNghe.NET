create database THIHK
go
use THIHK
go 
create table PHONG
(MaPhong int identity (1,1) not null primary key,
 Huongbien bit,
 Hinh varchar(50),
 Dongia float,
 Songuoi int)
 go
 create table CHITIET
 (SOHD int Identity (1,1) primary key,
  MaPhong int references PHONG (MaPhong),
  Hoten nvarchar(50),
  CMND varchar(10),
  Ngaynhan datetime,
  Ngaytra datetime)
  go
  Insert into Phong (Huongbien, Hinh, Dongia, Songuoi) values (0,'H01.jpg',1200,2)
  Insert into Phong (Huongbien, Hinh, Dongia, Songuoi) values (1,'H02.jpg',1000,2)
  Insert into Phong (Huongbien, Hinh, Dongia, Songuoi) values (0,'H03.jpg',900,2)
go
Insert into CHITIET(MaPhong, Hoten, CMND, Ngaynhan, Ngaytra) values (1,N'Lý Thiên Trang','311234234','7/14/2020','7/16/2020')