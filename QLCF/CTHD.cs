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
        void open()
        {
            if (cnn != null && cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
        }
        void close()
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        private Hoadon hd;
        public void ketnoi()
        {
            try
            {
                int idhd = hd.getmahd();
                txt_mahd.Text = idhd.ToString();
                open();
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
                close();
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
            open();
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
            close();
        }
        public class SANPHAM
        {
            public string MASP { get; set; }
            public string TENSP { get; set; }
            public string CHITIET { get; set; }
            public int? GIA { get; set; }
        }
        public class CTHOADON
        {
            public string MAHD { get; set; }
            public string MASP { get; set; }
            public string TENSP { get; set; }
            public int? SOLUONG { get; set; }
            public int? GIA { get; set; }
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
                if (txt_soluong.Text == null || txt_soluong.Text == "" || int.Parse(txt_soluong.Text) <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng");
                    return;
                }
                if (txt_gia.Text == null || txt_gia.Text == "" || int.Parse(txt_gia.Text) <= 0)
                {
                    MessageBox.Show("Vui lòng nhập giá");
                    return;
                }

                foreach (DataGridViewRow row in data_cthd.Rows)
                {

                    if (row.Cells[1].Value.ToString().Trim().Equals(cbb_sanpham.SelectedValue.ToString().Trim()))
                    {
                        MessageBox.Show("thức uốn đã tồn tại trong chi tiết hóa đơn, vui lòng chỉnh sửa");
                        return;
                    }

                }
                int idhd = hd.getmahd();
                open();
                string sql = @"Insert Into CTHOADON VALUES ('" + idhd + @"',N'" + cbb_sanpham.SelectedValue.ToString() + @"','" + txt_soluong.Text + @"','" + txt_gia.Text + @"','" + DBNull.Value + @"')";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MessageBox.Show(" Thêm Thành công");
                close();
                cleanData();
                ketnoi();
                hd.ketnoi();//get new data in before page
            }
            catch
            {
                MessageBox.Show("Lỗi");

            }


        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {

                open();
                string sql = @"Delete FROM CTHOADON  Where MAHD = '" + txt_mahd.Text + "' AND  MASP = '" + cbb_sanpham.SelectedValue.ToString() + "'";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MessageBox.Show("Xoá thành công !!!");
                close();
                cleanData();
                ketnoi();
                hd.ketnoi();
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

                if (txt_soluong.Text == null || txt_soluong.Text == "" || int.Parse(txt_soluong.Text) <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng");
                    return;
                }
                if (txt_gia.Text == null || txt_gia.Text == "" || int.Parse(txt_gia.Text) <= 0)
                {
                    MessageBox.Show("Vui lòng nhập giá");
                    return;
                }
                open();
                string sql = @"update CTHOADON set SOLUONG= '" + txt_soluong.Text.ToString() + "' ,GIA= '" + txt_gia.Text.ToString() + "' ,THANHTIEN= '" + DBNull.Value + "' where  MAHD = '" + txt_mahd.Text.ToString() + "' AND MASP = '" + cbb_sanpham.SelectedValue.ToString() + "'";
                SqlCommand com = new SqlCommand(sql, cnn);
                Console.Write(sql);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                close();
                MessageBox.Show("Thành công");
                cleanData();
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

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            sum();
        }

        private void txt_gia_TextChanged(object sender, EventArgs e)
        {
            sum();
        }
        void sum()
        {
            if (txt_gia.Text != null && txt_gia.Text != "" && txt_soluong.Text != null && txt_soluong.Text != "")
            {
                if (int.Parse(txt_gia.Text) > 0 && int.Parse(txt_soluong.Text) > 0)
                {
                    txt_thanhtien.Text = (int.Parse(txt_gia.Text) * int.Parse(txt_soluong.Text)).ToString();
                }
            }
        }
        void cleanData()
        {
            txt_mahd.Clear();
            txt_soluong.Clear();
            txt_thanhtien.Text = "";
            txt_mahd.Focus();
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
