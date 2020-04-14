namespace DB_Project
{
    partial class sysAddItem
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
            this.btn_AddCatback = new System.Windows.Forms.Button();
            this.btn_AddCat = new System.Windows.Forms.Button();
            this.lbl_AddItemTitle = new System.Windows.Forms.Label();
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.lbl_itemQuantity = new System.Windows.Forms.Label();
            this.lbl_suppName = new System.Windows.Forms.Label();
            this.lbl_catID = new System.Windows.Forms.Label();
            this.lbl_ItemPrice = new System.Windows.Forms.Label();
            this.lbl_ItemID = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_quantityInStock = new System.Windows.Forms.TextBox();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.cbx_catID = new System.Windows.Forms.ComboBox();
            this.cbx_ItemSupp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_AddCatback
            // 
            this.btn_AddCatback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCatback.Location = new System.Drawing.Point(96, 441);
            this.btn_AddCatback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddCatback.Name = "btn_AddCatback";
            this.btn_AddCatback.Size = new System.Drawing.Size(195, 49);
            this.btn_AddCatback.TabIndex = 25;
            this.btn_AddCatback.Text = "Back";
            this.btn_AddCatback.UseVisualStyleBackColor = true;
            this.btn_AddCatback.Click += new System.EventHandler(this.btn_AddCatback_Click);
            // 
            // btn_AddCat
            // 
            this.btn_AddCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCat.Location = new System.Drawing.Point(629, 437);
            this.btn_AddCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddCat.Name = "btn_AddCat";
            this.btn_AddCat.Size = new System.Drawing.Size(224, 53);
            this.btn_AddCat.TabIndex = 24;
            this.btn_AddCat.Text = "Add";
            this.btn_AddCat.UseVisualStyleBackColor = true;
            this.btn_AddCat.Click += new System.EventHandler(this.btn_AddCat_Click);
            // 
            // lbl_AddItemTitle
            // 
            this.lbl_AddItemTitle.Font = new System.Drawing.Font("Book Antiqua", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddItemTitle.Location = new System.Drawing.Point(296, 22);
            this.lbl_AddItemTitle.Name = "lbl_AddItemTitle";
            this.lbl_AddItemTitle.Size = new System.Drawing.Size(387, 75);
            this.lbl_AddItemTitle.TabIndex = 19;
            this.lbl_AddItemTitle.Text = "Add Item";
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemName.Location = new System.Drawing.Point(123, 142);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(168, 34);
            this.lbl_ItemName.TabIndex = 39;
            this.lbl_ItemName.Text = "Name";
            // 
            // lbl_itemQuantity
            // 
            this.lbl_itemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemQuantity.Location = new System.Drawing.Point(123, 201);
            this.lbl_itemQuantity.Name = "lbl_itemQuantity";
            this.lbl_itemQuantity.Size = new System.Drawing.Size(168, 34);
            this.lbl_itemQuantity.TabIndex = 38;
            this.lbl_itemQuantity.Text = "Quantity";
            // 
            // lbl_suppName
            // 
            this.lbl_suppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suppName.Location = new System.Drawing.Point(123, 320);
            this.lbl_suppName.Name = "lbl_suppName";
            this.lbl_suppName.Size = new System.Drawing.Size(168, 34);
            this.lbl_suppName.TabIndex = 37;
            this.lbl_suppName.Text = "Supp Name";
            // 
            // lbl_catID
            // 
            this.lbl_catID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_catID.Location = new System.Drawing.Point(123, 385);
            this.lbl_catID.Name = "lbl_catID";
            this.lbl_catID.Size = new System.Drawing.Size(168, 34);
            this.lbl_catID.TabIndex = 36;
            this.lbl_catID.Text = "CatID";
            // 
            // lbl_ItemPrice
            // 
            this.lbl_ItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemPrice.Location = new System.Drawing.Point(123, 261);
            this.lbl_ItemPrice.Name = "lbl_ItemPrice";
            this.lbl_ItemPrice.Size = new System.Drawing.Size(168, 34);
            this.lbl_ItemPrice.TabIndex = 35;
            this.lbl_ItemPrice.Text = "Price";
            // 
            // lbl_ItemID
            // 
            this.lbl_ItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemID.Location = new System.Drawing.Point(123, 90);
            this.lbl_ItemID.Name = "lbl_ItemID";
            this.lbl_ItemID.Size = new System.Drawing.Size(168, 34);
            this.lbl_ItemID.TabIndex = 34;
            this.lbl_ItemID.Text = "ItemID";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(387, 256);
            this.txt_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(256, 38);
            this.txt_price.TabIndex = 31;
            // 
            // txt_quantityInStock
            // 
            this.txt_quantityInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantityInStock.Location = new System.Drawing.Point(387, 196);
            this.txt_quantityInStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_quantityInStock.Multiline = true;
            this.txt_quantityInStock.Name = "txt_quantityInStock";
            this.txt_quantityInStock.Size = new System.Drawing.Size(256, 38);
            this.txt_quantityInStock.TabIndex = 30;
            // 
            // txt_itemName
            // 
            this.txt_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemName.Location = new System.Drawing.Point(387, 139);
            this.txt_itemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_itemName.Multiline = true;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(256, 38);
            this.txt_itemName.TabIndex = 29;
            // 
            // txt_itemID
            // 
            this.txt_itemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemID.Location = new System.Drawing.Point(387, 85);
            this.txt_itemID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_itemID.Multiline = true;
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.Size = new System.Drawing.Size(256, 38);
            this.txt_itemID.TabIndex = 40;
            // 
            // cbx_catID
            // 
            this.cbx_catID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_catID.FormattingEnabled = true;
            this.cbx_catID.ItemHeight = 29;
            this.cbx_catID.Location = new System.Drawing.Point(387, 383);
            this.cbx_catID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_catID.Name = "cbx_catID";
            this.cbx_catID.Size = new System.Drawing.Size(256, 37);
            this.cbx_catID.TabIndex = 42;
            // 
            // cbx_ItemSupp
            // 
            this.cbx_ItemSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ItemSupp.FormattingEnabled = true;
            this.cbx_ItemSupp.ItemHeight = 29;
            this.cbx_ItemSupp.Location = new System.Drawing.Point(387, 318);
            this.cbx_ItemSupp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_ItemSupp.Name = "cbx_ItemSupp";
            this.cbx_ItemSupp.Size = new System.Drawing.Size(256, 37);
            this.cbx_ItemSupp.TabIndex = 43;
            // 
            // sysAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 518);
            this.Controls.Add(this.cbx_ItemSupp);
            this.Controls.Add(this.cbx_catID);
            this.Controls.Add(this.txt_itemID);
            this.Controls.Add(this.lbl_ItemName);
            this.Controls.Add(this.lbl_itemQuantity);
            this.Controls.Add(this.lbl_suppName);
            this.Controls.Add(this.lbl_catID);
            this.Controls.Add(this.lbl_ItemPrice);
            this.Controls.Add(this.lbl_ItemID);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_quantityInStock);
            this.Controls.Add(this.txt_itemName);
            this.Controls.Add(this.btn_AddCatback);
            this.Controls.Add(this.btn_AddCat);
            this.Controls.Add(this.lbl_AddItemTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "sysAddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sysAddItem";
            this.Load += new System.EventHandler(this.sysAddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddCatback;
        private System.Windows.Forms.Button btn_AddCat;
        private System.Windows.Forms.Label lbl_AddItemTitle;
        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.Label lbl_itemQuantity;
        private System.Windows.Forms.Label lbl_suppName;
        private System.Windows.Forms.Label lbl_catID;
        private System.Windows.Forms.Label lbl_ItemPrice;
        private System.Windows.Forms.Label lbl_ItemID;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_quantityInStock;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.ComboBox cbx_catID;
        private System.Windows.Forms.ComboBox cbx_ItemSupp;
    }
}