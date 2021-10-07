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
        }

        private void CourseSelectingSystemButton_Click(object sender, EventArgs e)
        {
            SelectCourseForm selectCourseForm = new();
            selectCourseForm.ShowDialog();
        }

        private void StartUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
