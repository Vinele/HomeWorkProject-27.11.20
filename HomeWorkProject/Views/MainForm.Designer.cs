namespace HomeWorkProject.Views
{
    partial class MainForm
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
            this.specialityButton = new System.Windows.Forms.Button();
            this.groupButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // specialityButton
            // 
            this.specialityButton.Location = new System.Drawing.Point(25, 39);
            this.specialityButton.Name = "specialityButton";
            this.specialityButton.Size = new System.Drawing.Size(104, 23);
            this.specialityButton.TabIndex = 2;
            this.specialityButton.Text = "Специальность";
            this.specialityButton.UseVisualStyleBackColor = true;
            this.specialityButton.Click += new System.EventHandler(this.specialityButton_Click);
            // 
            // groupButton
            // 
            this.groupButton.Location = new System.Drawing.Point(265, 39);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(104, 23);
            this.groupButton.TabIndex = 3;
            this.groupButton.Text = "Группа";
            this.groupButton.UseVisualStyleBackColor = true;
            // 
            // studentButton
            // 
            this.studentButton.Location = new System.Drawing.Point(520, 39);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(104, 23);
            this.studentButton.TabIndex = 4;
            this.studentButton.Text = "Студент";
            this.studentButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.groupButton);
            this.Controls.Add(this.specialityButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button specialityButton;
        private System.Windows.Forms.Button groupButton;
        private System.Windows.Forms.Button studentButton;
    }
}

