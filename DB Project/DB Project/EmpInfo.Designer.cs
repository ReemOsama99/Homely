namespace DB_Project
{
    partial class empInfo
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl_ItemID = new System.Windows.Forms.Label();
            this.btn_empInfoBack = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt_empBid = new System.Windows.Forms.TextBox();
            this.txt_empEmail = new System.Windows.Forms.TextBox();
            this.txt_empSalary = new System.Windows.Forms.TextBox();
            this.txt_empName = new System.Windows.Forms.TextBox();
            this.cbx_empId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(100, 180);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(168, 35);
            this.lbl2.TabIndex = 39;
            this.lbl2.Text = "Name";
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(100, 239);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(168, 35);
            this.lbl3.TabIndex = 38;
            this.lbl3.Text = "Salary";
            // 
            // lbl5
            // 
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(100, 344);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(168, 35);
            this.lbl5.TabIndex = 37;
            this.lbl5.Text = "Branch ID";
            this.lbl5.Click += new System.EventHandler(this.lbl_suppName_Click);
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(100, 288);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(168, 35);
            this.lbl4.TabIndex = 36;
            this.lbl4.Text = "Email";
            // 
            // lbl_ItemID
            // 
            this.lbl_ItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemID.Location = new System.Drawing.Point(100, 120);
            this.lbl_ItemID.Name = "lbl_ItemID";
            this.lbl_ItemID.Size = new System.Drawing.Size(168, 35);
            this.lbl_ItemID.TabIndex = 35;
            this.lbl_ItemID.Text = "Emp ID";
            // 
            // btn_empInfoBack
            // 
            this.btn_empInfoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empInfoBack.Location = new System.Drawing.Point(699, 447);
            this.btn_empInfoBack.Name = "btn_empInfoBack";
            this.btn_empInfoBack.Size = new System.Drawing.Size(178, 49);
            this.btn_empInfoBack.TabIndex = 34;
            this.btn_empInfoBack.Text = "Back";
            this.btn_empInfoBack.UseVisualStyleBackColor = true;
            this.btn_empInfoBack.Click += new System.EventHandler(this.btn_empInfoBack_Click);
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Book Antiqua", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(256, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(403, 62);
            this.lbl1.TabIndex = 33;
            this.lbl1.Text = "Employees Info";
            // 
            // txt_empBid
            // 
            this.txt_empBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empBid.Location = new System.Drawing.Point(454, 344);
            this.txt_empBid.Multiline = true;
            this.txt_empBid.Name = "txt_empBid";
            this.txt_empBid.Size = new System.Drawing.Size(256, 38);
            this.txt_empBid.TabIndex = 32;
            // 
            // txt_empEmail
            // 
            this.txt_empEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empEmail.Location = new System.Drawing.Point(454, 285);
            this.txt_empEmail.Multiline = true;
            this.txt_empEmail.Name = "txt_empEmail";
            this.txt_empEmail.Size = new System.Drawing.Size(256, 38);
            this.txt_empEmail.TabIndex = 31;
            // 
            // txt_empSalary
            // 
            this.txt_empSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empSalary.Location = new System.Drawing.Point(454, 236);
            this.txt_empSalary.Multiline = true;
            this.txt_empSalary.Name = "txt_empSalary";
            this.txt_empSalary.Size = new System.Drawing.Size(256, 38);
            this.txt_empSalary.TabIndex = 30;
            // 
            // txt_empName
            // 
            this.txt_empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empName.Location = new System.Drawing.Point(454, 177);
            this.txt_empName.Multiline = true;
            this.txt_empName.Name = "txt_empName";
            this.txt_empName.Size = new System.Drawing.Size(256, 38);
            this.txt_empName.TabIndex = 29;
            // 
            // cbx_empId
            // 
            this.cbx_empId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_empId.FormattingEnabled = true;
            this.cbx_empId.ItemHeight = 29;
            this.cbx_empId.Location = new System.Drawing.Point(454, 118);
            this.cbx_empId.Name = "cbx_empId";
            this.cbx_empId.Size = new System.Drawing.Size(256, 37);
            this.cbx_empId.TabIndex = 28;
            this.cbx_empId.SelectedIndexChanged += new System.EventHandler(this.cbx_empId_SelectedIndexChanged);
            // 
            // empInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 518);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl_ItemID);
            this.Controls.Add(this.btn_empInfoBack);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt_empBid);
            this.Controls.Add(this.txt_empEmail);
            this.Controls.Add(this.txt_empSalary);
            this.Controls.Add(this.txt_empName);
            this.Controls.Add(this.cbx_empId);
            this.Name = "empInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emplyees Info";
            this.Load += new System.EventHandler(this.empInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl_ItemID;
        private System.Windows.Forms.Button btn_empInfoBack;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt_empBid;
        private System.Windows.Forms.TextBox txt_empEmail;
        private System.Windows.Forms.TextBox txt_empSalary;
        private System.Windows.Forms.TextBox txt_empName;
        private System.Windows.Forms.ComboBox cbx_empId;
    }
}