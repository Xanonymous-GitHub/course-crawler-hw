using System.Collections.Generic;

namespace CourseCrawler
{
    internal class Course : ICourse
    {
        public Course(
            string serial,
            string name,
            string level,
            string credit,
            string hour,
            CourseType type,
            string[] teachers = null,
            string[] mondayTimes = null,
            string[] tuesdayTimes = null,
            string[] wednesdayTimes = null,
            string[] thursdayTimes = null,
            string[] fridayTimes = null,
            string[] saturdayTimes = null,
            string[] sundayTimes = null,
            string[] classrooms = null,
            string studentAmount = "0",
            string givenUpStudentAmount = "0",
            string[] tas = null,
            CourseLanguage language = CourseLanguage.NotSet,
            string[] outlineAndProgressUrl = null,
            string remark = "",
            string attachedStudentAmount = "0",
            bool isExperiment = false,
            bool isSelected = false
        )
        {
            _isSelected = isSelected;
            _serial = serial;
            _name = name;
            _level = level;
            _credit = credit;
            _hour = hour;
            _type = type;
            _teachers = teachers;
            _mondayTimes = mondayTimes;
            _tuesdayTimes = tuesdayTimes;
            _wednesdayTimes = wednesdayTimes;
            _thursdayTimes = thursdayTimes;
            _fridayTimes = fridayTimes;
            _saturdayTimes = saturdayTimes;
            _sundayTimes = sundayTimes;
            _classrooms = classrooms;
            _studentAmount = studentAmount;
            _givenUpStudentAmount = givenUpStudentAmount;
            _tas = tas;
            _language = language;
            _outlineAndProgressUrl = outlineAndProgressUrl;
            _remark = remark;
            _attachedStudentAmount = attachedStudentAmount;
            _isExperiment = isExperiment;
        }

        private bool _isSelected = false;
        private string _serial;
        private string _name;
        private string _level;
        private string _credit;
        private string _hour;
        private CourseType _type;
        private string[] _teachers;
        private string[] _mondayTimes;
        private string[] _tuesdayTimes;
        private string[] _wednesdayTimes;
        private string[] _thursdayTimes;
        private string[] _fridayTimes;
        private string[] _saturdayTimes;
        private string[] _sundayTimes;
        private string[] _classrooms;
        private string _studentAmount;
        private string _givenUpStudentAmount;
        private string[] _tas;
        private CourseLanguage _language;
        private string[] _outlineAndProgressUrl;
        private string _remark;
        private string _attachedStudentAmount;
        private bool _isExperiment;


        public void MakeSelected() => _isSelected = true;

        public void MakeUnselected() => _isSelected = false;

        public bool IsSelected => _isSelected;

        public string Serial => _serial;

        public string Name => _name;

        public string Level => _level;

        public string Credit => _credit;

        public string Hour => _hour;

        public CourseType Type => _type;

        public string[] Teachers => _teachers;

        public List<WeekTime> WeekTimes => new()
        {
            new WeekTime(Constants.Monday, MondayTimes),
            new WeekTime(Constants.Tuesday, TuesdayTimes),
            new WeekTime(Constants.Wednesday, WednesdayTimes),
            new WeekTime(Constants.Thursday, ThursdayTimes),
            new WeekTime(Constants.Friday, FridayTimes),
            new WeekTime(Constants.Saturday, SaturdayTimes),
            new WeekTime(Constants.Sunday, SundayTimes),
        };

        public string[] MondayTimes => _mondayTimes;

        public string[] TuesdayTimes => _tuesdayTimes;

        public string[] WednesdayTimes => _wednesdayTimes;

        public string[] ThursdayTimes => _thursdayTimes;

        public string[] FridayTimes => _fridayTimes;

        public string[] SaturdayTimes => _saturdayTimes;

        public string[] SundayTimes => _sundayTimes;

        public string[] Classrooms => _classrooms;

        public string StudentAmount => _studentAmount;

        public string GivenUpStudentAmount => _givenUpStudentAmount;

        public string[] TAs => _tas;

        public CourseLanguage Language => _language;

        public string[] OutlineAndProgressUrl => _outlineAndProgressUrl;

        public string Remark => _remark;

        public string AttachedStudentAmount => _attachedStudentAmount;

        public bool IsExperiment => _isExperiment;
    }
}
