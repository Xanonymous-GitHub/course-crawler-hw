namespace CourseCrawler
{
    partial class CourseManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseManagementForm));
            this.CommingSoonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CommingSoonLabel
            // 
            this.CommingSoonLabel.AutoSize = true;
            this.CommingSoonLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F);
            this.CommingSoonLabel.Location = new System.Drawing.Point(34, 130);
            this.CommingSoonLabel.Name = "CommingSoonLabel";
            this.CommingSoonLabel.Size = new System.Drawing.Size(636, 85);
            this.CommingSoonLabel.TabIndex = 0;
            this.CommingSoonLabel.Text = "Comming Soon!!";
            // 
            // CourseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 355);
            this.Controls.Add(this.CommingSoonLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CourseManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CommingSoonLabel;
    }
}