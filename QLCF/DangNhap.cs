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

      
        
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {

      
                if (Convert.ToInt32(repository.logInV1(txt_tk.Text,txt_mk.Text)) ==1)
                   {

                       DSQUANLY DS = new DSQUANLY();
                       DS.Show();
                       this.Hide();

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
