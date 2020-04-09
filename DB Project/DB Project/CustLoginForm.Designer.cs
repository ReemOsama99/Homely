namespace DB_Project
{
    partial class CustLoginForm
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
            this.lbl_custLoginTitle = new System.Windows.Forms.Label();
            this.lbl_custUsername = new System.Windows.Forms.Label();
            this.txt_custUsername = new System.Windows.Forms.TextBox();
            this.lbl_custPassword = new System.Windows.Forms.Label();
            this.txt_custPassword = new System.Windows.Forms.TextBox();
            this.btn_custLoginback = new System.Windows.Forms.Button();
            this.btn_custLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_custLoginTitle
            // 
            this.lbl_custLoginTitle.Font = new System.Drawing.Font("Book Antiqua", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custLoginTitle.Location = new System.Drawing.Point(360, 52);
            this.lbl_custLoginTitle.Name = "lbl_custLoginTitle";
            this.lbl_custLoginTitle.Size = new System.Drawing.Size(219, 71);
            this.lbl_custLoginTitle.TabIndex = 8;
            this.lbl_custLoginTitle.Text = "Login";
            // 
            // lbl_custUsername
            // 
            this.lbl_custUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custUsername.Location = new System.Drawing.Point(120, 175);
            this.lbl_custUsername.Name = "lbl_custUsername";
            this.lbl_custUsername.Size = new System.Drawing.Size(168, 35);
            this.lbl_custUsername.TabIndex = 9;
            this.lbl_custUsername.Text = "Username";
            // 
            // txt_custUsername
            // 
            this.txt_custUsername.Location = new System.Drawing.Point(385, 172);
            this.txt_custUsername.Multiline = true;
            this.txt_custUsername.Name = "txt_custUsername";
            this.txt_custUsername.Size = new System.Drawing.Size(256, 38);
            this.txt_custUsername.TabIndex = 10;
            // 
            // lbl_custPassword
            // 
            this.lbl_custPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custPassword.Location = new System.Drawing.Point(120, 312);
            this.lbl_custPassword.Name = "lbl_custPassword";
            this.lbl_custPassword.Size = new System.Drawing.Size(148, 35);
            this.lbl_custPassword.TabIndex = 11;
            this.lbl_custPassword.Text = "Password";
            // 
            // txt_custPassword
            // 
            this.txt_custPassword.Location = new System.Drawing.Point(385, 309);
            this.txt_custPassword.Multiline = true;
            this.txt_custPassword.Name = "txt_custPassword";
            this.txt_custPassword.Size = new System.Drawing.Size(256, 38);
            this.txt_custPassword.TabIndex = 12;
            // 
            // btn_custLoginback
            // 
            this.btn_custLoginback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_custLoginback.Location = new System.Drawing.Point(87, 418);
            this.btn_custLoginback.Name = "btn_custLoginback";
            this.btn_custLoginback.Size = new System.Drawing.Size(256, 65);
            this.btn_custLoginback.TabIndex = 13;
            this.btn_custLoginback.Text = "Back";
            this.btn_custLoginback.UseVisualStyleBackColor = true;
            this.btn_custLoginback.Click += new System.EventHandler(this.btn_Loginback_Click);
            // 
            // btn_custLogin
            // 
            this.btn_custLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_custLogin.Location = new System.Drawing.Point(588, 418);
            this.btn_custLogin.Name = "btn_custLogin";
            this.btn_custLogin.Size = new System.Drawing.Size(256, 65);
            this.btn_custLogin.TabIndex = 14;
            this.btn_custLogin.Text = "Log in";
            this.btn_custLogin.UseVisualStyleBackColor = true;
            this.btn_custLogin.Click += new System.EventHandler(this.btn_custLogin_Click);
            // 
            // CustLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 518);
            this.Controls.Add(this.btn_custLogin);
            this.Controls.Add(this.btn_custLoginback);
            this.Controls.Add(this.txt_custPassword);
            this.Controls.Add(this.lbl_custPassword);
            this.Controls.Add(this.txt_custUsername);
            this.Controls.Add(this.lbl_custUsername);
            this.Controls.Add(this.lbl_custLoginTitle);
            this.Name = "CustLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_custLoginTitle;
        private System.Windows.Forms.Label lbl_custUsername;
        private System.Windows.Forms.TextBox txt_custUsername;
        private System.Windows.Forms.Label lbl_custPassword;
        private System.Windows.Forms.TextBox txt_custPassword;
        private System.Windows.Forms.Button btn_custLoginback;
        private System.Windows.Forms.Button btn_custLogin;
    }
}