namespace DB_Project
{
    partial class ViewSupp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSupp));
            this.cbx_SuppName = new System.Windows.Forms.ComboBox();
            this.txt_suppNumber = new System.Windows.Forms.TextBox();
            this.lbl_ViewSuppNum = new System.Windows.Forms.Label();
            this.lbl_viewSuppName = new System.Windows.Forms.Label();
            this.btn_viewSuppBack = new System.Windows.Forms.Button();
            this.lbl_sysLoginTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_SuppName
            // 
            this.cbx_SuppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_SuppName.FormattingEnabled = true;
            this.cbx_SuppName.Location = new System.Drawing.Point(312, 127);
            this.cbx_SuppName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_SuppName.Name = "cbx_SuppName";
            this.cbx_SuppName.Size = new System.Drawing.Size(193, 28);
            this.cbx_SuppName.TabIndex = 0;
            this.cbx_SuppName.SelectedIndexChanged += new System.EventHandler(this.cbx_SuppName_SelectedIndexChanged);
            // 
            // txt_suppNumber
            // 
            this.txt_suppNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suppNumber.Location = new System.Drawing.Point(313, 189);
            this.txt_suppNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_suppNumber.Multiline = true;
            this.txt_suppNumber.Name = "txt_suppNumber";
            this.txt_suppNumber.Size = new System.Drawing.Size(193, 32);
            this.txt_suppNumber.TabIndex = 14;
            // 
            // lbl_ViewSuppNum
            // 
            this.lbl_ViewSuppNum.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ViewSuppNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ViewSuppNum.Location = new System.Drawing.Point(138, 189);
            this.lbl_ViewSuppNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ViewSuppNum.Name = "lbl_ViewSuppNum";
            this.lbl_ViewSuppNum.Size = new System.Drawing.Size(157, 34);
            this.lbl_ViewSuppNum.TabIndex = 22;
            this.lbl_ViewSuppNum.Text = "Number";
            // 
            // lbl_viewSuppName
            // 
            this.lbl_viewSuppName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_viewSuppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewSuppName.Location = new System.Drawing.Point(138, 127);
            this.lbl_viewSuppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_viewSuppName.Name = "lbl_viewSuppName";
            this.lbl_viewSuppName.Size = new System.Drawing.Size(87, 34);
            this.lbl_viewSuppName.TabIndex = 24;
            this.lbl_viewSuppName.Text = "Name";
            this.lbl_viewSuppName.Click += new System.EventHandler(this.lbl_viewSuppName_Click);
            // 
            // btn_viewSuppBack
            // 
            this.btn_viewSuppBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_viewSuppBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewSuppBack.ForeColor = System.Drawing.Color.Yellow;
            this.btn_viewSuppBack.Location = new System.Drawing.Point(253, 351);
            this.btn_viewSuppBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_viewSuppBack.Name = "btn_viewSuppBack";
            this.btn_viewSuppBack.Size = new System.Drawing.Size(206, 42);
            this.btn_viewSuppBack.TabIndex = 25;
            this.btn_viewSuppBack.Text = "Back";
            this.btn_viewSuppBack.UseVisualStyleBackColor = false;
            this.btn_viewSuppBack.Click += new System.EventHandler(this.btn_viewSuppBack_Click);
            // 
            // lbl_sysLoginTitle
            // 
            this.lbl_sysLoginTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sysLoginTitle.Font = new System.Drawing.Font("Book Antiqua", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sysLoginTitle.Location = new System.Drawing.Point(244, 25);
            this.lbl_sysLoginTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sysLoginTitle.Name = "lbl_sysLoginTitle";
            this.lbl_sysLoginTitle.Size = new System.Drawing.Size(224, 50);
            this.lbl_sysLoginTitle.TabIndex = 26;
            this.lbl_sysLoginTitle.Text = "Suppliers";
            // 
            // ViewSupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(707, 421);
            this.Controls.Add(this.lbl_sysLoginTitle);
            this.Controls.Add(this.btn_viewSuppBack);
            this.Controls.Add(this.lbl_viewSuppName);
            this.Controls.Add(this.lbl_ViewSuppNum);
            this.Controls.Add(this.txt_suppNumber);
            this.Controls.Add(this.cbx_SuppName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewSupp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSupp";
            this.Load += new System.EventHandler(this.ViewSupp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_SuppName;
        private System.Windows.Forms.TextBox txt_suppNumber;
        private System.Windows.Forms.Label lbl_ViewSuppNum;
        private System.Windows.Forms.Label lbl_viewSuppName;
        private System.Windows.Forms.Button btn_viewSuppBack;
        private System.Windows.Forms.Label lbl_sysLoginTitle;
    }
}