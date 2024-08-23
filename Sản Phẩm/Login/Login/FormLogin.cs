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


namespace Login
{
    public partial class FormLogin : Form
    {

        // khai báo thông tin kết nối 
        SqlConnection conn = null;
        SqlCommand cmd = null;
        public FormLogin()
        {
            // khai báo cho các tổ hợp phím
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(btn_Login_KeyDown);

        }
  
        // hàm khai báo để phân quyền sử dụng
        private void phanquyen(string Quyen)
        {
            if (Quyen == "admin")
            {
                Dashboard dr = new Dashboard(Quyen);
                dr.ShowDialog();
            }
            else if (Quyen == "nguoidung")
            {
                MessageBox.Show("Tài khoản này bị hạn chế 1 số quyền!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dashboard dr = new Dashboard(Quyen);
                dr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Quyền không hợp lệ!,Bạn không có quyền đăng nhập vào hệ thống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Application.Exit();
        }
        // hàm check phân quyền, nếu khác admin và nguoidung thì sẽ không đăng nhập vô được hệ thống
        private bool phanquyen1(string Quyen)
        {
            return Quyen == "admin" || Quyen == "nguoidung";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắc muốn thoát ứng dụng không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void label_DontHaveAccount_Click(object sender, EventArgs e)
        {
            FormDangKy formDangKy = new FormDangKy();
            formDangKy.Show();
            this.Hide();

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // thêm hàm try, catch, finaly để bắt ngoại lệ
            try
            {
                {
                    if (conn == null)
                    {
                        // khai báo thông tin kết nối tới cơ sở dữ liệu
                        conn = new SqlConnection(@"Data Source=PHANVANTIEN\PHANVANTIEN;Initial Catalog=QuanLyNhanSu;Integrated Security=True;");
                    }
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string lb_username = txt_username.Text.Trim();
                    string lb_password = txt_password.Text.Trim();

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.Text;
                    string loginQuery = "SELECT * FROM tb_TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan AND MatKhau = @MatKhau";
                    SqlCommand loginCommand = new SqlCommand(loginQuery, conn);
                    loginCommand.Parameters.AddWithValue("@TenTaiKhoan", txt_username.Text.Trim());
                    loginCommand.Parameters.AddWithValue("@MatKhau", txt_password.Text.Trim());
                    sqlCommand.Connection = conn;
                    SqlDataReader reader = loginCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        //nếu đăng nhập thành công sẽ hiển thị thông báo và sẽ mở form mới
                        string Quyen = reader["quyen"].ToString();

                        //MessageBox.Show("Đăng Nhập Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        phanquyen(Quyen);
                        //Dashboard dr = new Dashboard();
                        //dr.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đăng Nhập Thất Bại! Tài khoản hoặc mật khẩu không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    // đóng kết nối
                    reader.Close();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ vui lòng kiểm tra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // đóng kết nối
                conn.Close();
            }
                      
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // hiển thị mật khẩu và ẩn mật khẩu
            if(checkbox_Showpassword.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }

        private void btn_Login_KeyDown(object sender, KeyEventArgs e)
        {
            // chức năng này để người dùng ấn tổ hợp phím
            if(e.KeyCode == Keys.Enter)
            {
               btn_Login_Click(sender, e);
            }
        }

        private void btn_exit_KeyDown(object sender, KeyEventArgs e)
        {
            // chức năng này để người dùng ấn tổ hợp phím
            if (e.KeyCode == Keys.Enter)
            {
                btn_exit_Click(sender, e);
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
            // hàm không cho copy mật khẩu
            if (e.Control && e.KeyCode == Keys.C)
            {
                if (txt_password.SelectedText == "*")
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

    }
}
