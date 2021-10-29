using System;
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
        }

        // BindCompomentsToData
        private void BindCompomentsToData()
        {
            CourseListBox.DataBindings.Add(nameof(CourseListBox.DataSource), _formViewModel, nameof(_formViewModel.CoursesToBeEditStr));
        }
    }
}
