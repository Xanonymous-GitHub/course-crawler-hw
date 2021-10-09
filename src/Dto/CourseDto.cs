using System;
using System.Linq;

namespace CourseCrawler
{
    internal static class CourseDto
    {
        public static Course FromElementStrings(params string[] source)
        {
            source = source.Select(data => data.Trim()).ToArray();

            return new Course
                (
                    serial: source[0],
                    name: source[1],
                    level: source[2],
                    credit: source[3],
                    hour: source[4],
                    type: ToCourseTypeFromString(source[5]),
                    teachers: source[6].Split(Constants.StringSplitSeperators, StringSplitOptions.None),
                    mondayTimes: source[7].Split(Constants.StringSplitSeperators, StringSplitOptions.None),
                    tuesdayTimes: source[8].Split(Constants.StringSplitSeperators, StringSplitOptions.None),
                    wednesdayTimes: source[9].Split(Constants.StringSplitSeperators, StringSplitOptions.None),
                    thursdayTimes: source[10].Split(Constants.StringSplitSeperators, StringSplitOptions.None),
                    fridayTimes: source[11].Split(Constants.StringSplitSeperators, StringSplitOptions.None),
                    saturdayTimes: source[12].Split(Constants.StringSplitSeperators, StringSplitOptions.None),
                    sundayTimes: source[13].Split(Constants.StringSplitSeperators, StringSplitOptions.None),
                    classrooms: source[14].Split(Constants.StringSplitSeperators, StringSplitOptions.None),
                    studentAmount: source[15],
                    givenUpStudentAmount: source[16],
                    tas: source[17].Split(Constants.StringSplitSeperators, StringSplitOptions.None),
                    language: ToCourseLanguageFromString(source[18]),
                    outlineAndProgressUrl: source[19].Split(Constants.StringSplitSeperators, StringSplitOptions.None),
                    remark: source[20],
                    attachedStudentAmount: source[21],
                    isExperiment: source[22] != ""
                );
        }

        public static string[] ToStringList(Course course)
        {
            return new string[]
            {
                course.IsSelected.ToString(),
                course.Serial,
                course.Name,
                course.Level,
                course.Credit,
                course.Hour,
                course.Type.ToOriginString(),
                string.Join(Constants.NewLineChar, course.Teachers),
                string.Join(Constants.SpaceChar, course.MondayTimes),
                string.Join(Constants.SpaceChar, course.TuesdayTimes),
                string.Join(Constants.SpaceChar, course.WednesdayTimes),
                string.Join(Constants.SpaceChar, course.ThursdayTimes),
                string.Join(Constants.SpaceChar, course.FridayTimes),
                string.Join(Constants.SpaceChar, course.SaturdayTimes),
                string.Join(Constants.SpaceChar, course.SundayTimes),
                string.Join(Constants.NewLineChar, course.Classrooms),
                course.StudentAmount,
                course.GivenUpStudentAmount,
                string.Join(Constants.NewLineChar, course.TAs),
                course.Language.ToOriginString(),
                string.Join(Constants.NewLineChar, course.OutlineAndProgressUrl),
                course.Remark,
                course.AttachedStudentAmount,
                course.IsExperiment ? Constants.DiamondChar.ToString() : "",
            };
        }

        public static string ToNumberAndName(Course course)
        {
            if (course.Serial == "") {
                return course.Name;
            }

            return course.Serial + Constants.Dash + course.Name;
        }

        public static CourseType ToCourseTypeFromString(string symbolText)
        {
            return (CourseType)Constants.CourseSymbols.IndexOf(symbolText);
        }

        public static string ToOriginString(this CourseType courseType)
        {
            return Constants.CourseSymbols[(int)courseType];
        }

        public static CourseLanguage ToCourseLanguageFromString(string symbolText)
        {
            return (CourseLanguage)Constants.LanguageSymbols.IndexOf(symbolText);
        }

        public static string ToOriginString(this CourseLanguage courseLanguage)
        {
            return Constants.LanguageSymbols[(int)courseLanguage];
        }
    }
}
