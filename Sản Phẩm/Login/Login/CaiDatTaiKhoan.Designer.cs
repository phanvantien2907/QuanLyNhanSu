namespace Login
{
    partial class CaiDatTaiKhoan
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
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.lb_matkhaucu = new ReaLTaiizor.Controls.FoxLabel();
            this.lb_matkhaumoi = new ReaLTaiizor.Controls.FoxLabel();
            this.lb_xacnhanmatkhau = new ReaLTaiizor.Controls.FoxLabel();
            this.btn_matkhaucu = new System.Windows.Forms.TextBox();
            this.btn_matkhaumoi = new System.Windows.Forms.TextBox();
            this.btn_xacnhanmatkhau = new System.Windows.Forms.TextBox();
            this.btn_luuthaydoi = new ReaLTaiizor.Controls.Button();
            this.btn_Resert = new ReaLTaiizor.Controls.Button();
            this.checkbox_Showpassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(292, 93);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(418, 57);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "CHANGE PASSWORD";
            // 
            // lb_matkhaucu
            // 
            this.lb_matkhaucu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_matkhaucu.BackColor = System.Drawing.Color.Transparent;
            this.lb_matkhaucu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matkhaucu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.lb_matkhaucu.Location = new System.Drawing.Point(247, 193);
            this.lb_matkhaucu.Name = "lb_matkhaucu";
            this.lb_matkhaucu.Size = new System.Drawing.Size(189, 42);
            this.lb_matkhaucu.TabIndex = 4;
            this.lb_matkhaucu.Text = "Mật Khẩu Cũ:";
            // 
            // lb_matkhaumoi
            // 
            this.lb_matkhaumoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_matkhaumoi.BackColor = System.Drawing.Color.Transparent;
            this.lb_matkhaumoi.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matkhaumoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.lb_matkhaumoi.Location = new System.Drawing.Point(234, 253);
            this.lb_matkhaumoi.Name = "lb_matkhaumoi";
            this.lb_matkhaumoi.Size = new System.Drawing.Size(214, 42);
            this.lb_matkhaumoi.TabIndex = 6;
            this.lb_matkhaumoi.Text = "Mật Khẩu Mới:";
            // 
            // lb_xacnhanmatkhau
            // 
            this.lb_xacnhanmatkhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_xacnhanmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.lb_xacnhanmatkhau.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_xacnhanmatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.lb_xacnhanmatkhau.Location = new System.Drawing.Point(172, 328);
            this.lb_xacnhanmatkhau.Name = "lb_xacnhanmatkhau";
            this.lb_xacnhanmatkhau.Size = new System.Drawing.Size(276, 42);
            this.lb_xacnhanmatkhau.TabIndex = 7;
            this.lb_xacnhanmatkhau.Text = "Xác Nhận Mật Khẩu:";
            // 
            // btn_matkhaucu
            // 
            this.btn_matkhaucu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_matkhaucu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_matkhaucu.Location = new System.Drawing.Point(473, 193);
            this.btn_matkhaucu.Multiline = true;
            this.btn_matkhaucu.Name = "btn_matkhaucu";
            this.btn_matkhaucu.PasswordChar = '*';
            this.btn_matkhaucu.Size = new System.Drawing.Size(292, 46);
            this.btn_matkhaucu.TabIndex = 8;
            // 
            // btn_matkhaumoi
            // 
            this.btn_matkhaumoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_matkhaumoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_matkhaumoi.Location = new System.Drawing.Point(473, 253);
            this.btn_matkhaumoi.Multiline = true;
            this.btn_matkhaumoi.Name = "btn_matkhaumoi";
            this.btn_matkhaumoi.PasswordChar = '*';
            this.btn_matkhaumoi.Size = new System.Drawing.Size(292, 46);
            this.btn_matkhaumoi.TabIndex = 9;
            // 
            // btn_xacnhanmatkhau
            // 
            this.btn_xacnhanmatkhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xacnhanmatkhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacnhanmatkhau.Location = new System.Drawing.Point(473, 328);
            this.btn_xacnhanmatkhau.Multiline = true;
            this.btn_xacnhanmatkhau.Name = "btn_xacnhanmatkhau";
            this.btn_xacnhanmatkhau.PasswordChar = '*';
            this.btn_xacnhanmatkhau.Size = new System.Drawing.Size(292, 46);
            this.btn_xacnhanmatkhau.TabIndex = 10;
            // 
            // btn_luuthaydoi
            // 
            this.btn_luuthaydoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_luuthaydoi.BackColor = System.Drawing.Color.Transparent;
            this.btn_luuthaydoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_luuthaydoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_luuthaydoi.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_luuthaydoi.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_luuthaydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_luuthaydoi.Image = null;
            this.btn_luuthaydoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luuthaydoi.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_luuthaydoi.Location = new System.Drawing.Point(345, 468);
            this.btn_luuthaydoi.Name = "btn_luuthaydoi";
            this.btn_luuthaydoi.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_luuthaydoi.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_luuthaydoi.Size = new System.Drawing.Size(201, 50);
            this.btn_luuthaydoi.TabIndex = 11;
            this.btn_luuthaydoi.Text = "Lưu Thay Đổi";
            this.btn_luuthaydoi.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_luuthaydoi.Click += new System.EventHandler(this.btn_luuthaydoi_Click);
            this.btn_luuthaydoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_luuthaydoi_KeyDown);
            // 
            // btn_Resert
            // 
            this.btn_Resert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Resert.BackColor = System.Drawing.Color.Transparent;
            this.btn_Resert.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_Resert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Resert.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_Resert.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_Resert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Resert.Image = null;
            this.btn_Resert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Resert.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_Resert.Location = new System.Drawing.Point(569, 468);
            this.btn_Resert.Name = "btn_Resert";
            this.btn_Resert.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_Resert.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_Resert.Size = new System.Drawing.Size(201, 50);
            this.btn_Resert.TabIndex = 12;
            this.btn_Resert.Text = "Resert";
            this.btn_Resert.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Resert.Click += new System.EventHandler(this.btn_Resert_Click);
            // 
            // checkbox_Showpassword
            // 
            this.checkbox_Showpassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkbox_Showpassword.AutoSize = true;
            this.checkbox_Showpassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.checkbox_Showpassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.checkbox_Showpassword.Location = new System.Drawing.Point(579, 403);
            this.checkbox_Showpassword.Name = "checkbox_Showpassword";
            this.checkbox_Showpassword.Size = new System.Drawing.Size(188, 36);
            this.checkbox_Showpassword.TabIndex = 20;
            this.checkbox_Showpassword.Text = "Show Pasword";
            this.checkbox_Showpassword.UseVisualStyleBackColor = true;
            this.checkbox_Showpassword.CheckedChanged += new System.EventHandler(this.checkbox_Showpassword_CheckedChanged);
            // 
            // CaiDatTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(1006, 760);
            this.Controls.Add(this.checkbox_Showpassword);
            this.Controls.Add(this.btn_Resert);
            this.Controls.Add(this.btn_luuthaydoi);
            this.Controls.Add(this.btn_xacnhanmatkhau);
            this.Controls.Add(this.btn_matkhaumoi);
            this.Controls.Add(this.btn_matkhaucu);
            this.Controls.Add(this.lb_xacnhanmatkhau);
            this.Controls.Add(this.lb_matkhaumoi);
            this.Controls.Add(this.lb_matkhaucu);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaiDatTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaiDatTaiKhoan";
            this.Load += new System.EventHandler(this.CaiDatTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.FoxLabel lb_matkhaucu;
        private ReaLTaiizor.Controls.FoxLabel lb_matkhaumoi;
        private ReaLTaiizor.Controls.FoxLabel lb_xacnhanmatkhau;
        private System.Windows.Forms.TextBox btn_matkhaucu;
        private System.Windows.Forms.TextBox btn_matkhaumoi;
        private System.Windows.Forms.TextBox btn_xacnhanmatkhau;
        private ReaLTaiizor.Controls.Button btn_luuthaydoi;
        private ReaLTaiizor.Controls.Button btn_Resert;
        private System.Windows.Forms.CheckBox checkbox_Showpassword;
    }
}