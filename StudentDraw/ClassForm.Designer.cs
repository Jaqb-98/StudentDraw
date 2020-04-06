namespace StudentDraw
{
    partial class ClassForm
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
            this.btn_DrawStudent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_AnswerCounter = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.rb_Answered = new System.Windows.Forms.RadioButton();
            this.rb_DidNotAnswer = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DrawStudent
            // 
            this.btn_DrawStudent.Location = new System.Drawing.Point(12, 12);
            this.btn_DrawStudent.Name = "btn_DrawStudent";
            this.btn_DrawStudent.Size = new System.Drawing.Size(179, 61);
            this.btn_DrawStudent.TabIndex = 0;
            this.btn_DrawStudent.Text = "Draw a student";
            this.btn_DrawStudent.UseVisualStyleBackColor = true;
            this.btn_DrawStudent.Click += new System.EventHandler(this.btn_DrawStudent_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_DidNotAnswer);
            this.panel1.Controls.Add(this.rb_Answered);
            this.panel1.Controls.Add(this.btn_Submit);
            this.panel1.Controls.Add(this.lbl_AnswerCounter);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(224, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 225);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(20, 25);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(0, 28);
            this.lbl_Name.TabIndex = 0;
            // 
            // lbl_AnswerCounter
            // 
            this.lbl_AnswerCounter.AutoSize = true;
            this.lbl_AnswerCounter.Location = new System.Drawing.Point(19, 78);
            this.lbl_AnswerCounter.Name = "lbl_AnswerCounter";
            this.lbl_AnswerCounter.Size = new System.Drawing.Size(0, 28);
            this.lbl_AnswerCounter.TabIndex = 1;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Submit.Location = new System.Drawing.Point(427, 130);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(94, 45);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // rb_Answered
            // 
            this.rb_Answered.AutoSize = true;
            this.rb_Answered.Location = new System.Drawing.Point(13, 131);
            this.rb_Answered.Name = "rb_Answered";
            this.rb_Answered.Size = new System.Drawing.Size(118, 32);
            this.rb_Answered.TabIndex = 3;
            this.rb_Answered.TabStop = true;
            this.rb_Answered.Text = "Answered";
            this.rb_Answered.UseVisualStyleBackColor = true;
            // 
            // rb_DidNotAnswer
            // 
            this.rb_DidNotAnswer.AutoSize = true;
            this.rb_DidNotAnswer.Location = new System.Drawing.Point(137, 131);
            this.rb_DidNotAnswer.Name = "rb_DidNotAnswer";
            this.rb_DidNotAnswer.Size = new System.Drawing.Size(164, 32);
            this.rb_DidNotAnswer.TabIndex = 4;
            this.rb_DidNotAnswer.TabStop = true;
            this.rb_DidNotAnswer.Text = "Did not answer";
            this.rb_DidNotAnswer.UseVisualStyleBackColor = true;
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 225);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_DrawStudent);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClassForm";
            this.Text = "ClassForm";
            this.Load += new System.EventHandler(this.ClassForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DrawStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_AnswerCounter;
        private System.Windows.Forms.RadioButton rb_DidNotAnswer;
        private System.Windows.Forms.RadioButton rb_Answered;
        private System.Windows.Forms.Button btn_Submit;
    }
}