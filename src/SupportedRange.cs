using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal static class SupportedRange
    {
        public static Dictionary<string, string> TableNumber = new()
        {
            { "資工三", "2433" },
            { "電子三甲", "2423" }
        };

        public static List<string> DepartmentNames = new()
        {
            "資工",
            "電子"
        };

        public static List<string> TableNames = new()
        {
            "一", 
            "二", 
            "三", 
            "四",
            "一甲",
            "二甲",
            "三甲",
            "四甲",
            "一乙",
            "二乙",
            "三乙",
            "四乙"
        };
    }
}
