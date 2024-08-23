namespace Login
{
    partial class FormDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKy));
            this.label_Exit = new System.Windows.Forms.Label();
            this.label_AlreadyHaveAccount = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.checkbox_Showpassword = new System.Windows.Forms.CheckBox();
            this.btn_Regisiter = new System.Windows.Forms.Button();
            this.label_ConfimPassword = new System.Windows.Forms.Label();
            this.txt_Confirmpassword = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label_GetStarted = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label_manv = new System.Windows.Forms.Label();
            this.txt_Manv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Exit
            // 
            this.label_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Exit.AutoSize = true;
            this.label_Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.label_Exit.Location = new System.Drawing.Point(139, 686);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(123, 28);
            this.label_Exit.TabIndex = 21;
            this.label_Exit.Text = "Exit Regisiter";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // label_AlreadyHaveAccount
            // 
            this.label_AlreadyHaveAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_AlreadyHaveAccount.AutoSize = true;
            this.label_AlreadyHaveAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AlreadyHaveAccount.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_AlreadyHaveAccount.Location = new System.Drawing.Point(57, 648);
            this.label_AlreadyHaveAccount.Name = "label_AlreadyHaveAccount";
            this.label_AlreadyHaveAccount.Size = new System.Drawing.Size(334, 28);
            this.label_AlreadyHaveAccount.TabIndex = 22;
            this.label_AlreadyHaveAccount.Text = "Already Have Account? back to login";
            this.label_AlreadyHaveAccount.Click += new System.EventHandler(this.label_AlreadyHaveAccount_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Clear.BackColor = System.Drawing.Color.White;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_Clear.Location = new System.Drawing.Point(80, 588);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(256, 57);
            this.btn_Clear.TabIndex = 20;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            this.btn_Clear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Clear_KeyDown);
            // 
            // checkbox_Showpassword
            // 
            this.checkbox_Showpassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkbox_Showpassword.AutoSize = true;
            this.checkbox_Showpassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_Showpassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.checkbox_Showpassword.Location = new System.Drawing.Point(197, 476);
            this.checkbox_Showpassword.Name = "checkbox_Showpassword";
            this.checkbox_Showpassword.Size = new System.Drawing.Size(141, 27);
            this.checkbox_Showpassword.TabIndex = 19;
            this.checkbox_Showpassword.Text = "Show Pasword";
            this.checkbox_Showpassword.UseVisualStyleBackColor = true;
            this.checkbox_Showpassword.CheckedChanged += new System.EventHandler(this.checkbox_Showpassword_CheckedChanged);
            // 
            // btn_Regisiter
            // 
            this.btn_Regisiter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Regisiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_Regisiter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regisiter.ForeColor = System.Drawing.Color.White;
            this.btn_Regisiter.Location = new System.Drawing.Point(80, 509);
            this.btn_Regisiter.Name = "btn_Regisiter";
            this.btn_Regisiter.Size = new System.Drawing.Size(256, 57);
            this.btn_Regisiter.TabIndex = 18;
            this.btn_Regisiter.Text = "REGISITER";
            this.btn_Regisiter.UseVisualStyleBackColor = false;
            this.btn_Regisiter.Click += new System.EventHandler(this.btn_Regisiter_Click);
            this.btn_Regisiter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Regisiter_KeyDown);
            // 
            // label_ConfimPassword
            // 
            this.label_ConfimPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ConfimPassword.AutoSize = true;
            this.label_ConfimPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConfimPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_ConfimPassword.Location = new System.Drawing.Point(76, 366);
            this.label_ConfimPassword.Name = "label_ConfimPassword";
            this.label_ConfimPassword.Size = new System.Drawing.Size(173, 28);
            this.label_ConfimPassword.TabIndex = 17;
            this.label_ConfimPassword.Text = " Confirm Password";
            // 
            // txt_Confirmpassword
            // 
            this.txt_Confirmpassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Confirmpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_Confirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txt_Confirmpassword.Location = new System.Drawing.Point(81, 411);
            this.txt_Confirmpassword.Multiline = true;
            this.txt_Confirmpassword.Name = "txt_Confirmpassword";
            this.txt_Confirmpassword.PasswordChar = '*';
            this.txt_Confirmpassword.Size = new System.Drawing.Size(257, 40);
            this.txt_Confirmpassword.TabIndex = 16;
            // 
            // label_password
            // 
            this.label_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_password.Location = new System.Drawing.Point(75, 258);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(93, 28);
            this.label_password.TabIndex = 15;
            this.label_password.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txt_password.Location = new System.Drawing.Point(80, 304);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(257, 40);
            this.txt_password.TabIndex = 14;
            // 
            // label_GetStarted
            // 
            this.label_GetStarted.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_GetStarted.AutoSize = true;
            this.label_GetStarted.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GetStarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.label_GetStarted.Location = new System.Drawing.Point(98, 9);
            this.label_GetStarted.Name = "label_GetStarted";
            this.label_GetStarted.Size = new System.Drawing.Size(216, 45);
            this.label_GetStarted.TabIndex = 13;
            this.label_GetStarted.Text = "GET STARTED";
            // 
            // label_UserName
            // 
            this.label_UserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_UserName.Location = new System.Drawing.Point(75, 160);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(103, 28);
            this.label_UserName.TabIndex = 12;
            this.label_UserName.Text = "UserName";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(80, 206);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(257, 40);
            this.txt_UserName.TabIndex = 11;
            // 
            // label_manv
            // 
            this.label_manv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_manv.AutoSize = true;
            this.label_manv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manv.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_manv.Location = new System.Drawing.Point(75, 70);
            this.label_manv.Name = "label_manv";
            this.label_manv.Size = new System.Drawing.Size(122, 28);
            this.label_manv.TabIndex = 24;
            this.label_manv.Text = "ID Employee";
            // 
            // txt_Manv
            // 
            this.txt_Manv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Manv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_Manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Manv.Location = new System.Drawing.Point(80, 116);
            this.txt_Manv.Multiline = true;
            this.txt_Manv.Name = "txt_Manv";
            this.txt_Manv.Size = new System.Drawing.Size(257, 40);
            this.txt_Manv.TabIndex = 23;
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 748);
            this.Controls.Add(this.label_manv);
            this.Controls.Add(this.txt_Manv);
            this.Controls.Add(this.label_Exit);
            this.Controls.Add(this.label_AlreadyHaveAccount);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.checkbox_Showpassword);
            this.Controls.Add(this.btn_Regisiter);
            this.Controls.Add(this.label_ConfimPassword);
            this.Controls.Add(this.txt_Confirmpassword);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label_GetStarted);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.txt_UserName);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký Tài Khoản";
            this.Load += new System.EventHandler(this.FormDangKy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDangKy_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.Label label_AlreadyHaveAccount;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.CheckBox checkbox_Showpassword;
        private System.Windows.Forms.Button btn_Regisiter;
        private System.Windows.Forms.Label label_ConfimPassword;
        private System.Windows.Forms.TextBox txt_Confirmpassword;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label_GetStarted;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label_manv;
        private System.Windows.Forms.TextBox txt_Manv;
    }
}