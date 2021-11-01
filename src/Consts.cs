using System;
using System.Collections.Generic;

namespace CourseCrawler
{
    internal static class Consts
    {
        public static readonly string CoursePagePath = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=";
        public static readonly string[] StringSplitSeperators = new[] { "\r\n", "\r", "\n", " ", "\n\r" };
        public static readonly List<string> CourseSymbols = new() { "", "○", "△", "☆", "●", "▲", "★" };
        public static readonly List<string> LanguageSymbols = new() { "", "中文", "英語" };
        public static readonly string NewLineChar = "\n";
        public static readonly string SpaceChar = " ";
        public static readonly string DiamondChar = "◆";
        public static readonly string Monday = "一";
        public static readonly string Tuesday = "二";
        public static readonly string Wednesday = "三";
        public static readonly string Thursday = "四";
        public static readonly string Friday = "五";
        public static readonly string Saturday = "六";
        public static readonly string Sunday = "日";
        public static readonly string Comma = "，";
        public static readonly string IdeographicComma = "、";
        public static readonly string Dash = "-";
        public static readonly string UpperQuoteTw = "「";
        public static readonly string LowerQuoteTw = "」";
        public static readonly string NameConflictErrMsgHead = "課程名稱相同：";
        public static readonly string TimeConflictErrMsgHead = "衝堂：";
        public static readonly string SuccessfullySelectCourse = "加選成功";
        public static readonly string SuccessfullySaveCourse = "儲存成功";
        public static readonly string FailToSelectCourse = "加選失敗";
        public static readonly string UnselectCourse = "退選";
        public static readonly string SelectedCourse = "SelectedCourse";
        public static readonly string TabPageNameTitle = "tabPage";
        public static readonly string AllCourses = "AllCourses";
        public static readonly string AllDepartments = "AllDepartments";
        public static readonly int Big5EncodingCodePage = 950;
        public static readonly int CourseAmountPerDay = 14;
        public static readonly string MsgCourseDayTimeStringArraySizeNotAllowed = "Time string array has invalid length.";
        public static readonly string MsgArrayLengthMustBeNonnegative = "Array length must be nonnegative";
        public static readonly string CourseTimePeriodNameChars = "1234N56789ABCD";
        public static readonly string MsgElementNotFound = "Member Not Found!";
        public static readonly string MsgElementShouldNotBeFound = "Member Should Not Be Found!";
        public static readonly string MsgDeadArea = "This area should not be proccessed!";
    }
}
