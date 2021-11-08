using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace CourseCrawler
{
    public static class Utils
    {
        // GetDepartmentCourseTableUri
        public static Uri GetDepartmentCourseTableUri(int supportedDataSourceIndex)
        {
            // TODO: implement the converter.
            return new(Consts.CoursePagePath + SupportedDataSourceInfo.GetAccessNumberStr(supportedDataSourceIndex));
        }

        // ShowDebugBox
        public static void ShowDebugBox(dynamic debugInfo)
        {
            MessageBox.Show(debugInfo.ToString());
        }

        // SplitStr
        public static string[] SplitStr(string source) => source?.Split(Consts.StringSplitSeperators, StringSplitOptions.None);

        // BooleansToStrNumbers
        public static string[] PositiveBooleansToStrNumbers(List<bool> source)
        {
            if (source == null) return null;

            List<string> result = new();

            for(int i = 0; i < source.Count; i++)
            {
                if (source[i]) result.Add((i + 1).ToString());
            }

            return result.ToArray();
        }

        // BooleansToStrNumbers
        public static List<bool> StrNumbersToPositiveBooleans(string[] source, [Optional] int? capacity)
        {
            if (source == null) return null;

            List<int> positiveIndexes = source.ToList().Select(str => Convert.ToInt32(str) - 1).ToList();
            
            int resultLength = positiveIndexes.Count > 0 ? positiveIndexes.Max() : 0;

            if (capacity != null) resultLength = Math.Max(resultLength, (int)capacity);

            List<bool> result = new(InitializeArray<bool>(resultLength));

            foreach (int index in positiveIndexes)
            {
                result[index] = true;
            }

            return result;
        }

        // InitializeArray
        public static T[] InitializeArray<T>(int length, T initialValue = default)
        {
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), Consts.MsgArrayLengthMustBeNonnegative);
            }

            var array = new T[length];
            for (var i = 0; i < length; i++)
            {
                array[i] = initialValue;
            }
            return array;
        }

        // KeyByValue
        public static T KeyByValue<T, W>(this Dictionary<T, W> dict, W val)
        {
            T key = default;
            foreach (KeyValuePair<T, W> pair in dict)
            {
                if (EqualityComparer<W>.Default.Equals(pair.Value, val))
                {
                    key = pair.Key;
                    break;
                }
            }
            return key;
        }

        /// <summary>
        /// Compute the OR result for each comparator and the subject's equivalence.
        /// 
        /// It is equal to (subject == comparator1 || subject == comparator2 || subject == comparator3 || ...)
        /// </summary>
        public static bool OR<T>(T subject, params T[] comparators)
        {
            bool result = false;
            foreach(T comparator in comparators)
            {
                result = result || Equals(subject, comparator);
            }

            return result;
        }

        /// <summary>
        /// Compute the AND result for each comparator and the subject's equivalence.
        /// 
        /// It is equal to (subject == comparator1 && subject == comparator2 && subject == comparator3 && ...)
        /// </summary>
        public static bool AND<T>(T subject, params T[] comparators)
        {
            bool result = true;
            foreach (T comparator in comparators)
            {
                result = result && Equals(subject, comparator);
            }
            return result;
        }
    }
}
