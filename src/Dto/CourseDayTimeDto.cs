using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal static class CourseDayTimeDto
    {
        // ToStringArray
        public static string[] ToStringArray(CourseDayTime times)
        {
            return NumberStrsToTimeWords(Utils.PositiveBooleansToStrNumbers(times.WholeDayList));
        }

        // FromStringArray
        public static CourseDayTime FromStringArray(string[] timeSource)
        {
            if (timeSource == null) return new();
            
            return new(Utils.StrNumbersToPositiveBooleans(TimeWordsToNumberStrs(timeSource), Consts.CourseAmountPerDay).ToArray());
        }

        private static readonly Dictionary<string, string> timeWordsMap = new()
        {
            { "N", "5" },
            { "A", "11" },
            { "B", "12" },
            { "C", "13" },
            { "D", "14" }
        };

        // TimeWordsToNumberStrs
        public static string[] TimeWordsToNumberStrs(string[] source)
        {
            if (source == null) return null;

            List<string> result = new();

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == string.Empty) continue;

                if (timeWordsMap.ContainsKey(source[i]))
                {
                    result.Add(timeWordsMap[source[i]]);
                }
                else
                {
                    int number = Convert.ToInt32(source[i]);
                    if (number > 4) number++;
                    result.Add(number.ToString());
                }
            }

            return result.ToArray();
        }

        // NumberStrsToTimeWords
        public static string[] NumberStrsToTimeWords(string[] source)
        {
            if (source == null) return null;

            List<string> result = new();

            for (int i = 0; i < source.Length; i++)
            {
                int number = Convert.ToInt32(source[i]);
                if (number <= 4)
                {
                    result.Add(source[i]);
                }
                else if (timeWordsMap.ContainsValue(source[i]))
                {
                    result.Add(Utils.KeyByValue(timeWordsMap, source[i]));
                }
                else
                {
                    result.Add((number - 1).ToString());
                }
            }

            return result.ToArray();
        }
    }
}
