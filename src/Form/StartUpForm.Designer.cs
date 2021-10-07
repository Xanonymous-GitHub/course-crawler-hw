namespace CourseCrawler
{
    partial class StartUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUpForm));
            this.CourseSelectingSystemButton = new System.Windows.Forms.Button();
            this.CourseManagementSystemButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CourseSelectingSystemButton
            // 
            this.CourseSelectingSystemButton.Location = new System.Drawing.Point(12, 12);
            this.CourseSelectingSystemButton.Name = "CourseSelectingSystemButton";
            this.CourseSelectingSystemButton.Size = new System.Drawing.Size(363, 66);
            this.CourseSelectingSystemButton.TabIndex = 0;
            this.CourseSelectingSystemButton.Text = "Select Course";
            this.CourseSelectingSystemButton.UseVisualStyleBackColor = true;
            // 
            // CourseManagementSystemButton
            // 
            this.CourseManagementSystemButton.Location = new System.Drawing.Point(12, 84);
            this.CourseManagementSystemButton.Name = "CourseManagementSystemButton";
            this.CourseManagementSystemButton.Size = new System.Drawing.Size(363, 66);
            this.CourseManagementSystemButton.TabIndex = 1;
            this.CourseManagementSystemButton.Text = "Manage Course";
            this.CourseManagementSystemButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(265, 156);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(110, 33);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Location = new System.Drawing.Point(12, 170);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(239, 19);
            this.CopyrightLabel.TabIndex = 3;
            this.CopyrightLabel.Text = "Copyright (C) 2021 Xanonymous";
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 201);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CourseManagementSystemButton);
            this.Controls.Add(this.CourseSelectingSystemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CourseSelectingSystemButton;
        private System.Windows.Forms.Button CourseManagementSystemButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label CopyrightLabel;
    }
}