-- TAO CO SO DU LIEU------------------------------------------------
create database QuanLyQuanCaPhe
go
use QuanLyQuanCaPhe
go


--TAO BANG-------------------------------------------------------------


-- 1.KHACHHANG(maKH,tenKH,diaChi,SDT, maPhieuYeucau,hinhAnh)
CREATE TABLE KhachHang(
	maKH			CHAR(10) NOT NULL ,
	tenKH			NVARCHAR(30) NULL,
	diaChi			NVARCHAR(50) NULL,
	SDT			CHAR(15) NULL,
	hinhAnh			VARCHAR(max) NULL 
)

-- 2.NHANVIEN(maNV,tenNV,diaChi,SDT,chucVu,hinhAnh, maPhieuNhap, maPhieuThanhToan)
CREATE TABLE NhanVien(
	maNV				CHAR(10) NOT NULL,
	tenNV				NVARCHAR(30) NOT NULL,
	diaChi				NVARCHAR(50) NULL,
	SDT				CHAR(15) NULL,
	chucVu				NVARCHAR(30) NULL,
	hinhAnh				VARCHAR(max) NULL
)
-- 3.BANAN(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
CREATE TABLE BanAn(
	maBan		CHAR(10) NOT NULL,
	loaiBan		NVARCHAR(10) NULL,
	tinhTrang	NVARCHAR(10) NULL,
	donGiaBan   	INT NULL,
	hinhAnh		VARCHAR(max) NULL
)
-- 4.MONAN(maMon,tenMon,donGiaMon,donViTinh,maNhom,hinhAnh)
CREATE TABLE MonAn(
	maMon		CHAR(10) NOT NULL,
	tenMon		NVARCHAR(30) NOT NULL,
	donGiaMon	INT NOT NULL,
	donViTinh	NVARCHAR(10) NULL,
	maNhom		CHAR(10) NOT NULL,
	hinhAnh		VARCHAR(max) NULL
)
-- 5.NHOMMONAN(tenNhom,maNhom)
CREATE TABLE NhomMonAn(
	maNhom	CHAR(10) NOT NULL,
	tenNhom	NVARCHAR(30) NOT NULL UNIQUE 
)

-- 6.THUCPHAM(maThucPham,tenThucPham,donViTinh,hinhAnh,NSX,HSD,maNCC)
CREATE TABLE ThucPham(
	maThucPham	CHAR(10) NOT NULL,
	tenThucPham	NVARCHAR(30) NOT NULL,
	donViTinh	NVARCHAR(10) NULL,
	NSX			DATE NULL,
	HSD			DATE NULL,
	maNCC		CHAR(10) NOT NULL
)
-- 7.NHACUNGCAP(maNCC,tenNCC,diaChi,sdt,hinhAnh)
CREATE TABLE NhaCungCap(
	maNCC			CHAR(10) NOT NULL,
	tenNCC			NVARCHAR(30) NOT NULL,
	diaChi			NVARCHAR(50) NULL,
	SDT			CHAR(15) NULL,
	hinhAnh			VARCHAR(max) NULL
)
--8.PHIEUNHAP(maPhieuNhap, ngayNhap,maNV,maNCC)
CREATE TABLE PhieuNhap(
	maPhieuNhap		INT NOT NULL,
	maNCC			CHAR(10) NOT NULL,
	ngayNhap		DATE NULL,
	maNV			CHAR(10) NOT NULL
)
-- 9.PHIEUNHAPCHITIET(maPhieuNhap_CT,soLuong, maThucPham, donGiaNhap)
CREATE TABLE PhieuNhapChiTiet(
	maPhieuNhap_CT		INT NOT NULL,
	soLuong			INT NOT NULL,
	maThucPham		CHAR(10) NOT NULL,
	donGiaNhap		INT NOT NULL,
)
-- 10.PHIEUYEUCAU(maPhieuYeucau, ngayYeuCau,maKH,maNV)
CREATE TABLE PhieuYeuCau(
	maPhieuYeuCau		INT  NOT NULL,
	maKH			CHAR(10) NOT NULL,
	maNV			CHAR(10) NOT NULL,
	ngayYeuCau		DATE NULL,
)
-- 11.PHIEUTHANHTOAN(maPhieuYeucau, maMon,tenMon, donGiaMon,maBan, ,donGiaBan,soLuong,ngayThanhToan,ThanhTien)
CREATE TABLE PhieuThanhToan(
	maPhieuYeuCau			INT  NOT NULL,
	maMon				CHAR(10) NOT NULL,
	soLuongMon			INT NOT NULL,
	maBan				CHAR(10) NOT NULL
)
-- 12.Account (UserID, username , password )
CREATE TABLE Account(
	UserID INT NOT NULL,
	username CHAR(20) NOT NULL,
	password CHAR(20) NOT NULL,
	role	 INT NOT NULL
)


-- KHOA CHINH (PRIMARY KEY)-------------------------------------------------------------------------------------------------

-- 1.KHACHHANG
ALTER TABLE KhachHang
ADD CONSTRAINT PK_KhachHang PRIMARY KEY (maKH);

--2.NHANVIEN
ALTER TABLE NhanVien
ADD CONSTRAINT PK_NhanVien PRIMARY KEY (maNV);
--3.BANAN
ALTER TABLE BanAn
ADD CONSTRAINT PK_BanAn PRIMARY KEY (maBan);
--4.MONAN
ALTER TABLE MonAn
ADD CONSTRAINT PK_MonAn PRIMARY KEY (maMon);
--5.NHOMMONAN
ALTER TABLE NhomMonAn
ADD CONSTRAINT PK_NhomMonAn PRIMARY KEY (maNhom);
--6.THUCPHAM
ALTER TABLE ThucPham
ADD CONSTRAINT PK_ThucPham PRIMARY KEY (maThucPham);
--7.NHACUNGCAP
ALTER TABLE NhaCungCap
ADD CONSTRAINT PK_NhaCungCap PRIMARY KEY (maNCC);
--8.PHIEUNHAP
ALTER TABLE PhieuNhap
ADD CONSTRAINT PK_PhieuNhap PRIMARY KEY (maPhieuNhap);
--9.PHIEUNHAPCHITIET
ALTER TABLE PhieuNhapChiTiet
ADD CONSTRAINT PK_PhieuNhapChiTiet PRIMARY KEY (maPhieuNhap_CT,maThucPham);
--10.PHIEUYEUCAU
ALTER TABLE PhieuYeuCau
ADD CONSTRAINT PK_PhieuYeuCau PRIMARY KEY (maPhieuYeuCau);
--11.PHIEUTHANHTOAN
ALTER TABLE PhieuThanhToan
ADD CONSTRAINT PK_PhieuThanhToan PRIMARY KEY (maPhieuYeuCau,maMon,maBan);
--12.Account
ALTER TABLE Account
ADD CONSTRAINT PK_Account PRIMARY KEY (UserID);


-- KHOA NGOAI (FOREIGN KEY)---------------------------------------------------------------------------------------------------

-- 1.MONAN -> NHOMMONAN
alter table MonAn
add constraint FK_MonAn_NhomMonAn
foreign key (maNhom)
references NhomMonAn(maNhom)

-- 2.PHIEUTHANHTOAN -> PHIEUYEUCAU
alter table PhieuThanhToan
add constraint FK_PhieuThanhToan_PhieuYeuCau
foreign key (maPhieuYeuCau)
references PhieuYeuCau(maPhieuYeuCau)

-- 3.PHIEUTHANHTOAN-> MONAN
alter table PhieuThanhToan
add constraint FK_PhieuThanhToan_MonAn
foreign key (maMon)
references MonAn(maMon)

-- 4.PHIEUTHANHTOAN-> BANAN
alter table PhieuThanhToan
add constraint FK_PhieuThanhToan_BanAn
foreign key (maBan)
references BanAn(maBan)

-- 5.PHIEUYEUCAU-> NHANVIEN
alter table PhieuYeuCau
add constraint FK_PhieuYeuCau_NhanVien
foreign key (maNV)
references NhanVien(maNV)

-- 6.PHIEUYEUCAU-> KHACHHANG
alter table PhieuYeuCau
add constraint FK_PhieuYeuCau_KhachHang
foreign key (maKH)
references KhachHang(maKH)

-- 7.PHIEUNHAP-> NHACUNGCAP
alter table PhieuNhap
add constraint FK_PhieuNhap_NhaCungCap
foreign key (maNCC)
references NhaCungCap(maNCC)

-- 8.PHIEUNHAP-> NHANVIEN
alter table PhieuNhap
add constraint FK_PhieuNhap_NhanVien
foreign key (maNV)
references NhanVien(maNV)

-- 9.PHIEUNHAPCHITIET -> PHIEUNHAP
alter table PhieuNhapChiTiet
add constraint FK_PhieuNhapChiTiet_PhieuNhap
foreign key (maPhieuNhap_CT)
references PhieuNhap(maPhieuNhap)

-- 10.PHIEUNHAPCHITIET -> THUCPHAM
alter table PhieuNhapChiTiet
add constraint FK_PhieuNhapChiTiet_ThucPham
foreign key (maThucPham)
references ThucPham(maThucPham)



-- TAO VIEW--------------------------------------------------------------------------------------------------------------------

------------ THONG KE NHAP HANG---------------

create View THONGKENHAPHANG as
select PhieuNhap.maPhieuNhap,PhieuNhap.ngayNhap,PhieuNhap.maNV,PhieuNhap.maNCC,PhieuNhapChiTiet.maThucPham,PhieuNhapChiTiet.donGiaNhap,PhieuNhapChiTiet.soLuong , PhieuNhapChiTiet.donGiaNhap*PhieuNhapChiTiet.soLuong as ThanhTien
from PhieuNhap,PhieuNhapChiTiet
where PhieuNhap.maPhieuNhap = PhieuNhapChiTiet.maPhieuNhap_CT
go
------------THONG KE BAN HANG-----------------

create View THONGKEBANHANG as
select PhieuYeuCau.maPhieuYeuCau,PhieuYeuCau.ngayYeuCau,PhieuYeuCau.maNV,PhieuYeuCau.maKH,PhieuThanhToan.maMon,MonAn.tenMon,PhieuThanhToan.soLuongMon,MonAn.donGiaMon,PhieuThanhToan.maBan,BanAn.donGiaBan,((MonAn.donGiaMon*PhieuThanhToan.soLuongMon)+(BanAn.donGiaBan)) as ThanhTien
from PhieuYeuCau,PhieuThanhToan,BanAn,MonAn
where PhieuYeuCau.maPhieuYeuCau = PhieuThanhToan.maPhieuYeuCau and BanAn.MaBan = PhieuThanhToan.MaBan and PhieuThanhToan.maMon = MonAn.maMon
go

------------HỖ TRỢ TÌM KIẾM---------------


create View VIEW_MONAN as
select MonAn.maMon,MonAn.tenMon,MonAn.donGiaMon,MonAn.donViTinh,MonAn.maNhom,MonAn.hinhAnh,NhomMonAn.tenNhom
from MonAn,NhomMonAn
go

create view view_phieunhap as
select maPhieuNhap,maNCC,ngayNhap,maNV, soLuong, maThucPham, donGiaNhap
from PhieuNhap
right join PhieuNhapChiTiet
on phieunhap.maPhieuNhap=PhieuNhapChiTiet.maPhieuNhap_CT

--------------------------------------------------------------------NHAP LIEU------------------------------------------------------------------------------------------------------------

-- 1. Tai khoan
INSERT INTO Account(UserID,username,password,role)
VALUES (01,'nhat','123456',1);
INSERT INTO Account(UserID,username,password,role)
VALUES (02,'hoang','123456',2);
INSERT INTO Account(UserID,username,password,role)
VALUES (03,'dong','123456',1);
INSERT INTO Account(UserID,username,password,role)
VALUES (04,'viet','123456',1);

-- 2. NhomMonAn
INSERT INTO NhomMonAn(maNhom,tenNhom)
VALUES ('NMA01',N'Cà phê');
INSERT INTO NhomMonAn(maNhom,tenNhom)
VALUES ('NMA02',N'Trà sữa');
INSERT INTO NhomMonAn(maNhom,tenNhom)
VALUES ('NMA03',N'Soda');
INSERT INTO NhomMonAn(maNhom,tenNhom)
VALUES ('NMA04',N'Nước ép');
INSERT INTO NhomMonAn(maNhom,tenNhom)
VALUES ('NMA05',N'Sinh tố');
INSERT INTO NhomMonAn(maNhom,tenNhom)
VALUES ('NMA06',N'Đồ ăn vặt');
INSERT INTO NhomMonAn(maNhom,tenNhom)
VALUES ('NMA07',N'Đồ lưu niệm');

-- 3. NhaCungCap
INSERT INTO NhaCungCap(maNCC,tenNCC,diaChi,SDT,hinhAnh)
VALUES ('NCC01',N'Trung Nguyên Coffee',N' P. Ben Thanh, Q.1, Tp Ho Chi Minh','0356485695','https://capherangxay.vn/wp-content/uploads/2019/11/mua-cafe-trung-nguyen-2.jpg');
INSERT INTO NhaCungCap(maNCC,tenNCC,diaChi,SDT,hinhAnh)
VALUES ('NCC02',N'Vinamilk',N' 813 Giai Phong, Hoang Mai, Ha Noi','0989864866','https://isaac.vn/wp-content/uploads/2020/04/phan-phoi-vinamilk-1.jpg');
INSERT INTO NhaCungCap(maNCC,tenNCC,diaChi,SDT,hinhAnh)
VALUES ('NCC03',N'Yellow pages',N' P. Tan Tao, Binh Tan,(TPHCM)','0934498168','https://trangvangvietnam.com/images/dangkytrangvang-icon.jpg');
INSERT INTO NhaCungCap(maNCC,tenNCC,diaChi,SDT,hinhAnh)
VALUES ('NCC04',N'Chính sơn',N'phuong Nhan Chinh, quan Thanh Xuan, Tp. Ha Noi','0243558645','https://file.hstatic.net/1000135323/article/cc0_9c022c2716f2469595f8eb172226b776.jpg');
INSERT INTO NhaCungCap(maNCC,tenNCC,diaChi,SDT,hinhAnh)
VALUES ('NCC05',N'Thái Nguyên',N'xa Phuc Xuan,TP.Thai Nguyen,tinh Thai Nguyen','0906314178','http://tradungdat.com/upload/hinhanh/bat-ngat-doi-che-thai-nguyen-5-2222-7665.jpg');

-- 4. NhanVien
INSERT INTO NhanVien(maNV,tenNV,diaChi,SDT,chucVu,hinhAnh)
VALUES ('NV01','Nguyen Trung Thanh','Quan 1 - TPHCM','0352698768','Nhan vien','https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-lam-the-can-cuoc-400x600.jpg');
INSERT INTO NhanVien(maNV,tenNV,diaChi,SDT,chucVu,hinhAnh)
VALUES ('NV02','Ha Thi Thanh Truc','Quan 2 - TPHCM','0355698754','Nhan vien','https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-voi-ao-vec-400x600.jpg');
INSERT INTO NhanVien(maNV,tenNV,diaChi,SDT,chucVu,hinhAnh)
VALUES ('NV03','Nguyen Huu Ai','Quan 3 - TPHCM','0355698754','Nhan vien','https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-nam-416x600.jpg');
INSERT INTO NhanVien(maNV,tenNV,diaChi,SDT,chucVu,hinhAnh)
VALUES ('NV04','Nguyen Ngoc Minh Tam','Quan 4 - TPHCM','0355698754','Quan Ly','https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-voi-ao-so-mi-439x600.jpg');
INSERT INTO NhanVien(maNV,tenNV,diaChi,SDT,chucVu,hinhAnh)
VALUES ('NV05','Nguyen Tan Tai','Quan 5 - TPHCM','0355698754','Nhan vien','https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-nen-trang-400x600.jpg');
INSERT INTO NhanVien(maNV,tenNV,diaChi,SDT,chucVu,hinhAnh)
VALUES ('NV06','Ho Ngoc Mai','Quan 6 - TPHCM','0355698754','Nhan vien','https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-voi-ao-so-mi-nu-450x600.jpg');
INSERT INTO NhanVien(maNV,tenNV,diaChi,SDT,chucVu,hinhAnh)
VALUES ('NV07','Nguyen Tu Tai','Quan 7 - TPHCM','0355698754','Nhan vien','https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-nam-sinh-dep-450x600.jpg');
INSERT INTO NhanVien(maNV,tenNV,diaChi,SDT,chucVu,hinhAnh)
VALUES ('NV08','Mai Thi Tuyet Tram','Quan 8 - TPHCM','0355698754','Nhan vien','https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-hoc-sinh-480x600.jpg');
INSERT INTO NhanVien(maNV,tenNV,diaChi,SDT,chucVu,hinhAnh)
VALUES ('NV09','Ho Ngoc Bao Anh','Quan 9 - TPHCM','0355698754','Nhan vien','https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-cho-hoc-sinh-495x600.jpg');
INSERT INTO NhanVien(maNV,tenNV,diaChi,SDT,chucVu,hinhAnh)
VALUES ('NV10','Tran Thi Thao','Quan 10 - TPHCM','0355698754','Nhan vien','https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-sat-net-443x600.jpeg');

-- 5. ThucPham
INSERT INTO ThucPham(maThucPham,tenThucPham,donViTinh,NSX,HSD,maNCC)
VALUES ('TP01','G7 3 trong 1','hop','2020-05-06','2024-05-06','NCC01');
INSERT INTO ThucPham(maThucPham,tenThucPham,donViTinh,NSX,HSD,maNCC)
VALUES ('TP02','Sua vinamilk','thung','2020-06-03','2024-05-06','NCC02');
INSERT INTO ThucPham(maThucPham,tenThucPham,donViTinh,NSX,HSD,maNCC)
VALUES ('TP03','Syrup','chai','2021-03-06','2025-05-06','NCC03');
INSERT INTO ThucPham(maThucPham,tenThucPham,donViTinh,NSX,HSD,maNCC)
VALUES ('TP04','Bot beo 500g','bich','2021-06-06','2025-05-06','NCC04');
INSERT INTO ThucPham(maThucPham,tenThucPham,donViTinh,NSX,HSD,maNCC)
VALUES ('TP05','Tra xanh moc cau Thai Nguyen','goi','2021-07-06','2025-05-06','NCC05');
-- 6. KhachHang
INSERT INTO KhachHang(maKH,tenKH,diaChi,SDT,hinhAnh)
VALUES ('KH01','Nguyen Xuan Huong','Quan 9 - TPHCM ', '0321568957', 'https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-chat-luong-400x600.jpg' );
INSERT INTO KhachHang(maKH,tenKH,diaChi,SDT,hinhAnh)
VALUES ('KH02','Nguyen Thanh Tam','Quan 2 - TPHCM ', '0325698758', 'https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-nam-sinh.jpeg' );
INSERT INTO KhachHang(maKH,tenKH,diaChi,SDT,hinhAnh)
VALUES ('KH03','Tran Cong Canh','Quan 1 - TPHCM ', '0325253659', 'https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-lam-the-can-cuoc-400x600.jpg' );
INSERT INTO KhachHang(maKH,tenKH,diaChi,SDT,hinhAnh)
VALUES ('KH04','Tran Quoc Khanh','Quan 5 - TPHCM ', '0325253653', 'https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-nam-sinh-dep-450x600.jpg' );
INSERT INTO KhachHang(maKH,tenKH,diaChi,SDT,hinhAnh)
VALUES ('KH05','Tran Quoc Huy','Quan 1 - TPHCM ', '0365256250', 'https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-chuan-450x600.jpg' );
-- 7. BanAn
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B01',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-vuong-2-tang-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B02',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-tron-D80-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B03',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-tron-D70-2.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B04',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/Ban-BE-80120-W-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B05',N'Silver',N'0', 100000,'https://noithatlogic.vn/upload/00aff611-24ef-43de-bd67-55d11a731bfc/hinh-anh-ban-ghe-nha-hang.jpg');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B06',N'Silver',N'0', 100000,'https://noithatlogic.vn/upload/00aff611-24ef-43de-bd67-55d11a731bfc/hinh-anh-ban-ghe-nha-hang-.jpg');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B07',N'Silver',N'0', 100000,'https://noithatlogic.vn/upload/00aff611-24ef-43de-bd67-55d11a731bfc/hinh-anh-ban-ghe-nha-hang-1.png');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B08',N'Bronze',N'0', 50000,'https://noithatlogic.vn/upload/00aff611-24ef-43de-bd67-55d11a731bfc/hinh-anh-ban-ghe-nha-hang-4.jpg');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B09',N'Bronze',N'1', 50000,'https://noithatlogic.vn/upload/ban-ghe-ngoai-troi-gia-may-10.jpg?w=400&h=267');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B10',N'Bronze',N'1', 50000,'https://noithatlogic.vn/upload/Nhom-duc-mat-da/mat-da-D120cm-BND-03.01.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B11',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-vuong-2-tang-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B12',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-vuong-2-tang-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B13',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-vuong-2-tang-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B14',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-vuong-2-tang-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B15',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-vuong-2-tang-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B16',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-vuong-2-tang-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B17',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-vuong-2-tang-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B18',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-vuong-2-tang-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B19',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-vuong-2-tang-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B20',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-vuong-2-tang-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B21',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-vuong-2-tang-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B22',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-vuong-2-tang-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B23',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-vuong-2-tang-1.jpg?w=400&h=400');
INSERT INTO BanAn(maBan,loaiBan,tinhTrang,donGiaBan,hinhAnh)
VALUES ('B24',N'Gold',N'0', 150000,'https://noithatlogic.vn/upload/8ca6f938-25bc-4321-aad6-dac837165fb6/ban-Eames-vuong-2-tang-1.jpg?w=400&h=400');

-- 8. MonAn
INSERT INTO MonAn(maMon,tenMon,donGiaMon,donViTinh,maNhom,hinhAnh)
VALUES ('MA01',N'Cà phê đen đá',45000,'ly','NMA01','https://neomartpro.com/wp-content/uploads/2020/05/cafedenda-1-768x768.jpg');
INSERT INTO MonAn(maMon,tenMon,donGiaMon,donViTinh,maNhom,hinhAnh)
VALUES ('MA02',N'Cà phê sữa đá',50000,'ly','NMA01','https://www.minhtiencoffee.com/wp-content/uploads/2020/10/ca-phe-sua-da-1.jpg');
INSERT INTO MonAn(maMon,tenMon,donGiaMon,donViTinh,maNhom,hinhAnh)
VALUES ('MA03',N'Cà phê cacao',55000,'ly','NMA01','https://freetuts.net/upload/product_series/images/2019/06/05/170/ca-phe-ca-cao_550x363.jpg');
INSERT INTO MonAn(maMon,tenMon,donGiaMon,donViTinh,maNhom,hinhAnh)
VALUES ('MA04',N'Soda 3 tầng',55000,'ly','NMA03','https://horecavn.com/uploads/images/bai-viet/siro-nho-02.jpg');
INSERT INTO MonAn(maMon,tenMon,donGiaMon,donViTinh,maNhom,hinhAnh)
VALUES ('MA05',N'Sinh tố bơ',65000,'ly','NMA05','https://www.tasteofaustralia.com.vn/wp-content/uploads/2020/03/cach-lam-sinh-to-bo.jpg');
INSERT INTO MonAn(maMon,tenMon,donGiaMon,donViTinh,maNhom,hinhAnh)
VALUES ('MA06',N'Nước ép táo',45000,'ly','NMA04','https://product.hstatic.net/1000166699/product/_cnt6111_da674db65cb54f5ab7593ded109430ff_master.jpg');
INSERT INTO MonAn(maMon,tenMon,donGiaMon,donViTinh,maNhom,hinhAnh)
VALUES ('MA07',N'Trà sữa đặc biệt',55000,'ly','NMA02','https://static.hotdeal.vn/images/604/603765/500x500/121695-combo-1-bong-tuyet-kem-thap-cam1-tra-sua-dac-biet1-korokke-rau-cu-tai-kim.jpg');
INSERT INTO MonAn(maMon,tenMon,donGiaMon,donViTinh,maNhom,hinhAnh)
VALUES ('MA08',N'Khoai tây chiên',25000,'ly','NMA06','https://cdn.tgdd.vn/2021/09/CookDish/cach-lam-khoai-tay-chien-thom-ngon-nhat-avt-1200x676.jpg');

-- 9. PhieuNhap
INSERT INTO PhieuNhap(maPhieuNhap,maNCC,ngayNhap,maNV)
VALUES (5,'NCC01','2020-05-03','NV01');
INSERT INTO PhieuNhap(maPhieuNhap,maNCC,ngayNhap,maNV)
VALUES (6,'NCC02','2021-03-03','NV02');
INSERT INTO PhieuNhap(maPhieuNhap,maNCC,ngayNhap,maNV)
VALUES (7,'NCC03','2020-04-04','NV03');
INSERT INTO PhieuNhap(maPhieuNhap,maNCC,ngayNhap,maNV)
VALUES (8,'NCC04','2021-07-03','NV04');
INSERT INTO PhieuNhap(maPhieuNhap,maNCC,ngayNhap,maNV)
VALUES (9,'NCC05','2020-07-06','NV05');

-- 10. PhieuNhapChiTiet
INSERT INTO PhieuNhapChiTiet(maPhieuNhap_CT,soLuong,maThucPham,donGiaNhap)
VALUES (5,100,'TP01',80000);
INSERT INTO PhieuNhapChiTiet(maPhieuNhap_CT,soLuong,maThucPham,donGiaNhap)
VALUES (6,200,'TP02',220000);
INSERT INTO PhieuNhapChiTiet(maPhieuNhap_CT,soLuong,maThucPham,donGiaNhap)
VALUES (7,300,'TP03',50000);
INSERT INTO PhieuNhapChiTiet(maPhieuNhap_CT,soLuong,maThucPham,donGiaNhap)
VALUES (8,100,'TP04',30000);
INSERT INTO PhieuNhapChiTiet(maPhieuNhap_CT,soLuong,maThucPham,donGiaNhap)
VALUES (9,50,'TP05',55000);

-- 11. PhieuYeuCau
INSERT INTO PhieuYeuCau(maPhieuYeuCau,maKH,maNV,ngayYeuCau)
VALUES (12,'KH01','NV02','2021-09-03');
INSERT INTO PhieuYeuCau(maPhieuYeuCau,maKH,maNV,ngayYeuCau)
VALUES (13,'KH02','NV01','2021-05-03');
INSERT INTO PhieuYeuCau(maPhieuYeuCau,maKH,maNV,ngayYeuCau)
VALUES (14,'KH03','NV03','2021-03-03');
INSERT INTO PhieuYeuCau(maPhieuYeuCau,maKH,maNV,ngayYeuCau)
VALUES (15,'KH04','NV02','2021-01-03');
INSERT INTO PhieuYeuCau(maPhieuYeuCau,maKH,maNV,ngayYeuCau)
VALUES (16,'KH05','NV01','2021-11-03');
-- 12. PhieuThanhToan
INSERT INTO PhieuThanhToan(maPhieuYeuCau,maMon,soLuongMon,maBan)
VALUES (12,'MA01',2,'B01');
INSERT INTO PhieuThanhToan(maPhieuYeuCau,maMon,soLuongMon,maBan)
VALUES (13,'MA02',2,'B02');
INSERT INTO PhieuThanhToan(maPhieuYeuCau,maMon,soLuongMon,maBan)
VALUES (14,'MA03',2,'B03');
INSERT INTO PhieuThanhToan(maPhieuYeuCau,maMon,soLuongMon,maBan)
VALUES (15,'MA04',2,'B04');
INSERT INTO PhieuThanhToan(maPhieuYeuCau,maMon,soLuongMon,maBan)
VALUES (16,'MA05',2,'B06');
INSERT INTO PhieuThanhToan(maPhieuYeuCau,maMon,soLuongMon,maBan)
VALUES (16,'MA01',2,'B06');


-------------------------------------------------THEM HAM---------------------------------------------------------
create function thongKeTheoNgay (@ngay varchar(50))
returns table return
	select  *
	from THONGKEBANHANG
	where THONGKEBANHANG.ngayYeuCau = @ngay
GO
-- select * from thongKeTheoNgay ('2021-11-03')

create function timPhieuThanhToan (@ngay1 varchar(50), @ngay2 varchar(50))
returns table return

	select THONGKEBANHANG.maPhieuYeuCau, THONGKEBANHANG.tenMon, THONGKEBANHANG.ngayYeuCau
	from THONGKEBANHANG
	where THONGKEBANHANG.ngayYeuCau > @ngay1 and THONGKEBANHANG.ngayYeuCau < @ngay2

-- select * from timPhieuThanhToan ('2021-01-03','2021-11-03')
GO

create proc addHOADON( @MaKH char(10) , @MaNV char(10), @ngayYeuCau date )
as
	declare @MaPhieu int
	set @MaPhieu = (select MAX(maPhieuYeuCau) from PhieuYeuCau) + 1

	insert PhieuYeuCau
	values (@MaPhieu,@MaKH ,@MaNV, @NgayYeuCau)

-- exec addHOADON  'KH01', 'NV01','2020-03-04'




