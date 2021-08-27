using System;
namespace Model
{
    public class tbl_sanpham
    {
        public string MAHD { get; set; }
        public string MANV { get; set; }
        public string MAKH { get; set; }
        public double TONGTIEN { get; set; }
        public DateTime? NGAYMUA { get; set; }
        public string CHUTHICH { get; set; }
    }
    public class UserModel
    {
        public int MANV { get; set; }
        public string TENNV { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public DateTime NGAYSINH { get; set; }
    }
    public class SANPHAM
    {
        public string MASP { get; set; }
        public string TENSP { get; set; }
        public string CHITIET { get; set; }
        public int? GIA { get; set; }
    }
    public class CTHOADON
    {
        public string MAHD { get; set; }
        public string MASP { get; set; }
        public string TENSP { get; set; }
        public int? SOLUONG { get; set; }
        public int? GIA { get; set; }
        public int? THANHTIEN { get; set; }
    }
    public class KHACHHANG
    {
        public string MAKH { get; set; }
        public string TENKH { get; set; }
        public string DIACHI { get; set; }
        public string EMAIL { get; set; }
        public DateTime? NGAYSINH { get; set; }
        public string SDT { get; set; }
    }
}







