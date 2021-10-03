namespace CourseCrawler
{
    internal enum CourseType
    {
        NoType,
        DeptRequired, // ○
        UniversityRequired, // △
        CommonElective, // ☆
        DeptMajorRequired, // ●
        UniversityMajorRequired, // ▲
        MajorElective, // ★
    }

    internal enum CourseLanguage
    {
        NotSet,
        TW,
        EN,
    }

    internal interface ICourse
    {
        public void MakeSelected();
        public void MakeUnselected();
        public bool IsSelected { get; }
        public string Serial { get; }
        public string Name { get; }
        public string Level { get; }
        public string Credit { get; }
        public string Hour { get; }
        public CourseType Type { get; }
        public string[] Teachers { get; }
        public string[] MondayTimes { get; }
        public string[] TuesdayTimes { get; }
        public string[] WednesdayTimes { get; }
        public string[] ThursdayTimes { get; }
        public string[] FridayTimes { get; }
        public string[] SaturdayTimes { get; }
        public string[] SundayTimes { get; }
        public string[] Classrooms { get; }
        public string StudentAmount { get; }
        public string GivenUpStudentAmount { get; }
        public string[] TAs { get; }
        public CourseLanguage Language { get; }
        public string OutlineAndProgressUrl { get; }
        public string Remark { get; }
        public string AttachedStudentAmount { get; }
        public bool IsExperiment { get; }
    }
}