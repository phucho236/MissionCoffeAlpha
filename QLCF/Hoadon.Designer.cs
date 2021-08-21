namespace QLCF
{
    partial class Hoadon
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
            this.data_hoadon = new System.Windows.Forms.DataGridView();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYMUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUTHICH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tongTien_txt = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.dt_ngaymua = new System.Windows.Forms.DateTimePicker();
            this.txt_chuthi = new System.Windows.Forms.Label();
            this.txt_s = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.Label();
            this.txt_ngay = new System.Windows.Forms.Label();
            this.txt_t = new System.Windows.Forms.Label();
            this.txt_chuthich = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_chitiethd = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_hoadon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_hoadon
            // 
            this.data_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.MANV,
            this.MAKH,
            this.TONGTIEN,
            this.NGAYMUA,
            this.CHUTHICH});
            this.data_hoadon.Location = new System.Drawing.Point(21, 204);
            this.data_hoadon.Name = "data_hoadon";
            this.data_hoadon.Size = new System.Drawing.Size(1086, 319);
            this.data_hoadon.TabIndex = 10;
            this.data_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_hoadon_CellClick);
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "Mã Hoá Đơn";
            this.MAHD.Name = "MAHD";
            this.MAHD.Width = 150;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã Nhân Viên";
            this.MANV.Name = "MANV";
            this.MANV.Width = 150;
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã Khách Hàng";
            this.MAKH.Name = "MAKH";
            this.MAKH.Width = 150;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng Tiền";
            this.TONGTIEN.Name = "TONGTIEN";
            // 
            // NGAYMUA
            // 
            this.NGAYMUA.DataPropertyName = "NGAYMUA";
            this.NGAYMUA.HeaderText = "Ngày Mua";
            this.NGAYMUA.Name = "NGAYMUA";
            this.NGAYMUA.Width = 190;
            // 
            // CHUTHICH
            // 
            this.CHUTHICH.DataPropertyName = "CHUTHICH";
            this.CHUTHICH.HeaderText = "Chú Thích";
            this.CHUTHICH.Name = "CHUTHICH";
            this.CHUTHICH.Width = 330;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tongTien_txt);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.txt_timkiem);
            this.groupBox1.Controls.Add(this.dt_ngaymua);
            this.groupBox1.Controls.Add(this.txt_chuthi);
            this.groupBox1.Controls.Add(this.txt_s);
            this.groupBox1.Controls.Add(this.txt_x);
            this.groupBox1.Controls.Add(this.txt_ngay);
            this.groupBox1.Controls.Add(this.txt_t);
            this.groupBox1.Controls.Add(this.txt_chuthich);
            this.groupBox1.Controls.Add(this.txt_makh);
            this.groupBox1.Controls.Add(this.txt_manv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_chitiethd);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.txt_mahd);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 188);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // tongTien_txt
            // 
            this.tongTien_txt.AutoSize = true;
            this.tongTien_txt.Location = new System.Drawing.Point(393, 95);
            this.tongTien_txt.Name = "tongTien_txt";
            this.tongTien_txt.Size = new System.Drawing.Size(0, 16);
            this.tongTien_txt.TabIndex = 20;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(6, 159);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(87, 160);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(251, 22);
            this.txt_timkiem.TabIndex = 9;
            // 
            // dt_ngaymua
            // 
            this.dt_ngaymua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaymua.Location = new System.Drawing.Point(390, 19);
            this.dt_ngaymua.Name = "dt_ngaymua";
            this.dt_ngaymua.Size = new System.Drawing.Size(200, 22);
            this.dt_ngaymua.TabIndex = 19;
            // 
            // txt_chuthi
            // 
            this.txt_chuthi.AutoSize = true;
            this.txt_chuthi.Location = new System.Drawing.Point(316, 63);
            this.txt_chuthi.Name = "txt_chuthi";
            this.txt_chuthi.Size = new System.Drawing.Size(63, 16);
            this.txt_chuthi.TabIndex = 17;
            this.txt_chuthi.Text = "Chú thích";
            // 
            // txt_s
            // 
            this.txt_s.AutoSize = true;
            this.txt_s.Location = new System.Drawing.Point(31, 96);
            this.txt_s.Name = "txt_s";
            this.txt_s.Size = new System.Drawing.Size(101, 16);
            this.txt_s.TabIndex = 16;
            this.txt_s.Text = "Mã Khách Hàng";
            // 
            // txt_x
            // 
            this.txt_x.AutoSize = true;
            this.txt_x.Location = new System.Drawing.Point(316, 96);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(64, 16);
            this.txt_x.TabIndex = 15;
            this.txt_x.Text = "Tổng Tiền";
            // 
            // txt_ngay
            // 
            this.txt_ngay.AutoSize = true;
            this.txt_ngay.Location = new System.Drawing.Point(313, 24);
            this.txt_ngay.Name = "txt_ngay";
            this.txt_ngay.Size = new System.Drawing.Size(67, 16);
            this.txt_ngay.TabIndex = 14;
            this.txt_ngay.Text = "Ngày mua";
            // 
            // txt_t
            // 
            this.txt_t.AutoSize = true;
            this.txt_t.Location = new System.Drawing.Point(31, 60);
            this.txt_t.Name = "txt_t";
            this.txt_t.Size = new System.Drawing.Size(90, 16);
            this.txt_t.TabIndex = 13;
            this.txt_t.Text = "Mã Nhân Viên";
            // 
            // txt_chuthich
            // 
            this.txt_chuthich.Location = new System.Drawing.Point(390, 57);
            this.txt_chuthich.Name = "txt_chuthich";
            this.txt_chuthich.Size = new System.Drawing.Size(204, 22);
            this.txt_chuthich.TabIndex = 10;
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(150, 93);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(147, 22);
            this.txt_makh.TabIndex = 9;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(150, 57);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(147, 22);
            this.txt_manv.TabIndex = 8;
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
            // btn_chitiethd
            // 
            this.btn_chitiethd.Location = new System.Drawing.Point(702, 159);
            this.btn_chitiethd.Name = "btn_chitiethd";
            this.btn_chitiethd.Size = new System.Drawing.Size(186, 23);
            this.btn_chitiethd.TabIndex = 5;
            this.btn_chitiethd.Text = "Show chi tiết hoá đơn";
            this.btn_chitiethd.UseVisualStyleBackColor = true;
            this.btn_chitiethd.Click += new System.EventHandler(this.btn_chitiethd_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(734, 37);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(85, 25);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(841, 37);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(90, 25);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(150, 21);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(147, 22);
            this.txt_mahd.TabIndex = 2;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(946, 37);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(92, 25);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(894, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Xuất hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 526);
            this.Controls.Add(this.data_hoadon);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hoadon";
            this.Text = "Hoadon";
            this.Load += new System.EventHandler(this.Hoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_hoadon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_hoadon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label txt_chuthi;
        private System.Windows.Forms.Label txt_s;
        private System.Windows.Forms.Label txt_x;
        private System.Windows.Forms.Label txt_t;
        private System.Windows.Forms.TextBox txt_chuthich;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_chitiethd;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.DateTimePicker dt_ngaymua;
        private System.Windows.Forms.Label txt_ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYMUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUTHICH;
        private System.Windows.Forms.Label tongTien_txt;
        private System.Windows.Forms.Button button1;
    }
}