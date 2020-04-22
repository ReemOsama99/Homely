namespace DB_Project
{
    partial class UpdateItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateItem));
            this.cbx_itemId = new System.Windows.Forms.ComboBox();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_quantityInStock = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.cbx_catID = new System.Windows.Forms.ComboBox();
            this.lbl_sysLoginTitle = new System.Windows.Forms.Label();
            this.btn_IupdateIteemBack = new System.Windows.Forms.Button();
            this.btn_updateItems = new System.Windows.Forms.Button();
            this.btn_delItems = new System.Windows.Forms.Button();
            this.lbl_ItemID = new System.Windows.Forms.Label();
            this.lbl_ItemPrice = new System.Windows.Forms.Label();
            this.lbl_catID = new System.Windows.Forms.Label();
            this.lbl_suppName = new System.Windows.Forms.Label();
            this.lbl_itemQuantity = new System.Windows.Forms.Label();
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.cbx_ItemSupp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbx_itemId
            // 
            this.cbx_itemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_itemId.FormattingEnabled = true;
            this.cbx_itemId.ItemHeight = 29;
            this.cbx_itemId.Location = new System.Drawing.Point(367, 84);
            this.cbx_itemId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_itemId.Name = "cbx_itemId";
            this.cbx_itemId.Size = new System.Drawing.Size(256, 37);
            this.cbx_itemId.TabIndex = 0;
            this.cbx_itemId.SelectedIndexChanged += new System.EventHandler(this.cbx_itemId_SelectedIndexChanged);
            // 
            // txt_itemName
            // 
            this.txt_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemName.Location = new System.Drawing.Point(367, 135);
            this.txt_itemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_itemName.Multiline = true;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(256, 38);
            this.txt_itemName.TabIndex = 12;
            // 
            // txt_quantityInStock
            // 
            this.txt_quantityInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantityInStock.Location = new System.Drawing.Point(367, 192);
            this.txt_quantityInStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_quantityInStock.Multiline = true;
            this.txt_quantityInStock.Name = "txt_quantityInStock";
            this.txt_quantityInStock.Size = new System.Drawing.Size(256, 38);
            this.txt_quantityInStock.TabIndex = 14;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(367, 255);
            this.txt_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(256, 38);
            this.txt_price.TabIndex = 15;
            // 
            // cbx_catID
            // 
            this.cbx_catID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_catID.FormattingEnabled = true;
            this.cbx_catID.ItemHeight = 29;
            this.cbx_catID.Location = new System.Drawing.Point(367, 379);
            this.cbx_catID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_catID.Name = "cbx_catID";
            this.cbx_catID.Size = new System.Drawing.Size(256, 37);
            this.cbx_catID.TabIndex = 17;
            // 
            // lbl_sysLoginTitle
            // 
            this.lbl_sysLoginTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sysLoginTitle.Font = new System.Drawing.Font("Book Antiqua", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sysLoginTitle.Location = new System.Drawing.Point(356, 11);
            this.lbl_sysLoginTitle.Name = "lbl_sysLoginTitle";
            this.lbl_sysLoginTitle.Size = new System.Drawing.Size(171, 53);
            this.lbl_sysLoginTitle.TabIndex = 18;
            this.lbl_sysLoginTitle.Text = "Items";
            // 
            // btn_IupdateIteemBack
            // 
            this.btn_IupdateIteemBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_IupdateIteemBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IupdateIteemBack.ForeColor = System.Drawing.Color.Yellow;
            this.btn_IupdateIteemBack.Location = new System.Drawing.Point(689, 455);
            this.btn_IupdateIteemBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_IupdateIteemBack.Name = "btn_IupdateIteemBack";
            this.btn_IupdateIteemBack.Size = new System.Drawing.Size(179, 49);
            this.btn_IupdateIteemBack.TabIndex = 19;
            this.btn_IupdateIteemBack.Text = "Back";
            this.btn_IupdateIteemBack.UseVisualStyleBackColor = false;
            this.btn_IupdateIteemBack.Click += new System.EventHandler(this.btn_IupdateIteemBack_Click);
            // 
            // btn_updateItems
            // 
            this.btn_updateItems.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_updateItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateItems.ForeColor = System.Drawing.Color.Yellow;
            this.btn_updateItems.Location = new System.Drawing.Point(31, 455);
            this.btn_updateItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_updateItems.Name = "btn_updateItems";
            this.btn_updateItems.Size = new System.Drawing.Size(179, 49);
            this.btn_updateItems.TabIndex = 20;
            this.btn_updateItems.Text = "Update";
            this.btn_updateItems.UseVisualStyleBackColor = false;
            this.btn_updateItems.Click += new System.EventHandler(this.btn_updateItems_Click);
            // 
            // btn_delItems
            // 
            this.btn_delItems.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delItems.ForeColor = System.Drawing.Color.Yellow;
            this.btn_delItems.Location = new System.Drawing.Point(367, 455);
            this.btn_delItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delItems.Name = "btn_delItems";
            this.btn_delItems.Size = new System.Drawing.Size(179, 49);
            this.btn_delItems.TabIndex = 21;
            this.btn_delItems.Text = "Delete";
            this.btn_delItems.UseVisualStyleBackColor = false;
            this.btn_delItems.Click += new System.EventHandler(this.btn_delItems_Click);
            // 
            // lbl_ItemID
            // 
            this.lbl_ItemID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemID.Location = new System.Drawing.Point(143, 84);
            this.lbl_ItemID.Name = "lbl_ItemID";
            this.lbl_ItemID.Size = new System.Drawing.Size(168, 34);
            this.lbl_ItemID.TabIndex = 22;
            this.lbl_ItemID.Text = "ItemID";
            // 
            // lbl_ItemPrice
            // 
            this.lbl_ItemPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemPrice.Location = new System.Drawing.Point(143, 255);
            this.lbl_ItemPrice.Name = "lbl_ItemPrice";
            this.lbl_ItemPrice.Size = new System.Drawing.Size(168, 34);
            this.lbl_ItemPrice.TabIndex = 23;
            this.lbl_ItemPrice.Text = "Price";
            this.lbl_ItemPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_catID
            // 
            this.lbl_catID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_catID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_catID.Location = new System.Drawing.Point(143, 379);
            this.lbl_catID.Name = "lbl_catID";
            this.lbl_catID.Size = new System.Drawing.Size(168, 34);
            this.lbl_catID.TabIndex = 24;
            this.lbl_catID.Text = "CatID";
            // 
            // lbl_suppName
            // 
            this.lbl_suppName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_suppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suppName.Location = new System.Drawing.Point(143, 314);
            this.lbl_suppName.Name = "lbl_suppName";
            this.lbl_suppName.Size = new System.Drawing.Size(168, 34);
            this.lbl_suppName.TabIndex = 25;
            this.lbl_suppName.Text = "Supp Name";
            // 
            // lbl_itemQuantity
            // 
            this.lbl_itemQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_itemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemQuantity.Location = new System.Drawing.Point(143, 194);
            this.lbl_itemQuantity.Name = "lbl_itemQuantity";
            this.lbl_itemQuantity.Size = new System.Drawing.Size(168, 34);
            this.lbl_itemQuantity.TabIndex = 26;
            this.lbl_itemQuantity.Text = "Quantity";
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemName.Location = new System.Drawing.Point(143, 135);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(168, 34);
            this.lbl_ItemName.TabIndex = 27;
            this.lbl_ItemName.Text = "Name";
            // 
            // cbx_ItemSupp
            // 
            this.cbx_ItemSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ItemSupp.FormattingEnabled = true;
            this.cbx_ItemSupp.ItemHeight = 29;
            this.cbx_ItemSupp.Location = new System.Drawing.Point(366, 314);
            this.cbx_ItemSupp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_ItemSupp.Name = "cbx_ItemSupp";
            this.cbx_ItemSupp.Size = new System.Drawing.Size(256, 37);
            this.cbx_ItemSupp.TabIndex = 28;
            // 
            // UpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(901, 518);
            this.Controls.Add(this.cbx_ItemSupp);
            this.Controls.Add(this.lbl_ItemName);
            this.Controls.Add(this.lbl_itemQuantity);
            this.Controls.Add(this.lbl_suppName);
            this.Controls.Add(this.lbl_catID);
            this.Controls.Add(this.lbl_ItemPrice);
            this.Controls.Add(this.lbl_ItemID);
            this.Controls.Add(this.btn_delItems);
            this.Controls.Add(this.btn_updateItems);
            this.Controls.Add(this.btn_IupdateIteemBack);
            this.Controls.Add(this.lbl_sysLoginTitle);
            this.Controls.Add(this.cbx_catID);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_quantityInStock);
            this.Controls.Add(this.txt_itemName);
            this.Controls.Add(this.cbx_itemId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateItem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateItem_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateItem_FormClosed);
            this.Load += new System.EventHandler(this.UpdateItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_itemId;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.TextBox txt_quantityInStock;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.ComboBox cbx_catID;
        private System.Windows.Forms.Label lbl_sysLoginTitle;
        private System.Windows.Forms.Button btn_IupdateIteemBack;
        private System.Windows.Forms.Button btn_updateItems;
        private System.Windows.Forms.Button btn_delItems;
        private System.Windows.Forms.Label lbl_ItemID;
        private System.Windows.Forms.Label lbl_ItemPrice;
        private System.Windows.Forms.Label lbl_catID;
        private System.Windows.Forms.Label lbl_suppName;
        private System.Windows.Forms.Label lbl_itemQuantity;
        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.ComboBox cbx_ItemSupp;
    }
}