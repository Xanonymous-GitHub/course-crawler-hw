using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal enum CourseType
    {
        DeptRequired, // ○
        UniversityRequired, // △
        CommonElective, // ☆
        DeptMajorRequired, // ●
        UniversityMajorRequired, // ▲
        MajorElective, // ★
        NoType
    }

    internal enum CourseLanguage
    {
        TW,
        EN,
        NotSet
    }

    internal interface ICourse
    {
        public void MakeSelected();
        public void MakeUnselected();
        public uint Number { get; }
        public string Name { get; }
        public byte Level { get; }
        public float Credit { get; }
        public byte Hour { get; }
        public CourseType Type { get; }
        public string[] Teachers { get; }
        public byte[] MondayTimes { get; }
        public byte[] TuesdayTimes { get; }
        public byte[] WednesdayTimes { get; }
        public byte[] ThursdayTimes { get; }
        public byte[] FridayTimes { get; }
        public byte[] SaturdayTimes { get; }
        public byte[] SundayTimes { get; }
        public string[] Classrooms { get; }
        public byte StudentAmount { get; }
        public byte GivenUpStudentAmount { get; }
        public string[] TAs { get; }
        public CourseLanguage Language { get; }
        public string OutlineAndProgressUrl { get; }
        public string Remark { get; }
        public byte AttachedStudentAmount { get; }
        public bool IsExperiment { get; }
    }

    internal class Course : ICourse
    {
        public Course(
            uint number,
            string name,
            byte level,
            float credit,
            byte hour,
            CourseType type,
            string[] teachers = null,
            byte[] mondayTimes = null,
            byte[] tuesdayTimes = null,
            byte[] wednesdayTimes = null,
            byte[] thursdayTimes = null,
            byte[] fridayTimes = null,
            byte[] saturdayTimes = null,
            byte[] sundayTimes = null,
            string[] classrooms = null,
            byte studentAmount = 0,
            byte givenUpStudentAmount = 0,
            string[] tas = null,
            CourseLanguage language = CourseLanguage.NotSet,
            string outlineAndProgressUrl = null,
            string remark = "",
            byte attachedStudentAmount = 0,
            bool isExperiment = false,
            bool isSelected = false
        )
        {
            _isSelected = isSelected;
            _number = number;
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
            _tas = tas;
            _language = language;
            _outlineAndProgressUrl = outlineAndProgressUrl;
            _remark = remark;
            _attachedStudentAmount = attachedStudentAmount;
            _isExperiment = isExperiment;
        }

        private bool _isSelected = false;
        private uint _number;
        private string _name;
        private byte _level;
        private float _credit;
        private byte _hour;
        private CourseType _type;
        private string[] _teachers;
        private byte[] _mondayTimes;
        private byte[] _tuesdayTimes;
        private byte[] _wednesdayTimes;
        private byte[] _thursdayTimes;
        private byte[] _fridayTimes;
        private byte[] _saturdayTimes;
        private byte[] _sundayTimes;
        private string[] _classrooms;
        private byte _studentAmount;
        private byte _givenUpStudentAmount;
        private string[] _tas;
        private CourseLanguage _language;
        private string _outlineAndProgressUrl;
        private string _remark;
        private byte _attachedStudentAmount;
        private bool _isExperiment;


        public void MakeSelected() => _isSelected = true;

        public void MakeUnselected() => _isSelected = false;

        public uint Number => _number;

        public string Name => _name;

        public byte Level => _level;

        public float Credit => _credit;

        public byte Hour => _hour;

        public CourseType Type => _type;

        public string[] Teachers => _teachers;

        public byte[] MondayTimes => _mondayTimes;

        public byte[] TuesdayTimes => _tuesdayTimes;

        public byte[] WednesdayTimes => _wednesdayTimes;

        public byte[] ThursdayTimes => _thursdayTimes;

        public byte[] FridayTimes => _fridayTimes;

        public byte[] SaturdayTimes => _saturdayTimes;

        public byte[] SundayTimes => _sundayTimes;

        public string[] Classrooms => _classrooms;

        public byte StudentAmount => _studentAmount;

        public byte GivenUpStudentAmount => _givenUpStudentAmount;

        public string[] TAs => _tas;

        public CourseLanguage Language => _language;

        public string OutlineAndProgressUrl => _outlineAndProgressUrl;

        public string Remark => _remark;

        public byte AttachedStudentAmount => _attachedStudentAmount;

        public bool IsExperiment => _isExperiment;
    }
}
