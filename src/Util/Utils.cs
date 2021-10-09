using System;
using System.Windows.Forms;

namespace CourseCrawler
{
    internal static class Utils
    {
        public static Uri GetDepartmentCourseTableUri(string departmentName, string tableName)
        {
            // TODO: implement the converter.
            return Constants.CoursePageUri;
        }

        public static void ShowDebugBox(dynamic debugInfo)
        {
            MessageBox.Show(debugInfo.ToString());
        }
    }
}
