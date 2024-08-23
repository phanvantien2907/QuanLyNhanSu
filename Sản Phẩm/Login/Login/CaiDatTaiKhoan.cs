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
    public partial class CaiDatTaiKhoan : Form
    {
        public CaiDatTaiKhoan(string vaiTro)
        {
            // khai báo cho các tổ hợp phím
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(btn_luuthaydoi_KeyDown);
            this.vaiTro = vaiTro;
        }
        // khai báo thông tin kết nối 
        SqlConnection conn = null;

        private string vaiTro;

        // hàm hiển thị dữ liệu
        private void HienThi()
        {
            string sqlSelect = "select * from tb_TaiKhoan";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
        }

        void PhanQuyen()
        {
            if (vaiTro != "admin")
            {
                btn_matkhaucu.Enabled = false;
                btn_matkhaumoi.Enabled = false;
                btn_xacnhanmatkhau.Enabled = false;
                btn_luuthaydoi.Enabled = false;
                btn_Resert.Enabled = false;
                checkbox_Showpassword.Enabled = false;

            }
        }

        private void CaiDatTaiKhoan_Load(object sender, EventArgs e)
        {
            // khai báo thông tin kết nối tới csdl
            string connstring = @"Data Source=PHANVANTIEN\PHANVANTIEN;Initial Catalog=QuanLyNhanSu;Integrated Security=True;";
            conn = new SqlConnection(connstring);
            conn.Open();
            HienThi();
            PhanQuyen();
        }

        private void btn_luuthaydoi_Click(object sender, EventArgs e)
        {
            // hàm kiểm tra mật khẩu phải khớp
            if (btn_matkhaumoi.Text != btn_xacnhanmatkhau.Text)
            {
                MessageBox.Show("Mật khẩu của bạn không khớp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn lưu không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string lb_matkhaucu = btn_matkhaucu.Text;
                    string lb_matkhaumoi = btn_matkhaumoi.Text;
                    string lb_xacnhanmatkhau = btn_xacnhanmatkhau.Text;

                    string SQLUpdate = "UPDATE tb_TaiKhoan SET MatKhau = @MatKhauMoi WHERE MatKhau = @MatKhauCu";
                    SqlCommand cmd = new SqlCommand(SQLUpdate, conn);
                    cmd.Parameters.AddWithValue("@MatKhauMoi", btn_matkhaumoi.Text);
                    cmd.Parameters.AddWithValue("@MatKhauCu", btn_matkhaucu.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi();
                    }
                }
                else { MessageBox.Show("Cập nhật mật khẩu thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                btn_matkhaucu.PasswordChar = '\0';
                btn_matkhaucu.PasswordChar = '\0';

                btn_matkhaumoi.PasswordChar = '\0';
                btn_matkhaumoi.PasswordChar = '\0';

                btn_xacnhanmatkhau.PasswordChar = '\0';
                btn_xacnhanmatkhau.PasswordChar = '\0';
            }

            else
            {
                btn_matkhaucu.PasswordChar = '*';
                btn_matkhaucu.PasswordChar = '*';

                btn_matkhaumoi.PasswordChar = '*';
                btn_matkhaumoi.PasswordChar = '*';

                btn_xacnhanmatkhau.PasswordChar = '*';
                btn_xacnhanmatkhau.PasswordChar = '*';
            }
        }

        private void btn_Resert_Click(object sender, EventArgs e)
        {
            btn_matkhaucu.Text = "";
            btn_matkhaumoi.Text = "";
            btn_xacnhanmatkhau.Text = "";
        }

        private void btn_luuthaydoi_KeyDown(object sender, KeyEventArgs e)
        {
            // chức năng này để người dùng ấn tổ hợp phím enter
            if (e.KeyCode == Keys.Enter)
            {
                btn_luuthaydoi_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                if (btn_matkhaucu.SelectedText == "*")
                {
                    e.SuppressKeyPress = true;
                }
            }


            if (e.Control && e.KeyCode == Keys.C)
            {
                if (btn_matkhaumoi.SelectedText == "*")
                {
                    e.SuppressKeyPress = true;
                }
            }


            if (e.Control && e.KeyCode == Keys.C)
            {
                if (btn_xacnhanmatkhau.SelectedText == "*")
                {
                    e.SuppressKeyPress = true;
                }
            }
        }
    }

   
}
