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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCategoryItems));
            this.lbl_n = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cbx_categName = new System.Windows.Forms.ComboBox();
            this.dgvCategItems = new System.Windows.Forms.DataGridView();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_viewSuppBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_n
            // 
            this.lbl_n.BackColor = System.Drawing.Color.Transparent;
            this.lbl_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n.Location = new System.Drawing.Point(101, 101);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(277, 42);
            this.lbl_n.TabIndex = 38;
            this.lbl_n.Text = "Category Name";
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Book Antiqua", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(97, 11);
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
            this.cbx_categName.Location = new System.Drawing.Point(384, 106);
            this.cbx_categName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_categName.Name = "cbx_categName";
            this.cbx_categName.Size = new System.Drawing.Size(256, 37);
            this.cbx_categName.TabIndex = 36;
            this.cbx_categName.SelectedIndexChanged += new System.EventHandler(this.cbx_categName_SelectedIndexChanged);
            // 
            // dgvCategItems
            // 
            this.dgvCategItems.AllowUserToAddRows = false;
            this.dgvCategItems.AllowUserToDeleteRows = false;
            this.dgvCategItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Name,
            this.price,
            this.rate});
            this.dgvCategItems.Location = new System.Drawing.Point(108, 181);
            this.dgvCategItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCategItems.Name = "dgvCategItems";
            this.dgvCategItems.ReadOnly = true;
            this.dgvCategItems.RowTemplate.Height = 24;
            this.dgvCategItems.Size = new System.Drawing.Size(387, 325);
            this.dgvCategItems.TabIndex = 39;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // rate
            // 
            this.rate.HeaderText = "Rate";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            // 
            // btn_viewSuppBack
            // 
            this.btn_viewSuppBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_viewSuppBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewSuppBack.ForeColor = System.Drawing.Color.Yellow;
            this.btn_viewSuppBack.Location = new System.Drawing.Point(587, 454);
            this.btn_viewSuppBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_viewSuppBack.Name = "btn_viewSuppBack";
            this.btn_viewSuppBack.Size = new System.Drawing.Size(275, 52);
            this.btn_viewSuppBack.TabIndex = 40;
            this.btn_viewSuppBack.Text = "Back";
            this.btn_viewSuppBack.UseVisualStyleBackColor = false;
            this.btn_viewSuppBack.Click += new System.EventHandler(this.btn_viewSuppBack_Click);
            // 
            // ViewCategoryItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(901, 534);
            this.Controls.Add(this.btn_viewSuppBack);
            this.Controls.Add(this.dgvCategItems);
            this.Controls.Add(this.lbl_n);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cbx_categName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewCategoryItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCategoryItems";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewCategoryItems_FormClosing);
            this.Load += new System.EventHandler(this.ViewCategoryItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cbx_categName;
        private System.Windows.Forms.DataGridView dgvCategItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.Button btn_viewSuppBack;
    }
}