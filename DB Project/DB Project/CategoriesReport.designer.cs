namespace DB_Project
{
    partial class CategoriesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesReport));
            this.btn_catRepo = new System.Windows.Forms.Button();
            this.cbx_CatNmaeRepo = new System.Windows.Forms.ComboBox();
            this.lbl_CatIdRepo = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lbl_maxPriceRepo = new System.Windows.Forms.Label();
            this.txt_maxPriceRepo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_catRepo
            // 
            this.btn_catRepo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_catRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_catRepo.ForeColor = System.Drawing.Color.Yellow;
            this.btn_catRepo.Location = new System.Drawing.Point(1048, 17);
            this.btn_catRepo.Name = "btn_catRepo";
            this.btn_catRepo.Size = new System.Drawing.Size(133, 41);
            this.btn_catRepo.TabIndex = 1;
            this.btn_catRepo.Text = "Generate";
            this.btn_catRepo.UseVisualStyleBackColor = false;
            this.btn_catRepo.Click += new System.EventHandler(this.btn_catRepo_Click);
            // 
            // cbx_CatNmaeRepo
            // 
            this.cbx_CatNmaeRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_CatNmaeRepo.FormattingEnabled = true;
            this.cbx_CatNmaeRepo.ItemHeight = 29;
            this.cbx_CatNmaeRepo.Location = new System.Drawing.Point(259, 19);
            this.cbx_CatNmaeRepo.Name = "cbx_CatNmaeRepo";
            this.cbx_CatNmaeRepo.Size = new System.Drawing.Size(256, 37);
            this.cbx_CatNmaeRepo.TabIndex = 2;
            // 
            // lbl_CatIdRepo
            // 
            this.lbl_CatIdRepo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CatIdRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CatIdRepo.Location = new System.Drawing.Point(24, 19);
            this.lbl_CatIdRepo.Name = "lbl_CatIdRepo";
            this.lbl_CatIdRepo.Size = new System.Drawing.Size(229, 35);
            this.lbl_CatIdRepo.TabIndex = 23;
            this.lbl_CatIdRepo.Text = "Category Name";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 73);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1184, 719);
            this.crystalReportViewer1.TabIndex = 24;
            // 
            // lbl_maxPriceRepo
            // 
            this.lbl_maxPriceRepo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_maxPriceRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maxPriceRepo.Location = new System.Drawing.Point(559, 19);
            this.lbl_maxPriceRepo.Name = "lbl_maxPriceRepo";
            this.lbl_maxPriceRepo.Size = new System.Drawing.Size(168, 35);
            this.lbl_maxPriceRepo.TabIndex = 25;
            this.lbl_maxPriceRepo.Text = "Max Price";
            // 
            // txt_maxPriceRepo
            // 
            this.txt_maxPriceRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maxPriceRepo.Location = new System.Drawing.Point(733, 17);
            this.txt_maxPriceRepo.Multiline = true;
            this.txt_maxPriceRepo.Name = "txt_maxPriceRepo";
            this.txt_maxPriceRepo.Size = new System.Drawing.Size(230, 37);
            this.txt_maxPriceRepo.TabIndex = 26;
            // 
            // CategoriesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1208, 804);
            this.Controls.Add(this.txt_maxPriceRepo);
            this.Controls.Add(this.lbl_maxPriceRepo);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.lbl_CatIdRepo);
            this.Controls.Add(this.cbx_CatNmaeRepo);
            this.Controls.Add(this.btn_catRepo);
            this.Name = "CategoriesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriesReport";
            this.Load += new System.EventHandler(this.CategoriesReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_catRepo;
        private System.Windows.Forms.ComboBox cbx_CatNmaeRepo;
        private System.Windows.Forms.Label lbl_CatIdRepo;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label lbl_maxPriceRepo;
        private System.Windows.Forms.TextBox txt_maxPriceRepo;
    }
}