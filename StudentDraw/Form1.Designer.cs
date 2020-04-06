namespace StudentDraw
{
    partial class Form1
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
            this.btn_AddNewGroup = new System.Windows.Forms.Button();
            this.btn_StartClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddNewGroup
            // 
            this.btn_AddNewGroup.Location = new System.Drawing.Point(13, 14);
            this.btn_AddNewGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_AddNewGroup.Name = "btn_AddNewGroup";
            this.btn_AddNewGroup.Size = new System.Drawing.Size(282, 298);
            this.btn_AddNewGroup.TabIndex = 0;
            this.btn_AddNewGroup.Text = "Add new group";
            this.btn_AddNewGroup.UseVisualStyleBackColor = true;
            this.btn_AddNewGroup.Click += new System.EventHandler(this.btn_AddNewGroup_Click);
            // 
            // btn_StartClass
            // 
            this.btn_StartClass.Location = new System.Drawing.Point(303, 14);
            this.btn_StartClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_StartClass.Name = "btn_StartClass";
            this.btn_StartClass.Size = new System.Drawing.Size(274, 298);
            this.btn_StartClass.TabIndex = 1;
            this.btn_StartClass.Text = "Start class";
            this.btn_StartClass.UseVisualStyleBackColor = true;
            this.btn_StartClass.Click += new System.EventHandler(this.btn_StartClass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 327);
            this.Controls.Add(this.btn_StartClass);
            this.Controls.Add(this.btn_AddNewGroup);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddNewGroup;
        private System.Windows.Forms.Button btn_StartClass;
    }
}

