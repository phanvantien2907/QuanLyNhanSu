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
using System.Text.RegularExpressions;

namespace Login
{
    public partial class FormDangKy : Form
    {
        // khai báo thông tin kết nối
        SqlConnection conn = null; 
        public FormDangKy()
        {
            InitializeComponent();
        }
        // khai báo 1 phương thức kết nối để sau gọi cho dễ 
        private void HienThi()
        {
            string sqlSelect = "select * from tb_TaiKhoan";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
           }

        // hàm check viết Hoa
        private bool ContainsUppercase(string password)
        {
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainsSpecialCharacter(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsValidUsername(string username)
        {
            string pattern = @"[^\p{IsBasicLatin}]";
            Regex regex = new Regex(pattern);
            return !regex.IsMatch(username);
        }
        private bool IsLengthValid(string username, string password, string confirmPassword)
        {
            return username.Length >= 5 && password.Length >= 5 && confirmPassword.Length >= 5;
        }


        private void btn_Regisiter_Click(object sender, EventArgs e)
        {
            // hàm check lỗi khi đăng ký
            // hàm kiểm tra phải nhập đầy đủ thông tin
            if (string.IsNullOrWhiteSpace(txt_UserName.Text) ||
                string.IsNullOrWhiteSpace(txt_password.Text) ||
                string.IsNullOrWhiteSpace(txt_Confirmpassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // hàm kiểm tra mật khẩu phải khớp
            if (txt_password.Text != txt_Confirmpassword.Text)
            {
                MessageBox.Show("Mật khẩu của bạn không khớp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // hàm kiểm tra không quá 50 kí tự
            if (txt_UserName.Text.Length > 50 || txt_password.Text.Length > 50 || txt_Confirmpassword.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng không nhập quá 50 ký tự!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // hàm kiểm tra mật khẩu 1 chự cái viết hoa và 1 kí tự đặc biệt
            if ((!ContainsUppercase(txt_password.Text) || !ContainsSpecialCharacter(txt_password.Text)) ||
        (!ContainsUppercase(txt_Confirmpassword.Text) || !ContainsSpecialCharacter(txt_Confirmpassword.Text)))
            {
                MessageBox.Show("Cả mật khẩu và mật khẩu xác nhận phải chứa ít nhất một chữ cái viết hoa và ít nhất một ký tự đặc biệt!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // hàm kiểm tra nhập đúng định dạng cho username chưa
            if (!IsValidUsername(txt_UserName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng đúng định dạng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ dài của các chuỗi
            if (!IsLengthValid(txt_UserName.Text, txt_password.Text, txt_Confirmpassword.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng, mật khẩu và xác nhận mật khẩu có ít nhất 5 ký tự!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn tạo tài khoản không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sqlCheckExisting = "SELECT COUNT(*) FROM tb_TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                    SqlCommand cmdCheckExisting = new SqlCommand(sqlCheckExisting, conn);
                    cmdCheckExisting.Parameters.AddWithValue("@TenTaiKhoan", txt_UserName.Text);
                    int existingCount = (int)cmdCheckExisting.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }

                    string SQlCreate = "INSERT INTO tb_TaiKhoan (MaNV,TenTaiKhoan, MatKhau) VALUES (@MaNV,@TenTaiKhoan, @MatKhau)";
                    SqlCommand cmd = new SqlCommand(SQlCreate, conn);
                    cmd.Parameters.AddWithValue("@MaNV", txt_Manv.Text);
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", txt_UserName.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txt_password.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đăng ký tài khoản thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký tài khoản không thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoài mong muốn: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        private void checkbox_Showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_Showpassword.Checked == true)
            {
                txt_password.PasswordChar = '\0';
                txt_Confirmpassword.PasswordChar = '\0';
            }

            else
            {
                txt_Confirmpassword.PasswordChar = '*';
                txt_password.PasswordChar = '*';
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_UserName.Text = "";
            txt_password.Text = "";
            txt_Confirmpassword.Text = "";
            txt_UserName.Focus();
            txt_password.Focus();
            txt_Confirmpassword.Focus();
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes) { Application.Exit(); }
        }

        private void label_AlreadyHaveAccount_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();

        }

        private void btn_Regisiter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Regisiter_Click(sender, e);
            }
        }

        private void btn_Clear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Clear_Click(sender, e);  
            }
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            string connstring = @"Data Source=PHANVANTIEN\PHANVANTIEN;Initial Catalog=QuanLyNhanSu;Integrated Security=True;";
            conn = new SqlConnection(connstring);
            conn.Open();
            HienThi();
        }

        private void FormDangKy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                if (txt_password.SelectedText == "*")
                {
                    e.SuppressKeyPress = true; 
                }
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                if (txt_Confirmpassword.SelectedText == "*")
                {
                    e.SuppressKeyPress = true;
                }
            }

        }
    }
}
