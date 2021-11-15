using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System;

namespace CourseCrawler
{
    public sealed class CourseManagementFormViewModel : Bindable
    {
        public CourseManagementFormViewModel()
        {
            LoadCourses();
            CourseWeekTimeCheckStates = GenerateCourseWeekTimeCheckBoxGridView();
        }

        public int DefaultCourseEnabledComboBoxSelectedIndex = 0;
        public int DefaultCourseListBoxSelectedIndex = -1;
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
        public void LoadCourses(bool shouldNotifyAllDepartmentListener = false)
        {
            for (int dataSourceIndex = 0; dataSourceIndex < SupportedDataSourceInfo.Amount; dataSourceIndex++)
            {
                GetCourseTableUseCase getCourseTableUseCase = new(dataSourceIndex);
                getCourseTableUseCase.Do();
            }

            GetAllCourseUseCase getAllCourseUseCase = new();
            _coursesToBeEdit = getAllCourseUseCase.Do();

            DirectlyNotifyPropertyChanged(nameof(CoursesToBeEditStrList));

            if (shouldNotifyAllDepartmentListener)
            {
                GetAllDepartmentsUseCase getAllDepartmentsUseCase = new();
                getAllDepartmentsUseCase.Do().DirectlyNotifyPropertyChanged();
            }
        }

        // FindGroupIndexPairIn2dList
        private (int groupIndex, int childIndex) FindGroupIndexPairIn2dList<T>(List<BindingList<T>> source, int targetIndex)
        {
            if (targetIndex < 0) return (0, 0);

            int groupIndex = 0, total = 0;

            for (; groupIndex < source.Count; groupIndex++)
            {
                int childIndex;
                for (childIndex = 0; childIndex < source[groupIndex].Count; childIndex++)
                {
                    if (total == targetIndex) return (groupIndex, childIndex);
                    total++;
                }
            }

            throw new Exception(Consts.MsgDeadArea);
        }

        // GenerateCourseWeekTimeCheckBoxGridView
        private List<List<bool>> GenerateCourseWeekTimeCheckBoxGridView(ICourse course = null)
        {
            int wholeDayTimeAmount = Consts.CourseTimePeriodNameChars.Length;
            return new()
            {
                course?.SundayTimes.WholeDayList ?? new(new bool[wholeDayTimeAmount]),
                course?.MondayTimes.WholeDayList ?? new(new bool[wholeDayTimeAmount]),
                course?.TuesdayTimes.WholeDayList ?? new(new bool[wholeDayTimeAmount]),
                course?.WednesdayTimes.WholeDayList ?? new(new bool[wholeDayTimeAmount]),
                course?.ThursdayTimes.WholeDayList ?? new(new bool[wholeDayTimeAmount]),
                course?.FridayTimes.WholeDayList ?? new(new bool[wholeDayTimeAmount]),
                course?.SaturdayTimes.WholeDayList ?? new(new bool[wholeDayTimeAmount]),
            };
        }

        // GenerateEditableFieldContens
        public void GenerateEditableFieldContens(int selectedIndex)
        {
            (int groupIndex, int childIndex) = FindGroupIndexPairIn2dList(_coursesToBeEdit, selectedIndex);
            CurrentEditingContent = (groupIndex, _coursesToBeEdit[groupIndex][childIndex]);
            CourseWeekTimeCheckStates = GenerateCourseWeekTimeCheckBoxGridView(CurrentEditingContent.course);
        }

        // GenerateEmptyFieldContens
        public void GenerateEmptyFieldContens()
        {
            CurrentEditingContent = (-1, null);
            CourseWeekTimeCheckStates = GenerateCourseWeekTimeCheckBoxGridView();
        }

        // UpdateCourse
        public void UpdateCourse
        (
            string newSerial, string newName, string newLevel,
            string newCredit, string newTeachers, string newType,
            string newTas, string newLanguage, string newRemark,
            string newHour, int newDataSourceIndex, List<List<bool>> newTimes,
            bool isNewCourse = false, bool isEnabled = true
        )
        {
            // FIXME: Don't write this ugly code ...
            Course originCourse = (Course)CurrentEditingContent.course;

            string[] modifiedCourseElementStrings = new string[]
            {
                newSerial, newName, newLevel, newCredit, newHour, newType, newTeachers,
                null, null, null, null, null, null, null,
                string.Join(Consts.NewLineChar, originCourse?.Classrooms ?? new string[] { }), // Non changed.
                originCourse?.StudentAmount ?? string.Empty, // Non changed.
                originCourse?.GivenUpStudentAmount ?? string.Empty, // Non changed.
                newTas, newLanguage,
                string.Join(Consts.NewLineChar, originCourse?.OutlineAndProgressUrl ?? new string[] { }), // Non changed.
                newRemark,
                originCourse?.AttachedStudentAmount ?? string.Empty, // Non changed.
                originCourse?.IsExperiment ?? false ? Consts.DiamondChar.ToString() : string.Empty // Non changed.
            };

            Course modifiedCourse = CourseDto.FromElementStrings(modifiedCourseElementStrings);
            
            modifiedCourse.SundayTimes = new(newTimes[0].ToArray());
            modifiedCourse.MondayTimes = new(newTimes[1].ToArray());
            modifiedCourse.TuesdayTimes = new(newTimes[2].ToArray());
            modifiedCourse.WednesdayTimes = new(newTimes[3].ToArray());
            modifiedCourse.ThursdayTimes = new(newTimes[4].ToArray());
            modifiedCourse.FridayTimes = new(newTimes[5].ToArray());
            modifiedCourse.SaturdayTimes = new(newTimes[6].ToArray());

            modifiedCourse.IsChecked = originCourse?.IsChecked ?? false;
            modifiedCourse.IsSelected = originCourse?.IsSelected ?? false;
            modifiedCourse.IsEnabled = isEnabled;

            if (isNewCourse || newDataSourceIndex != CurrentEditingContent.dataSourceIndex)
            {
                if (!isNewCourse)
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

            LoadCourses();
            GenerateDefaultCourseListBoxSelectedIndex(newDataSourceIndex, modifiedCourse);
        }

        // GenerateDefaultCourseListBoxSelectedIndex
        public void GenerateDefaultCourseListBoxSelectedIndex(int targetDataSourceIndex, ICourse targetCourse)
        {
            int previousGroupsTotalLength = 0;
            for (int i = 0; i < targetDataSourceIndex; i++)
            {
                previousGroupsTotalLength += _coursesToBeEdit[i].Count;
            }

            int targetIndexInItsGroup = _coursesToBeEdit[targetDataSourceIndex].ToList().FindIndex(course => course.GetHashCode() == targetCourse.GetHashCode());

            DefaultCourseListBoxSelectedIndex = previousGroupsTotalLength + targetIndexInItsGroup;
        }
    }
}
