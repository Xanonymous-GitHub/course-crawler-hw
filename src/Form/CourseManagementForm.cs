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
            SetupDefaultState();
        }

        // SetupDefaultState
        private void SetupDefaultState()
        {
            CourseListBox.ClearSelected();
            CourseEnabledComboBox.SelectedIndex = 0;
            SupportedDataSourceInfo.GetAllCombinedNames.ForEach(name => CourseClassComboBox.Items.Add(name));
            Consts.CourseSymbols.Skip(1).ToList().ForEach(symbol => CourseTypeComboBox.Items.Add(symbol));
        }

        // BindCompomentsToData
        private void BindCompomentsToData()
        {
            CourseListBox.DataSource = _formViewModel.CoursesToBeEditStrList;
            _formViewModel.PropertyChanged += UpdateDisplayedCompoments;
        }

        // GenerateCourseSectionCheckBoxGridView
        private void GenerateCourseSectionCheckBoxGridView(List<List<bool>> weekTimeStates)
        {
            
        }


        // UpdateDisplayedCompoments
        private void UpdateDisplayedCompoments(object sender, PropertyChangedEventArgs e)
        {
            ICourse course = _formViewModel.CurrentEditingCourse.course;
            int dataSourceIndex = _formViewModel.CurrentEditingCourse.dataSourceIndex;

            CourseNumberTextBox.Text = course.Serial;
            CourseNameTextBox.Text = course.Name;
            CourseLevelTextBox.Text = course.Level;
            CourseCreditTextBox.Text = course.Credit;
            CourseRemarkTextBox.Text = course.Remark;
            CourseTeacherTextBox.Text = string.Join(string.Empty, course.Teachers);
            CourseTAsTextBox.Text = string.Join(string.Empty, course.TAs);
            CourseLanguageTextBox.Text = course.Language.ToOriginString();
            CourseTypeComboBox.SelectedIndex = Consts.CourseSymbols.Skip(1).ToList().IndexOf(course.Type.ToOriginString());
            CourseClassComboBox.SelectedIndex = dataSourceIndex;
        }

        // CourseListBox_SelectedIndexChanged
        private void CourseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseListBox.SelectedIndex < 0) return;
            _formViewModel.GenerateEditableFieldContens(CourseListBox.SelectedIndex);
        }
    }
}
