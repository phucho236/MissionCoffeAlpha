using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using REPOSITORY;
namespace QLCF
{


    public partial class NhanVien : Form
    {


        Repository repository = new Repository();
        int idNhanvien = 0;
        public NhanVien()
        {
            InitializeComponent();

        }
     
        public void getData()
            
        {  
            dataGridView1.DataSource = repository.getDSNhanvien();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getData();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            idNhanvien = int.Parse(dataGridView1.Rows[numrow].Cells[0].Value.ToString());
            txt_tennv.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            txt_sdt.Text    = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
            txt_diachi.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
            dt_ngay.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
            txt_taikhoan.Text = dataGridView1.Rows[numrow].Cells[5].Value.ToString();
            txt_matkhau.Text = dataGridView1.Rows[numrow].Cells[6].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_tennv.Text == null || txt_tennv.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên");
                return;
            }
         
            if (txt_sdt.Text == null || txt_sdt.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return;
            }
            if (txt_taikhoan.Text== null || txt_taikhoan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                return;
            }
            if (txt_matkhau.Text == null || txt_matkhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            int response = repository.insertNhanvien( txt_tennv.Text, txt_diachi.Text, txt_sdt.Text, dt_ngay.Value, txt_taikhoan.Text, txt_matkhau.Text);
            if (response == 1)
            {
                MessageBox.Show(" Thêm Thành công");
                cleanData();
                getData();
            }
            else
            {
                MessageBox.Show("Thất bại vui lòng nhập lại");
            }

        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(idNhanvien == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!!!");
                return;
            }
            int response = repository.deleteNhanvien(idNhanvien);
            if(response ==1)
            {
                 MessageBox.Show("Xoá thành công !!!");
                 getData();
            }
            else
            {
                MessageBox.Show("Xoá không thành công !!!");
            }
         




        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {

            if (idNhanvien == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!!!");
                return;
            }
            if (txt_tennv.Text == null || txt_tennv.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên");
                return;
            }

            if (txt_sdt.Text == null || txt_sdt.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return;
            }
            if (txt_taikhoan.Text == null || txt_taikhoan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                return;
            }
            if (txt_matkhau.Text == null || txt_matkhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            int response = repository.updateNhanVien(idNhanvien, txt_tennv.Text, txt_diachi.Text, txt_sdt.Text, dt_ngay.Value, txt_taikhoan.Text, txt_matkhau.Text);
            if (response == 1)
            {
                cleanData();

                getData();
                MessageBox.Show("Sửa thành công !!!");
            }
            else
            {
                MessageBox.Show("Xãy ra lỗi vui lòng thử lại !!!");
            }

        }
        void cleanData()
        {

            txt_tennv.Clear();
            txt_sdt.Clear();
            txt_diachi.Clear();
            txt_taikhoan.Clear();
            txt_matkhau.Clear();
            idNhanvien = 0;
            txt_tennv.Focus();
        }

     


   


     
        
      

     

      
    }
}
