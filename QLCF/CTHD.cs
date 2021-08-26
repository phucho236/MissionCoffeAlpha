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
    public partial class CTHD : Form
    {
        public CTHD()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(connection.getconnect());
        Hoadon hd = new Hoadon();
        public void ketnoi()
        {
            try
            {
                int idhd = hd.getmahd();
                txt_mahd.Text = idhd.ToString();
                if (cnn != null && cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                ///////
                string queryString = "Select * from CTHOADON where MAHD ='" + idhd + "'";

                var l = new List<CTHOADON>();
                SqlCommand command = new SqlCommand(queryString, cnn);
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        var r = new CTHOADON();
                        r.MAHD = reader["MAHD"] is DBNull ? "" : reader["MAHD"].ToString();
                        r.MASP = reader["MASP"] is DBNull ? "" : reader["MASP"].ToString();
                        r.SOLUONG = reader["SOLUONG"] is DBNull ? 0 : int.Parse(reader["SOLUONG"].ToString());
                        r.GIA = reader["GIA"] is DBNull ? 0 : int.Parse(reader["GIA"].ToString());
                        r.THANHTIEN = reader["THANHTIEN"] is DBNull ? 0 : int.Parse(reader["THANHTIEN"].ToString());
                        l.Add(r);
                    }
                }
                finally
                {
                    reader.Close();
                }
                data_cthd.DataSource = l;
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Kết nối  không thành công !!!");

            }
            
        }
        List<SANPHAM> l = new List<SANPHAM>();
        public void loadcbb()
        {

            int idhd = hd.getmahd();
            txt_mahd.Text = idhd.ToString();
            cnn.Open();
            ///////
            string queryString = "Select * from sanpham";
            SqlCommand command = new SqlCommand(queryString, cnn);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    var r = new SANPHAM();
                    r.TENSP = reader["TENSP"] is DBNull ? "" : reader["TENSP"].ToString();
                    r.MASP = reader["MASP"] is DBNull ? "" : reader["MASP"].ToString();
                    r.CHITIET = reader["CHITIET"] is DBNull ? "" : reader["CHITIET"].ToString();
                    r.GIA = reader["GIA"] is DBNull ? 0 : int.Parse(reader["GIA"].ToString());
                    l.Add(r);
                }
            }
            finally
            {
                reader.Close();
            }
            cbb_sanpham.DataSource = l;
            cbb_sanpham.DisplayMember = "TENSP";
            cbb_sanpham.ValueMember = "MASP";
            cnn.Close();
        }
        public class SANPHAM
        { 
            public string MASP {get;set;}
            public string TENSP {get;set;}
            public string CHITIET {get;set;}
            public int? GIA { get; set; }
        }
        public class CTHOADON
        {
            public string MAHD { get;set;}
            public string MASP {get;set;}
            public string TENSP { get; set; }
            public int? SOLUONG {get;set;}
            public int? GIA {get;set;}
            public int? THANHTIEN { get; set; }
        }
        private void CTHD_Load(object sender, EventArgs e)
        {
            ketnoi();
            loadcbb();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                int idhd = hd.getmahd();
                cnn.Open();
                string sql = @"Insert Into CTHOADON VALUES ('" + idhd + @"',N'" + cbb_sanpham.SelectedValue.ToString() + @"','" + txt_soluong.Text + @"','" + txt_gia.Text + @"','" + DBNull.Value + @"')";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MessageBox.Show(" Thêm Thành công");
                cnn.Close();
                txt_mahd.Clear();
                txt_soluong.Clear();
                txt_gia.Clear();
                txt_thanhtien.Clear();
                txt_mahd.Focus();
                hd.ketnoi();//get new data in before page

                ketnoi();
            }
            catch
            {
                MessageBox.Show("Thêm không thành công !!!");
                ketnoi();
            }
       
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                
                cnn.Open();
                string sql = @"Delete FROM CTHOADON  Where MAHD = '" + txt_mahd.Text + "' AND  MASP = '" + cbb_sanpham.SelectedValue.ToString() + "'";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MessageBox.Show("Xoá thành công !!!");
                cnn.Close();

                ketnoi();
                hd.ketnoi();//get new data in before page
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
                string sql = @"update CTHOADON set SOLUONG= '" + txt_soluong.Text.ToString() + "' ,GIA= '" + txt_gia.Text.ToString() + "' ,THANHTIEN= '" + txt_thanhtien.Text.ToString() + "' where  MAHD = '" + txt_mahd.Text.ToString() + "' AND MASP = '" + cbb_sanpham.Text.ToString() + "'";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();

                MessageBox.Show("Thành công");
                cnn.Close();

                ketnoi();
                hd.ketnoi();//get new data in before page
            }
            catch
            {
                MessageBox.Show("Thất bại mời nhập lại");
            }

        }

        private void data_cthd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_mahd.Text = data_cthd.Rows[numrow].Cells["MAHD"].Value.ToString();
            cbb_sanpham.SelectedValue = data_cthd.Rows[numrow].Cells["MASP"].Value.ToString();
            txt_soluong.Text = data_cthd.Rows[numrow].Cells["SOLUONG"].Value.ToString();
            txt_gia.Text = data_cthd.Rows[numrow].Cells["GIA"].Value.ToString();
            txt_thanhtien.Text = data_cthd.Rows[numrow].Cells["THANHTIEN"].Value.ToString();

        }

        private void cbb_sanpham_SelectedValueChanged(object sender, EventArgs e)
        {
            try 
            {
                string masp = cbb_sanpham.SelectedValue.ToString();
                var sp = l.Where(x => x.MASP.ToUpper() == masp.ToUpper()).FirstOrDefault();
                txt_gia.Text = sp.GIA.ToString();
            }
            catch { }
        }






    }
}
