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

        public (int dataSourceIndex, ICourse course) CurrentEditingContent
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
            return new()
            {
                course?.SundayTimes.WholeDayList,
                course?.MondayTimes.WholeDayList,
                course?.TuesdayTimes.WholeDayList,
                course?.WednesdayTimes.WholeDayList,
                course?.ThursdayTimes.WholeDayList,
                course?.FridayTimes.WholeDayList,
                course?.SaturdayTimes.WholeDayList
            };
        }

        // GenerateEditableFieldContens
        public void GenerateEditableFieldContens(int selectedIndex)
        {
            (int groupIndex, int childIndex) = FindGroupIndexPairIn2dList(_coursesToBeEdit, selectedIndex);
            CurrentEditingContent = (groupIndex, _coursesToBeEdit[groupIndex][childIndex]);
            CourseWeekTimeCheckStates = GenerateCourseWeekTimeCheckBoxGridView(CurrentEditingContent.course);
        }

        // UpdateCourse
        public void UpdateCourse
        (
            string newSerial, string newName, string newLevel,
            string newCredit, string newTeachers, string newType,
            string newTas, string newLanguage, string newRemark,
            string newHour, int newDataSourceIndex, List<List<bool>> newTimes,
            bool isNewCouse = false
        )
        {
            // FIXME: Don't write this ugly code ...
            Course originCourse = (Course)CurrentEditingContent.course;

            string[] modifiedCourseElementStrings = new string[]
            {
                newSerial, newName, newLevel, newCredit, newHour, newType, newTeachers,
                null, null, null, null, null, null, null,
                string.Join(Consts.NewLineChar, originCourse.Classrooms), // Non changed.
                originCourse.StudentAmount, // Non changed.
                originCourse.GivenUpStudentAmount, // Non changed.
                newTas, newLanguage,
                string.Join(Consts.NewLineChar, originCourse.OutlineAndProgressUrl), // Non changed.
                newRemark,
                originCourse.AttachedStudentAmount, // Non changed.
                originCourse.IsExperiment ? Consts.DiamondChar.ToString() : string.Empty // Non changed.
            };

            Course modifiedCourse = CourseDto.FromElementStrings(modifiedCourseElementStrings);
            
            modifiedCourse.SundayTimes = new(newTimes[0].ToArray());
            modifiedCourse.MondayTimes = new(newTimes[1].ToArray());
            modifiedCourse.TuesdayTimes = new(newTimes[2].ToArray());
            modifiedCourse.WednesdayTimes = new(newTimes[3].ToArray());
            modifiedCourse.ThursdayTimes = new(newTimes[4].ToArray());
            modifiedCourse.FridayTimes = new(newTimes[5].ToArray());
            modifiedCourse.SaturdayTimes = new(newTimes[6].ToArray());

            if (isNewCouse || newDataSourceIndex != CurrentEditingContent.dataSourceIndex)
            {
                if (!isNewCouse)
                {
                    RemoveCourseUseCase removeCourseUseCase = new(CurrentEditingContent.dataSourceIndex, CurrentEditingContent.course);
                    removeCourseUseCase.Do();
                }

                AddCourseUseCase addCourseUseCase = new(newDataSourceIndex, modifiedCourse);
                addCourseUseCase.Do();
            }
            else
            {
                UpdateCourseUseCase updateCourseUseCase = new(CurrentEditingContent.dataSourceIndex, CurrentEditingContent.course, modifiedCourse);
                updateCourseUseCase.Do();
            }
        }
    }
}
