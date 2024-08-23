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
    public partial class QuanLyChamCong : Form
    {
        private string vaiTro;
        // khai báo thông tin kết nối 
        SqlConnection conn = null;
        public QuanLyChamCong(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }
        // khởi tạo 1 phương thức để dùng cho sau này
        private void HienThi()
        {
            string sqlSelect = "select * from tb_QuanLyChamCong";
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

        private void QuanLyChamCong_Load(object sender, EventArgs e)
        {
            // khai báo thông tin kết nối tới csdl
            string connstring = @"Data Source=PHANVANTIEN\PHANVANTIEN;Initial Catalog=QuanLyNhanSu;Integrated Security=True;";
            conn = new SqlConnection(connstring);
            conn.Open();
            HienThi();
            PhanQuyen();
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
                    string sqltimKiem = "SELECT * FROM tb_QuanLyChamCong WHERE MANV LIKE @MANV OR HoTen LIKE @HoTen OR NgayChamCong LIKE @NgayChamCong";


                    // Tạo SqlCommand và thêm tham số cho câu truy vấn
                    SqlCommand cmd = new SqlCommand(sqltimKiem, conn);
                    cmd.Parameters.AddWithValue("@MANV", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@HoTen", "%" + txt_TimKiem.Text + "%");
                    cmd.Parameters.AddWithValue("@NgayChamCong", "%" + txt_TimKiem.Text + "%");

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
                if (string.IsNullOrEmpty(txt_Tennhanvien.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin để chấm công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // hàm check trùng MANV
                string checkQuery = "SELECT COUNT(*) FROM tb_QuanLyChamCong WHERE MANV = @MANV";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("MANV", txt_MaNV.Text);
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Không được nhập trùng Mã NV", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // kiểm tra xem có chắc chắn muốn chấm công không ? 
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn chấm công không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string query = "INSERT INTO tb_QuanLyChamCong (MANV,HoTen,NgayChamCong,Có,Vắng) VALUES (@MANV, @HoTen,@NgayChamCong,@Có,@Vắng)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("MANV", txt_MaNV.Text);
                    cmd.Parameters.AddWithValue("HoTen", txt_Tennhanvien.Text);
                    cmd.Parameters.AddWithValue("NgayChamCong", dtpc_ngaychamcong.Value);

                    // kiểm tra radio button nào được chọn
                    if (rdo_Co.Checked)
                    {
                        cmd.Parameters.AddWithValue("Có",true);
                        cmd.Parameters.AddWithValue("Vắng", false);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("Có", false);
                        cmd.Parameters.AddWithValue("Vắng", true);
                    }

                    // đoạn này là hàm để kiểm tra đã thêm thành công hay chưa
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Chấm công thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi();
                    }
                    else { MessageBox.Show("Chấm công thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                if (string.IsNullOrEmpty(txt_MaNV.Text) || string.IsNullOrEmpty(txt_Tennhanvien.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // kiểm tra có chắc chắn muốn sửa dữ liệu không
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa cái này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string SQlUpDate = "UPDATE tb_QuanLyChamCong SET HoTen = @HoTen, NgayChamCong = @NgayChamCong WHERE MANV = @MANV";
                    SqlCommand cmd = new SqlCommand(SQlUpDate, conn);
                    cmd.Parameters.AddWithValue("MANV", txt_MaNV.Text);
                    cmd.Parameters.AddWithValue("HoTen", txt_Tennhanvien.Text);
                    cmd.Parameters.AddWithValue("NgayChamCong", dtpc_ngaychamcong.Value);
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

        private void dtgv_DuLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Lấy ra chỉ số của hàng được chọn
            int rowIndex = e.RowIndex;

            // Kiểm tra nếu chỉ số hàng hợp lệ
            if (rowIndex >= 0 && rowIndex < dtgv_DuLieu.Rows.Count)
            {
                // Lấy dòng dữ liệu tương ứng với chỉ số hàng
                DataGridViewRow selectedRow = dtgv_DuLieu.Rows[rowIndex];

                // Hiển thị dữ liệu từ các ô DataGridView lên các ô TextBox tương ứng
                txt_MaNV.Text = selectedRow.Cells["MANV"].Value.ToString();
                txt_Tennhanvien.Text = selectedRow.Cells["HoTen"].Value.ToString();
                dtpc_ngaychamcong.Value = Convert.ToDateTime(selectedRow.Cells["NgayChamCong"].Value.ToString());

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
                if (string.IsNullOrEmpty(txt_MaNV.Text) || string.IsNullOrEmpty(txt_Tennhanvien.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // kiểm tra có chắc chắn muốn xóa dữ liệu không
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa cái này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string sqlDelete = "DELETE FROM tb_QuanLyChamCong WHERE MANV = @MANV";
                    SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                    cmd.Parameters.AddWithValue("MANV", txt_MaNV.Text);
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
            txt_MaNV.Text = "";
            dtpc_ngaychamcong.Value = DateTime.Today;
            txt_Tennhanvien.Text = "";
        }
    }
}
