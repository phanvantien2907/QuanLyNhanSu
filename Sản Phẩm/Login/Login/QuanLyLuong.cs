using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class QuanLyLuong : Form
    {
        private string vaiTro;
        // khai báo thông tin kết nối 
        SqlConnection conn = null;
        public QuanLyLuong(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }
        // gọi 1 hàm để dùng cho sau này
        private void HienThi()
        {
            string sqlSelect = "select * from tb_QuanLyLuong";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
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
            }
        }

        private void QuanLyLuong_Load(object sender, EventArgs e)
        {
            // khai báo thông tin kết nối tới csdl
            string connstring = @"Data Source=PHANVANTIEN\PHANVANTIEN;Initial Catalog=QuanLyNhanSu;Integrated Security=True;";
            conn = new SqlConnection(connstring);
            conn.Open();
            HienThi();
            PhanQuyen();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // bắt ngoại lệ
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                // hàm kiểm tra người dùng nhập đầy đủ thông tin chưa
                if (string.IsNullOrEmpty(txt_Hoten.Text) || string.IsNullOrEmpty(txt_sotienluong.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // hàm check trùng Mã Nhân Viên
                string checkQuery = "SELECT COUNT(*) FROM tb_QuanLyLuong WHERE MaNV = @MaNV";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("MaNV", txt_Machucvu.Text);
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Không được nhập trùng Mã nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // hàm check trùng mã chức vụ không
                checkCmd.CommandText = "SELECT COUNT(*) FROM tb_QuanLyLuong WHERE MaChucVu = @MaChucVu";
                checkCmd.Parameters.AddWithValue("MaChucVu", txt_Machucvu.Text);
                count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Không được nhập trùng Mã chức vụ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // kiểm tra xem có chắc chắn muốn thêm dữ liệu vào không ? 
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thêm dữ liệu này vào không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string SQlInSert = "INSERT INTO tb_QuanLyLuong  (MaNV,MaChucVu,HoTen,ChucVu,SoTienLuong,NgayNhanLuong)  VALUES  (@MaNV,@MaChucVu,@HoTen,@ChucVu,@SoTienLuong,@NgayNhanLuong)";
                    SqlCommand cmd = new SqlCommand(SQlInSert, conn);
                    cmd.Parameters.AddWithValue("HoTen", txt_Hoten.Text);
                    cmd.Parameters.AddWithValue("MaNV", txt_MaNV.Text);
                    cmd.Parameters.AddWithValue("MaChucVu", txt_Machucvu.Text);
                    cmd.Parameters.AddWithValue("SoTienLuong", txt_sotienluong.Text);
                    cmd.Parameters.AddWithValue("ChucVu", txt_chucvu.Text);
                    cmd.Parameters.AddWithValue("NgayNhanLuong", dtpc_ngaynhanluong.Value);

                    // đoạn này là hàm để kiểm tra đã thêm thành công hay chưa
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi();
                    }
                    else { MessageBox.Show("Thêm dữ liệu thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dtgv_DuLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy dữ liệu đc chọn
            // Lấy ra chỉ số của hàng được chọn
            int rowIndex = e.RowIndex;

            // Kiểm tra nếu chỉ số hàng hợp lệ
            if (rowIndex >= 0 && rowIndex < dtgv_DuLieu.Rows.Count)
            {
                // Lấy dòng dữ liệu tương ứng với chỉ số hàng
                DataGridViewRow selectedRow = dtgv_DuLieu.Rows[rowIndex];

                // Hiển thị dữ liệu từ các ô DataGridView lên các ô TextBox tương ứng
                txt_MaNV.Text = selectedRow.Cells["MANV"].Value.ToString();
                txt_Machucvu.Text = selectedRow.Cells["MaChucVu"].Value.ToString();
                txt_Hoten.Text = selectedRow.Cells["HoTen"].Value.ToString();
                txt_chucvu.Text = selectedRow.Cells["ChucVu"].Value.ToString();
                dtpc_ngaynhanluong.Value = DateTime.Parse(selectedRow.Cells["NgayNhanLuong"].Value.ToString());
                txt_sotienluong.Text = selectedRow.Cells["SoTienLuong"].Value.ToString();
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
                // hàm kiểm tra người dùng nhập đầy đủ thông tin chưa
                if (string.IsNullOrEmpty(txt_Hoten.Text) || string.IsNullOrEmpty(txt_chucvu.Text) || string.IsNullOrEmpty(txt_sotienluong.Text) || string.IsNullOrEmpty(txt_sotienluong.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // kiểm tra có chắc chắn muốn sửa dữ liệu không
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa cái này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string SQlUpDate = "UPDATE tb_QuanLyLuong SET HoTen = @HoTen, @MaChucVu = @MaChucVu, SoTienLuong = @SoTienLuong, ChucVu = @ChucVu, NgayNhanLuong = @NgayNhanLuong  WHERE MaNV = @MaNV";
                    SqlCommand cmd = new SqlCommand(SQlUpDate, conn);
                    cmd.Parameters.AddWithValue("HoTen", txt_Hoten.Text);
                    cmd.Parameters.AddWithValue("MaNV", txt_MaNV.Text);
                    cmd.Parameters.AddWithValue("MaChucVu", txt_Machucvu.Text);
                    cmd.Parameters.AddWithValue("SoTienLuong", txt_sotienluong.Text);
                    cmd.Parameters.AddWithValue("ChucVu", txt_chucvu.Text);
                    cmd.Parameters.AddWithValue("NgayNhanLuong", dtpc_ngaynhanluong.Value);
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
                MessageBox.Show("Database error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // hàm kiểm tra người dùng nhập đầy đủ thông tin chưa
                if (string.IsNullOrEmpty(txt_Hoten.Text) || string.IsNullOrEmpty(txt_chucvu.Text) || string.IsNullOrEmpty(txt_sotienluong.Text) || string.IsNullOrEmpty(txt_sotienluong.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // kiểm tra có chắc chắn muốn xóa dữ liệu không
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa cái này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string sqlDelete = "DELETE FROM tb_QuanLyLuong WHERE MaNV = @MaNV";
                    SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                    cmd.Parameters.AddWithValue("HoTen", txt_Hoten.Text);
                    cmd.Parameters.AddWithValue("MaNV", txt_MaNV.Text);
                    cmd.Parameters.AddWithValue("MaChucVu", txt_Machucvu.Text);
                    cmd.Parameters.AddWithValue("SoTienLuong", txt_sotienluong.Text);
                    cmd.Parameters.AddWithValue("ChucVu", txt_chucvu.Text);
                    cmd.Parameters.AddWithValue("NgayNhanLuong", dtpc_ngaynhanluong.Value);
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
                MessageBox.Show("Database error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_Resert_Click(object sender, EventArgs e)
        {
            txt_chucvu.Clear();
            txt_sotienluong.Clear();
            txt_MaNV.Clear();
            txt_Machucvu.Clear();
            txt_Hoten.Clear();
            dtpc_ngaynhanluong.Value = DateTime.Today;

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                // Kiểm tra xem TextBox tìm kiếm có dữ liệu không
                if (!string.IsNullOrEmpty(txt_TimKiem.Text))
                {
                    // Xóa dữ liệu hiển thị trên DataGridView trước khi thực hiện tìm kiếm mới
                    dtgv_DuLieu.DataSource = null;

                    // Tạo câu truy vấn SQL để tìm kiếm dữ liệu
                    string sqltimKiem = "SELECT * FROM tb_QuanLyLuong WHERE MaNV LIKE @MaNV OR HoTen LIKE @HoTen OR NgayNhanLuong LIKE @NgayNhanLuong OR MaChucVu LIKE @MaChucVu OR SoTienLuong LIKE @SoTienLuong";
                    // Tạo SqlCommand và thêm tham số cho câu truy vấn
                    SqlCommand cmd = new SqlCommand(sqltimKiem, conn);
                    cmd.Parameters.AddWithValue("@MaNV", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@HoTen", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@NgayNhanLuong", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@SoTienLuong", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@ChucVu", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@MaChucVu", "%" + txt_TimKiem.Text + "%");

                    // Thực hiện truy vấn và đổ dữ liệu vào DataTable
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    // Hiển thị dữ liệu lên DataGridView
                    dtgv_DuLieu.DataSource = dt;
                }
                else
                {
                    // Nếu TextBox tìm kiếm trống, hiển thị thông báo
                    MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
