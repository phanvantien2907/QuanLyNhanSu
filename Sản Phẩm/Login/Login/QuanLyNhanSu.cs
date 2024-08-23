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
using static ReaLTaiizor.Drawing.Poison.PoisonPaint;
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


namespace Login
{
    public partial class QuanLyNhanSu : Form
    {
        private string vaiTro;

        // khai báo thông tin kết nối 
        SqlConnection conn = null;
        public QuanLyNhanSu(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }

        private void HienThi()
        {
            string sqlSelect = "select * from tb_NhanVien";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            dtgv_DuLieu.DataSource = dt;

        }

        void PhanQuyen()
        {
            if (vaiTro != "admin")
            {
                btn_Them.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_TimKiem.Enabled = false;
                btn_Resert.Enabled = false;
                btn_XuatFileExcel.Enabled = false;
            }
        }

        private void QuanLyNhanSu_Load(object sender, EventArgs e)
        {
            string connstring = @"Data Source=PHANVANTIEN\PHANVANTIEN;Initial Catalog=QuanLyNhanSu;Integrated Security=True;";
            conn = new SqlConnection(connstring);
            conn.Open();
            HienThi();
            PhanQuyen();
        }

        private void QuanLyNhanSu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // khi đóng form thì kết nối đến csdl sẽ đóng 
            conn.Close();
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                // hàm kiểm tra người dùng nhập đầy đủ thông tin chưa
                if (string.IsNullOrEmpty(txt_HoTen.Text) ||
                    string.IsNullOrEmpty(txt_MaChucVu.Text) ||
                    string.IsNullOrEmpty(txt_MaPhongBan.Text) ||
                    string.IsNullOrEmpty(txt_MaTDHV.Text) ||
                    string.IsNullOrEmpty(txt_PhongBan.Text) ||
                    string.IsNullOrEmpty(txt_QueQuan.Text) ||
                    string.IsNullOrEmpty(txt_SoDienThoai.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // hàm check trùng mã nhân viên không
                string checkQuery = "SELECT COUNT(*) FROM tb_NhanVien WHERE MaNV = @MaNV";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("MaNV", txt_MaNhanVien.Text);
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Không được nhập trùng Mã nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // hàm check trùng mã chức vụ không
                checkCmd.CommandText = "SELECT COUNT(*) FROM tb_NhanVien WHERE Machucvu = @Machucvu";
                checkCmd.Parameters.AddWithValue("Machucvu", txt_MaChucVu.Text);
                count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Không được nhập trùng Mã chức vụ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // hàm check trùng MaPB không
                checkCmd.CommandText = "SELECT COUNT(*) FROM tb_NhanVien WHERE MaPB = @MaPB";
                checkCmd.Parameters.AddWithValue("MaPB", txt_MaPhongBan.Text);
                count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Không được nhập trùng Mã phòng ban!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // hàm check trùng hợp đồng lao động
                checkCmd.CommandText = "SELECT COUNT(*) FROM tb_NhanVien WHERE HopDongLaoDong = @HopDongLaoDong";
                checkCmd.Parameters.AddWithValue("HopDongLaoDong", txt_HopDongLaoDong.Text);
                count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Không được nhập trùng Mã hợp đồng lao động!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // hàm check trùng MATDHV
                checkCmd.CommandText = "SELECT COUNT(*) FROM tb_NhanVien WHERE MaTDHV = @MaTDHV";
                checkCmd.Parameters.AddWithValue("MaTDHV", txt_MaTDHV.Text);
                count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Không được nhập trùng Mã trình độ học vấn!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thêm dữ liệu này vào không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string SQlInSert = "INSERT INTO tb_NhanVien (HoTen, GioiTinh, QueQuan, NgaySinh, SoDienThoai, Machucvu, MaPB, TrinhDoHocVan, PhongBan, HopDongLaoDong, MaTDHV, ChuyenNganh) VALUES (@HoTen, @GioiTinh, @QueQuan, @NgaySinh, @SoDienThoai, @Machucvu, @MaPB, @TrinhDoHocVan, @PhongBan, @HopDongLaoDong, @MaTDHV, @ChuyenNganh)";
                    SqlCommand cmd = new SqlCommand(SQlInSert, conn);
                    cmd.Parameters.AddWithValue("HoTen", txt_HoTen.Text);
                    cmd.Parameters.AddWithValue("NgaySinh", DateTime.Parse(txt_NgaySinh.Text));
                    cmd.Parameters.AddWithValue("GioiTinh", combobox_GioiTinh.Text);
                    cmd.Parameters.AddWithValue("QueQuan", txt_QueQuan.Text);
                    cmd.Parameters.AddWithValue("SoDienThoai", txt_SoDienThoai.Text);
                    cmd.Parameters.AddWithValue("Machucvu", txt_MaChucVu.Text);
                    cmd.Parameters.AddWithValue("MaPB", txt_MaPhongBan.Text);
                    cmd.Parameters.AddWithValue("TrinhDoHocVan", combobox_Trinhdohocvan.Text);
                    cmd.Parameters.AddWithValue("PhongBan", txt_PhongBan.Text);
                    cmd.Parameters.AddWithValue("HopDongLaoDong", txt_HopDongLaoDong.Text);
                    cmd.Parameters.AddWithValue("MaTDHV", txt_MaTDHV.Text);
                    cmd.Parameters.AddWithValue("ChuyenNganh", txt_ChuyenNganh.Text);
                    // đoạn này là hàm để kiểm tra đã thêm thành công hay chưa
                    int rowsAffected = cmd.ExecuteNonQuery();
                    // kiểm tra xem thêm thành công hay chưa
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi();
                    }
                    else { MessageBox.Show("Thêm dữ liệu thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { return; }
                    
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ!: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                if (string.IsNullOrEmpty(txt_HoTen.Text) ||
                    string.IsNullOrEmpty(txt_MaChucVu.Text) ||
                    string.IsNullOrEmpty(txt_MaNhanVien.Text) ||
                    string.IsNullOrEmpty(txt_MaPhongBan.Text) ||
                    string.IsNullOrEmpty(txt_MaTDHV.Text) ||
                    string.IsNullOrEmpty(txt_PhongBan.Text) ||
                    string.IsNullOrEmpty(txt_QueQuan.Text) ||
                    txt_NgaySinh.Value == DateTimePicker.MinimumDateTime ||
                    string.IsNullOrEmpty(txt_SoDienThoai.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa cái này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string SQlUpDate = "UPDATE tb_NhanVien SET HoTen = @HoTen, GioiTinh = @GioiTinh, QueQuan = @QueQuan, NgaySinh = @NgaySinh, SoDienThoai = @SoDienThoai, Machucvu = @Machucvu, MaPB = @MaPB, TrinhDoHocVan = @TrinhDoHocVan, PhongBan = @PhongBan, HopDongLaoDong = @HopDongLaoDong, MaTDHV = @MaTDHV, ChuyenNganh = @ChuyenNganh WHERE MaNV = @MaNV";
                    SqlCommand cmd = new SqlCommand(SQlUpDate, conn);
                    cmd.Parameters.AddWithValue("MaNV", txt_MaNhanVien.Text);
                    cmd.Parameters.AddWithValue("HoTen", txt_HoTen.Text);
                    cmd.Parameters.AddWithValue("GioiTinh", combobox_GioiTinh.Text);
                    cmd.Parameters.AddWithValue("QueQuan", txt_QueQuan.Text);
                    cmd.Parameters.AddWithValue("NgaySinh", txt_NgaySinh.Value);
                    cmd.Parameters.AddWithValue("SoDienThoai", txt_SoDienThoai.Text);
                    cmd.Parameters.AddWithValue("Machucvu", txt_MaChucVu.Text);
                    cmd.Parameters.AddWithValue("MaPB", txt_MaPhongBan.Text);
                    cmd.Parameters.AddWithValue("TrinhDoHocVan", combobox_Trinhdohocvan.Text);
                    cmd.Parameters.AddWithValue("PhongBan", txt_PhongBan.Text);
                    cmd.Parameters.AddWithValue("HopDongLaoDong", txt_HopDongLaoDong.Text);
                    cmd.Parameters.AddWithValue("MaTDHV", txt_MaTDHV.Text);
                    cmd.Parameters.AddWithValue("ChuyenNganh", txt_ChuyenNganh.Text);
                    //  hàm để kiểm tra đã sửa thành công hay chưa
                    int rowsAffected = cmd.ExecuteNonQuery();
                    // kiểm tra xem thêm thành công hay chưa
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sửa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi();
                    }
                    else { MessageBox.Show("Sửa dữ liệu thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ!: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                if (string.IsNullOrEmpty(txt_HoTen.Text) ||
                    string.IsNullOrEmpty(txt_MaChucVu.Text) ||
                    string.IsNullOrEmpty(txt_MaNhanVien.Text) ||
                    string.IsNullOrEmpty(txt_MaPhongBan.Text) ||
                    string.IsNullOrEmpty(txt_MaTDHV.Text) ||
                    string.IsNullOrEmpty(txt_PhongBan.Text) ||
                    string.IsNullOrEmpty(txt_QueQuan.Text) ||
                    txt_NgaySinh.Value == DateTimePicker.MinimumDateTime ||
                    string.IsNullOrEmpty(txt_SoDienThoai.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa cái này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string sqlDelete = "DELETE FROM tb_NhanVien WHERE MaNV = @MaNV";
                    SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                    cmd.Parameters.AddWithValue("MaNV", txt_MaNhanVien.Text);
                    cmd.Parameters.AddWithValue("HoTen", txt_HoTen.Text);
                    cmd.Parameters.AddWithValue("GioiTinh", combobox_GioiTinh.Text);
                    cmd.Parameters.AddWithValue("QueQuan", txt_QueQuan.Text);
                    cmd.Parameters.AddWithValue("NgaySinh", txt_NgaySinh.Value);
                    cmd.Parameters.AddWithValue("SoDienThoai", txt_SoDienThoai.Text);
                    cmd.Parameters.AddWithValue("Machucvu", txt_MaChucVu.Text);
                    cmd.Parameters.AddWithValue("MaPB", txt_MaPhongBan.Text);
                    cmd.Parameters.AddWithValue("TrinhDoHocVan", combobox_Trinhdohocvan.Text);
                    cmd.Parameters.AddWithValue("PhongBan", txt_PhongBan.Text);
                    cmd.Parameters.AddWithValue("HopDongLaoDong", txt_HopDongLaoDong.Text);
                    cmd.Parameters.AddWithValue("MaTDHV", txt_MaTDHV.Text);
                    cmd.Parameters.AddWithValue("ChuyenNganh", txt_ChuyenNganh.Text);
                    //  hàm để kiểm tra đã xóa thành công hay chưa
                    int rowsAffected = cmd.ExecuteNonQuery();
                    // kiểm tra xem xóa thành công hay chưa
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi();
                    }
                    else { MessageBox.Show("Xóa dữ liệu thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ!: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                if (!string.IsNullOrEmpty(txt_TimKiem.Text))
                {
                    // Xóa dữ liệu hiển thị trên DataGridView trước khi thực hiện tìm kiếm mới
                    dtgv_DuLieu.DataSource = null;
                    // câu truy vấn để tìm kiếm dữ liệu
                    string sqltimKiem = "SELECT * FROM tb_NhanVien WHERE MaNV LIKE @MaNV OR HoTen LIKE @HoTen OR GioiTinh LIKE @GioiTinh OR QueQuan LIKE @QueQuan OR NgaySinh LIKE @NgaySinh OR SoDienThoai LIKE @SoDienThoai OR MaPB LIKE @MaPB OR Machucvu LIKE @Machucvu OR TrinhDoHocVan LIKE @TrinhDoHocVan OR PhongBan LIKE @PhongBan OR HopDongLaoDong LIKE @HopDongLaoDong OR ChuyenNganh LIKE @ChuyenNganh";
                    // Tạo SqlCommand và thêm tham số cho câu truy vấn
                    SqlCommand cmd = new SqlCommand(sqltimKiem, conn);
                    cmd.Parameters.AddWithValue("@MaNV", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@HoTen", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@GioiTinh", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@QueQuan", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@NgaySinh", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@SoDienThoai", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@MaPB", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@Machucvu", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@TrinhDoHocVan", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@PhongBan", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@HopDongLaoDong", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@ChuyenNganh", "%" + txt_TimKiem.Text + "%");
                    // Thực hiện truy vấn và đổ dữ liệu vào DataTable
                    SqlDataReader dr = cmd.ExecuteReader();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Load(dr);
                    // Hiển thị dữ liệu lên DataGridView    
                    dtgv_DuLieu.DataSource = dt;
                }
                else
                {
                    // Nếu textBox tìm kiếm trống, hiển thị thông báo
                    MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ!: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_Resert_Click_2(object sender, EventArgs e)
        {
            txt_MaNhanVien.Text = "";
            txt_HoTen.Text = "";
            combobox_GioiTinh.ResetText();
            txt_QueQuan.Text = "";
            txt_NgaySinh.Value = DateTime.Now;
            txt_SoDienThoai.Text = "";
            txt_MaChucVu.Text = "";
            txt_MaPhongBan.Text = "";
            combobox_Trinhdohocvan.ResetText();
            txt_PhongBan.Text = "";
            txt_HopDongLaoDong.Text = "";
            txt_MaTDHV.Text = "";
            txt_ChuyenNganh.Text = "";

        }

            // khởi tạo phương thức xuất file 
            private void XuatFile(string path)
            {
                Excel.Application application = new Excel.Application();
                application.Application.Workbooks.Add(Type.Missing);

            //thêm tiêu đề
            application.Cells[1, 1] = "DANH SÁCH NHÂN SỰ";
            application.Cells[1, 1].Font.Name = "Times New Roman";
            application.Cells[1, 1].Font.Size = 17;
            application.get_Range("A1", "M1").Merge();
            application.get_Range("A1", "M1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            for (int i = 0; i <dtgv_DuLieu.Columns.Count; i++) {
                application.Cells[3, i + 1] = dtgv_DuLieu.Columns[i].HeaderText;
            }

                // Căn giữa
                application.Cells.Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                // Phông chữ Times New Roman, cỡ chữ 12
                application.Cells.Style.Font.Name = "Times New Roman";
                application.Cells.Style.Font.Size = 12;

            // đặt độ rộng
            application.Columns[1].ColumnWidth = 8.33;
            application.Columns[2].ColumnWidth = 20.67;
            application.Columns[3].ColumnWidth = 9.67;
            application.Columns[4].ColumnWidth = 25.33;
            application.Columns[5].ColumnWidth = 11.78;
            application.Columns[6].ColumnWidth = 14.56;
            application.Columns[7].ColumnWidth = 11.56;
            application.Columns[8].ColumnWidth = 7.56;
            application.Columns[9].ColumnWidth = 16.89;
            application.Columns[10].ColumnWidth = 10.67;
            application.Columns[11].ColumnWidth = 19.89;
            application.Columns[12].ColumnWidth = 10.78;
            application.Columns[13].ColumnWidth = 28.78;

            for (int i = 0; i<dtgv_DuLieu.Rows.Count; i++)
            {
                for(int j = 0; j<dtgv_DuLieu.Columns.Count;j++)
                {
                    application.Cells[i + 4, j + 1] = dtgv_DuLieu.Rows[i].Cells[j].Value;
                }
            }

            for (int i = 1; i <= dtgv_DuLieu.Rows.Count + 3; i++)
            {
                for (int j = 1; j <= dtgv_DuLieu.Columns.Count; j++)
                {
                    Excel.Range range = (Excel.Range)application.Cells[i, j];
                    Excel.Borders borders = range.Borders;
                    borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                }
            }

            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
            }

          private void btn_XuatFileExcel_Click(object sender, EventArgs e)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xuất File không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Xuất File Excel";
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XuatFile(saveFileDialog.FileName);
                        MessageBox.Show("Xuất File Thành Công!","Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Xuất File Không Thành Công\n!"+ex.Message);
                    }
                }
                }
            }

        private void dtgv_DuLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < dtgv_DuLieu.Rows.Count)
            {
                DataGridViewRow selectedRow = dtgv_DuLieu.Rows[rowIndex];
                txt_MaNhanVien.Text = selectedRow.Cells["MaNV"].Value.ToString();
                txt_HoTen.Text = selectedRow.Cells["HoTen"].Value.ToString();
                combobox_GioiTinh.SelectedItem = selectedRow.Cells["GioiTinh"].Value.ToString();
                txt_QueQuan.Text = selectedRow.Cells["QueQuan"].Value.ToString();
                txt_NgaySinh.Text = selectedRow.Cells["NgaySinh"].Value.ToString();
                txt_SoDienThoai.Text = selectedRow.Cells["SoDienThoai"].Value.ToString();
                txt_MaChucVu.Text = selectedRow.Cells["Machucvu"].Value.ToString();
                txt_MaPhongBan.Text = selectedRow.Cells["MaPB"].Value.ToString();
                combobox_Trinhdohocvan.Text = selectedRow.Cells["TrinhDoHocVan"].Value.ToString();
                txt_PhongBan.Text = selectedRow.Cells["PhongBan"].Value.ToString();
                txt_HopDongLaoDong.Text = selectedRow.Cells["HopDongLaoDong"].Value.ToString();
                txt_MaTDHV.Text = selectedRow.Cells["MaTDHV"].Value.ToString();
                txt_PhongBan.Text = selectedRow.Cells["PhongBan"].Value.ToString();
                txt_ChuyenNganh.Text = selectedRow.Cells["ChuyenNganh"].Value.ToString();
            }
        }
    }
 }