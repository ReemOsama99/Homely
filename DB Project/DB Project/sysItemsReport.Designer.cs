namespace DB_Project
{
    partial class sysItemsReport
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
            this.ItemsReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ItemsReportViewer1
            // 
            this.ItemsReportViewer1.ActiveViewIndex = -1;
            this.ItemsReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemsReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItemsReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.ItemsReportViewer1.Name = "ItemsReportViewer1";
            this.ItemsReportViewer1.Size = new System.Drawing.Size(984, 461);
            this.ItemsReportViewer1.TabIndex = 0;
            // 
            // sysItemsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.ItemsReportViewer1);
            this.Name = "sysItemsReport";
            this.Text = "sysItemsReport";
            this.Load += new System.EventHandler(this.sysItemsReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ItemsReportViewer1;
    }
}