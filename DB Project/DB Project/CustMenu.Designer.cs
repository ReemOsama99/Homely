namespace DB_Project
{
    partial class CustMenu
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
            this.btn_custviewItems = new System.Windows.Forms.Button();
            this.lbl_custMenutitle = new System.Windows.Forms.Label();
            this.btn_custMenuback = new System.Windows.Forms.Button();
            this.btn_custViewBranches = new System.Windows.Forms.Button();
            this.btn_categItems = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_custviewItems
            // 
            this.btn_custviewItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_custviewItems.Location = new System.Drawing.Point(261, 186);
            this.btn_custviewItems.Margin = new System.Windows.Forms.Padding(2);
            this.btn_custviewItems.Name = "btn_custviewItems";
            this.btn_custviewItems.Size = new System.Drawing.Size(419, 59);
            this.btn_custviewItems.TabIndex = 0;
            this.btn_custviewItems.Text = "Branch Items";
            this.btn_custviewItems.UseVisualStyleBackColor = true;
            this.btn_custviewItems.Click += new System.EventHandler(this.btn_custviewItems_Click);
            // 
            // lbl_custMenutitle
            // 
            this.lbl_custMenutitle.Font = new System.Drawing.Font("Book Antiqua", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custMenutitle.Location = new System.Drawing.Point(387, 9);
            this.lbl_custMenutitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_custMenutitle.Name = "lbl_custMenutitle";
            this.lbl_custMenutitle.Size = new System.Drawing.Size(230, 78);
            this.lbl_custMenutitle.TabIndex = 2;
            this.lbl_custMenutitle.Text = "Menu";
            this.lbl_custMenutitle.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // btn_custMenuback
            // 
            this.btn_custMenuback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_custMenuback.Location = new System.Drawing.Point(21, 433);
            this.btn_custMenuback.Margin = new System.Windows.Forms.Padding(2);
            this.btn_custMenuback.Name = "btn_custMenuback";
            this.btn_custMenuback.Size = new System.Drawing.Size(186, 58);
            this.btn_custMenuback.TabIndex = 16;
            this.btn_custMenuback.Text = "Back";
            this.btn_custMenuback.UseVisualStyleBackColor = true;
            this.btn_custMenuback.Click += new System.EventHandler(this.btn_custMenuback_Click);
            // 
            // btn_custViewBranches
            // 
            this.btn_custViewBranches.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_custViewBranches.Location = new System.Drawing.Point(261, 276);
            this.btn_custViewBranches.Margin = new System.Windows.Forms.Padding(2);
            this.btn_custViewBranches.Name = "btn_custViewBranches";
            this.btn_custViewBranches.Size = new System.Drawing.Size(419, 59);
            this.btn_custViewBranches.TabIndex = 18;
            this.btn_custViewBranches.Text = "View Branches";
            this.btn_custViewBranches.UseVisualStyleBackColor = true;
            this.btn_custViewBranches.Click += new System.EventHandler(this.btn_custViewBranches_Click);
            // 
            // btn_categItems
            // 
            this.btn_categItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categItems.Location = new System.Drawing.Point(261, 89);
            this.btn_categItems.Margin = new System.Windows.Forms.Padding(2);
            this.btn_categItems.Name = "btn_categItems";
            this.btn_categItems.Size = new System.Drawing.Size(419, 59);
            this.btn_categItems.TabIndex = 19;
            this.btn_categItems.Text = "Category Items";
            this.btn_categItems.UseVisualStyleBackColor = true;
            this.btn_categItems.Click += new System.EventHandler(this.btn_categItems_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 360);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(419, 59);
            this.button1.TabIndex = 20;
            this.button1.Text = "Categories Price Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_categItems);
            this.Controls.Add(this.btn_custViewBranches);
            this.Controls.Add(this.btn_custMenuback);
            this.Controls.Add(this.lbl_custMenutitle);
            this.Controls.Add(this.btn_custviewItems);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_custviewItems;
        private System.Windows.Forms.Label lbl_custMenutitle;
        private System.Windows.Forms.Button btn_custMenuback;
        private System.Windows.Forms.Button btn_custViewBranches;
        private System.Windows.Forms.Button btn_categItems;
        private System.Windows.Forms.Button button1;
    }
}