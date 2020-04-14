namespace DB_Project
{
    partial class AddCategory
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
            this.lbl_AddCattitle = new System.Windows.Forms.Label();
            this.txt_addCatID = new System.Windows.Forms.TextBox();
            this.txt_addCatName = new System.Windows.Forms.TextBox();
            this.lbl_AddCatName = new System.Windows.Forms.Label();
            this.lbl_addCatID = new System.Windows.Forms.Label();
            this.btn_AddCat = new System.Windows.Forms.Button();
            this.btn_AddCatback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_AddCattitle
            // 
            this.lbl_AddCattitle.Font = new System.Drawing.Font("Book Antiqua", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddCattitle.Location = new System.Drawing.Point(293, 54);
            this.lbl_AddCattitle.Name = "lbl_AddCattitle";
            this.lbl_AddCattitle.Size = new System.Drawing.Size(386, 75);
            this.lbl_AddCattitle.TabIndex = 4;
            this.lbl_AddCattitle.Text = "Add Category";
            // 
            // txt_addCatID
            // 
            this.txt_addCatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addCatID.Location = new System.Drawing.Point(322, 191);
            this.txt_addCatID.Multiline = true;
            this.txt_addCatID.Name = "txt_addCatID";
            this.txt_addCatID.Size = new System.Drawing.Size(256, 38);
            this.txt_addCatID.TabIndex = 12;
            // 
            // txt_addCatName
            // 
            this.txt_addCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addCatName.Location = new System.Drawing.Point(322, 340);
            this.txt_addCatName.Multiline = true;
            this.txt_addCatName.Name = "txt_addCatName";
            this.txt_addCatName.Size = new System.Drawing.Size(256, 38);
            this.txt_addCatName.TabIndex = 13;
            // 
            // lbl_AddCatName
            // 
            this.lbl_AddCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddCatName.Location = new System.Drawing.Point(33, 340);
            this.lbl_AddCatName.Name = "lbl_AddCatName";
            this.lbl_AddCatName.Size = new System.Drawing.Size(223, 35);
            this.lbl_AddCatName.TabIndex = 14;
            this.lbl_AddCatName.Text = "Category Name";
            // 
            // lbl_addCatID
            // 
            this.lbl_addCatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addCatID.Location = new System.Drawing.Point(56, 181);
            this.lbl_addCatID.Name = "lbl_addCatID";
            this.lbl_addCatID.Size = new System.Drawing.Size(168, 35);
            this.lbl_addCatID.TabIndex = 15;
            this.lbl_addCatID.Text = "CatID";
            // 
            // btn_AddCat
            // 
            this.btn_AddCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCat.Location = new System.Drawing.Point(623, 441);
            this.btn_AddCat.Name = "btn_AddCat";
            this.btn_AddCat.Size = new System.Drawing.Size(224, 53);
            this.btn_AddCat.TabIndex = 17;
            this.btn_AddCat.Text = "Add";
            this.btn_AddCat.UseVisualStyleBackColor = true;
            this.btn_AddCat.Click += new System.EventHandler(this.btn_AddCat_Click);
            // 
            // btn_AddCatback
            // 
            this.btn_AddCatback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCatback.Location = new System.Drawing.Point(62, 445);
            this.btn_AddCatback.Name = "btn_AddCatback";
            this.btn_AddCatback.Size = new System.Drawing.Size(194, 49);
            this.btn_AddCatback.TabIndex = 18;
            this.btn_AddCatback.Text = "Back";
            this.btn_AddCatback.UseVisualStyleBackColor = true;
            this.btn_AddCatback.Click += new System.EventHandler(this.btn_AddCatback_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 518);
            this.Controls.Add(this.btn_AddCatback);
            this.Controls.Add(this.btn_AddCat);
            this.Controls.Add(this.lbl_addCatID);
            this.Controls.Add(this.lbl_AddCatName);
            this.Controls.Add(this.txt_addCatName);
            this.Controls.Add(this.txt_addCatID);
            this.Controls.Add(this.lbl_AddCattitle);
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategory";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AddCattitle;
        private System.Windows.Forms.TextBox txt_addCatID;
        private System.Windows.Forms.TextBox txt_addCatName;
        private System.Windows.Forms.Label lbl_AddCatName;
        private System.Windows.Forms.Label lbl_addCatID;
        private System.Windows.Forms.Button btn_AddCat;
        private System.Windows.Forms.Button btn_AddCatback;
    }
}