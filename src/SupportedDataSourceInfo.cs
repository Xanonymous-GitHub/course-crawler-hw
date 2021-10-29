using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal static class SupportedDataSourceInfo
    {
        private static List<(string departmentName, string tableName, string accessNumberStr)> Current = new()
        {
            ("資工", "三", "2433"),
            ("電子", "三甲", "2423"),
            ("化工", "三乙", "2416")
        };

        public static int Amount => Current.Count;

        // GetDepartmentName
        public static string GetDepartmentName(int supportedDataSourceIndex) => Current[supportedDataSourceIndex].departmentName;

        // GetTableName
        public static string GetTableName(int supportedDataSourceIndex) => Current[supportedDataSourceIndex].tableName;

        // GetAccessNumberStr
        public static string GetAccessNumberStr(int supportedDataSourceIndex) => Current[supportedDataSourceIndex].accessNumberStr;
    }
}
