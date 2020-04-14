namespace DB_Project
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_sysAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Book Antiqua", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(32, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(192, 62);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Homely";
            this.lbl_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.ForeColor = System.Drawing.Color.Yellow;
            this.btn_customer.Location = new System.Drawing.Point(356, 48);
            this.btn_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(254, 53);
            this.btn_customer.TabIndex = 2;
            this.btn_customer.Text = "Customer";
            this.btn_customer.UseVisualStyleBackColor = false;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_sysAdmin
            // 
            this.btn_sysAdmin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sysAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sysAdmin.ForeColor = System.Drawing.Color.Yellow;
            this.btn_sysAdmin.Location = new System.Drawing.Point(356, 127);
            this.btn_sysAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sysAdmin.Name = "btn_sysAdmin";
            this.btn_sysAdmin.Size = new System.Drawing.Size(254, 53);
            this.btn_sysAdmin.TabIndex = 3;
            this.btn_sysAdmin.Text = "System Admin";
            this.btn_sysAdmin.UseVisualStyleBackColor = false;
            this.btn_sysAdmin.Click += new System.EventHandler(this.btn_sysAdmin_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 421);
            this.Controls.Add(this.btn_sysAdmin);
            this.Controls.Add(this.btn_customer);
            this.Controls.Add(this.lbl_title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                 ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_sysAdmin;
    }
}

