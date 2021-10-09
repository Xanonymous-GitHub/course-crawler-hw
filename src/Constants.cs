﻿using System;
using System.Collections.Generic;

namespace CourseCrawler
{
    internal static class Constants
    {
        public static readonly Uri CoursePageUri = new("https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433");
        public static readonly string[] StringSplitSeperators = new[] { "\r\n", "\r", "\n", " ", "\n\r" };
        public static readonly List<string> CourseSymbols = new() { "", "○", "△", "☆", "●", "▲", "★" };
        public static readonly List<string> LanguageSymbols = new() { "", "中文", "英語" };
        public static readonly char NewLineChar = '\n';
        public static readonly char SpaceChar = ' ';
        public static readonly char DiamondChar = '◆';
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
        public static readonly string FailToSelectCourse = "加選失敗";
    }
}
