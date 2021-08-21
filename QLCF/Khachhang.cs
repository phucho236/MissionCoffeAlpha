using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace QLCF
{
    public partial class Khachhang : Form
    {
        public Khachhang()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(connection.getconnect());
        public void ketnoi()
        {
            cnn.Open();
            string sql = "Select * from KHACHHANG";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            data_khachhang.DataSource = dt;
        }
        public class tbl_khachhang
        {
            public string MAKH { get;set;}
            public string TENKH { get;set;}
            public string DIACHI {get;set;}
            public string EMAIL {get;set;}
            public DateTime? NGAYSINH {get;set;}
            public string SDT { get; set; }
        }
        public void timkiem()
        {
            string queryString = "Select * from KHACHHANG";

            var l = new List<tbl_khachhang>();
        
            
            SqlCommand command = new SqlCommand(queryString, cnn);
            cnn.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        var r = new tbl_khachhang();
                        r.MAKH = reader["MAKH"] is DBNull ? "" : reader["MAKH"].ToString();
                        r.TENKH = reader["TENKH"] is DBNull ? "" : reader["TENKH"].ToString();
                        r.DIACHI = reader["DIACHI"] is DBNull ? "" : reader["DIACHI"].ToString();
                        r.EMAIL = reader["EMAIL"] is DBNull ? "" : reader["TENKH"].ToString();
                        r.NGAYSINH = DateTime.Parse(reader["NGAYSINH"].ToString());
                        r.SDT = reader["SDT"] is DBNull ? "" : reader["SDT"].ToString();
                        l.Add(r);
                    }
                }
                finally
                {
                    reader.Close();
                }

                var data = (from a in l 
                            where RemoveUnicode(a.TENKH).ToUpper().Contains(RemoveUnicode(txt_timkiem.Text.ToString()).ToUpper())
                            select a).ToList();
                data_khachhang.DataSource = data;
                cnn.Close();
        
        }
        public static string RemoveUnicode(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
            "đ",
            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
            "í","ì","ỉ","ĩ","ị",
            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
            "ý","ỳ","ỷ","ỹ","ỵ",};

            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
            "d",
            "e","e","e","e","e","e","e","e","e","e","e",
            "i","i","i","i","i",
            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
            "u","u","u","u","u","u","u","u","u","u","u",
            "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
        private void Khachhang_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void data_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_makh.Text = data_khachhang.Rows[numrow].Cells[0].Value.ToString();
            txt_tenkh.Text = data_khachhang.Rows[numrow].Cells[1].Value.ToString();
            dt_ngaysinh.Text = data_khachhang.Rows[numrow].Cells["NGAYSINH"].Value.ToString();
            txt_diachi.Text = data_khachhang.Rows[numrow].Cells["DIACHI"].Value.ToString();
            txt_sdt.Text = data_khachhang.Rows[numrow].Cells["SDT"].Value.ToString();
            txt_email.Text = data_khachhang.Rows[numrow].Cells["EMAIL"].Value.ToString();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string sql = @"Insert Into KHACHHANG VALUES ('" + txt_makh.Text + @"',N'" + txt_tenkh.Text + @"',N'" + txt_diachi.Text + @"','" + txt_email.Text + @"','" + dt_ngaysinh.Value + @"','" + txt_sdt.Text + @"')";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MessageBox.Show(" Thêm Thành công");
                cnn.Close();

                txt_makh.Clear();
                txt_tenkh.Clear();
                txt_diachi.Clear();
                txt_email.Clear();
                txt_makh.Focus();
                txt_sdt.Clear();
                ketnoi();

            }
            catch
            {
                MessageBox.Show("Thất bại mời nhập lại");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {

                cnn.Open();
                string sql = @"Delete FROM KHACHHANG  Where MAKH = '" + txt_makh.Text + "'";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MessageBox.Show("Xoá thành công !!!");
                cnn.Close();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Xoá không thành công !!!");

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            try
            {

                cnn.Open();
                string sql = @"update KHACHHANG set TENKH= N'" + txt_tenkh.Text.ToString() + "' ,DIACHI= N'" + txt_diachi.Text.ToString() + "',EMAIL='" + txt_email.Text.ToString() + "',NGAYSINH='" + dt_ngaysinh.Value + "',SDT='" + txt_sdt.Text.ToString() + "' where  MAKH = '" + txt_makh.Text.ToString() + "'";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();

                MessageBox.Show("Thành công");
                cnn.Close();

                txt_makh.Clear();
                txt_tenkh.Clear();
                txt_diachi.Clear();
                txt_email.Clear();
                txt_makh.Focus();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Thất bại mời nhập lại");
            }

        

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            timkiem();
        }

    }
}
