using System;
using System.Collections.Generic;

namespace CourseCrawler
{
    internal static class Constants
    {
        public static readonly Uri CoursePageUri = new("https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433");
        public static readonly string[] StringSplitSeperators = new[] { "\r\n", "\r", "\n", " " };
        public static readonly List<string> CourseSymbols = new() { null, "○", "△", "☆", "●", "▲", "★" };
        public static readonly List<string> LanguageSymbols = new() { null, "中文", "英語" };
        public static readonly char NewLineChar = '\n';
    }
}
