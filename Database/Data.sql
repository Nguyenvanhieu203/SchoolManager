﻿CREATE DATABASE  QLth34
GO
USE  QLth34


------------------------------- Quản lí loại người dung -------------------------------------
CREATE TABLE LoaiNguoiDung
(
	MaLoai VARCHAR(6) NOT NULL PRIMARY KEY,
	TenLoai NVARCHAR(30) NOT NULL
)

INSERT INTO LOAINGUOIDUNG VALUES('LND001', N'Ban giám hiệu')
INSERT INTO LOAINGUOIDUNG VALUES('LND002', N'Giáo viên')
INSERT INTO LOAINGUOIDUNG VALUES('LND003', N'Nhân viên giáo vụ')

---------------Quản lí người dùng ------------------------------------------------------
CREATE TABLE NGUOIDUNG
(
	MaNguoiDung VARCHAR(6) NOT NULL PRIMARY KEY,
	MaLoai VARCHAR(6) NOT NULL,
	TenNguoiDung NVARCHAR(30) NOT NULL,
	TenDangNhap NVARCHAR(30) NOT NULL,
	MatKhau VARCHAR(64) NOT NULL,
	CONSTRAINT FK_NGUOIDUNG_LOAINGUOIDUNG FOREIGN KEY(MaLoai) REFERENCES LOAINGUOIDUNG(MaLoai)
)

--------------------Quản lí năm học -----------------------------------------------
CREATE TABLE NAMHOC
(
	MaNamhoc VARCHAR(6) NOT NULL PRIMARY KEY,
	TenNamHoc NVARCHAR(30) NOT NULL
)

INSERT INTO NAMHOC VALUES('NH1920', '2019-2020')
INSERT INTO NAMHOC VALUES('NH2021', '2020-2021')


-------------------------------Quản lí học kì ---------------------------------------------
CREATE TABLE HOCKY
(
	MaHocKy VARCHAR(3) NOT NULL PRIMARY KEY,
	TenHocKy NVARCHAR(30) NOT NULL,
	HeSo INT,
	CONSTRAINT CK_HOCKY CHECK(CAST(RIGHT(MaHocKy, 1) AS INT) BETWEEN 1 AND 3)
)

INSERT INTO HOCKY VALUES('HK1', N'Học Kỳ 1', 1)
INSERT INTO HOCKY VALUES('HK2', N'Học Kỳ 2', 2)
 
 -----------------------Quản lí khối lớp -------------------------------------
CREATE TABLE KHOILOP
(
	MaKhoiLop VARCHAR(6) NOT NULL PRIMARY KEY,
	TenKhoiLop NVARCHAR(30) NOT NULL
)

INSERT INTO KHOILOP VALUES('KHOI10', N'Khối 10')
INSERT INTO KHOILOP VALUES('KHOI11', N'Khối 11')
INSERT INTO KHOILOP VALUES('KHOI12', N'Khối 12')
--------------------------Quản lí môn học-----------------------------------
CREATE TABLE MONHOC(
	MaMonHoc VARCHAR(6) NOT NULL PRIMARY KEY,
	TenMonHoc NVARCHAR(30) NOT NULL,
	SoTiet INT NOT NULL,
	HeSo INT NOT NULL
)

insert into MonHoc(MaMonHoc,TenMonHoc,SoTiet,HeSo)values('MH001',N'Toán Học',2,1);
insert into MonHoc(MaMonHoc,TenMonHoc,SoTiet,HeSo)values('MH002',N'Văn Học',2,1);
insert into MonHoc(MaMonHoc,TenMonHoc,SoTiet,HeSo)values('MH003',N'Hóa Học',2,1);
insert into MonHoc(MaMonHoc,TenMonHoc,SoTiet,HeSo)values('MH004',N'Lý',2,1);
insert into MonHoc(MaMonHoc,TenMonHoc,SoTiet,HeSo)values('MH005',N'Tiếng ANh',2,1);
insert into MonHoc(MaMonHoc,TenMonHoc,SoTiet,HeSo)values('MH006',N'Tin Học',2,1);
insert into MonHoc(MaMonHoc,TenMonHoc,SoTiet,HeSo)values('MH007',N'Lịch sử',2,1);
insert into MonHoc(MaMonHoc,TenMonHoc,SoTiet,HeSo)values('MH008',N'Địa lý',2,1);
insert into MonHoc(MaMonHoc,TenMonHoc,SoTiet,HeSo)values('MH009',N'Giáo dục Công Dân',1,1);


---------------------------Quản lí học lực ------------------------------------
CREATE TABLE HOCLUC
(
	MaHocLuc VARCHAR(6) NOT NULL PRIMARY KEY,
	TenHocLuc NVARCHAR(30) NOT NULL,
	DiemCanDuoi FLOAT NOT NULL,
	DiemCanTren FLOAT NOT NULL,
	DiemKhongChe FLOAT NOT NULL,

	CONSTRAINT CK_DiemCanDuoi CHECK(DiemCanDuoi BETWEEN 0 AND 10),
	CONSTRAINT CK_DiemCanTren CHECK(DiemCanTren BETWEEN 0 AND 10),
	CONSTRAINT CK_DiemKhongChe CHECK(DiemKhongChe BETWEEN 0 AND 10),
)

INSERT INTO HOCLUC VALUES('HL0001', N'Giỏi', 8.0, 10.0, 6.5)
INSERT INTO HOCLUC VALUES('HL0002', N'Khá', 6.5, 7.9, 5.0)
INSERT INTO HOCLUC VALUES('HL0003', N'Trung bình', 5.0, 6.4, 3.5)
INSERT INTO HOCLUC VALUES('HL0004', N'Yếu', 3.5, 4.9, 2.0)
INSERT INTO HOCLUC VALUES('HL0005', N'Kém', 0.0, 3.4, 0.0)



----------------------Quản lí hạnh kiểm --------------------------------------
CREATE TABLE HANHKIEM
(
	MaHanhKiem VARCHAR(6) NOT NULL PRIMARY KEY,
	TenHanhKiem NVARCHAR(30) NOT NULL
)

INSERT INTO HANHKIEM VALUES('HK0001', N'Tốt')
INSERT INTO HANHKIEM VALUES('HK0002', N'Khá')
INSERT INTO HANHKIEM VALUES('HK0003', N'Trung bình')
INSERT INTO HANHKIEM VALUES('HK0004', N'Yếu')

----------------------Quản lí việc lên lớp -----------------------------------
CREATE TABLE KETQUA
(
	MaKetQua VARCHAR(6) NOT NULL PRIMARY KEY,
	TenKetQua NVARCHAR(30) NOT NULL
)

INSERT INTO KETQUA VALUES('KQ0001', N'Lên lớp')
INSERT INTO KETQUA VALUES('KQ0002', N'Thi lại')
INSERT INTO KETQUA VALUES('KQ0003', N'Rèn luyện hè')
INSERT INTO KETQUA VALUES('KQ0004', N'Ở lại')



--------------------------Quản lí giáo viên-----------------------------------
CREATE TABLE GIAOVIEN
(
	MaGiaoVien VARCHAR(6) NOT NULL PRIMARY KEY,
	TenGiaoVien NVARCHAR(30) NOT NULL,
	DiaChi NVARCHAR(50) NOT NULL,
	DienThoai NVARCHAR(15) NOT NULL,
	MaMonHoc VARCHAR(6) NOT NULL,
	CONSTRAINT FK_GIAOVIEN_MONHOC FOREIGN KEY(MaMonHoc) REFERENCES MONHOC(MaMonHoc)
)

INSERT INTO GIAOVIEN VALUES('GV0001', N'Nguyễn Hoàng Trung', N'100 Trần Hưng Đạo, Long Xuyên', '0975058876','MH001')
INSERT INTO GIAOVIEN VALUES('GV0002', N'Phan Hồng Nhung', N'Lac Quoi - Tri Ton', '0976630315','MH002')
INSERT INTO GIAOVIEN VALUES('GV0003', N'Huỳnh Thanh Trúc', N'10C Nguyễn Trung Trực, Châu Đốc', '0699015456','MH003')
INSERT INTO GIAOVIEN VALUES('GV0004', N'Lam Trung Toan', N'Long Dien B, An Phú', '0845241566','MH004')
INSERT INTO GIAOVIEN VALUES('GV0005', N'Huynh Túc Trí', N'Rạch Giá, Kiên Giang', '0123456789','MH005')
INSERT INTO GIAOVIEN VALUES('GV0006', N'Lê Thi Minh Nguyệt', N'000 Long Xuyên, An Giang', '0123456789','MH006')

-----------------------------------------Quản lí nghề nghiệp ---------------------------------------
CREATE TABLE NGHENGHIEP
(
	MaNghe VARCHAR(6) NOT NULL PRIMARY KEY,
	TenNghe NVARCHAR(30) NOT NULL
)

INSERT INTO NGHENGHIEP VALUES('NN0001', N'Nội trợ')
INSERT INTO NGHENGHIEP VALUES('NN0002', N'Giáo viên')
INSERT INTO NGHENGHIEP VALUES('NN0003', N'Công nhân')
INSERT INTO NGHENGHIEP VALUES('NN0004', N'Làm ruộng')
INSERT INTO NGHENGHIEP VALUES('NN0005', N'Buôn bán')
------------------------------------------Quản lí học sinh ------------------------------------------
CREATE TABLE HOCSINH
(
	MaHocSinh VARCHAR(6) NOT NULL PRIMARY KEY,
	HoTen NVARCHAR(30) NOT NULL,
	GioiTinh NVARCHAR(10),
	NgaySinh DATETIME,
	DiaChi NVARCHAR(50) NOT NULL,
	HoTenCha NVARCHAR(30) NOT NULL,
	MaNgheCha VARCHAR(6) NOT NULL,
	SdtCha VARCHAR(20) NOT NULL,
	HoTenMe NVARCHAR(30) NOT NULL,
	MaNgheMe VARCHAR(6) NOT NULL,
	SdtMe VARCHAR(20) NOT NULL,
	Email NVARCHAR(50) NOT NULL UNIQUE,
 
	CONSTRAINT FK_HOCSINH_NGHENGHIEPCHA FOREIGN KEY(MaNgheCha) REFERENCES NGHENGHIEP(MaNghe),
	CONSTRAINT FK_HOCSINH_NGHENGHIEPME FOREIGN KEY(MaNgheMe) REFERENCES NGHENGHIEP(MaNghe)
)

INSERT INTO HOCSINH VALUES('HS0001', N'Nguyễn Văn Tú', N'nam', '01/02/2005', N'Long Xuyên',  N'Thêm vào','NN0005','0323445678', N'Thêm vào', 'NN0002','034561245679', 'hs001@gmail.com')
INSERT INTO HOCSINH VALUES('HS0002', N'Nguyễn Ngọc An', N'nam', '01/02/2005', N'Bến Tre',  N'Thêm vào','NN0003','09781245671', N'Thêm vào', 'NN0001','096535672', 'hs002@gmail.com')
INSERT INTO HOCSINH VALUES('HS0003', N'Lê Hoàng Anh', N'nam', '04/15/2005', N'Chợ Mới', N'Thêm vào','NN0005','08264245673',  N'Thêm vào', 'NN0005','0244555674', 'hs003@gmail.com')
INSERT INTO HOCSINH VALUES('HS0004', N'Huỳnh Thiên Chí', N'nam', '01/02/2004', N'Đồng Tháp',  N'Thêm vào','NN0002','04561345675',  N'Thêm vào', 'NN0004','05551245676', 'hs004@gmail.com')
INSERT INTO HOCSINH VALUES('HS0005', N'Lý Ngọc Duy', N'nam', '01/02/2005', N'Long Xuyên',  N'Thêm vào','NN0005','0742145677',  N'Thêm vào', 'NN0002','01231245612', 'hs005@gmail.com')
INSERT INTO HOCSINH VALUES('HS0006', N'Huỳnh Ngọc Điệp', N'nữ', '01/02/2005', N'Bến Tre', N'Thêm vào','NN0003','0324245613',  N'Thêm vào', 'NN0001','078961245614', 'hs006@gmail.com')
INSERT INTO HOCSINH VALUES('HS0007', N'Trần Thị Huệ', N'nữ', '04/15/2005', N'Chợ Mới', N'Thêm vào','NN0005','01254245615',  N'Thêm vào', 'NN0005','0945645616', 'hs007@gmail.com')
INSERT INTO HOCSINH VALUES('HS0008', N'Nguyễn Thanh Huy', N'nam', '01/02/2004', N'Đồng Tháp',  N'Thêm vào','NN0002','04125245617',  N'Thêm vào', 'NN0004', '08962245618','hs008@gmail.com')
INSERT INTO HOCSINH VALUES('HS0009', N'Trần Phước Lập', N'nam', '01/02/2005', N'Long Xuyên',  N'Thêm vào','NN0005','0789245620',  N'Thêm vào', 'NN0002','0789545619', 'hs009@gmail.com')
INSERT INTO HOCSINH VALUES('HS0010', N'Trương Thị Nga', N'nữ', '01/02/2005', N'Bến Tre',  N'Thêm vào','NN0003','07854245621',  N'Thêm vào', 'NN0001','09452145622', 'hs010@gmail.com')
INSERT INTO HOCSINH VALUES('HS0011', N'Nguyễn Thị Nga', N'nữ', '04/15/2005', N'Chợ Mới',  N'Thêm vào','NN0005','0387545623',  N'Thêm vào', 'NN0005','09789545625', 'hs011@gmail.com')


------------------------------------------Quản lí lop ------------------------------------------

CREATE TABLE LOP
(
	MaLop VARCHAR(20) NOT NULL PRIMARY KEY,
	TenLop NVARCHAR(30) NOT NULL,
	MaKhoiLop VARCHAR(6) NOT NULL,
	MaNamHoc VARCHAR(6) NOT NULL,
	SiSo INT NOT NULL,
	MaGiaoVien VARCHAR(6) NOT NULL,
 
	CONSTRAINT FK_LOP_KHOILOP FOREIGN KEY(MaKhoiLop) REFERENCES KHOILOP(MaKhoiLop),
	CONSTRAINT FK_LOP_NAMHOC FOREIGN KEY(MaNamHoc) REFERENCES NAMHOC(MaNamHoc),
	CONSTRAINT FK_LOP_GIAOVIEN FOREIGN KEY(MaGiaoVien) REFERENCES GIAOVIEN(MaGiaoVien)
)

INSERT INTO LOP VALUES('LOP10A11920', '10A1', 'KHOI10', 'NH1920', 35, 'GV0006')
INSERT INTO LOP VALUES('LOP10A21920', '10A2', 'KHOI10', 'NH1920', 36, 'GV0005')
INSERT INTO LOP VALUES('LOP10A31920', '10A3', 'KHOI10', 'NH1920', 34, 'GV0004')
INSERT INTO LOP VALUES('LOP11A11920', '11A1', 'KHOI11', 'NH1920', 37, 'GV0003')
INSERT INTO LOP VALUES('LOP11A21920', '11A2', 'KHOI11', 'NH1920', 38, 'GV0002')
INSERT INTO LOP VALUES('LOP12A11920', '12A1', 'KHOI12', 'NH1920', 39, 'GV0001')

INSERT INTO LOP VALUES('LOP10A42021', '10A4', 'KHOI10', 'NH2021', 39, 'GV0001')
INSERT INTO LOP VALUES('LOP11A32021', '11A3', 'KHOI11', 'NH2021', 38, 'GV0002')
INSERT INTO LOP VALUES('LOP11A42021', '11A4', 'KHOI11', 'NH2021', 35, 'GV0003')
INSERT INTO LOP VALUES('LOP12A22021', '12A2', 'KHOI12', 'NH2021', 40, 'GV0004')
INSERT INTO LOP VALUES('LOP12A32021', '11A3', 'KHOI12', 'NH2021', 38, 'GV0005')
INSERT INTO LOP VALUES('LOP12A42021', '12A4', 'KHOI12', 'NH2021', 38, 'GV0006')


---------------------------------Quản li lớp học -------------------------------------
CREATE TABLE PHANLOP
(
	MaNamHoc VARCHAR(6) NOT NULL,
	MaKhoiLop VARCHAR(6) NOT NULL,
	MaLop VARCHAR(20) NOT NULL,
	MaHocSinh VARCHAR(6) NOT NULL,
	PRIMARY KEY(MaNamHoc, MaKhoiLop, MaLop, MaHocSinh),

	CONSTRAINT FK_PHANLOP_NAMHOC FOREIGN KEY(MaNamHoc) REFERENCES NAMHOC(MaNamHoc),
	CONSTRAINT FK_PHANLOP_KHOI FOREIGN KEY(MaKhoiLop) REFERENCES KHOILOP(MaKhoiLop),
	CONSTRAINT FK_PHANLOP_LOP FOREIGN KEY(MaLop) REFERENCES LOP(MaLop),
	CONSTRAINT FK_PHANLOP_HOCSINH FOREIGN KEY(MaHocSinh) REFERENCES HOCSINH(MaHocSinh)
)

INSERT INTO PHANLOP VALUES('NH1920', 'KHOI10', 'LOP10A11920', 'HS0001')
INSERT INTO PHANLOP VALUES('NH1920', 'KHOI10', 'LOP10A21920', 'HS0002')
INSERT INTO PHANLOP VALUES('NH1920', 'KHOI10', 'LOP10A31920', 'HS0003')

INSERT INTO PHANLOP VALUES('NH1920', 'KHOI11', 'LOP11A11920', 'HS0004')
INSERT INTO PHANLOP VALUES('NH1920', 'KHOI11', 'LOP11A21920', 'HS0005')
INSERT INTO PHANLOP VALUES('NH1920', 'KHOI11', 'LOP11A32021', 'HS0006')
INSERT INTO PHANLOP VALUES('NH1920', 'KHOI11', 'LOP11A42021', 'HS0007')

INSERT INTO PHANLOP VALUES('NH1920', 'KHOI12', 'LOP12A11920', 'HS0008')
INSERT INTO PHANLOP VALUES('NH1920', 'KHOI12', 'LOP12A22021', 'HS0009')
INSERT INTO PHANLOP VALUES('NH1920', 'KHOI12', 'LOP12A32021', 'HS0010')
INSERT INTO PHANLOP VALUES('NH1920', 'KHOI12', 'LOP12A42021', 'HS0011')

---------------------------------Quản li phân công giáo viên  -------------------------------------

CREATE TABLE PHANCONG
(
	STT INT IDENTITY PRIMARY KEY,
	MaNamHoc VARCHAR(6) NOT NULL,
	MaLop VARCHAR(20) NOT NULL,
	MaMonHoc VARCHAR(6) NOT NULL,
	MaGiaoVien VARCHAR(6) NOT NULL,
 
	CONSTRAINT FK_PHANCONG_NAMHOC FOREIGN KEY(MaNamHoc) REFERENCES NAMHOC(MaNamHoc),
	CONSTRAINT FK_PHANCONG_LOP FOREIGN KEY(MaLop) REFERENCES LOP(MaLop),
	CONSTRAINT FK_PHANCONG_MONHOC FOREIGN KEY(MaMonHoc) REFERENCES MONHOC(MaMonHoc),
	CONSTRAINT FK_PHANCONG_GIAOVIEN FOREIGN KEY(MaGiaoVien) REFERENCES GIAOVIEN(MaGiaoVien)
)

INSERT INTO PHANCONG VALUES('NH1920', 'LOP10A11920', 'MH001', 'GV0001')
INSERT INTO PHANCONG VALUES('NH1920', 'LOP10A21920', 'MH002', 'GV0002')
INSERT INTO PHANCONG VALUES('NH1920', 'LOP10A31920', 'MH003', 'GV0003')
INSERT INTO PHANCONG VALUES('NH1920', 'LOP10A42021', 'MH004', 'GV0004')

INSERT INTO PHANCONG VALUES('NH1920', 'LOP11A11920', 'MH001', 'GV0001')
INSERT INTO PHANCONG VALUES('NH1920', 'LOP11A21920', 'MH002', 'GV0002')
INSERT INTO PHANCONG VALUES('NH1920', 'LOP11A32021', 'MH003', 'GV0003')
INSERT INTO PHANCONG VALUES('NH1920', 'LOP11A42021', 'MH004', 'GV0004')

INSERT INTO PHANCONG VALUES('NH1920', 'LOP12A11920', 'MH001', 'GV0001')
INSERT INTO PHANCONG VALUES('NH1920', 'LOP12A22021', 'MH002', 'GV0002')
INSERT INTO PHANCONG VALUES('NH1920', 'LOP12A32021', 'MH003', 'GV0003')
INSERT INTO PHANCONG VALUES('NH1920', 'LOP12A42021', 'MH004', 'GV0004')


--------------------------------------Quản lí loại điểm --------------------------------------

CREATE TABLE LOAIDIEM
(
	MaLoai VARCHAR(6) NOT NULL PRIMARY KEY,
	TenLoai NVARCHAR(30) NOT NULL,
	HeSo INT NOT NULL
)

INSERT INTO LOAIDIEM VALUES('LD0001', N'Kiểm tra miệng', 1)
INSERT INTO LOAIDIEM VALUES('LD0002', N'Kiểm tra 15 phút', 1)
INSERT INTO LOAIDIEM VALUES('LD0003', N'Kiểm tra 1 tiết', 2)
INSERT INTO LOAIDIEM VALUES('LD0004', N'Thi học kỳ', 3)


-------------------------------------------Quản lí điểm -------------------------------------------

CREATE TABLE DIEM
(
	STT INT IDENTITY PRIMARY KEY,
	MaHocSinh VARCHAR(6) NOT NULL,
	MaMonHoc VARCHAR(6) NOT NULL,
	MaHocKy VARCHAR(3) NOT NULL,
	MaNamHoc VARCHAR(6) NOT NULL,
	MaLop VARCHAR(20) NOT NULL,
	MaLoai VARCHAR(6) NOT NULL,
	Diem FLOAT NOT NULL,
 
	CONSTRAINT FK_DIEM_HOCSINH FOREIGN KEY(MaHocSinh) REFERENCES HOCSINH(MaHocSinh),
	CONSTRAINT FK_DIEM_MONHOC FOREIGN KEY(MaMonHoc) REFERENCES MONHOC(MaMonHoc),
	CONSTRAINT FK_DIEM_HOCKY FOREIGN KEY(MaHocKy) REFERENCES HOCKY(MaHocKy),
	CONSTRAINT FK_DIEM_NAMHOC FOREIGN KEY(MaNamHoc) REFERENCES NAMHOC(MaNamHoc),
	CONSTRAINT FK_DIEM_LOP FOREIGN KEY(MaLop) REFERENCES LOP(MaLop),
	CONSTRAINT FK_DIEM_LOAIDIEM FOREIGN KEY(MaLoai) REFERENCES LOAIDIEM(MaLoai),
	CONSTRAINT CK_DIEM CHECK(Diem BETWEEN 0 AND 10)
)

INSERT INTO DIEM VALUES('HS0001','MH001','HK1','NH1920','LOP10A11920','LD0004',9)
INSERT INTO DIEM VALUES('HS0002','MH001','HK1','NH1920','LOP10A21920','LD0004',8)
INSERT INTO DIEM VALUES('HS0003','MH001','HK1','NH1920','LOP10A31920','LD0004',8)
INSERT INTO DIEM VALUES('HS0004','MH001','HK1','NH1920','LOP11A11920','LD0004',9)

-----------------------------------------Quản lí kết quả môn học ------------------------------------------

CREATE TABLE KQ_HOCSINH_MONHOC
(
	MaHocSinh VARCHAR(6) NOT NULL,
	MaLop VARCHAR(20) NOT NULL,
	MaNamHoc VARCHAR(6) NOT NULL,
	MaMonHoc VARCHAR(6) NOT NULL,
	MaHocKy VARCHAR(3) NOT NULL,
	DiemMiengTB FLOAT NOT NULL,
	Diem15PhutTB FLOAT NOT NULL,
	Diem45PhutTB FLOAT NOT NULL,
	DiemThi FLOAT NOT NULL,
	DiemTBHK FLOAT NOT NULL,
	PRIMARY KEY(MaHocSinh, MaLop, MaNamHoc, MaMonHoc, MaHocKy),

	CONSTRAINT FK_KQHSMH_HOCSINH FOREIGN KEY(MaHocSinh) REFERENCES HOCSINH(MaHocSinh),
	CONSTRAINT FK_KQHSMH_LOP FOREIGN KEY(MaLop) REFERENCES LOP(MaLop),
	CONSTRAINT FK_KQHSMH_NAMHOC FOREIGN KEY(MaNamHoc) REFERENCES NAMHOC(MaNamHoc),
	CONSTRAINT FK_KQHSMH_MONHOC FOREIGN KEY(MaMonHoc) REFERENCES MONHOC(MaMonHoc),
	CONSTRAINT FK_KQHSMH_HOCKY FOREIGN KEY(MaHocKy) REFERENCES HOCKY(MaHocKy),

	CONSTRAINT CK_DiemMiengTB CHECK(DiemMiengTB BETWEEN 0 AND 10),
	CONSTRAINT CK_Diem15PhutTB CHECK(Diem15PhutTB BETWEEN 0 AND 10),
	CONSTRAINT CK_Diem45PhutTB CHECK(Diem45PhutTB BETWEEN 0 AND 10),
	CONSTRAINT CK_DiemThi CHECK(DiemThi BETWEEN 0 AND 10),
	CONSTRAINT CK_DiemTBHK CHECK(DiemTBHK BETWEEN 0 AND 10),
)

-----------------------------------------Quản lí kết quả môn học cả năm  ------------------------------------------

CREATE TABLE KQ_HOCSINH_CANAM
(
	MaHocSinh VARCHAR(6) NOT NULL,
	MaLop VARCHAR(20) NOT NULL,
	MaNamHoc VARCHAR(6) NOT NULL,
	MaHocLuc VARCHAR(6) NOT NULL,
	MaHanhKiem VARCHAR(6) NOT NULL,
	MaKetQua VARCHAR(6) NOT NULL,
	DiemTBHK1 FLOAT NOT NULL,
	DiemTBHK2 FLOAT NOT NULL,
	DiemTBCN FLOAT NOT NULL, 
	PRIMARY KEY(MaHocSinh, MaLop, MaNamHoc),
 
	CONSTRAINT FK_KQHSCN_HOCSINH FOREIGN KEY(MaHocSinh) REFERENCES HOCSINH(MaHocSinh),
	CONSTRAINT FK_KQHSCN_LOP FOREIGN KEY(MaLop) REFERENCES LOP(MaLop),
	CONSTRAINT FK_KQHSCN_NAMHOC FOREIGN KEY(MaNamHoc) REFERENCES NAMHOC(MaNamHoc),
	CONSTRAINT FK_KQHSCN_HOCLUC FOREIGN KEY(MaHocLuc) REFERENCES HOCLUC(MaHocLuc),
	CONSTRAINT FK_KQHSCN_HANHKIEM FOREIGN KEY(MaHanhKiem) REFERENCES HANHKIEM(MaHanhKiem),
	CONSTRAINT FK_KQHSCN_KETQUA FOREIGN KEY(MaKetQua) REFERENCES KETQUA(MaKetQua),

	CONSTRAINT CK_DiemTBHK1 CHECK(DiemTBHK1 BETWEEN 0 AND 10),
	CONSTRAINT CK_DiemTBHK2 CHECK(DiemTBHK2 BETWEEN 0 AND 10),
	CONSTRAINT CK_DiemTBCN CHECK(DiemTBCN BETWEEN 0 AND 10),
)

------------------------------------------Kết quả theo lớp học -------------------------------------------------------
CREATE TABLE KQ_LOPHOC_MONHOC
(
	MaLop VARCHAR(20) NOT NULL,
	MaNamHoc VARCHAR(6) NOT NULL,
	MaMonHoc VARCHAR(6) NOT NULL,
	MaHocKy VARCHAR(3) NOT NULL,
	SoLuongDat INT NOT NULL,
	TiLe FLOAT NOT NULL,
	PRIMARY KEY(MaLop, MaNamHoc, MaMonHoc, MaHocKy),

	CONSTRAINT FK_KQLHMH_LOP FOREIGN KEY(MaLop) REFERENCES LOP(MaLop),
	CONSTRAINT FK_KQLHMH_NAMHOC FOREIGN KEY(MaNamHoc) REFERENCES NAMHOC(MaNamHoc),
	CONSTRAINT FK_KQLHMH_MONHOC FOREIGN KEY(MaMonHoc) REFERENCES MONHOC(MaMonHoc),
	CONSTRAINT FK_KQLHMH_HOCKY FOREIGN KEY(MaHocKy) REFERENCES HOCKY(MaHocKy),
)

----------------------------------------Kết quả lớp học theo học kì ----------------------------------------------------------

CREATE TABLE KQ_LOPHOC_HOCKY
(
	MaLop VARCHAR(20) NOT NULL,
	MaNamHoc VARCHAR(6) NOT NULL,
	MaHocKy VARCHAR(3) NOT NULL,
	SoLuongDat INT NOT NULL,
	TiLe FLOAT NOT NULL,
	PRIMARY KEY(MaLop, MaNamHoc, MaHocKy),

	CONSTRAINT FK_KQLHHK_LOP FOREIGN KEY(MaLop) REFERENCES LOP(MaLop),
	CONSTRAINT FK_KQLHHK_NAMHOC FOREIGN KEY(MaNamHoc) REFERENCES NAMHOC(MaNamHoc),
	CONSTRAINT FK_KQLHHK_HOCKY FOREIGN KEY(MaHocKy) REFERENCES HOCKY(MaHocKy),
)

select *from GIAOVIEN
select *from HOCSINH
select *from LOP
select *from PHANCONG
Select * from DIEM 
