namespace DB_Project
{
    partial class ViewCategoryItems
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
            this.lbl_n = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cbx_categName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_n
            // 
            this.lbl_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n.Location = new System.Drawing.Point(59, 127);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(278, 42);
            this.lbl_n.TabIndex = 38;
            this.lbl_n.Text = "Category Name";
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Book Antiqua", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(211, 40);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(403, 62);
            this.lbl1.TabIndex = 37;
            this.lbl1.Text = "Category Items";
            // 
            // cbx_categName
            // 
            this.cbx_categName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_categName.FormattingEnabled = true;
            this.cbx_categName.ItemHeight = 29;
            this.cbx_categName.Location = new System.Drawing.Point(509, 127);
            this.cbx_categName.Name = "cbx_categName";
            this.cbx_categName.Size = new System.Drawing.Size(256, 37);
            this.cbx_categName.TabIndex = 36;
            this.cbx_categName.SelectedIndexChanged += new System.EventHandler(this.cbx_categName_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 302);
            this.dataGridView1.TabIndex = 39;
            // 
            // ViewCategoryItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 518);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_n);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cbx_categName);
            this.Name = "ViewCategoryItems";
            this.Text = "ViewCategoryItems";
            this.Load += new System.EventHandler(this.ViewCategoryItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cbx_categName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}