namespace DB_Project
{
    partial class sysLoginForm
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
            this.lbl_sysLoginTitle = new System.Windows.Forms.Label();
            this.lbl_sysUsername = new System.Windows.Forms.Label();
            this.txt_sysUsername = new System.Windows.Forms.TextBox();
            this.txt_sysPassword = new System.Windows.Forms.TextBox();
            this.lbl_sysPassword = new System.Windows.Forms.Label();
            this.btn_sysLoginback = new System.Windows.Forms.Button();
            this.btn_sysLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_sysLoginTitle
            // 
            this.lbl_sysLoginTitle.Font = new System.Drawing.Font("Book Antiqua", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sysLoginTitle.Location = new System.Drawing.Point(344, 50);
            this.lbl_sysLoginTitle.Name = "lbl_sysLoginTitle";
            this.lbl_sysLoginTitle.Size = new System.Drawing.Size(219, 71);
            this.lbl_sysLoginTitle.TabIndex = 9;
            this.lbl_sysLoginTitle.Text = "Login";
            // 
            // lbl_sysUsername
            // 
            this.lbl_sysUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sysUsername.Location = new System.Drawing.Point(107, 175);
            this.lbl_sysUsername.Name = "lbl_sysUsername";
            this.lbl_sysUsername.Size = new System.Drawing.Size(168, 35);
            this.lbl_sysUsername.TabIndex = 10;
            this.lbl_sysUsername.Text = "Username";
            this.lbl_sysUsername.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // txt_sysUsername
            // 
            this.txt_sysUsername.Location = new System.Drawing.Point(354, 172);
            this.txt_sysUsername.Multiline = true;
            this.txt_sysUsername.Name = "txt_sysUsername";
            this.txt_sysUsername.Size = new System.Drawing.Size(256, 38);
            this.txt_sysUsername.TabIndex = 11;
            // 
            // txt_sysPassword
            // 
            this.txt_sysPassword.Location = new System.Drawing.Point(354, 300);
            this.txt_sysPassword.Multiline = true;
            this.txt_sysPassword.Name = "txt_sysPassword";
            this.txt_sysPassword.Size = new System.Drawing.Size(256, 38);
            this.txt_sysPassword.TabIndex = 13;
            // 
            // lbl_sysPassword
            // 
            this.lbl_sysPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sysPassword.Location = new System.Drawing.Point(107, 303);
            this.lbl_sysPassword.Name = "lbl_sysPassword";
            this.lbl_sysPassword.Size = new System.Drawing.Size(148, 35);
            this.lbl_sysPassword.TabIndex = 14;
            this.lbl_sysPassword.Text = "Password";
            // 
            // btn_sysLoginback
            // 
            this.btn_sysLoginback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sysLoginback.Location = new System.Drawing.Point(79, 413);
            this.btn_sysLoginback.Name = "btn_sysLoginback";
            this.btn_sysLoginback.Size = new System.Drawing.Size(256, 65);
            this.btn_sysLoginback.TabIndex = 15;
            this.btn_sysLoginback.Text = "Back";
            this.btn_sysLoginback.UseVisualStyleBackColor = true;
            this.btn_sysLoginback.Click += new System.EventHandler(this.btn_sysLoginback_Click);
            // 
            // btn_sysLogin
            // 
            this.btn_sysLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sysLogin.Location = new System.Drawing.Point(569, 413);
            this.btn_sysLogin.Name = "btn_sysLogin";
            this.btn_sysLogin.Size = new System.Drawing.Size(256, 65);
            this.btn_sysLogin.TabIndex = 16;
            this.btn_sysLogin.Text = "Log in";
            this.btn_sysLogin.UseVisualStyleBackColor = true;
            this.btn_sysLogin.Click += new System.EventHandler(this.btn_sysLogin_Click);
            // 
            // sysLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 518);
            this.Controls.Add(this.btn_sysLogin);
            this.Controls.Add(this.btn_sysLoginback);
            this.Controls.Add(this.lbl_sysPassword);
            this.Controls.Add(this.txt_sysPassword);
            this.Controls.Add(this.txt_sysUsername);
            this.Controls.Add(this.lbl_sysUsername);
            this.Controls.Add(this.lbl_sysLoginTitle);
            this.Name = "sysLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sysLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sysLoginTitle;
        private System.Windows.Forms.Label lbl_sysUsername;
        private System.Windows.Forms.TextBox txt_sysUsername;
        private System.Windows.Forms.TextBox txt_sysPassword;
        private System.Windows.Forms.Label lbl_sysPassword;
        private System.Windows.Forms.Button btn_sysLoginback;
        private System.Windows.Forms.Button btn_sysLogin;
    }
}