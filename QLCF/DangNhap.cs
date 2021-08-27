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
using REPOSITORY;

namespace QLCF
{
    public partial class DangNhap : Form
    {
        Repository repository = new Repository();
        public DangNhap()
        {
            InitializeComponent();
        }
        public static Model.UserModel userModel = new Model.UserModel();
        public Model.UserModel getUserModel()
        {
            return userModel;
        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            var data = repository.logInV2(txt_tk.Text, txt_mk.Text);


            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {

                    userModel.MANV = int.Parse(row["MANV"].ToString());
                    userModel.TENNV = row["TENNV"].ToString();
                    userModel.DIACHI = row["DIACHI"].ToString();
                    userModel.SDT =  row["SDT"].ToString();
                    userModel.NGAYSINH = DateTime.Parse(row["NGAYSINH"].ToString());
                }
              
                var DS = new DSQUANLY();
                this.Hide();
                DS.Show();
               
            }
            else
            {
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

   
}
