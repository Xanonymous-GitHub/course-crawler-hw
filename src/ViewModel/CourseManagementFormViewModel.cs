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
            CourseWeekTimeCheckStates = GenerateCourseWeekTimeCheckBoxGridView();
        }

        public readonly int DefaultCourseEnabledComboBoxSelectedIndex = 0;
        public readonly List<string> CourseClassComboBoxItems = SupportedDataSourceInfo.GetAllCombinedNames;
        public readonly List<string> CourseTypeComboBoxItems = Consts.CourseSymbols.Skip(1).ToList();

        private List<BindingList<ICourse>> _coursesToBeEdit;
        private (int dataSourceIndex, ICourse course) _currentEditingContent;
        private List<List<bool>> _courseWeekTimeCheckStates;

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

        public List<List<bool>> CourseWeekTimeCheckStates
        {
            get => _courseWeekTimeCheckStates;
            set => SetField(ref _courseWeekTimeCheckStates, value);
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
        private List<List<bool>> GenerateCourseWeekTimeCheckBoxGridView(ICourse course = null)
        {
            // CourseWeekTimeCheckBoxInitialCheckedAmount
            List<List<bool>> result = new();

            CourseWeekTimeCheckBoxInitialCheckedAmount = 0;

            for (int i = 0; i < Consts.CourseTimePeriodNameChars.Length; i++)
            {
                if (course == null)
                {
                    result.Add(null);
                }
                else
                {
                    bool mondayTimes = course.MondayTimes.WholeDayList[i];
                    bool tuesdayTimes = course.TuesdayTimes.WholeDayList[i];
                    bool wednesdayTimes = course.WednesdayTimes.WholeDayList[i];
                    bool thursdayTimes = course.ThursdayTimes.WholeDayList[i];
                    bool fridayTimes = course.FridayTimes.WholeDayList[i];
                    bool saturdayTimes = course.SaturdayTimes.WholeDayList[i];
                    bool sundayTimes = course.SundayTimes.WholeDayList[i];

                    CourseWeekTimeCheckBoxInitialCheckedAmount += Convert.ToInt32(mondayTimes);
                    CourseWeekTimeCheckBoxInitialCheckedAmount += Convert.ToInt32(tuesdayTimes);
                    CourseWeekTimeCheckBoxInitialCheckedAmount += Convert.ToInt32(wednesdayTimes);
                    CourseWeekTimeCheckBoxInitialCheckedAmount += Convert.ToInt32(thursdayTimes);
                    CourseWeekTimeCheckBoxInitialCheckedAmount += Convert.ToInt32(fridayTimes);
                    CourseWeekTimeCheckBoxInitialCheckedAmount += Convert.ToInt32(saturdayTimes);
                    CourseWeekTimeCheckBoxInitialCheckedAmount += Convert.ToInt32(sundayTimes);

                    result.Add(new() { mondayTimes, tuesdayTimes, wednesdayTimes, thursdayTimes, fridayTimes, saturdayTimes, sundayTimes });
                }
            }

            return result;
        }

        // GenerateEditableFieldContens
        public void GenerateEditableFieldContens(int selectedIndex)
        {
            (int groupIndex, int childIndex) = FindGroupIndexPairIn2dList(_coursesToBeEdit, selectedIndex);
            CurrentEditingCourse = (groupIndex, _coursesToBeEdit[groupIndex][childIndex]);
            CourseWeekTimeCheckStates = GenerateCourseWeekTimeCheckBoxGridView(CurrentEditingCourse.course);
        }
    }
}
