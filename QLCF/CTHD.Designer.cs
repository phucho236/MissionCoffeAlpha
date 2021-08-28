namespace QLCF
{
    partial class CTHD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_cthd = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_thanhtien = new System.Windows.Forms.Label();
            this.cbb_sanpham = new System.Windows.Forms.ComboBox();
            this.txt_m = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.txt_s = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.Label();
            this.txt_t = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_cthd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_cthd
            // 
            this.data_cthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_cthd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.MASP,
            this.TENSP,
            this.SOLUONG,
            this.GIA,
            this.THANHTIEN});
            this.data_cthd.Location = new System.Drawing.Point(19, 181);
            this.data_cthd.Name = "data_cthd";
            this.data_cthd.Size = new System.Drawing.Size(784, 316);
            this.data_cthd.TabIndex = 12;
            this.data_cthd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_cthd_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txt_thanhtien);
            this.groupBox1.Controls.Add(this.cbb_sanpham);
            this.groupBox1.Controls.Add(this.txt_m);
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Controls.Add(this.txt_s);
            this.groupBox1.Controls.Add(this.txt_x);
            this.groupBox1.Controls.Add(this.txt_t);
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(this.txt_soluong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.txt_mahd);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 151);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.AutoSize = true;
            this.txt_thanhtien.Location = new System.Drawing.Point(108, 116);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(0, 16);
            this.txt_thanhtien.TabIndex = 20;
            // 
            // cbb_sanpham
            // 
            this.cbb_sanpham.FormattingEnabled = true;
            this.cbb_sanpham.Location = new System.Drawing.Point(128, 67);
            this.cbb_sanpham.Name = "cbb_sanpham";
            this.cbb_sanpham.Size = new System.Drawing.Size(147, 24);
            this.cbb_sanpham.TabIndex = 19;
            this.cbb_sanpham.SelectedValueChanged += new System.EventHandler(this.cbb_sanpham_SelectedValueChanged);
            this.cbb_sanpham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbb_sanpham_KeyDown);
            // 
            // txt_m
            // 
            this.txt_m.AutoSize = true;
            this.txt_m.Location = new System.Drawing.Point(801, 57);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(0, 16);
            this.txt_m.TabIndex = 18;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(31, 116);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(71, 16);
            this.a.TabIndex = 17;
            this.a.Text = "Thành Tiền";
            // 
            // txt_s
            // 
            this.txt_s.AutoSize = true;
            this.txt_s.Location = new System.Drawing.Point(305, 32);
            this.txt_s.Name = "txt_s";
            this.txt_s.Size = new System.Drawing.Size(67, 16);
            this.txt_s.TabIndex = 16;
            this.txt_s.Text = "Số Lượng";
            // 
            // txt_x
            // 
            this.txt_x.AutoSize = true;
            this.txt_x.Location = new System.Drawing.Point(305, 70);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(28, 16);
            this.txt_x.TabIndex = 15;
            this.txt_x.Text = "Giá";
            // 
            // txt_t
            // 
            this.txt_t.AutoSize = true;
            this.txt_t.Location = new System.Drawing.Point(31, 70);
            this.txt_t.Name = "txt_t";
            this.txt_t.Size = new System.Drawing.Size(69, 16);
            this.txt_t.TabIndex = 13;
            this.txt_t.Text = "Sản Phẩm";
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(378, 69);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(147, 22);
            this.txt_gia.TabIndex = 11;
            this.txt_gia.TextChanged += new System.EventHandler(this.txt_gia_TextChanged);
            this.txt_gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gia_KeyPress);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(378, 29);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(147, 22);
            this.txt_soluong.TabIndex = 9;
            this.txt_soluong.TextChanged += new System.EventHandler(this.txt_soluong_TextChanged);
            this.txt_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Hoá Đơn";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(230, 113);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(340, 113);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(128, 26);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.ReadOnly = true;
            this.txt_mahd.Size = new System.Drawing.Size(147, 22);
            this.txt_mahd.TabIndex = 2;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(450, 113);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "Mã Hoá Đơn";
            this.MAHD.Name = "MAHD";
            this.MAHD.Width = 150;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã Sản Phẩm";
            this.MASP.Name = "MASP";
            this.MASP.Width = 150;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.Name = "TENSP";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 150;
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "Giá";
            this.GIA.Name = "GIA";
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.HeaderText = "Thành Tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.Width = 190;
            // 
            // CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 513);
            this.Controls.Add(this.data_cthd);
            this.Controls.Add(this.groupBox1);
            this.Name = "CTHD";
            this.Text = "CTHD";
            this.Load += new System.EventHandler(this.CTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_cthd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_cthd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txt_m;
        private System.Windows.Forms.Label txt_s;
        private System.Windows.Forms.Label txt_x;
        private System.Windows.Forms.Label txt_t;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.ComboBox cbb_sanpham;
        private System.Windows.Forms.Label txt_thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
    }
}