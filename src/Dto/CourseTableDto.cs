using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal static class CourseTableDto
    {
        public static List<string[]> FromTableToRows(CourseTable table)
        {
            List<string[]> result = new();

            foreach (Course course in table.Courses)
            {
                result.Add(CourseDto.ToStringList(course));
            }

            return result;
        }
    }
}
