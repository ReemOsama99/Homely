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
            this.btn_custSearch = new System.Windows.Forms.Button();
            this.lbl_custMenutitle = new System.Windows.Forms.Label();
            this.btn_custMenuback = new System.Windows.Forms.Button();
            this.btn_custViewBranches = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_custviewItems
            // 
            this.btn_custviewItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_custviewItems.Location = new System.Drawing.Point(290, 158);
            this.btn_custviewItems.Margin = new System.Windows.Forms.Padding(2);
            this.btn_custviewItems.Name = "btn_custviewItems";
            this.btn_custviewItems.Size = new System.Drawing.Size(258, 59);
            this.btn_custviewItems.TabIndex = 0;
            this.btn_custviewItems.Text = "View Items";
            this.btn_custviewItems.UseVisualStyleBackColor = true;
            this.btn_custviewItems.Click += new System.EventHandler(this.btn_custviewItems_Click);
            // 
            // btn_custSearch
            // 
            this.btn_custSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_custSearch.Location = new System.Drawing.Point(290, 315);
            this.btn_custSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_custSearch.Name = "btn_custSearch";
            this.btn_custSearch.Size = new System.Drawing.Size(258, 59);
            this.btn_custSearch.TabIndex = 1;
            this.btn_custSearch.Text = "Search Order";
            this.btn_custSearch.UseVisualStyleBackColor = true;
            this.btn_custSearch.Click += new System.EventHandler(this.btn_custSearch_Click);
            // 
            // lbl_custMenutitle
            // 
            this.lbl_custMenutitle.Font = new System.Drawing.Font("Book Antiqua", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custMenutitle.Location = new System.Drawing.Point(320, 41);
            this.lbl_custMenutitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_custMenutitle.Name = "lbl_custMenutitle";
            this.lbl_custMenutitle.Size = new System.Drawing.Size(201, 78);
            this.lbl_custMenutitle.TabIndex = 2;
            this.lbl_custMenutitle.Text = "Menu";
            this.lbl_custMenutitle.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // btn_custMenuback
            // 
            this.btn_custMenuback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_custMenuback.Location = new System.Drawing.Point(49, 418);
            this.btn_custMenuback.Margin = new System.Windows.Forms.Padding(2);
            this.btn_custMenuback.Name = "btn_custMenuback";
            this.btn_custMenuback.Size = new System.Drawing.Size(224, 65);
            this.btn_custMenuback.TabIndex = 16;
            this.btn_custMenuback.Text = "Back";
            this.btn_custMenuback.UseVisualStyleBackColor = true;
            this.btn_custMenuback.Click += new System.EventHandler(this.btn_custMenuback_Click);
            // 
            // btn_custViewBranches
            // 
            this.btn_custViewBranches.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_custViewBranches.Location = new System.Drawing.Point(290, 233);
            this.btn_custViewBranches.Margin = new System.Windows.Forms.Padding(2);
            this.btn_custViewBranches.Name = "btn_custViewBranches";
            this.btn_custViewBranches.Size = new System.Drawing.Size(258, 59);
            this.btn_custViewBranches.TabIndex = 18;
            this.btn_custViewBranches.Text = "View Branches";
            this.btn_custViewBranches.UseVisualStyleBackColor = true;
            this.btn_custViewBranches.Click += new System.EventHandler(this.btn_custViewBranches_Click);
            // 
            // CustMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 518);
            this.Controls.Add(this.btn_custViewBranches);
            this.Controls.Add(this.btn_custMenuback);
            this.Controls.Add(this.lbl_custMenutitle);
            this.Controls.Add(this.btn_custSearch);
            this.Controls.Add(this.btn_custviewItems);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_custviewItems;
        private System.Windows.Forms.Button btn_custSearch;
        private System.Windows.Forms.Label lbl_custMenutitle;
        private System.Windows.Forms.Button btn_custMenuback;
        private System.Windows.Forms.Button btn_custViewBranches;
    }
}