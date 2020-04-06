namespace StudentDraw
{
    partial class PresenceCheckForm
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
            this.btn_MarkAsPresent = new System.Windows.Forms.Button();
            this.dgv_PresenceCheck = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_AttendanceList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PresenceCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_MarkAsPresent
            // 
            this.btn_MarkAsPresent.Location = new System.Drawing.Point(12, 426);
            this.btn_MarkAsPresent.Name = "btn_MarkAsPresent";
            this.btn_MarkAsPresent.Size = new System.Drawing.Size(362, 50);
            this.btn_MarkAsPresent.TabIndex = 1;
            this.btn_MarkAsPresent.Text = "Mark as present and start class";
            this.btn_MarkAsPresent.UseVisualStyleBackColor = true;
            this.btn_MarkAsPresent.Click += new System.EventHandler(this.btn_MarkAsPresent_Click);
            // 
            // dgv_PresenceCheck
            // 
            this.dgv_PresenceCheck.AllowUserToAddRows = false;
            this.dgv_PresenceCheck.AllowUserToDeleteRows = false;
            this.dgv_PresenceCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PresenceCheck.Location = new System.Drawing.Point(12, 69);
            this.dgv_PresenceCheck.Name = "dgv_PresenceCheck";
            this.dgv_PresenceCheck.RowHeadersWidth = 51;
            this.dgv_PresenceCheck.RowTemplate.Height = 24;
            this.dgv_PresenceCheck.Size = new System.Drawing.Size(362, 348);
            this.dgv_PresenceCheck.TabIndex = 2;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 482);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(108, 59);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_AttendanceList
            // 
            this.lbl_AttendanceList.AutoSize = true;
            this.lbl_AttendanceList.Location = new System.Drawing.Point(12, 32);
            this.lbl_AttendanceList.Name = "lbl_AttendanceList";
            this.lbl_AttendanceList.Size = new System.Drawing.Size(142, 28);
            this.lbl_AttendanceList.TabIndex = 4;
            this.lbl_AttendanceList.Text = "Attendance list";
            // 
            // PresenceCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 553);
            this.Controls.Add(this.lbl_AttendanceList);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dgv_PresenceCheck);
            this.Controls.Add(this.btn_MarkAsPresent);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(430, 600);
            this.MinimumSize = new System.Drawing.Size(430, 600);
            this.Name = "PresenceCheckForm";
            this.Text = "PresenceCheckForm";
            this.Load += new System.EventHandler(this.PresenceCheckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PresenceCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_MarkAsPresent;
        private System.Windows.Forms.DataGridView dgv_PresenceCheck;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_AttendanceList;
    }
}