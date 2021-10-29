using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;

namespace CourseCrawler
{
    internal static class Utils
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
        public static string[] SplitStr(string source) => source.Split(Consts.StringSplitSeperators, StringSplitOptions.None);

        // BooleansToStrNumbers
        public static string[] PositiveBooleansToStrNumbers(List<bool> source)
        {
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
            List<int> positiveIndexes = source.ToList().Select(str => Convert.ToInt32(str)).ToList();
            int resultLength = positiveIndexes.Max();

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
    }
}
