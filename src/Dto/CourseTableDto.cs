using System.Collections.Generic;

namespace CourseCrawler
{
    public static class CourseTableDto
    {
        // FromTableToRows
        public static List<List<string>> FromTableToRows(CourseTable table)
        {
            List<List<string>> result = new();

            foreach (Course course in table.Courses)
            {
                result.Add(CourseDto.ToStringList(course));
            }

            return result;
        }
    }
}
