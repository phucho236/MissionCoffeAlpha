using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF
{
    public partial class DSQUANLY : Form
    {
        public DSQUANLY()
        {
            InitializeComponent();
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            NhanVien NV = new NhanVien();
            NV.Show();
           
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            SanPham SP = new SanPham();
            SP.Show();
            
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            Khachhang KH = new Khachhang();
            KH.Show();
            
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            Hoadon HD = new Hoadon();
            HD.Show();
        }
    }
}
