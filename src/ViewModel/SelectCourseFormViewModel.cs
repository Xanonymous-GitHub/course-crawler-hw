using System.Collections.Generic;

namespace CourseCrawler
{
    internal sealed class SelectCourseFormViewModel
    {
        public SelectCourseFormViewModel(string departmentName, string tableName) 
        {
            CurrentDepartmentName = departmentName;
            CurrentTableName = tableName;
        }

        public string CurrentDepartmentName, CurrentTableName;

        public List<string[]> GetCourseTableRows()
        {
            GetCourseTableUseCase getTableUseCase = new(CurrentDepartmentName, CurrentTableName);
            return CourseTableDto.FromTableToRows(getTableUseCase.Do());
        }

        public bool IsAnyCourseSelected()
        {
            GetCourseTableUseCase getTableUseCase = new(CurrentDepartmentName, CurrentTableName);
            CourseTable table = getTableUseCase.Do();

            return table != null && table.IsAnyCourseSelected;
        }

        public void ChangeCourseSelectionStatus(int index, bool isSelected)
        {
            GetCourseTableUseCase getTableUseCase = new(CurrentDepartmentName, CurrentTableName);
            CourseTable table = getTableUseCase.Do();

            if (isSelected)
            {
                table.Courses[index].MakeSelected();
            }
            else
            {
                table.Courses[index].MakeUnselected();
            }
        }
    }
}
