namespace Login
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lb_Menu = new System.Windows.Forms.Label();
            this.ptrMenu = new System.Windows.Forms.PictureBox();
            this.MenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_TrangChu = new ReaLTaiizor.Controls.Button();
            this.btn_TrinhDoHocVan = new ReaLTaiizor.Controls.Button();
            this.btn_QuanLyPhongBan = new ReaLTaiizor.Controls.Button();
            this.btn_QuanLyChucVu = new ReaLTaiizor.Controls.Button();
            this.btn_NVCV = new ReaLTaiizor.Controls.Button();
            this.btn_QuanLyHopDong = new ReaLTaiizor.Controls.Button();
            this.btn_QuanLyNhanSu = new ReaLTaiizor.Controls.Button();
            this.btn_QuanLyChamCong = new ReaLTaiizor.Controls.Button();
            this.btn_QuanLyLuong = new ReaLTaiizor.Controls.Button();
            this.menuthongke = new System.Windows.Forms.Panel();
            this.btn_thongkeluong = new ReaLTaiizor.Controls.Button();
            this.btn_thongkenhansu = new ReaLTaiizor.Controls.Button();
            this.btn_ThongKe = new ReaLTaiizor.Controls.Button();
            this.btn_CaiDatTaiKhoan = new ReaLTaiizor.Controls.Button();
            this.btn_ThongTin = new ReaLTaiizor.Controls.Button();
            this.btn_DangXuat = new ReaLTaiizor.Controls.Button();
            this.menutransition = new System.Windows.Forms.Timer(this.components);
            this.sidebartransition = new System.Windows.Forms.Timer(this.components);
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.pn_TrangChu = new System.Windows.Forms.Panel();
            this.lb_TrangChu = new ReaLTaiizor.Controls.BigLabel();
            this.panelTrangChu = new System.Windows.Forms.Timer(this.components);
            this.panel_body = new System.Windows.Forms.Panel();
            this.timer_menuthongke = new System.Windows.Forms.Timer(this.components);
            this.sidebarContainer.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrMenu)).BeginInit();
            this.MenuContainer.SuspendLayout();
            this.menuthongke.SuspendLayout();
            this.pn_TrangChu.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebarContainer.Controls.Add(this.panel10);
            this.sidebarContainer.Controls.Add(this.MenuContainer);
            this.sidebarContainer.Controls.Add(this.menuthongke);
            this.sidebarContainer.Controls.Add(this.btn_CaiDatTaiKhoan);
            this.sidebarContainer.Controls.Add(this.btn_ThongTin);
            this.sidebarContainer.Controls.Add(this.btn_DangXuat);
            this.sidebarContainer.Location = new System.Drawing.Point(0, -2);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(254, 856);
            this.sidebarContainer.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel10.Controls.Add(this.lb_Menu);
            this.panel10.Controls.Add(this.ptrMenu);
            this.panel10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(252, 80);
            this.panel10.TabIndex = 1;
            // 
            // lb_Menu
            // 
            this.lb_Menu.AutoSize = true;
            this.lb_Menu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Menu.ForeColor = System.Drawing.Color.White;
            this.lb_Menu.Location = new System.Drawing.Point(88, 30);
            this.lb_Menu.Name = "lb_Menu";
            this.lb_Menu.Size = new System.Drawing.Size(95, 41);
            this.lb_Menu.TabIndex = 9;
            this.lb_Menu.Text = "Menu";
            // 
            // ptrMenu
            // 
            this.ptrMenu.Image = ((System.Drawing.Image)(resources.GetObject("ptrMenu.Image")));
            this.ptrMenu.Location = new System.Drawing.Point(-3, 30);
            this.ptrMenu.Name = "ptrMenu";
            this.ptrMenu.Size = new System.Drawing.Size(44, 39);
            this.ptrMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrMenu.TabIndex = 9;
            this.ptrMenu.TabStop = false;
            this.ptrMenu.Click += new System.EventHandler(this.ptrMenu_Click);
            // 
            // MenuContainer
            // 
            this.MenuContainer.Controls.Add(this.btn_TrangChu);
            this.MenuContainer.Controls.Add(this.btn_TrinhDoHocVan);
            this.MenuContainer.Controls.Add(this.btn_QuanLyPhongBan);
            this.MenuContainer.Controls.Add(this.btn_QuanLyChucVu);
            this.MenuContainer.Controls.Add(this.btn_NVCV);
            this.MenuContainer.Controls.Add(this.btn_QuanLyHopDong);
            this.MenuContainer.Controls.Add(this.btn_QuanLyNhanSu);
            this.MenuContainer.Controls.Add(this.btn_QuanLyChamCong);
            this.MenuContainer.Controls.Add(this.btn_QuanLyLuong);
            this.MenuContainer.Location = new System.Drawing.Point(3, 89);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(249, 50);
            this.MenuContainer.TabIndex = 4;
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btn_TrangChu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_TrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TrangChu.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_TrangChu.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_TrangChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btn_TrangChu.Image")));
            this.btn_TrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TrangChu.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_TrangChu.Location = new System.Drawing.Point(3, 3);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_TrangChu.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_TrangChu.Size = new System.Drawing.Size(249, 50);
            this.btn_TrangChu.TabIndex = 3;
            this.btn_TrangChu.Text = "Trang Chủ";
            this.btn_TrangChu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // btn_TrinhDoHocVan
            // 
            this.btn_TrinhDoHocVan.BackColor = System.Drawing.Color.Transparent;
            this.btn_TrinhDoHocVan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_TrinhDoHocVan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TrinhDoHocVan.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_TrinhDoHocVan.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_TrinhDoHocVan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrinhDoHocVan.Image = ((System.Drawing.Image)(resources.GetObject("btn_TrinhDoHocVan.Image")));
            this.btn_TrinhDoHocVan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TrinhDoHocVan.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_TrinhDoHocVan.Location = new System.Drawing.Point(3, 59);
            this.btn_TrinhDoHocVan.Name = "btn_TrinhDoHocVan";
            this.btn_TrinhDoHocVan.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_TrinhDoHocVan.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_TrinhDoHocVan.Size = new System.Drawing.Size(249, 50);
            this.btn_TrinhDoHocVan.TabIndex = 6;
            this.btn_TrinhDoHocVan.Text = "Quản Lý Học Vấn";
            this.btn_TrinhDoHocVan.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_TrinhDoHocVan.Click += new System.EventHandler(this.btn_TrinhDoHocVan_Click);
            // 
            // btn_QuanLyPhongBan
            // 
            this.btn_QuanLyPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.btn_QuanLyPhongBan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyPhongBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuanLyPhongBan.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyPhongBan.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyPhongBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyPhongBan.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuanLyPhongBan.Image")));
            this.btn_QuanLyPhongBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyPhongBan.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyPhongBan.Location = new System.Drawing.Point(3, 115);
            this.btn_QuanLyPhongBan.Name = "btn_QuanLyPhongBan";
            this.btn_QuanLyPhongBan.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyPhongBan.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyPhongBan.Size = new System.Drawing.Size(249, 50);
            this.btn_QuanLyPhongBan.TabIndex = 5;
            this.btn_QuanLyPhongBan.Text = "Quản Lý Phòng Ban";
            this.btn_QuanLyPhongBan.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_QuanLyPhongBan.Click += new System.EventHandler(this.btn_QuanLyPhongBan_Click_1);
            // 
            // btn_QuanLyChucVu
            // 
            this.btn_QuanLyChucVu.BackColor = System.Drawing.Color.Transparent;
            this.btn_QuanLyChucVu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyChucVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuanLyChucVu.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyChucVu.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyChucVu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyChucVu.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuanLyChucVu.Image")));
            this.btn_QuanLyChucVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyChucVu.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyChucVu.Location = new System.Drawing.Point(3, 171);
            this.btn_QuanLyChucVu.Name = "btn_QuanLyChucVu";
            this.btn_QuanLyChucVu.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyChucVu.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyChucVu.Size = new System.Drawing.Size(249, 50);
            this.btn_QuanLyChucVu.TabIndex = 4;
            this.btn_QuanLyChucVu.Text = "Quản Lý Chức Vụ";
            this.btn_QuanLyChucVu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_QuanLyChucVu.Click += new System.EventHandler(this.btn_QuanLyChucVu_Click);
            // 
            // btn_NVCV
            // 
            this.btn_NVCV.BackColor = System.Drawing.Color.Transparent;
            this.btn_NVCV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_NVCV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NVCV.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_NVCV.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_NVCV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NVCV.Image = ((System.Drawing.Image)(resources.GetObject("btn_NVCV.Image")));
            this.btn_NVCV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NVCV.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_NVCV.Location = new System.Drawing.Point(3, 227);
            this.btn_NVCV.Name = "btn_NVCV";
            this.btn_NVCV.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_NVCV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_NVCV.Size = new System.Drawing.Size(249, 50);
            this.btn_NVCV.TabIndex = 7;
            this.btn_NVCV.Text = "Nhân Viên Chức Vụ";
            this.btn_NVCV.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_NVCV.Click += new System.EventHandler(this.btn_NVCV_Click);
            // 
            // btn_QuanLyHopDong
            // 
            this.btn_QuanLyHopDong.BackColor = System.Drawing.Color.Transparent;
            this.btn_QuanLyHopDong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyHopDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuanLyHopDong.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyHopDong.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyHopDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyHopDong.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuanLyHopDong.Image")));
            this.btn_QuanLyHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyHopDong.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyHopDong.Location = new System.Drawing.Point(3, 283);
            this.btn_QuanLyHopDong.Name = "btn_QuanLyHopDong";
            this.btn_QuanLyHopDong.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyHopDong.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyHopDong.Size = new System.Drawing.Size(249, 50);
            this.btn_QuanLyHopDong.TabIndex = 6;
            this.btn_QuanLyHopDong.Text = "Quản Lý Hợp Đồng";
            this.btn_QuanLyHopDong.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_QuanLyHopDong.Click += new System.EventHandler(this.btn_QuanLyHopDong_Click);
            // 
            // btn_QuanLyNhanSu
            // 
            this.btn_QuanLyNhanSu.BackColor = System.Drawing.Color.Transparent;
            this.btn_QuanLyNhanSu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyNhanSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuanLyNhanSu.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyNhanSu.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyNhanSu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyNhanSu.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuanLyNhanSu.Image")));
            this.btn_QuanLyNhanSu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyNhanSu.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyNhanSu.Location = new System.Drawing.Point(3, 339);
            this.btn_QuanLyNhanSu.Name = "btn_QuanLyNhanSu";
            this.btn_QuanLyNhanSu.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyNhanSu.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyNhanSu.Size = new System.Drawing.Size(249, 50);
            this.btn_QuanLyNhanSu.TabIndex = 3;
            this.btn_QuanLyNhanSu.Text = "Quản Lý Nhân Sự";
            this.btn_QuanLyNhanSu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_QuanLyNhanSu.Click += new System.EventHandler(this.btn_QuanLyNhanSu_Click);
            // 
            // btn_QuanLyChamCong
            // 
            this.btn_QuanLyChamCong.BackColor = System.Drawing.Color.Transparent;
            this.btn_QuanLyChamCong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_QuanLyChamCong.BackgroundImage")));
            this.btn_QuanLyChamCong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuanLyChamCong.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyChamCong.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyChamCong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyChamCong.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuanLyChamCong.Image")));
            this.btn_QuanLyChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyChamCong.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyChamCong.Location = new System.Drawing.Point(3, 395);
            this.btn_QuanLyChamCong.Name = "btn_QuanLyChamCong";
            this.btn_QuanLyChamCong.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyChamCong.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyChamCong.Size = new System.Drawing.Size(249, 50);
            this.btn_QuanLyChamCong.TabIndex = 8;
            this.btn_QuanLyChamCong.Text = "Quản Lý Chấm Công";
            this.btn_QuanLyChamCong.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_QuanLyChamCong.Click += new System.EventHandler(this.btn_QuanLyChamCong_Click);
            // 
            // btn_QuanLyLuong
            // 
            this.btn_QuanLyLuong.BackColor = System.Drawing.Color.Transparent;
            this.btn_QuanLyLuong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_QuanLyLuong.BackgroundImage")));
            this.btn_QuanLyLuong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuanLyLuong.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyLuong.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyLuong.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuanLyLuong.Image")));
            this.btn_QuanLyLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyLuong.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_QuanLyLuong.Location = new System.Drawing.Point(3, 451);
            this.btn_QuanLyLuong.Name = "btn_QuanLyLuong";
            this.btn_QuanLyLuong.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyLuong.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_QuanLyLuong.Size = new System.Drawing.Size(249, 50);
            this.btn_QuanLyLuong.TabIndex = 9;
            this.btn_QuanLyLuong.Text = "Quản Lý Lương";
            this.btn_QuanLyLuong.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_QuanLyLuong.Click += new System.EventHandler(this.btn_QuanLyLuong_Click);
            // 
            // menuthongke
            // 
            this.menuthongke.Controls.Add(this.btn_thongkeluong);
            this.menuthongke.Controls.Add(this.btn_thongkenhansu);
            this.menuthongke.Controls.Add(this.btn_ThongKe);
            this.menuthongke.Location = new System.Drawing.Point(3, 145);
            this.menuthongke.Name = "menuthongke";
            this.menuthongke.Size = new System.Drawing.Size(249, 50);
            this.menuthongke.TabIndex = 4;
            // 
            // btn_thongkeluong
            // 
            this.btn_thongkeluong.BackColor = System.Drawing.Color.Transparent;
            this.btn_thongkeluong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_thongkeluong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thongkeluong.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_thongkeluong.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_thongkeluong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongkeluong.Image = ((System.Drawing.Image)(resources.GetObject("btn_thongkeluong.Image")));
            this.btn_thongkeluong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongkeluong.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_thongkeluong.Location = new System.Drawing.Point(3, 112);
            this.btn_thongkeluong.Name = "btn_thongkeluong";
            this.btn_thongkeluong.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_thongkeluong.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_thongkeluong.Size = new System.Drawing.Size(249, 50);
            this.btn_thongkeluong.TabIndex = 5;
            this.btn_thongkeluong.Text = "Thống Kê Lương";
            this.btn_thongkeluong.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_thongkeluong.Click += new System.EventHandler(this.btn_thongkeluong_Click);
            // 
            // btn_thongkenhansu
            // 
            this.btn_thongkenhansu.BackColor = System.Drawing.Color.Transparent;
            this.btn_thongkenhansu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_thongkenhansu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thongkenhansu.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_thongkenhansu.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_thongkenhansu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongkenhansu.Image = ((System.Drawing.Image)(resources.GetObject("btn_thongkenhansu.Image")));
            this.btn_thongkenhansu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongkenhansu.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_thongkenhansu.Location = new System.Drawing.Point(3, 56);
            this.btn_thongkenhansu.Name = "btn_thongkenhansu";
            this.btn_thongkenhansu.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_thongkenhansu.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_thongkenhansu.Size = new System.Drawing.Size(249, 50);
            this.btn_thongkenhansu.TabIndex = 4;
            this.btn_thongkenhansu.Text = "Thống Kê Nhân Sự";
            this.btn_thongkenhansu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_thongkenhansu.Click += new System.EventHandler(this.btn_thongkenhanvien_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThongKe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_ThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThongKe.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_ThongKe.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_ThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongKe.Image")));
            this.btn_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKe.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_ThongKe.Location = new System.Drawing.Point(3, 0);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_ThongKe.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_ThongKe.Size = new System.Drawing.Size(249, 50);
            this.btn_ThongKe.TabIndex = 3;
            this.btn_ThongKe.Text = "Thống Kê";
            this.btn_ThongKe.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_CaiDatTaiKhoan
            // 
            this.btn_CaiDatTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.btn_CaiDatTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_CaiDatTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CaiDatTaiKhoan.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_CaiDatTaiKhoan.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_CaiDatTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CaiDatTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_CaiDatTaiKhoan.Image")));
            this.btn_CaiDatTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CaiDatTaiKhoan.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_CaiDatTaiKhoan.Location = new System.Drawing.Point(3, 201);
            this.btn_CaiDatTaiKhoan.Name = "btn_CaiDatTaiKhoan";
            this.btn_CaiDatTaiKhoan.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_CaiDatTaiKhoan.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_CaiDatTaiKhoan.Size = new System.Drawing.Size(249, 50);
            this.btn_CaiDatTaiKhoan.TabIndex = 3;
            this.btn_CaiDatTaiKhoan.Text = "Cài Đặt Tài Khoản";
            this.btn_CaiDatTaiKhoan.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_CaiDatTaiKhoan.Click += new System.EventHandler(this.btn_CaiDatTaiKhoan_Click);
            // 
            // btn_ThongTin
            // 
            this.btn_ThongTin.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThongTin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_ThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThongTin.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_ThongTin.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_ThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongTin.Image")));
            this.btn_ThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongTin.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_ThongTin.Location = new System.Drawing.Point(3, 257);
            this.btn_ThongTin.Name = "btn_ThongTin";
            this.btn_ThongTin.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_ThongTin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_ThongTin.Size = new System.Drawing.Size(249, 50);
            this.btn_ThongTin.TabIndex = 3;
            this.btn_ThongTin.Text = "Thông Tin";
            this.btn_ThongTin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_ThongTin.Click += new System.EventHandler(this.btn_ThongTin_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btn_DangXuat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangXuat.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_DangXuat.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_DangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.Image")));
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_DangXuat.Location = new System.Drawing.Point(3, 313);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_DangXuat.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_DangXuat.Size = new System.Drawing.Size(249, 50);
            this.btn_DangXuat.TabIndex = 3;
            this.btn_DangXuat.Text = "Đăng Xuất";
            this.btn_DangXuat.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // menutransition
            // 
            this.menutransition.Interval = 10;
            this.menutransition.Tick += new System.EventHandler(this.menutransition_Tick_1);
            // 
            // sidebartransition
            // 
            this.sidebartransition.Interval = 5;
            this.sidebartransition.Tick += new System.EventHandler(this.sidebartransition_Tick);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(261, 221);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(0, 57);
            this.bigLabel1.TabIndex = 1;
            // 
            // pn_TrangChu
            // 
            this.pn_TrangChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_TrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(236)))), ((int)(((byte)(180)))));
            this.pn_TrangChu.Controls.Add(this.lb_TrangChu);
            this.pn_TrangChu.Location = new System.Drawing.Point(253, 1);
            this.pn_TrangChu.Name = "pn_TrangChu";
            this.pn_TrangChu.Size = new System.Drawing.Size(1350, 80);
            this.pn_TrangChu.TabIndex = 2;
            // 
            // lb_TrangChu
            // 
            this.lb_TrangChu.AutoSize = true;
            this.lb_TrangChu.BackColor = System.Drawing.Color.Transparent;
            this.lb_TrangChu.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrangChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lb_TrangChu.Location = new System.Drawing.Point(447, 13);
            this.lb_TrangChu.Name = "lb_TrangChu";
            this.lb_TrangChu.Size = new System.Drawing.Size(284, 62);
            this.lb_TrangChu.TabIndex = 3;
            this.lb_TrangChu.Text = "TRANG CHỦ";
            // 
            // panelTrangChu
            // 
            this.panelTrangChu.Enabled = true;
            this.panelTrangChu.Interval = 10;
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.White;
            this.panel_body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_body.BackgroundImage")));
            this.panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_body.Location = new System.Drawing.Point(253, 79);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1350, 693);
            this.panel_body.TabIndex = 3;
            // 
            // timer_menuthongke
            // 
            this.timer_menuthongke.Interval = 10;
            this.timer_menuthongke.Tick += new System.EventHandler(this.timer_menuthongke_Tick);
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1599, 767);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.pn_TrangChu);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.sidebarContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.sidebarContainer.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrMenu)).EndInit();
            this.MenuContainer.ResumeLayout(false);
            this.menuthongke.ResumeLayout(false);
            this.pn_TrangChu.ResumeLayout(false);
            this.pn_TrangChu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion      

     
        private System.Windows.Forms.FlowLayoutPanel sidebarContainer;
        private System.Windows.Forms.Panel panel10;
        private ReaLTaiizor.Controls.Button btn_TrangChu;
        private ReaLTaiizor.Controls.Button btn_CaiDatTaiKhoan;
        private ReaLTaiizor.Controls.Button btn_ThongTin;
        private ReaLTaiizor.Controls.Button btn_DangXuat;
        private ReaLTaiizor.Controls.Button btn_QuanLyNhanSu;
        private System.Windows.Forms.Label lb_Menu;
        private System.Windows.Forms.PictureBox ptrMenu;
        private System.Windows.Forms.Timer menutransition;
        private System.Windows.Forms.Timer sidebartransition;
        private System.Windows.Forms.FlowLayoutPanel MenuContainer;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.Button btn_QuanLyChucVu;
        private ReaLTaiizor.Controls.Button btn_QuanLyPhongBan;
        private ReaLTaiizor.Controls.Button btn_QuanLyHopDong;
        private ReaLTaiizor.Controls.Button btn_TrinhDoHocVan;
        private System.Windows.Forms.Panel pn_TrangChu;
        private ReaLTaiizor.Controls.BigLabel lb_TrangChu;
        private ReaLTaiizor.Controls.Button btn_NVCV;
        private System.Windows.Forms.Timer panelTrangChu;
        private ReaLTaiizor.Controls.Button btn_QuanLyChamCong;
        private ReaLTaiizor.Controls.Button btn_QuanLyLuong;
        private ReaLTaiizor.Controls.Button btn_ThongKe;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel menuthongke;
        private ReaLTaiizor.Controls.Button btn_thongkenhansu;
        private ReaLTaiizor.Controls.Button btn_thongkeluong;
        private System.Windows.Forms.Timer timer_menuthongke;
    }
}