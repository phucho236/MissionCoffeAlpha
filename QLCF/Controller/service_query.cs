using System;
using Model;
using BASE_SERVICE;
using BASE_QUERY;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SERVICE_QUERY
{
    public class ServiceQuery : BaseService
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NLHV1L4\SQLEXPRESS;Initial Catalog=QUANLYCAPHE;Integrated Security=True;User ID=sa;Password=sa2012");

        BaseQuery baseQuery = new BaseQuery();
        void openConn()
        {
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

        }
        void closeConn()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }
        public int logInV1(string userName, string passWord)
        {
            openConn();
            SqlCommand com = new SqlCommand(baseQuery.logInQueryV1(userName, passWord), conn);
            var result =  com.ExecuteScalar();
            closeConn();
            return Convert.ToInt32(result);
        }
        public DataTable logInV2(string userName, string passWord)
        {
            openConn();
            SqlCommand com = new SqlCommand(baseQuery.logInQueryV2(userName, passWord), conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeConn();
            return dt;
        }
        public DataTable getDSNhanvien()
        {
            openConn();
            SqlCommand com = new SqlCommand(baseQuery.getDSNhanVienQuery, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeConn();
            return  dt;
        }
        public int insertNhanvien( string tennv, string diachi,string sdt, DateTime dtngay,string taikhoan, string matkhau)
            {
            try
            {
                openConn();
                SqlCommand com = new SqlCommand(baseQuery.insertNhanVienQuery(tennv, diachi, sdt, dtngay, taikhoan, matkhau), conn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                closeConn();
                return 1;
        }
            catch
            {
                return 0;
            }
        }
      

        public int deleteNhanvien(int maNV)
        {
          try
            {
                openConn();
                SqlCommand com = new SqlCommand(baseQuery.deleteNhanVienQuery(maNV), conn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                closeConn();
                return 1;
            }
            catch
            {
                return 0;
            }
           
        }
        public int updateNhanVien(int manv,string tennv, string diachi, string sdt, DateTime dtngay, string taikhoan, string matkhau)
        {
            try
            {
                openConn();
                SqlCommand com = new SqlCommand(baseQuery.updateNhanVienQuery(manv, tennv, diachi, sdt, dtngay, taikhoan, matkhau), conn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                closeConn();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}

