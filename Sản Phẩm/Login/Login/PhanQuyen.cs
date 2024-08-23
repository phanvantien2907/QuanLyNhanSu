using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    internal class PhanQuyen
    {
        private string quyen;

        public PhanQuyen(string vaiTro)
        {
            this.quyen = vaiTro;
        }

        public void CapNhatQuyenHan(Form form)
        {
            if (quyen == "Admin")
            {
                // Cho phép Admin sử dụng tất cả các nút
                BatTatNang(form, false);
            }
            else if (quyen == "NguoiDung")
            {
                // Vô hiệu hóa các nút thêm, sửa, xóa đối với Người dùng
                BatTatNang(form, true, "btn_Them", "btn_Sua", "btn_Xoa");
            }
            else
            {
                // Hiển thị thông báo lỗi nếu vai trò không hợp lệ
                MessageBox.Show("Vai trò không hợp lệ!");
            }
        }

        private void BatTatNang(Form form, bool tat, params string[] tenNang)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is Button && tenNang.Contains(ctrl.Name))
                {
                    ctrl.Enabled = !tat;
                }
            }
        }
    }
}
