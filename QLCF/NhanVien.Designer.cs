namespace QLCF
{
    partial class NhanVien
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
            this.btn_them = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt_ngay = new System.Windows.Forms.DateTimePicker();
            this.txt_m = new System.Windows.Forms.Label();
            this.txt_ta = new System.Windows.Forms.Label();
            this.txt_s = new System.Windows.Forms.Label();
            this.txt_d = new System.Windows.Forms.Label();
            this.txt_ngay = new System.Windows.Forms.Label();
            this.txt_t = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(77, 100);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(922, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Refesh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(663, 100);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(375, 100);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.dt_ngay);
            this.groupBox1.Controls.Add(this.txt_m);
            this.groupBox1.Controls.Add(this.txt_ta);
            this.groupBox1.Controls.Add(this.txt_s);
            this.groupBox1.Controls.Add(this.txt_d);
            this.groupBox1.Controls.Add(this.txt_ngay);
            this.groupBox1.Controls.Add(this.txt_t);
            this.groupBox1.Controls.Add(this.txt_matkhau);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_taikhoan);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_tennv);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 188);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // dt_ngay
            // 
            this.dt_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngay.Location = new System.Drawing.Point(150, 53);
            this.dt_ngay.Name = "dt_ngay";
            this.dt_ngay.Size = new System.Drawing.Size(200, 22);
            this.dt_ngay.TabIndex = 19;
            // 
            // txt_m
            // 
            this.txt_m.AutoSize = true;
            this.txt_m.Location = new System.Drawing.Point(801, 57);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(62, 16);
            this.txt_m.TabIndex = 18;
            this.txt_m.Text = "Mật khẩu";
            // 
            // txt_ta
            // 
            this.txt_ta.AutoSize = true;
            this.txt_ta.Location = new System.Drawing.Point(801, 19);
            this.txt_ta.Name = "txt_ta";
            this.txt_ta.Size = new System.Drawing.Size(89, 16);
            this.txt_ta.TabIndex = 17;
            this.txt_ta.Text = "Tên Tài khoản";
            // 
            // txt_s
            // 
            this.txt_s.AutoSize = true;
            this.txt_s.Location = new System.Drawing.Point(428, 19);
            this.txt_s.Name = "txt_s";
            this.txt_s.Size = new System.Drawing.Size(93, 16);
            this.txt_s.TabIndex = 16;
            this.txt_s.Text = "Số  Điện Thoại";
            // 
            // txt_d
            // 
            this.txt_d.AutoSize = true;
            this.txt_d.Location = new System.Drawing.Point(428, 60);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(50, 16);
            this.txt_d.TabIndex = 15;
            this.txt_d.Text = "Địa Chỉ";
            // 
            // txt_ngay
            // 
            this.txt_ngay.AutoSize = true;
            this.txt_ngay.Location = new System.Drawing.Point(44, 60);
            this.txt_ngay.Name = "txt_ngay";
            this.txt_ngay.Size = new System.Drawing.Size(68, 16);
            this.txt_ngay.TabIndex = 14;
            this.txt_ngay.Text = "Ngày Sinh";
            // 
            // txt_t
            // 
            this.txt_t.AutoSize = true;
            this.txt_t.Location = new System.Drawing.Point(31, 22);
            this.txt_t.Name = "txt_t";
            this.txt_t.Size = new System.Drawing.Size(93, 16);
            this.txt_t.TabIndex = 13;
            this.txt_t.Text = "Tên Nhân Viên";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(911, 53);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(129, 22);
            this.txt_matkhau.TabIndex = 12;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(522, 54);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(216, 22);
            this.txt_diachi.TabIndex = 11;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(911, 16);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(129, 22);
            this.txt_taikhoan.TabIndex = 10;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(522, 16);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(100, 22);
            this.txt_sdt.TabIndex = 9;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(150, 19);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(147, 22);
            this.txt_tennv.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.TENNV,
            this.NGAYSINH,
            this.DIACHI,
            this.SDT,
            this.TENTK,
            this.PASSWD});
            this.dataGridView1.Location = new System.Drawing.Point(12, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1086, 365);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã Nhân Viên";
            this.MANV.Name = "MANV";
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên Nhân Viên";
            this.TENNV.Name = "TENNV";
            this.TENNV.Width = 180;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày Sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 200;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            this.SDT.Width = 190;
            // 
            // TENTK
            // 
            this.TENTK.DataPropertyName = "TENTK";
            this.TENTK.HeaderText = "Tên Tài Khoản";
            this.TENTK.Name = "TENTK";
            this.TENTK.Width = 160;
            // 
            // PASSWD
            // 
            this.PASSWD.DataPropertyName = "PASSWD";
            this.PASSWD.HeaderText = "Password";
            this.PASSWD.Name = "PASSWD";
            this.PASSWD.Width = 140;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 538);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhanVien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txt_m;
        private System.Windows.Forms.Label txt_ta;
        private System.Windows.Forms.Label txt_s;
        private System.Windows.Forms.Label txt_d;
        private System.Windows.Forms.Label txt_ngay;
        private System.Windows.Forms.Label txt_t;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWD;
        private System.Windows.Forms.DateTimePicker dt_ngay;
    }
}

