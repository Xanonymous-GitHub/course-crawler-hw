using System;
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
    }
}
