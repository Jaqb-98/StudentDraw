namespace StudentDraw
{
    partial class ChooseGroupForm
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
            this.dgv_AvilableGroups = new System.Windows.Forms.DataGridView();
            this.lbl_ChooseGroup = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AvilableGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AvilableGroups
            // 
            this.dgv_AvilableGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AvilableGroups.Location = new System.Drawing.Point(12, 42);
            this.dgv_AvilableGroups.Name = "dgv_AvilableGroups";
            this.dgv_AvilableGroups.RowHeadersWidth = 51;
            this.dgv_AvilableGroups.RowTemplate.Height = 24;
            this.dgv_AvilableGroups.Size = new System.Drawing.Size(457, 303);
            this.dgv_AvilableGroups.TabIndex = 0;
            this.dgv_AvilableGroups.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AvilableGroups_CellContentDoubleClick);
            // 
            // lbl_ChooseGroup
            // 
            this.lbl_ChooseGroup.AutoSize = true;
            this.lbl_ChooseGroup.Location = new System.Drawing.Point(12, 11);
            this.lbl_ChooseGroup.Name = "lbl_ChooseGroup";
            this.lbl_ChooseGroup.Size = new System.Drawing.Size(136, 28);
            this.lbl_ChooseGroup.TabIndex = 1;
            this.lbl_ChooseGroup.Text = "Choose group";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 369);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(96, 54);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // ChooseGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 437);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_ChooseGroup);
            this.Controls.Add(this.dgv_AvilableGroups);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChooseGroupForm";
            this.Text = "ChooseGroupForm";
            this.Load += new System.EventHandler(this.LoadGroupList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AvilableGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AvilableGroups;
        private System.Windows.Forms.Label lbl_ChooseGroup;
        private System.Windows.Forms.Button btn_Back;
    }
}