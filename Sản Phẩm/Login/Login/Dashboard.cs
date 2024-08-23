using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Dashboard : Form
    {
        private string vaiTro;
        public Dashboard(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
        }
        // kahi báo trạng thái mở ra thu vô
        bool menuExpand = true;
        bool sidebarExpand = true;
        bool panelhome = true;
        bool menu1 = true;


        // khởi tạo 1 đối tượng để thao tác form con trên form cha
        public void loadform(object Form)
        {
            if (this.panel_body.Controls.Count > 0)
                this.panel_body.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel_body.Controls.Add(f);
            this.panel_body.Tag = f;
            f.Show();
        }

        // nếu như đăng nhập tài khoản khác quyền admin thì hạn chế 1 số from
        void Hihi()
        {
            if (vaiTro != "admin")
            {
               btn_ThongKe.Enabled = false;
                btn_thongkeluong.Enabled = false;
                btn_thongkenhansu.Enabled = false;
            }
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình luôn không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) { Application.Exit(); }
        }

        private void btn_QuanLyNhanSu_Click(object sender, EventArgs e)
        {
            loadform(new QuanLyNhanSu(vaiTro));
        }
        
          private void sidebartransition_Tick(object sender, EventArgs e)
            {
            // Xử lý hiệu ứng mở rộng và thu gọn của sidebar
            if (sidebarExpand)
                {
                    sidebarContainer.Width -= 10;
                if (sidebarContainer.Width <= 50)
                    {
                     sidebarExpand = false;
                    sidebartransition.Stop();

                }

                }
                else
                {
                    sidebarContainer.Width += 10;
                if (sidebarContainer.Width >= 254)
                    {
                        sidebarExpand = true;
                        sidebartransition.Stop();
                }
                }   
        }

            private void ptrMenu_Click(object sender, EventArgs e)
            {

            // thực hiện mở ra đóng vô của thanh menu
                sidebartransition.Start();

        }

        private void menutransition_Tick_1(object sender, EventArgs e)
        {
            // Xử lý hiệu ứng mở rộng và thu gọn của menu
            if (menuExpand == false)
            {
                MenuContainer.Height += 10;
                if (MenuContainer.Height >= 505)
                {
                    menutransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                MenuContainer.Height -= 10;
                if (MenuContainer.Height <= 50)
                {
                    menutransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            //bắt đầu thực hiện mở ra thu vô
            menutransition.Start();

        }

        private void btn_TrinhDoHocVan_Click(object sender, EventArgs e)
        {
            loadform(new TrinhDoHocVan(vaiTro));

        }

        private void btn_QuanLyPhongBan_Click_1(object sender, EventArgs e)
        {
            loadform(new QuanLyPhongBan(vaiTro));
        }

        private void btn_QuanLyChucVu_Click(object sender, EventArgs e)
        {
            loadform(new QuanLyChucVu(vaiTro));
        }

        private void btn_NVCV_Click(object sender, EventArgs e)
        {
            loadform(new NhanVienChucVu(vaiTro));
        }

        private void btn_QuanLyHopDong_Click(object sender, EventArgs e)
        {
            loadform(new QuanLyHopDong(vaiTro));
        }


       private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            //loadform(new ThongKe());
            timer_menuthongke.Start();
        }

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            loadform(new ThongTin());
        }

        private void btn_CaiDatTaiKhoan_Click(object sender, EventArgs e)
        {
            loadform(new CaiDatTaiKhoan(vaiTro));
        }

        private void btn_QuanLyChamCong_Click(object sender, EventArgs e)
        {
            loadform(new QuanLyChamCong(vaiTro));
        }

        private void btn_QuanLyLuong_Click(object sender, EventArgs e)
        {
            loadform(new QuanLyLuong(vaiTro));
        }

        private void btn_thongkenhanvien_Click(object sender, EventArgs e)
        {
            loadform(new ThongKeNhanSu());
        }

        private void btn_thongkeluong_Click(object sender, EventArgs e)
        {
            loadform(new ThongKeLuong());
        }

        private void timer_menuthongke_Tick(object sender, EventArgs e)
        {
            // Xử lý hiệu ứng mở rộng và thu gọn của menu thống kê
            if (menu1 == false)
            {
                menuthongke.Height += 10;
                if (menuthongke.Height >= 163)
                {
                    timer_menuthongke.Stop();
                    menu1 = true;
                }
            }
            else
            {
                menuthongke.Height -= 10;
                if (menuthongke.Height <= 50)
                {
                    timer_menuthongke.Stop();
                    menu1 = false;
                }
            }
        }

    }

    }
