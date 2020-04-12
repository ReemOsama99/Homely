namespace DB_Project
{
    partial class CustItemsForm
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
            this.cmb_Branches = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_AllItems = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AllItems)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Branches
            // 
            this.cmb_Branches.FormattingEnabled = true;
            this.cmb_Branches.Location = new System.Drawing.Point(407, 129);
            this.cmb_Branches.Name = "cmb_Branches";
            this.cmb_Branches.Size = new System.Drawing.Size(158, 24);
            this.cmb_Branches.TabIndex = 0;
            this.cmb_Branches.SelectedIndexChanged += new System.EventHandler(this.cmb_Branches_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Branch";
            // 
            // DGV_AllItems
            // 
            this.DGV_AllItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AllItems.Location = new System.Drawing.Point(66, 203);
            this.DGV_AllItems.Name = "DGV_AllItems";
            this.DGV_AllItems.RowTemplate.Height = 26;
            this.DGV_AllItems.Size = new System.Drawing.Size(616, 223);
            this.DGV_AllItems.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Avaliable Items";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(619, 470);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(126, 36);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 518);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_AllItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Branches);
            this.Name = "CustItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustItemsForm";
            this.Load += new System.EventHandler(this.CustItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AllItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Branches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_AllItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Back;
    }
}