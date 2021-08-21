using System;
using Model;
using System.Data;

namespace BASE_SERVICE 
{
    interface BaseService
    {
        int logInV1(string userName, string passWord);
        DataTable getDSNhanvien();
        int insertNhanvien(string tennv, string diachi, string sdt, DateTime dtngay, string taikhoan, string matkhau);
        int deleteNhanvien(int maNV);
        int updateNhanVien(int manv, string tennv, string diachi, string sdt, DateTime dtngay, string taikhoan, string matkhau);
    }
   
}