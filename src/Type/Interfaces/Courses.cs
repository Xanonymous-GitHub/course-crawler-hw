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
        public bool IsSelected { get; }
        public string Serial { get; }
        public string Name { get; }
        public string Level { get; }
        public string Credit { get; }
        public string Hour { get; }
        public CourseType Type { get; }
        public string[] Teachers { get; }
        public List<WeekTime> WeekTimes { get; }
        public string[] Classrooms { get; }
        public string StudentAmount { get; }
        public string GivenUpStudentAmount { get; }
        public string[] TAs { get; }
        public CourseLanguage Language { get; }
        public string[] OutlineAndProgressUrl { get; }
        public string Remark { get; }
        public string AttachedStudentAmount { get; }
        public bool IsExperiment { get; }
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
