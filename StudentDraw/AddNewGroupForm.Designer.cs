namespace StudentDraw
{
    partial class AddNewGroupForm
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
            this.lbl_GroupName = new System.Windows.Forms.Label();
            this.txtbox_GroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_GroupNumber = new System.Windows.Forms.NumericUpDown();
            this.lbl_GroupSign = new System.Windows.Forms.Label();
            this.txtbox_GroupSign = new System.Windows.Forms.TextBox();
            this.btn_UploadStudentsList = new System.Windows.Forms.Button();
            this.FileDialog_UploadStudentsList = new System.Windows.Forms.OpenFileDialog();
            this.btn_AddGroup = new System.Windows.Forms.Button();
            this.dgv_StudentsList = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_GroupNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentsList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_GroupName
            // 
            this.lbl_GroupName.AutoSize = true;
            this.lbl_GroupName.Location = new System.Drawing.Point(16, 16);
            this.lbl_GroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GroupName.Name = "lbl_GroupName";
            this.lbl_GroupName.Size = new System.Drawing.Size(121, 28);
            this.lbl_GroupName.TabIndex = 0;
            this.lbl_GroupName.Text = "Group name";
            // 
            // txtbox_GroupName
            // 
            this.txtbox_GroupName.Location = new System.Drawing.Point(21, 51);
            this.txtbox_GroupName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbox_GroupName.Name = "txtbox_GroupName";
            this.txtbox_GroupName.Size = new System.Drawing.Size(342, 34);
            this.txtbox_GroupName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group number";
            // 
            // num_GroupNumber
            // 
            this.num_GroupNumber.Location = new System.Drawing.Point(21, 137);
            this.num_GroupNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_GroupNumber.Name = "num_GroupNumber";
            this.num_GroupNumber.Size = new System.Drawing.Size(77, 34);
            this.num_GroupNumber.TabIndex = 3;
            // 
            // lbl_GroupSign
            // 
            this.lbl_GroupSign.AutoSize = true;
            this.lbl_GroupSign.Location = new System.Drawing.Point(16, 189);
            this.lbl_GroupSign.Name = "lbl_GroupSign";
            this.lbl_GroupSign.Size = new System.Drawing.Size(109, 28);
            this.lbl_GroupSign.TabIndex = 4;
            this.lbl_GroupSign.Text = "Group sign";
            // 
            // txtbox_GroupSign
            // 
            this.txtbox_GroupSign.Location = new System.Drawing.Point(21, 220);
            this.txtbox_GroupSign.Name = "txtbox_GroupSign";
            this.txtbox_GroupSign.Size = new System.Drawing.Size(94, 34);
            this.txtbox_GroupSign.TabIndex = 5;
            // 
            // btn_UploadStudentsList
            // 
            this.btn_UploadStudentsList.Location = new System.Drawing.Point(21, 273);
            this.btn_UploadStudentsList.Name = "btn_UploadStudentsList";
            this.btn_UploadStudentsList.Size = new System.Drawing.Size(226, 57);
            this.btn_UploadStudentsList.TabIndex = 6;
            this.btn_UploadStudentsList.Text = "Upload studnets list";
            this.btn_UploadStudentsList.UseVisualStyleBackColor = true;
            this.btn_UploadStudentsList.Click += new System.EventHandler(this.UploadStudentsList_Click);
            // 
            // FileDialog_UploadStudentsList
            // 
            this.FileDialog_UploadStudentsList.FileName = "openFileDialog1";
            this.FileDialog_UploadStudentsList.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialog_UploadStudentsList_FileOk);
            // 
            // btn_AddGroup
            // 
            this.btn_AddGroup.Enabled = false;
            this.btn_AddGroup.Location = new System.Drawing.Point(143, 348);
            this.btn_AddGroup.Name = "btn_AddGroup";
            this.btn_AddGroup.Size = new System.Drawing.Size(116, 82);
            this.btn_AddGroup.TabIndex = 8;
            this.btn_AddGroup.Text = "Add group";
            this.btn_AddGroup.UseVisualStyleBackColor = true;
            this.btn_AddGroup.Click += new System.EventHandler(this.btn_AddGroup_Click);
            // 
            // dgv_StudentsList
            // 
            this.dgv_StudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StudentsList.Location = new System.Drawing.Point(370, 51);
            this.dgv_StudentsList.Name = "dgv_StudentsList";
            this.dgv_StudentsList.RowHeadersWidth = 51;
            this.dgv_StudentsList.RowTemplate.Height = 24;
            this.dgv_StudentsList.Size = new System.Drawing.Size(366, 379);
            this.dgv_StudentsList.TabIndex = 9;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(21, 348);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(116, 82);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // AddNewGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 444);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dgv_StudentsList);
            this.Controls.Add(this.btn_AddGroup);
            this.Controls.Add(this.btn_UploadStudentsList);
            this.Controls.Add(this.txtbox_GroupSign);
            this.Controls.Add(this.lbl_GroupSign);
            this.Controls.Add(this.num_GroupNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_GroupName);
            this.Controls.Add(this.lbl_GroupName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(769, 491);
            this.MinimumSize = new System.Drawing.Size(769, 491);
            this.Name = "AddNewGroupForm";
            this.Text = "AddNewGroupForm";
            ((System.ComponentModel.ISupportInitialize)(this.num_GroupNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_GroupName;
        private System.Windows.Forms.TextBox txtbox_GroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_GroupNumber;
        private System.Windows.Forms.Label lbl_GroupSign;
        private System.Windows.Forms.TextBox txtbox_GroupSign;
        private System.Windows.Forms.Button btn_UploadStudentsList;
        private System.Windows.Forms.OpenFileDialog FileDialog_UploadStudentsList;
        private System.Windows.Forms.Button btn_AddGroup;
        private System.Windows.Forms.DataGridView dgv_StudentsList;
        private System.Windows.Forms.Button btn_Back;
    }
}