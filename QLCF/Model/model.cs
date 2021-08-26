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
}







