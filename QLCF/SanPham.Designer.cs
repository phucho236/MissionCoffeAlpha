namespace QLCF
{
    partial class SanPham
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
            this.data_sanpham = new System.Windows.Forms.DataGridView();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHITIET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_m = new System.Windows.Forms.Label();
            this.txt_s = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.Label();
            this.txt_t = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_chitiet = new System.Windows.Forms.TextBox();
            this.txt_tensanpham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_chitiethd = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_sanpham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_sanpham
            // 
            this.data_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_sanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.TENSP,
            this.CHITIET,
            this.GIA});
            this.data_sanpham.Location = new System.Drawing.Point(23, 192);
            this.data_sanpham.Name = "data_sanpham";
            this.data_sanpham.Size = new System.Drawing.Size(784, 305);
            this.data_sanpham.TabIndex = 14;
            this.data_sanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_sanpham_CellClick);
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
            this.TENSP.HeaderText = "Tên Sản Phẩm";
            this.TENSP.Name = "TENSP";
            this.TENSP.Width = 200;
            // 
            // CHITIET
            // 
            this.CHITIET.DataPropertyName = "CHITIET";
            this.CHITIET.HeaderText = "Chi Tiết Sản Phẩm";
            this.CHITIET.Name = "CHITIET";
            this.CHITIET.Width = 250;
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "Giá";
            this.GIA.Name = "GIA";
            this.GIA.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txt_m);
            this.groupBox1.Controls.Add(this.txt_s);
            this.groupBox1.Controls.Add(this.txt_x);
            this.groupBox1.Controls.Add(this.txt_t);
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(this.txt_chitiet);
            this.groupBox1.Controls.Add(this.txt_tensanpham);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_chitiethd);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.txt_masp);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 160);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // txt_m
            // 
            this.txt_m.AutoSize = true;
            this.txt_m.Location = new System.Drawing.Point(801, 57);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(0, 16);
            this.txt_m.TabIndex = 18;
            // 
            // txt_s
            // 
            this.txt_s.AutoSize = true;
            this.txt_s.Location = new System.Drawing.Point(360, 32);
            this.txt_s.Name = "txt_s";
            this.txt_s.Size = new System.Drawing.Size(117, 16);
            this.txt_s.TabIndex = 16;
            this.txt_s.Text = "Chi Tiết Sản Phẩm";
            // 
            // txt_x
            // 
            this.txt_x.AutoSize = true;
            this.txt_x.Location = new System.Drawing.Point(449, 80);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(28, 16);
            this.txt_x.TabIndex = 15;
            this.txt_x.Text = "Giá";
            // 
            // txt_t
            // 
            this.txt_t.AutoSize = true;
            this.txt_t.Location = new System.Drawing.Point(31, 86);
            this.txt_t.Name = "txt_t";
            this.txt_t.Size = new System.Drawing.Size(94, 16);
            this.txt_t.TabIndex = 13;
            this.txt_t.Text = "Tên Sản Phẩm";
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(513, 77);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(147, 22);
            this.txt_gia.TabIndex = 11;
            // 
            // txt_chitiet
            // 
            this.txt_chitiet.Location = new System.Drawing.Point(513, 23);
            this.txt_chitiet.Name = "txt_chitiet";
            this.txt_chitiet.Size = new System.Drawing.Size(147, 22);
            this.txt_chitiet.TabIndex = 9;
            // 
            // txt_tensanpham
            // 
            this.txt_tensanpham.Location = new System.Drawing.Point(152, 77);
            this.txt_tensanpham.Name = "txt_tensanpham";
            this.txt_tensanpham.Size = new System.Drawing.Size(147, 22);
            this.txt_tensanpham.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // btn_chitiethd
            // 
            this.btn_chitiethd.Location = new System.Drawing.Point(585, 131);
            this.btn_chitiethd.Name = "btn_chitiethd";
            this.btn_chitiethd.Size = new System.Drawing.Size(75, 23);
            this.btn_chitiethd.TabIndex = 5;
            this.btn_chitiethd.Text = "Refesh";
            this.btn_chitiethd.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(77, 135);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(236, 135);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(152, 26);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(147, 22);
            this.txt_masp.TabIndex = 2;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(386, 137);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 509);
            this.Controls.Add(this.data_sanpham);
            this.Controls.Add(this.groupBox1);
            this.Name = "SanPham";
            this.Text = "QUẢN LÝ SẢN PHẨM";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_sanpham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_sanpham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txt_m;
        private System.Windows.Forms.Label txt_s;
        private System.Windows.Forms.Label txt_x;
        private System.Windows.Forms.Label txt_t;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_chitiet;
        private System.Windows.Forms.TextBox txt_tensanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_chitiethd;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHITIET;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
    }
}