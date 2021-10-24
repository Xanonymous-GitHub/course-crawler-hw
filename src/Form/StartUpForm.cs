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
    public partial class StartUpForm : Form
    {
        public StartUpForm()
        {
            InitializeComponent();

            _formViewModel = new();
        }

        private StartUpFormViewModel _formViewModel;

        // Event handler for StartUpForm FormClosed.
        private void StartUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }
        
        // Event handler for ExitButton Click.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        // Event handler for CourseSelectingSystemButton Click.
        private void CourseSelectingSystemButton_Click(object sender, EventArgs e)
        {
            SelectCourseForm selectCourseForm = new();
            _formViewModel.AcceptToOpenSelectCourseForm = false;
            selectCourseForm.FormClosed += new((object sender, FormClosedEventArgs e) => _formViewModel.AcceptToOpenSelectCourseForm = true);
            selectCourseForm.Show();
        }

        // Event handler for CourseManagementSystemButton Click.
        private void CourseManagementSystemButton_Click(object sender, EventArgs e)
        {
            CourseManagementForm courseManagementForm = new();
            _formViewModel.AcceptToOpenCourseManagementForm = false;
            courseManagementForm.ShowDialog();
            _formViewModel.AcceptToOpenCourseManagementForm = true;
        }

        // StartUpForm_Load
        private void StartUpForm_Load(object sender, EventArgs e)
        {
            BindComponents();
        }

        // BindComponents
        private void BindComponents()
        {
            CourseSelectingSystemButton.DataBindings.Add(nameof(Enabled), _formViewModel, nameof(_formViewModel.AcceptToOpenSelectCourseForm), true);
            CourseManagementSystemButton.DataBindings.Add(nameof(Enabled), _formViewModel, nameof(_formViewModel.AcceptToOpenCourseManagementForm), true);
        }
    }
}
