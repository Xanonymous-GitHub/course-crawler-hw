﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseCrawler
{
    public partial class CourseManagementForm : Form
    {
        public CourseManagementForm()
        {
            InitializeComponent();

            _formViewModel = new();
        }

        private readonly CourseManagementFormViewModel _formViewModel;

        // CourseManagementForm_Load
        private void CourseManagementForm_Load(object sender, EventArgs e)
        {
            BindCompomentsToData();
            CourseListBox.ClearSelected();
            SupportedDataSourceInfo.GetAllCombinedNames.ForEach(name => CourseClassComboBox.Items.Add(name));
        }

        // BindCompomentsToData
        private void BindCompomentsToData()
        {
            CourseListBox.DataSource = _formViewModel.CoursesToBeEditStr;
        }

        private void CourseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseListBox.SelectedIndex < 0) return;
            (int dataSourceIndex, ICourse course) = _formViewModel.GenerateEditableFieldContens(CourseListBox.SelectedIndex);
            
            CourseNumberTextBox.Text = course.Serial;
            CourseNameTextBox.Text = course.Name;
            CourseLevelTextBox.Text = course.Level;
            CourseCreditTextBox.Text = course.Credit;
        }
    }
}
