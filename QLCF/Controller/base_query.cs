using System;

//Interface members are by default abstract and public
namespace BASE_QUERY
{
    public  class BaseQuery
    {
       //public string logInQuery => "SELECT * From Person";
       
        public string logInQuery(string userName,string pass) => "SELECT dbo.LoginV1('" + userName + @"','" + pass + @"')";

        public string getDSNhanVienQuery = "Select * from NHANVIEN";

        public string insertNhanVienQuery(string tennv, string diachi, string sdt, DateTime dtngay, string taikhoan, string matkhau) => "Insert Into NHANVIEN VALUES" + @"(N'" + tennv + @"',N'" + diachi + @"','" + sdt + @"','" + dtngay + @"','" + taikhoan + @"','" + matkhau + @"')";

        public string deleteNhanVienQuery(int maNV) => @"Delete FROM NHANVIEN  Where (MANV = '" + maNV + "')";

        public string updateNhanVienQuery(int manv, string tennv, string diachi, string sdt, DateTime dtngay, string taikhoan, string matkhau) => "update NHANVIEN SET TENNV = N'" + tennv + "' ,DIACHI= '" + diachi + "',SDT='" + sdt + "',NGAYSINH='" + dtngay + "',TENTK='" + taikhoan + "',PASSWD='" + matkhau + "' where MANV = '" + manv + "'";
    }
}

