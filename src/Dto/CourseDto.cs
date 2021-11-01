using System;
using System.Linq;
using System.Collections.Generic;

namespace CourseCrawler
{
    internal static class CourseDto
    {
        // FromElementStrings
        public static Course FromElementStrings(params string[] source)
        {
            source = source.Select(data => data.Trim()).ToArray();

            return new
                (
                    serial: source[0],
                    name: source[1],
                    level: source[2],
                    credit: source[3],
                    hour: source[4],
                    type: ToCourseTypeFromString(source[5]),
                    teachers: Utils.SplitStr(source[6]),
                    sundayTimes: CourseDayTimeDto.FromStringArray(Utils.SplitStr(source[7])),
                    mondayTimes: CourseDayTimeDto.FromStringArray(Utils.SplitStr(source[8])),
                    tuesdayTimes: CourseDayTimeDto.FromStringArray(Utils.SplitStr(source[9])),
                    wednesdayTimes: CourseDayTimeDto.FromStringArray(Utils.SplitStr(source[10])),
                    thursdayTimes: CourseDayTimeDto.FromStringArray(Utils.SplitStr(source[11])),
                    fridayTimes: CourseDayTimeDto.FromStringArray(Utils.SplitStr(source[12])),
                    saturdayTimes: CourseDayTimeDto.FromStringArray(Utils.SplitStr(source[13])),
                    classrooms: Utils.SplitStr(source[14]),
                    studentAmount: source[15],
                    givenUpStudentAmount: source[16],
                    tas: Utils.SplitStr(source[17]),
                    language: ToCourseLanguageFromString(source[18]),
                    outlineAndProgressUrl: Utils.SplitStr(source[19]),
                    remark: source[20],
                    attachedStudentAmount: source[21],
                    isExperiment: source[22] != string.Empty
                );
        }

        // ToStringList
        public static List<string> ToStringList(Course course)
        {
            return new()
            {
                course.Serial,
                course.Name,
                course.Level,
                course.Credit,
                course.Hour,
                course.Type.ToOriginString(),
                string.Join(Consts.NewLineChar, course.Teachers),
                string.Join(Consts.SpaceChar, CourseDayTimeDto.ToStringArray(course.SundayTimes)),
                string.Join(Consts.SpaceChar, CourseDayTimeDto.ToStringArray(course.MondayTimes)),
                string.Join(Consts.SpaceChar, CourseDayTimeDto.ToStringArray(course.TuesdayTimes)),
                string.Join(Consts.SpaceChar, CourseDayTimeDto.ToStringArray(course.WednesdayTimes)),
                string.Join(Consts.SpaceChar, CourseDayTimeDto.ToStringArray(course.ThursdayTimes)),
                string.Join(Consts.SpaceChar, CourseDayTimeDto.ToStringArray(course.FridayTimes)),
                string.Join(Consts.SpaceChar, CourseDayTimeDto.ToStringArray(course.SaturdayTimes)),
                string.Join(Consts.NewLineChar, course.Classrooms),
                course.StudentAmount,
                course.GivenUpStudentAmount,
                string.Join(Consts.NewLineChar, course.TAs),
                course.Language.ToOriginString(),
                string.Join(Consts.NewLineChar, course.OutlineAndProgressUrl),
                course.Remark,
                course.AttachedStudentAmount,
                course.IsExperiment ? Consts.DiamondChar.ToString() : string.Empty,
            };
        }

        // ToNumberAndName
        public static string ToNumberAndName(Course course)
        {
            if (course.Serial == string.Empty) 
            {
                return course.Name;
            }

            return course.Serial + Consts.Dash + course.Name;
        }

        // ToCourseTypeFromString
        public static CourseType ToCourseTypeFromString(string symbolText)
        {
            return (CourseType)Consts.CourseSymbols.IndexOf(symbolText);
        }

        // ToOriginString
        public static string ToOriginString(this CourseType courseType)
        {
            return Consts.CourseSymbols[(int)courseType];
        }

        // ToCourseLanguageFromString
        public static CourseLanguage ToCourseLanguageFromString(string symbolText)
        {
            return (CourseLanguage)Consts.LanguageSymbols.IndexOf(symbolText);
        }

        // ToOriginString
        public static string ToOriginString(this CourseLanguage courseLanguage)
        {
            return Consts.LanguageSymbols[(int)courseLanguage];
        }
    }
}
