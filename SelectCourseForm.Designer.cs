﻿namespace CourseCrawler
{
    partial class SelectCourseForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCourseForm));
            this.courseGridView = new System.Windows.Forms.DataGridView();
            this.coursePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).BeginInit();
            this.coursePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseGridView
            // 
            this.courseGridView.AllowUserToAddRows = false;
            this.courseGridView.AllowUserToDeleteRows = false;
            this.courseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseGridView.Location = new System.Drawing.Point(0, 0);
            this.courseGridView.Name = "courseGridView";
            this.courseGridView.ReadOnly = true;
            this.courseGridView.RowHeadersWidth = 51;
            this.courseGridView.RowTemplate.Height = 27;
            this.courseGridView.Size = new System.Drawing.Size(982, 703);
            this.courseGridView.TabIndex = 0;
            // 
            // coursePanel
            // 
            this.coursePanel.Controls.Add(this.courseGridView);
            this.coursePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coursePanel.Location = new System.Drawing.Point(0, 0);
            this.coursePanel.Name = "coursePanel";
            this.coursePanel.Size = new System.Drawing.Size(982, 703);
            this.coursePanel.TabIndex = 1;
            // 
            // SelectCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.coursePanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseCrawler by Xanonymous";
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).EndInit();
            this.coursePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView courseGridView;
        private System.Windows.Forms.Panel coursePanel;
    }
}

