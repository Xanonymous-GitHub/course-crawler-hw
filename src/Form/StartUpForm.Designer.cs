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
            this.CourseSelectingSystemButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CourseSelectingSystemButton.Location = new System.Drawing.Point(11, 9);
            this.CourseSelectingSystemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CourseSelectingSystemButton.Name = "CourseSelectingSystemButton";
            this.CourseSelectingSystemButton.Size = new System.Drawing.Size(323, 52);
            this.CourseSelectingSystemButton.TabIndex = 0;
            this.CourseSelectingSystemButton.Text = "Select Course";
            this.CourseSelectingSystemButton.UseVisualStyleBackColor = true;
            this.CourseSelectingSystemButton.Click += new System.EventHandler(this.CourseSelectingSystemButton_Click);
            // 
            // CourseManagementSystemButton
            // 
            this.CourseManagementSystemButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CourseManagementSystemButton.Location = new System.Drawing.Point(11, 66);
            this.CourseManagementSystemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CourseManagementSystemButton.Name = "CourseManagementSystemButton";
            this.CourseManagementSystemButton.Size = new System.Drawing.Size(323, 52);
            this.CourseManagementSystemButton.TabIndex = 1;
            this.CourseManagementSystemButton.Text = "Manage Course";
            this.CourseManagementSystemButton.UseVisualStyleBackColor = true;
            this.CourseManagementSystemButton.Click += new System.EventHandler(this.CourseManagementSystemButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ExitButton.Location = new System.Drawing.Point(236, 123);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(98, 26);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Font = new System.Drawing.Font("微軟正黑體", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CopyrightLabel.Location = new System.Drawing.Point(12, 129);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(223, 18);
            this.CopyrightLabel.TabIndex = 3;
            this.CopyrightLabel.Text = "Copyright (C) 2021 Xanonymous";
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 159);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CourseManagementSystemButton);
            this.Controls.Add(this.CourseSelectingSystemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "StartUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartUpForm_FormClosed);
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