using System.ComponentModel;
using System.Collections.Generic;

namespace CourseCrawler
{
    internal interface ICourse
    {
        // MakeSelected
        public void MakeSelected();
        // MakeUnselected
        public void MakeUnselected();
        public bool IsSelected { get; set; }
        public string Serial { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public string Credit { get; set; }
        public string Hour { get; set; }
        public CourseType Type { get; set; }
        public string[] Teachers { get; set; }
        public List<WeekTime> WeekTimes { get; }
        public string[] Classrooms { get; set; }
        public string StudentAmount { get; set; }
        public string GivenUpStudentAmount { get; set; }
        public string[] TAs { get; set; }
        public CourseLanguage Language { get; set; }
        public string[] OutlineAndProgressUrl { get; set; }
        public string Remark { get; set; }
        public string AttachedStudentAmount { get; set; }
        public bool IsExperiment { get; set; }
        public CourseDayTime MondayTimes { get; set; }
        public CourseDayTime TuesdayTimes { get; set; }
        public CourseDayTime WednesdayTimes { get; set; }
        public CourseDayTime ThursdayTimes { get; set; }
        public CourseDayTime FridayTimes { get; set; }
        public CourseDayTime SaturdayTimes { get; set; }
        public CourseDayTime SundayTimes { get; set; }
    }

    internal interface ICourseDayTime
    {
        public bool One { get; set; }
        public bool Two { get; set; }
        public bool Three { get; set; }
        public bool Four { get; set; }
        public bool N { get; set; }
        public bool Five { get; set; }
        public bool Six { get; set; }
        public bool Seven { get; set; }
        public bool Eight { get; set; }
        public bool Nine { get; set; }
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C { get; set; }
        public bool D { get; set; }
        public List<bool> WholeDayList { get; }
    }

    internal readonly struct WeekTime
    {
        public WeekTime(string name, string[] times) 
        {
            Name = name;
            Times = times;
        }

        public readonly string Name { get; }
        public readonly string[] Times { get; }
    }

    internal interface ICourseTable
    {
        public string Name { get; }

        public BindingList<ICourse> Courses { get; }

        public bool IsAnyCourseSelected { get; }
    }

    internal interface IDepartment
    {
        public string Name { get; }

        public Dictionary<string, ICourseTable> CourseTables { get; }
    }

    internal struct DepartmentNameWithTableName
    {
        public DepartmentNameWithTableName(string departmentName, string tableName)
        {
            DepartmentName = departmentName;
            TableName = tableName;
        }

        public string DepartmentName { get; }
        public string TableName { get; }
    }

    internal class CourseTabSourceIndex
    {
        public CourseTabSourceIndex(int departmentIndex, int tableIndex)
        {
            DepartmentIndex = departmentIndex;
            TableIIndex = tableIndex;
        }

        public int DepartmentIndex { get; }
        public int TableIIndex { get; }
    }
}
