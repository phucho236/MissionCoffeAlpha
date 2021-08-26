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
        public CTHD(Hoadon hoadon)
        {
            InitializeComponent();
            hd = hoadon;
        }

        SqlConnection cnn = new SqlConnection(connection.getconnect());
       private  Hoadon hd;
        public void ketnoi()
        {
           
            int idhd = hd.getmahd();
            txt_mahd.Text = idhd.ToString();
            cnn.Open();
            string sql = "Select * from CTHOADON where MAHD = '"+idhd+"'";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            data_cthd.DataSource = dt;
        }

        private void CTHD_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
           
            int idhd = hd.getmahd();
            cnn.Open();
            string sql = @"Insert Into CTHOADON VALUES ('" + idhd + @"',N'" + txt_sanpham.Text + @"','" + txt_soluong.Text + @"','" + txt_gia.Text + @"','" + DBNull.Value + @"')";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            MessageBox.Show(" Thêm Thành công");
            cnn.Close();

            hd.ketnoi();//get new data in before page

            txt_mahd.Clear();
            txt_sanpham.Clear();//ok
            txt_soluong.Clear();
            txt_gia.Clear();
            txt_thanhtien.Clear();


            txt_mahd.Focus();
            ketnoi();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                
                cnn.Open();
                string sql = @"Delete FROM CTHOADON  Where MAHD = '" + txt_mahd.Text + "' AND  MASP = '" + txt_sanpham.Text + "'";
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
                string sql = @"update CTHOADON set SOLUONG= '" + txt_soluong.Text.ToString() + "' ,GIA= '" + txt_gia.Text.ToString() + "' ,THANHTIEN= '" + txt_thanhtien.Text.ToString() + "' where  MAHD = '" + txt_mahd.Text.ToString() + "' AND MASP = '" + txt_sanpham.Text.ToString() + "'";
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
            txt_mahd.Text = data_cthd.Rows[numrow].Cells[0].Value.ToString();
            txt_sanpham.Text = data_cthd.Rows[numrow].Cells[1].Value.ToString();
            txt_soluong.Text = data_cthd.Rows[numrow].Cells[2].Value.ToString();
            txt_gia.Text = data_cthd.Rows[numrow].Cells[3].Value.ToString();
            txt_thanhtien.Text = data_cthd.Rows[numrow].Cells[4].Value.ToString();

        }






    }
}
