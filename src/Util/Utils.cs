using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseCrawler
{
    internal static class Utils
    {
        public static Uri GetDepartmentCourseTableUri(string departmentName, string tableName)
        {
            // TODO: implement the converter.
            Uri uri = new(Constants.CoursePagePath + SupportedRange.TableNumber[departmentName + tableName]);
            return uri;
        }

        public static void ShowDebugBox(dynamic debugInfo)
        {
            MessageBox.Show(debugInfo.ToString());
        }
    }
}
