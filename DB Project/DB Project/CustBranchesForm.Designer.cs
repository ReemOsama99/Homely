namespace DB_Project
{
    partial class CustBranchesForm
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
            this.DGV_AllBranches = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AllBranches)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_AllBranches
            // 
            this.DGV_AllBranches.AllowUserToAddRows = false;
            this.DGV_AllBranches.AllowUserToDeleteRows = false;
            this.DGV_AllBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AllBranches.Location = new System.Drawing.Point(119, 182);
            this.DGV_AllBranches.Name = "DGV_AllBranches";
            this.DGV_AllBranches.RowTemplate.Height = 26;
            this.DGV_AllBranches.Size = new System.Drawing.Size(532, 209);
            this.DGV_AllBranches.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branches";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(620, 459);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(118, 39);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // CustBranchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 518);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_AllBranches);
            this.Name = "CustBranchesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustBranchesForm";
            this.Load += new System.EventHandler(this.ViewingBranchesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AllBranches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_AllBranches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back;
    }
}