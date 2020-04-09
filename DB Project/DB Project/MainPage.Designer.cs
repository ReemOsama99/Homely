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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_sysAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Book Antiqua", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(341, 57);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(229, 77);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Homely";
            this.lbl_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.Location = new System.Drawing.Point(276, 201);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(338, 65);
            this.btn_customer.TabIndex = 2;
            this.btn_customer.Text = "Customer";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_sysAdmin
            // 
            this.btn_sysAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sysAdmin.Location = new System.Drawing.Point(276, 345);
            this.btn_sysAdmin.Name = "btn_sysAdmin";
            this.btn_sysAdmin.Size = new System.Drawing.Size(338, 65);
            this.btn_sysAdmin.TabIndex = 3;
            this.btn_sysAdmin.Text = "System Admin";
            this.btn_sysAdmin.UseVisualStyleBackColor = true;
            this.btn_sysAdmin.Click += new System.EventHandler(this.btn_sysAdmin_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 518);
            this.Controls.Add(this.btn_sysAdmin);
            this.Controls.Add(this.btn_customer);
            this.Controls.Add(this.lbl_title);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_sysAdmin;
    }
}

