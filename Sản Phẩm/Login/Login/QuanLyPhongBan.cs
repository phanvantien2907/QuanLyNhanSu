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
    public partial class QuanLyPhongBan : Form
    {
        private string vaiTro;

        // khai báo thông tin kết nối 
        SqlConnection conn = null;

        public QuanLyPhongBan(string vaiTro)
        {
            // khai báo cho các tổ hợp phím
            InitializeComponent();
            this.vaiTro = vaiTro;
        }

        // gọi 1 hàm để dùng cho sau này
        private void HienThi()
        {
            string sqlSelect = "select * from tb_PhongBan";
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
                    if (string.IsNullOrEmpty(txt_TenPB.Text) || string.IsNullOrEmpty(txt_Diachi.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // hàm check trùng MaPB
                    string checkQuery = "SELECT COUNT(*) FROM tb_PhongBan WHERE MaPB = @MaPB";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("MaPB", txt_MaPhongBan.Text);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Không được nhập trùng Mã phòng ban!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // kiểm tra xem có chắc chắn muốn thêm dữ liệu vào không ? 
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thêm dữ liệu này vào không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        string SQlInSert = "INSERT INTO tb_PhongBan (TenPB, DiaChi) VALUES (@TenPB, @DiaChi)";
                        SqlCommand cmd = new SqlCommand(SQlInSert, conn);
                        cmd.Parameters.AddWithValue("TenPB", txt_TenPB.Text);
                        cmd.Parameters.AddWithValue("DiaChi", txt_Diachi.Text);
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    // hàm kiểm tra người dùng nhập đầy đủ thông tin chưa
                    if (string.IsNullOrEmpty(txt_TenPB.Text) || string.IsNullOrEmpty(txt_Diachi.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                // kiểm tra có chắc chắn muốn sửa dữ liệu không
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa cái này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string SQlUpDate = "UPDATE tb_PhongBan SET TenPB = @TenPB, DiaChi = @DiaChi WHERE MAPB = @MAPB";
                        SqlCommand cmd = new SqlCommand(SQlUpDate, conn);
                        cmd.Parameters.AddWithValue("MAPB", txt_MaPhongBan.Text);
                        cmd.Parameters.AddWithValue("TenPB", txt_TenPB.Text);
                        cmd.Parameters.AddWithValue("DiaChi", txt_Diachi.Text);
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

        private void QuanLyPhongBan_Load(object sender, EventArgs e)
        {
            // khai báo thông tin kết nối tới csdl
            string connstring = @"Data Source=PHANVANTIEN\PHANVANTIEN;Initial Catalog=QuanLyNhanSu;Integrated Security=True;";
            conn = new SqlConnection(connstring);
            conn.Open();
            HienThi();
            PhanQuyen();

        }

        private void btn_Resert_Click(object sender, EventArgs e)
        {
                txt_Diachi.Text = "";
                txt_MaPhongBan.Text = "";
                txt_TenPB.Text = "";
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
                    if (string.IsNullOrEmpty(txt_TenPB.Text) || string.IsNullOrEmpty(txt_Diachi.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                // kiểm tra có chắc chắn muốn xóa dữ liệu không
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa cái này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string sqlDelete = "DELETE FROM tb_PhongBan WHERE MAPB = @MAPB";
                        SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                        cmd.Parameters.AddWithValue("MAPB", txt_MaPhongBan.Text);
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
                txt_MaPhongBan.Text = selectedRow.Cells["MAPB"].Value.ToString();
                txt_TenPB.Text = selectedRow.Cells["TenPB"].Value.ToString();
                txt_Diachi.Text = selectedRow.Cells["DiaChi"].Value.ToString();

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

                // Kiểm tra xem TextBox tìm kiếm có dữ liệu không
                if (!string.IsNullOrEmpty(txt_TimKiem.Text))
                    {
                        // Xóa dữ liệu hiển thị trên DataGridView trước khi thực hiện tìm kiếm mới
                        dtgv_DuLieu.DataSource = null;

                        // Tạo câu truy vấn SQL để tìm kiếm dữ liệu
                        string sqltimKiem = "SELECT * FROM tb_PhongBan WHERE MAPB LIKE @MAPB OR TenPB LIKE @TenPB OR DiaChi LIKE @DiaChi";

                        // Tạo SqlCommand và thêm tham số cho câu truy vấn
                        SqlCommand cmd = new SqlCommand(sqltimKiem, conn);
                        cmd.Parameters.AddWithValue("@MAPB", "%" + txt_TimKiem.Text + "%");
                        cmd.Parameters.AddWithValue("@TenPB", "%" + txt_TimKiem.Text + "%");
                        cmd.Parameters.AddWithValue("@DiaChi", "%" + txt_TimKiem.Text + "%");

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
