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
    public partial class SelectCourseForm : Form
    {
        public SelectCourseForm()
        {
            InitializeComponent();

            ResizeGridViewRemarkColumnWidth();

            _currentShownTabIndex = 0;

            _formViewModel = new();
        }

        private static int _currentShownTabIndex = 0;

        private SelectCourseFormViewModel _formViewModel;

        private bool _selectionResultFormShowing = false;

        private bool _updatingTabs = false;

        // ResizeGridViewRemarkColumnWidth
        private void ResizeGridViewRemarkColumnWidth()
        {
            const int remarkColumnIndex = 21;

            int columnTotalWidth = 0, gridViewWidth = 0;
            foreach(DataGridViewColumn col in CourseGridView.Columns)
            {
                columnTotalWidth += col.MinimumWidth;
                gridViewWidth += col.Width;
            }

            if (columnTotalWidth < gridViewWidth)
            {
                CourseGridView.Columns[remarkColumnIndex].MinimumWidth += (gridViewWidth - columnTotalWidth) / 2;
            }
        }

        // Event handler when SelectCourseForm Loaded.
        private void SelectCourseForm_Load(object sender, EventArgs e)
        {
            _formViewModel.PropertyChanged += HandleVMChanged;
            UpdateCourseGridView();
        }

        // HandleVMChanged
        public void HandleVMChanged(object sender, PropertyChangedEventArgs e)
        {
            UpdateCourseGridView();
        }

        // Use _currentDepartmentName & _currentTableName to fetch new course table data then redraw the gridview.
        private void UpdateCourseGridView()
        {
            _updatingTabs = true;
            CourseTableTabControl.SuspendLayout();
            CourseTableTabControl.TabPages.Clear();

            List<string> allCombinedNames = SupportedDataSourceInfo.GetAllCombinedNames;

            for (int i = 0; i < SupportedDataSourceInfo.Amount; i++)
            {
                List<string[]> courseRows = _formViewModel.GetCourseTableRows(i);

                if (_currentShownTabIndex == i)
                {
                    CourseGridView.Rows.Clear();
                    courseRows?.ForEach(row => CourseGridView.Rows.Add(row));
                }

                if (courseRows != null)
                {
                    TabPage newTabPage = CreateNewTabPage(Consts.TabPageNameTitle + (i + 1).ToString(), allCombinedNames[i], _currentShownTabIndex == i ? CoursePanel : null);
                    CourseTableTabControl.TabPages.Add(newTabPage);
                }
            }

            ChangeButtonEnableStates();
            CourseTableTabControl.ResumeLayout();
            CourseTableTabControl.SelectedIndex = _currentShownTabIndex;
            _updatingTabs = false;
            CourseGridView.NotifyCurrentCellDirty(true);
        }

        // Event handler when CourseGridView CellContentClick.
        private void CourseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && CourseGridView.Columns[e.ColumnIndex].Name == CourseSelectionBoxColumn.Name)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)CourseGridView.Rows[e.RowIndex].Cells[CourseSelectionBoxColumn.Name];

                bool isCurrentCheckBoxSelected = checkCell.Value.ToString() == checkCell.TrueValue.ToString();

                _formViewModel.ChangeCourseCheckStatus(e.RowIndex, !isCurrentCheckBoxSelected, _currentShownTabIndex);

                checkCell.Value = !isCurrentCheckBoxSelected ? checkCell.TrueValue : checkCell.FalseValue;
            }
        }
        
        // Event handler when CourseGridView CellValueChanged.
        private void CourseGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!CourseGridView.IsCurrentCellDirty) return;

            ChangeButtonEnableStates();
        }

        // Event handler when SubmitCourseSelectionButton Click.
        private void SubmitCourseSelectionButton_Click(object sender, EventArgs e)
        {
            Result<string> submitResult = _formViewModel.HandleSelectCourseSubmission();

            string resultMsg = submitResult.Success ? submitResult.Data : (submitResult as ErrorResult<string>).Message;

            MessageBox.Show(resultMsg, string.Empty, buttons: MessageBoxButtons.OK, icon: submitResult.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (submitResult.Success)
            {
                ChangeButtonEnableStates();
                UpdateCourseGridView();
            }
        }

        // Event handler when GetCourseSelectResultbutton Click.
        private void GetCourseSelectResultbutton_Click(object sender, EventArgs e)
        {
            CourseSelectionResultForm courseSelectionResultForm = new();

            courseSelectionResultForm.FormClosed += new((object sender, FormClosedEventArgs e) => 
            {
                _selectionResultFormShowing = false;
                ChangeButtonEnableStates();
            });

            _selectionResultFormShowing = true;
            ChangeButtonEnableStates();
            courseSelectionResultForm.Show();
        }

        // ReConfigure the properties of Controllers in the form, exclude the gridView.
        private void ChangeButtonEnableStates()
        {
            SubmitCourseSelectionButton.Enabled = _formViewModel.IsAnyCourseChecked();
            GetCourseSelectResultbutton.Enabled = !_selectionResultFormShowing && _formViewModel.IsAnyCourseSelected();
        }

        private TabPage CreateNewTabPage(string name, string text, Control content = null)
        {
            TabPage newTabPage = new();
            newTabPage.SuspendLayout();
            newTabPage.Name = name;
            newTabPage.Text = text;
            newTabPage.Controls.Clear();
            if (content != null) newTabPage.Controls.Add(content);
            newTabPage.ResumeLayout();
            newTabPage.Refresh();
            return newTabPage;
        }

        // Event handler when CourseTableTabControl SelectedIndexChanged.
        private void CourseTableTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CourseTableTabControl.SelectedIndex;

            if (selectedIndex >= 0 && CourseTableTabControl.TabPages.Count > 0 && !_updatingTabs)
            {
                _currentShownTabIndex = selectedIndex;
                UpdateCourseGridView();
            }
        }

        private void SelectCourseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _formViewModel.PropertyChanged -= HandleVMChanged;
        }
    }
}
