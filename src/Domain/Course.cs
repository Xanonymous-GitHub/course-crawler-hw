using System.Collections.Generic;

namespace CourseCrawler
{
    public class Course : Bindable, ICourse
    {
        public Course(
            string serial,
            string name,
            string level,
            string credit,
            string hour,
            CourseType type,
            string[] teachers = null,
            CourseDayTime sundayTimes = null,
            CourseDayTime mondayTimes = null,
            CourseDayTime tuesdayTimes = null,
            CourseDayTime wednesdayTimes = null,
            CourseDayTime thursdayTimes = null,
            CourseDayTime fridayTimes = null,
            CourseDayTime saturdayTimes = null,
            string[] classrooms = null,
            string studentAmount = "0",
            string givenUpStudentAmount = "0",
            string[] tas = null,
            CourseLanguage language = CourseLanguage.NotSet,
            string[] outlineAndProgressUrl = null,
            string remark = "",
            string attachedStudentAmount = "0",
            bool isExperiment = false,
            bool isSelected = false,
            bool isChecked = false
        )
        {
            _isSelected = isSelected;
            _isChecked = isChecked;
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
        private bool _isChecked = false;
        private string _serial;
        private string _name;
        private string _level;
        private string _credit;
        private string _hour;
        private CourseType _type;
        private string[] _teachers;
        private CourseDayTime _mondayTimes;
        private CourseDayTime _tuesdayTimes;
        private CourseDayTime _wednesdayTimes;
        private CourseDayTime _thursdayTimes;
        private CourseDayTime _fridayTimes;
        private CourseDayTime _saturdayTimes;
        private CourseDayTime _sundayTimes;
        private string[] _classrooms;
        private string _studentAmount;
        private string _givenUpStudentAmount;
        private string[] _tas;
        private CourseLanguage _language;
        private string[] _outlineAndProgressUrl;
        private string _remark;
        private string _attachedStudentAmount;
        private bool _isExperiment;

        // MakeSelected
        public void MakeSelected() => IsSelected = true;

        // MakeUnselected
        public void MakeUnselected() => IsSelected = false;

        public bool IsSelected
        {
            get => _isSelected;
            set => SetField(ref _isSelected, value);
        }

        public bool IsChecked
        {
            get => _isChecked;
            set => SetField(ref _isChecked, value);
        }

        public string Serial
        {
            get => _serial;
            set => SetField(ref _serial, value);
        }

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public string Level
        {
            get => _level;
            set => SetField(ref _level, value);
        }

        public string Credit
        {
            get => _credit;
            set => SetField(ref _credit, value);
        }

        public string Hour
        {
            get => _hour;
            set => SetField(ref _hour, value);
        }

        public CourseType Type
        {
            get => _type;
            set => SetField(ref _type, value);
        }

        public string[] Teachers
        {
            get => _teachers;
            set => SetField(ref _teachers, value);
        }

        public List<WeekTime> WeekTimes => new()
        {
            new(Consts.Sunday, CourseDayTimeDto.ToStringArray(SundayTimes)),
            new(Consts.Monday, CourseDayTimeDto.ToStringArray(MondayTimes)),
            new(Consts.Tuesday, CourseDayTimeDto.ToStringArray(TuesdayTimes)),
            new(Consts.Wednesday, CourseDayTimeDto.ToStringArray(WednesdayTimes)),
            new(Consts.Thursday, CourseDayTimeDto.ToStringArray(ThursdayTimes)),
            new(Consts.Friday, CourseDayTimeDto.ToStringArray(FridayTimes)),
            new(Consts.Saturday, CourseDayTimeDto.ToStringArray(SaturdayTimes)),
        };

        public CourseDayTime MondayTimes
        {
            get => _mondayTimes;
            set => SetField(ref _mondayTimes, value);
        }

        public CourseDayTime TuesdayTimes
        {
            get => _tuesdayTimes;
            set => SetField(ref _tuesdayTimes, value);
        }

        public CourseDayTime WednesdayTimes
        {
            get => _wednesdayTimes;
            set => SetField(ref _wednesdayTimes, value);
        }

        public CourseDayTime ThursdayTimes
        {
            get => _thursdayTimes;
            set => SetField(ref _thursdayTimes, value);
        }

        public CourseDayTime FridayTimes
        {
            get => _fridayTimes;
            set => SetField(ref _fridayTimes, value);
        }

        public CourseDayTime SaturdayTimes
        {
            get => _saturdayTimes;
            set => SetField(ref _saturdayTimes, value);
        }

        public CourseDayTime SundayTimes
        {
            get => _sundayTimes;
            set => SetField(ref _sundayTimes, value);
        }

        public string[] Classrooms
        {
            get => _classrooms;
            set => SetField(ref _classrooms, value);
        }

        public string StudentAmount
        {
            get => _studentAmount;
            set => SetField(ref _studentAmount, value);
        }

        public string GivenUpStudentAmount
        {
            get => _givenUpStudentAmount;
            set => SetField(ref _givenUpStudentAmount, value);
        }

        public string[] TAs
        {
            get => _tas;
            set => SetField(ref _tas, value);
        }

        public CourseLanguage Language
        {
            get => _language;
            set => SetField(ref _language, value);
        }

        public string[] OutlineAndProgressUrl
        {
            get => _outlineAndProgressUrl;
            set => SetField(ref _outlineAndProgressUrl, value);
        }

        public string Remark
        {
            get => _remark;
            set => SetField(ref _remark, value);
        }

        public string AttachedStudentAmount
        {
            get => _attachedStudentAmount;
            set => SetField(ref _attachedStudentAmount, value);
        }

        public bool IsExperiment
        {
            get => _isExperiment;
            set => SetField(ref _isExperiment, value);
        }
    }
}
