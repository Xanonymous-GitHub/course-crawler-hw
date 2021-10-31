using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System;

namespace CourseCrawler
{
    internal sealed class CourseManagementFormViewModel : Bindable
    {
        public CourseManagementFormViewModel()
        {
            LoadCourses();
            CourseWeekTimeCheckBoxRows = GenerateCourseWeekTimeCheckBoxGridView();
        }

        public readonly int DefaultCourseEnabledComboBoxSelectedIndex = 0;
        public readonly List<string> CourseClassComboBoxItems = SupportedDataSourceInfo.GetAllCombinedNames;
        public readonly List<string> CourseTypeComboBoxItems = Consts.CourseSymbols.Skip(1).ToList();

        private List<BindingList<ICourse>> _coursesToBeEdit;
        private (int dataSourceIndex, ICourse course) _currentEditingContent;
        private List<string[]> _courseWeekTimeCheckBoxRows;

        public List<string> CoursesToBeEditStrList
        {
            get => _coursesToBeEdit.Select(courses => courses.Select(course => course.Name).ToList()).ToList().SelectMany(x => x).ToList();
        }

        public int CourseWeekTimeCheckBoxInitialCheckedAmount = 0;

        public (int dataSourceIndex, ICourse course) CurrentEditingCourse
        {
            get => _currentEditingContent;
            set => SetField(ref _currentEditingContent, value);
        }

        public List<string[]> CourseWeekTimeCheckBoxRows
        {
            get => _courseWeekTimeCheckBoxRows;
            set => SetField(ref _courseWeekTimeCheckBoxRows, value);
        }

        // LoadCourses
        private void LoadCourses()
        {
            for (int dataSourceIndex = 0; dataSourceIndex < SupportedDataSourceInfo.Amount; dataSourceIndex++)
            {
                GetCourseTableUseCase getCourseTableUseCase = new(dataSourceIndex);
                getCourseTableUseCase.Do();
            }

            GetAllCourseUseCase getAllCourseUseCase = new();
            _coursesToBeEdit = getAllCourseUseCase.Do();
        }

        // FindGroupIndexPairIn2dList
        private (int groupIndex, int childIndex) FindGroupIndexPairIn2dList<T>(List<BindingList<T>> source, int targetIndex)
        {
            int groupIndex = 0, childIndex = 0, total = 0;

            for (; groupIndex < source.Count; groupIndex++)
            {
                for (childIndex = 0; childIndex < source[groupIndex].Count; childIndex++)
                {
                    if (total == targetIndex) return (groupIndex, childIndex);
                    total++;
                }
            }

            // FIXME prevent invalid targetIndex.
            // if this return be called, means expected index is not found in source
            // this line should not be called.
            return (groupIndex, childIndex);
        }

        // GenerateCourseWeekTimeCheckBoxGridView
        private List<string[]> GenerateCourseWeekTimeCheckBoxGridView(ICourse course = null)
        {
            string titles = Consts.CourseTimePeriodNameChars;
            List<string> tmpRow = new();
            List<string[]> rows = new();

            CourseWeekTimeCheckBoxInitialCheckedAmount = 0;

            for (int i = 0; i < titles.Length; i++)
            {
                tmpRow.Clear();

                tmpRow.Add(titles[i].ToString());

                if (course == null)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        tmpRow.Add(false.ToString());
                    }
                }
                else
                {
                    bool monday = course.MondayTimes.WholeDayList[i];
                    bool tuesday = course.TuesdayTimes.WholeDayList[i];
                    bool wednesday = course.WednesdayTimes.WholeDayList[i];
                    bool thursday = course.ThursdayTimes.WholeDayList[i];
                    bool friday = course.FridayTimes.WholeDayList[i];
                    bool saturday = course.SaturdayTimes.WholeDayList[i];
                    bool sunday = course.SundayTimes.WholeDayList[i];

                    tmpRow.Add(monday.ToString());
                    tmpRow.Add(tuesday.ToString());
                    tmpRow.Add(wednesday.ToString());
                    tmpRow.Add(thursday.ToString());
                    tmpRow.Add(friday.ToString());
                    tmpRow.Add(saturday.ToString());
                    tmpRow.Add(sunday.ToString());

                    CourseWeekTimeCheckBoxInitialCheckedAmount += Convert.ToInt32(monday);
                    CourseWeekTimeCheckBoxInitialCheckedAmount += Convert.ToInt32(tuesday);
                    CourseWeekTimeCheckBoxInitialCheckedAmount += Convert.ToInt32(wednesday);
                    CourseWeekTimeCheckBoxInitialCheckedAmount += Convert.ToInt32(thursday);
                    CourseWeekTimeCheckBoxInitialCheckedAmount += Convert.ToInt32(friday);
                    CourseWeekTimeCheckBoxInitialCheckedAmount += Convert.ToInt32(saturday);
                    CourseWeekTimeCheckBoxInitialCheckedAmount += Convert.ToInt32(sunday);
                }

                rows.Add(tmpRow.ToArray());
            }

            return rows;
        }

        // GenerateEditableFieldContens
        public void GenerateEditableFieldContens(int selectedIndex)
        {
            (int groupIndex, int childIndex) = FindGroupIndexPairIn2dList(_coursesToBeEdit, selectedIndex);
            CurrentEditingCourse = (groupIndex, _coursesToBeEdit[groupIndex][childIndex]);
            CourseWeekTimeCheckBoxRows = GenerateCourseWeekTimeCheckBoxGridView(CurrentEditingCourse.course);
        }
    }
}
