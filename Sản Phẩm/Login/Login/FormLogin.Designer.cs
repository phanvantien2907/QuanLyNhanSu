namespace Login
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lb_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.label_DontHaveAccount = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.checkbox_Showpassword = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label_GetStarted = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lb_username
            // 
            this.lb_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_username.AutoSize = true;
            this.lb_username.BackColor = System.Drawing.Color.White;
            this.lb_username.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lb_username.Location = new System.Drawing.Point(55, 125);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(117, 31);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Username";
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_username.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(56, 176);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(293, 36);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_password.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(56, 292);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(293, 36);
            this.txt_password.TabIndex = 4;
            // 
            // lb_password
            // 
            this.lb_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_password.AutoSize = true;
            this.lb_password.BackColor = System.Drawing.Color.White;
            this.lb_password.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lb_password.Location = new System.Drawing.Point(62, 245);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(110, 31);
            this.lb_password.TabIndex = 3;
            this.lb_password.Text = "Password";
            // 
            // label_DontHaveAccount
            // 
            this.label_DontHaveAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_DontHaveAccount.AutoSize = true;
            this.label_DontHaveAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DontHaveAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.label_DontHaveAccount.Location = new System.Drawing.Point(51, 568);
            this.label_DontHaveAccount.Name = "label_DontHaveAccount";
            this.label_DontHaveAccount.Size = new System.Drawing.Size(327, 28);
            this.label_DontHaveAccount.TabIndex = 27;
            this.label_DontHaveAccount.Text = "Dont Have Account? Let go regisiter";
            this.label_DontHaveAccount.Click += new System.EventHandler(this.label_DontHaveAccount_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_exit.Location = new System.Drawing.Point(56, 483);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(293, 54);
            this.btn_exit.TabIndex = 25;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_exit_KeyDown);
            // 
            // checkbox_Showpassword
            // 
            this.checkbox_Showpassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkbox_Showpassword.AutoSize = true;
            this.checkbox_Showpassword.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_Showpassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.checkbox_Showpassword.Location = new System.Drawing.Point(208, 357);
            this.checkbox_Showpassword.Name = "checkbox_Showpassword";
            this.checkbox_Showpassword.Size = new System.Drawing.Size(141, 27);
            this.checkbox_Showpassword.TabIndex = 24;
            this.checkbox_Showpassword.Text = "Show Pasword";
            this.checkbox_Showpassword.UseVisualStyleBackColor = true;
            this.checkbox_Showpassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(56, 407);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(293, 54);
            this.btn_Login.TabIndex = 23;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            this.btn_Login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Login_KeyDown);
            // 
            // label_GetStarted
            // 
            this.label_GetStarted.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_GetStarted.AutoSize = true;
            this.label_GetStarted.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GetStarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.label_GetStarted.Location = new System.Drawing.Point(101, 36);
            this.label_GetStarted.Name = "label_GetStarted";
            this.label_GetStarted.Size = new System.Drawing.Size(216, 45);
            this.label_GetStarted.TabIndex = 28;
            this.label_GetStarted.Text = "GET STARTED";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 667);
            this.Controls.Add(this.label_GetStarted);
            this.Controls.Add(this.label_DontHaveAccount);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.checkbox_Showpassword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lb_username);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label label_GetStarted;
        private System.Windows.Forms.Label label_DontHaveAccount;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.CheckBox checkbox_Showpassword;
        private System.Windows.Forms.Button btn_Login;
    }
}

