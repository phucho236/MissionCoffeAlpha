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
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace QLCF
{
    public partial class Hoadon : Form
    {
        public Hoadon()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(connection.getconnect());
        public static int idhd = 0;
        DangNhap dangnhap = new DangNhap();
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
        public void ketnoi()
        {
            cnn.Open();
            string sql = "Select * from HOADON";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            data_hoadon.DataSource = dt;
        }
        

        public int getmahd()
        {
            return idhd;
        }

        private void btn_chitiethd_Click(object sender, EventArgs e)
        {
           if(idhd == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
                return;
            }
            CTHD ct = new CTHD(this);
            ct.Show();
        }
  
        private void Hoadon_Load(object sender, EventArgs e)
        {
            ketnoi();
            loadcbbKH();
        }

    
        public void timkiem()
        {
            string queryString = "Select * from HOADON";

            var l = new List<Model.tbl_sanpham>();
            SqlCommand command = new SqlCommand(queryString, cnn);
            cnn.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    var r = new Model.tbl_sanpham();
                    r.MAHD = reader["MAHD"] is DBNull ? "" : reader["MAHD"].ToString();
                    r.MANV = reader["MANV"] is DBNull ? "" : reader["MANV"].ToString();
                    r.MAKH = reader["MAKH"] is DBNull ? "" : reader["MAKH"].ToString();
                    r.TONGTIEN = double.Parse(reader["TONGTIEN"].ToString());
                    r.NGAYMUA = DateTime.Parse(reader["NGAYMUA"].ToString());
                    r.CHUTHICH = reader["CHUTHICH"] is DBNull ? "" : reader["CHUTHICH"].ToString();
                    l.Add(r);
                }
            }
            finally
            {
                reader.Close();
            }

            var data = (from a in l
                        where RemoveUnicode(a.MAHD).ToUpper().Contains(RemoveUnicode(txt_timkiem.Text.ToString()).ToUpper())
                        select a).ToList();
            data_hoadon.DataSource = data;
            cnn.Close();

        }
        public static string RemoveUnicode(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
            "đ",
            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
            "í","ì","ỉ","ĩ","ị",
            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
            "ý","ỳ","ỷ","ỹ","ỵ",};

            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
            "d",
            "e","e","e","e","e","e","e","e","e","e","e",
            "i","i","i","i","i",
            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
            "u","u","u","u","u","u","u","u","u","u","u",
            "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
       public List<Model.KHACHHANG> l = new List<Model.KHACHHANG>();
        public void loadcbbKH()
        {
            
            open();
            ///////
            string queryString = "Select * from KHACHHANG";
            SqlCommand command = new SqlCommand(queryString, cnn);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    var r = new Model.KHACHHANG();
                    r.MAKH = reader["MAKH"] is DBNull ? "" : reader["MAKH"].ToString();
                    r.TENKH = reader["TENKH"] is DBNull ? "" : reader["TENKH"].ToString();
                    r.SDT = reader["SDT"] is DBNull ? "" : reader["SDT"].ToString();
                    r.EMAIL = reader["EMAIL"] is DBNull ? "" : reader["EMAIL"].ToString();
                    l.Add(r);
                }
            }
            finally
            {
                reader.Close();
            }
           
            cbb_khachhang.DataSource = l;
            cbb_khachhang.DisplayMember = "TENKH";
            cbb_khachhang.ValueMember = "MAKH";
            cbb_khachhang.SelectedIndex = -1;
            close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
               
                cnn.Open();
                string sql = @"Insert Into HOADON VALUES (N'" + dangnhap.getUserModel().MANV + @"','" + cbb_khachhang.SelectedValue + @"','" + DBNull.Value + @"','" + dt_ngaymua.Value + @"',N'" + txt_chuthich.Text + @"')";

                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MessageBox.Show(" Thêm Thành công");
                cnn.Close();
                cleanData();
                ketnoi();
            }
            catch

            {
                MessageBox.Show(" lỖI");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {

                cnn.Open();
                string sql = @"Delete FROM HOADON  Where (MAHD = '" + idhd + "')";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MessageBox.Show("Xoá thành công !!!");
                cnn.Close();
                cleanData();

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
                string sql = @"update HOADON set MANV= '" + dangnhap.getUserModel().MANV + "' ,MAKH= '" + cbb_khachhang.SelectedValue + "' ,NGAYMUA='" + dt_ngaymua.Value + "',CHUTHICH= N'" + txt_chuthich.Text.ToString() + "' where  MAHD = '" + idhd + "'";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();

                MessageBox.Show("Thành công");
                cnn.Close();

                ketnoi();
            }
            catch
            {
                MessageBox.Show("Thất bại mời nhập lại");
            }
        }

        private void data_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            idhd = int.Parse(data_hoadon.Rows[numrow].Cells[0].Value.ToString());
           
            cbb_khachhang.SelectedValue = data_hoadon.Rows[numrow].Cells[2].Value.ToString();
            tongTien_txt.Text = data_hoadon.Rows[numrow].Cells[3].Value.ToString();
            dt_ngaymua.Text = data_hoadon.Rows[numrow].Cells[4].Value.ToString();
            txt_chuthich.Text = data_hoadon.Rows[numrow].Cells[5].Value.ToString();
        }
        void cleanData()
        {
           
            txt_chuthich.Clear();
     
            cbb_khachhang.SelectedIndex = -1;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            timkiem();
        }

        private void cbb_khachhang_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btn_xhd_Click(object sender, EventArgs e)
        {

            if(idhd ==  0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
                return;
            }
            List<Model.CTHOADON> listCTHD = getCTHD(idhd.ToString());
            Model.KHACHHANG modelKh =new Model.KHACHHANG();

            foreach(var item in l)
            {
                if(item.MAKH.Trim().Equals(cbb_khachhang.SelectedValue.ToString().Trim())  )
                {
                    modelKh = item;
                }
            }


            CreateDocument(modelKh, dt_ngaymua.Text ,tongTien_txt.Text, listCTHD);

        }
        List<Model.CTHOADON> getCTHD(string id)
        {
            var listCTHDTMP = new List<Model.CTHOADON>();
            open();
            ///////
            string queryString = "Select * from CTHOADON where MAHD ='" + id + "'";
            SqlCommand command = new SqlCommand(queryString, cnn);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    var r = new Model.CTHOADON();
                    r.MAHD = reader["MAHD"] is DBNull ? "" : reader["MAHD"].ToString();
                    r.MASP = reader["MASP"] is DBNull ? "" : reader["MASP"].ToString();
                    r.SOLUONG = reader["SOLUONG"] is DBNull ? 0 : int.Parse(reader["SOLUONG"].ToString());
                    r.GIA = reader["GIA"] is DBNull ? 0 : int.Parse(reader["GIA"].ToString());
                    r.THANHTIEN = reader["THANHTIEN"] is DBNull ? 0 : int.Parse(reader["THANHTIEN"].ToString());
                    listCTHDTMP.Add(r);
                }
            }
            finally
            {
                reader.Close();
            }
 
            close();
            return listCTHDTMP;
        }
        private void CreateDocument(Model.KHACHHANG modelKh,string ngayMua, string tongHD, List<Model.CTHOADON> listCTHD )
        {
            //try
            //{
                //Create an instance for word app  
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application  
                winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.  
                winword.Visible = false;

                //Create a missing variable for missing value  
                object missing = System.Reflection.Missing.Value;

                //Create a new document  
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                //Add header into the document  
                foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                {
                    //Get the header range and add the header details.  
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                    headerRange.Font.Size = 24;
                    headerRange.Text = "Mission Coffe Alpha";
                }

                //Add the footers into the document  
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.  
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 12;
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Text = "Cám ơn và hẹn gặp lại";
                }

                //adding text to document  
                //document.Content.SetRange(0, 0);
                //document.Content.Text = "Content " + Environment.NewLine;


                //style
                object styleHeading1 = "Heading 1";
                object styleNormal = "Normal";

                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                para1.Range.set_Style(ref styleNormal);
                para1.Range.Text = "Khách hàng: " + modelKh.TENKH + "  ";
                para1.Range.InsertParagraphAfter();

                Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                para2.Range.set_Style(ref styleNormal);
                para2.Range.Text = "SĐT: " + modelKh.SDT + "  ";
                para2.Range.InsertParagraphAfter();

                Microsoft.Office.Interop.Word.Paragraph para3 = document.Content.Paragraphs.Add(ref missing);
                para3.Range.set_Style(ref styleNormal);
                para3.Range.Text = "EMAIL: " + modelKh.EMAIL + "  ";
                para3.Range.InsertParagraphAfter();


                Microsoft.Office.Interop.Word.Paragraph para4 = document.Content.Paragraphs.Add(ref missing);
                para4.Range.set_Style(ref styleNormal);
                para4.Range.Text = "Ngày Đến: " + ngayMua + "  ";
                para4.Range.InsertParagraphAfter();

                List<string> thuoctinh = new List<string> { "Thức uốn", "Số lượng", " Tổng tiền" };
                //Create a 5X5 table and insert some dummy record  
                // Số dòng nhân với số thuộc tính
                Word.Table firstTable = document.Tables.Add(para1.Range, listCTHD.Count()+1, thuoctinh.Count, ref missing, ref missing);

                firstTable.Borders.Enable = 1;
                foreach (Word.Row row in firstTable.Rows)
                {
                    foreach (Word.Cell cell in row.Cells)
                    {
                        //Header row  
                        if (cell.RowIndex == 1)
                        {
   
                                cell.Range.Text = thuoctinh[cell.ColumnIndex -1];

            
                            cell.Range.Font.Bold = 1;
                                //other format properties goes here  
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                              
                                cell.Shading.BackgroundPatternColor = Word.WdColor.wdColorGray25;
                                //Center alignment for the Header cells  
                                cell.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                          

                        }
                        //Data row  
                        else
                        {
                            if(cell.ColumnIndex == 1)
                            cell.Range.Text = listCTHD[cell.RowIndex-2].MASP ;
                            if (cell.ColumnIndex == 2)
                                cell.Range.Text = listCTHD[cell.RowIndex-2].SOLUONG.ToString();
                            if (cell.ColumnIndex == 3)
                                cell.Range.Text = listCTHD[cell.RowIndex-2].THANHTIEN.ToString();
                        }
                    }
                }
                Microsoft.Office.Interop.Word.Paragraph para5 = document.Content.Paragraphs.Add(ref missing);
                para5.Range.set_Style(ref styleHeading1);
                para5.Range.Text = "Thành tiền: " + tongHD + "  ";
                para5.Range.InsertParagraphAfter();

                //Save the document  
                object filename = @"c:\temp1.docx";
                document.SaveAs2(ref filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                MessageBox.Show("Document created successfully !");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
