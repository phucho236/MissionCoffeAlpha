using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BASE_SERVICE;
using Model;
using SERVICE_QUERY;
using System.Data;

namespace REPOSITORY 
{
   public class Repository : BaseService
    {
        ServiceQuery servicerQuery = new ServiceQuery();
        public int logInV1(string userName, string passWord)
        {
            return servicerQuery.logInV1(userName, passWord);
        }
        public DataTable getDSNhanvien()
        {
            return servicerQuery.getDSNhanvien();
        }
        public int insertNhanvien( string tennv, string diachi, string sdt, DateTime dtngay, string taikhoan, string matkhau)
        {
            return servicerQuery.insertNhanvien(  tennv,  diachi,  sdt,  dtngay,  taikhoan,  matkhau);
        }

        public int deleteNhanvien(int maNV)
        {
            return servicerQuery.deleteNhanvien(maNV);
        }

        public int updateNhanVien(int manv, string tennv, string diachi, string sdt, DateTime dtngay, string taikhoan, string matkhau)
        {
            return servicerQuery.updateNhanVien(manv,tennv, diachi, sdt, dtngay, taikhoan, matkhau);
        }
    }
}
