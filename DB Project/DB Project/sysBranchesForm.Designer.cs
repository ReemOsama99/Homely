namespace DB_Project
{
    partial class sysBranchesForm
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
            this.btn_viewAllBranches = new System.Windows.Forms.Button();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.dgv_sysBranches = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sysBranches)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_viewAllBranches
            // 
            this.btn_viewAllBranches.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewAllBranches.Location = new System.Drawing.Point(30, 375);
            this.btn_viewAllBranches.Margin = new System.Windows.Forms.Padding(2);
            this.btn_viewAllBranches.Name = "btn_viewAllBranches";
            this.btn_viewAllBranches.Size = new System.Drawing.Size(203, 53);
            this.btn_viewAllBranches.TabIndex = 15;
            this.btn_viewAllBranches.Text = "View Branches";
            this.btn_viewAllBranches.UseVisualStyleBackColor = true;
            this.btn_viewAllBranches.Click += new System.EventHandler(this.btn_viewAllBranches_Click);
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveChanges.Location = new System.Drawing.Point(248, 375);
            this.btn_saveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(203, 53);
            this.btn_saveChanges.TabIndex = 16;
            this.btn_saveChanges.Text = "Save Changes";
            this.btn_saveChanges.UseVisualStyleBackColor = true;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // dgv_sysBranches
            // 
            this.dgv_sysBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sysBranches.Location = new System.Drawing.Point(30, 27);
            this.dgv_sysBranches.Name = "dgv_sysBranches";
            this.dgv_sysBranches.Size = new System.Drawing.Size(733, 308);
            this.dgv_sysBranches.TabIndex = 17;
            this.dgv_sysBranches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sysBranches_CellContentClick);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(482, 375);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(203, 53);
            this.btn_Back.TabIndex = 18;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // sysBranchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dgv_sysBranches);
            this.Controls.Add(this.btn_saveChanges);
            this.Controls.Add(this.btn_viewAllBranches);
            this.Name = "sysBranchesForm";
            this.Text = "sysBranchesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.sysBranchesForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sysBranches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_viewAllBranches;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.DataGridView dgv_sysBranches;
        private System.Windows.Forms.Button btn_Back;
    }
}