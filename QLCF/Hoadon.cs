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

namespace QLCF
{
    public partial class Hoadon : Form
    {
        public Hoadon()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(connection.getconnect());
        public static int idhd = 0;

        public void ketnoi()
        {
            cnn.Open();
            string sql = "Select * from HOADON";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            data_hoadon.DataSource = dt;
        }
        

        public int getmahd()
        {
            return idhd;
        }

        private void btn_chitiethd_Click(object sender, EventArgs e)
        {
           if(idhd == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
                return;
            }
            CTHD ct = new CTHD();
            ct.Show();
        }
  
        private void Hoadon_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

    
        public void timkiem()
        {
            string queryString = "Select * from HOADON";

            var l = new List<Model.tbl_sanpham>();
            SqlCommand command = new SqlCommand(queryString, cnn);
            cnn.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    var r = new Model.tbl_sanpham();
                    r.MAHD = reader["MAHD"] is DBNull ? "" : reader["MAHD"].ToString();
                    r.MANV = reader["MANV"] is DBNull ? "" : reader["MANV"].ToString();
                    r.MAKH = reader["MAKH"] is DBNull ? "" : reader["MAKH"].ToString();
                    r.TONGTIEN = double.Parse(reader["TONGTIEN"].ToString());
                    r.NGAYMUA = DateTime.Parse(reader["NGAYMUA"].ToString());
                    r.CHUTHICH = reader["CHUTHICH"] is DBNull ? "" : reader["CHUTHICH"].ToString();
                    l.Add(r);
                }
            }
            finally
            {
                reader.Close();
            }

            var data = (from a in l
                        where RemoveUnicode(a.MAHD).ToUpper().Contains(RemoveUnicode(txt_timkiem.Text.ToString()).ToUpper())
                        select a).ToList();
            data_hoadon.DataSource = data;
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            //try
            //{
                var dangNhap = new DangNhap();
                Model.UserModel userModel = dangNhap.getUserModel();
                cnn.Open();
                string sql = @"Insert Into HOADON VALUES (N'" + userModel.MANV.ToString() + @"','" + txt_makh.Text + @"','" + DBNull.Value + @"','" + dt_ngaymua.Value + @"',N'" + txt_chuthich.Text + @"')";

                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MessageBox.Show(" Thêm Thành công");
                cnn.Close();
                txt_makh.Clear();
                txt_manv.Clear();
                txt_makh.Clear();
                txt_chuthich.Clear();
                txt_makh.Focus();
                ketnoi();
            //}
            //catch

            //{
            //    MessageBox.Show(" lỖI");
            //}
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {

                cnn.Open();
                string sql = @"Delete FROM HOADON  Where (MAHD = '" + idhd + "')";
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
                string sql = @"update HOADON set MANV= '" + txt_manv.Text.ToString() + "' ,MAKH= '" + txt_makh.Text.ToString() + "' ,NGAYMUA='" + dt_ngaymua.Value + "',CHUTHICH= N'" + txt_chuthich.Text.ToString() + "' where  MAHD = '" + idhd + "'";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();

                MessageBox.Show("Thành công");
                cnn.Close();

                ketnoi();
            }
            catch
            {
                MessageBox.Show("Thất bại mời nhập lại");
            }
        }

        private void data_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            idhd = int.Parse(data_hoadon.Rows[numrow].Cells[0].Value.ToString());
            txt_manv.Text = data_hoadon.Rows[numrow].Cells[1].Value.ToString();
            txt_makh.Text = data_hoadon.Rows[numrow].Cells[2].Value.ToString();
            tongTien_txt.Text = data_hoadon.Rows[numrow].Cells[3].Value.ToString();
            dt_ngaymua.Text = data_hoadon.Rows[numrow].Cells[4].Value.ToString();
            txt_chuthich.Text = data_hoadon.Rows[numrow].Cells[5].Value.ToString();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            timkiem();
        }
    }
}
