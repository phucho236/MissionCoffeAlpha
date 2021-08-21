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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(connection.getconnect());
        public void ketnoi()
        {
            cnn.Open();
            string sql = "Select * from SANPHAM";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            data_sanpham.DataSource = dt;
        }


        private void SanPham_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void data_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_masp.Text = data_sanpham.Rows[numrow].Cells[0].Value.ToString();
            txt_tensanpham.Text = data_sanpham.Rows[numrow].Cells[1].Value.ToString();
            txt_chitiet.Text = data_sanpham.Rows[numrow].Cells[2].Value.ToString();
            txt_gia.Text = data_sanpham.Rows[numrow].Cells[3].Value.ToString();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string sql = @"Insert Into SANPHAM VALUES ('" + txt_masp.Text + @"',N'" + txt_tensanpham.Text + @"',N'" + txt_chitiet.Text + @"','" + txt_gia.Text + @"')";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MessageBox.Show(" Thêm Thành công");
                cnn.Close();

                txt_masp.Clear();
                txt_tensanpham.Clear();
                txt_chitiet.Clear();
                txt_gia.Clear();
                txt_masp.Focus();
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
                string sql = @"Delete FROM SANPHAM  Where (MASP = '" + txt_masp.Text + "')";
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
                string sql = @"update SANPHAM set TENSP= N'" + txt_tensanpham.Text.ToString() + "' ,CHITIET= '" + txt_chitiet.Text.ToString() + "',GIA='" + txt_gia.Text.ToString()  + "' where  MASP = '" + txt_masp.Text.ToString() + "'";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();

                MessageBox.Show("Thành công");
                cnn.Close();



                txt_masp.Clear();
                txt_tensanpham.Clear();
                txt_chitiet.Clear();
                txt_gia.Clear();
                txt_masp.Focus();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Thất bại mời nhập lại");
            }
        }


    }
}
