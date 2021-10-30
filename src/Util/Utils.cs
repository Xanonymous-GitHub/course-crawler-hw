using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using System.ComponentModel;

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

        // FindGroupIndexPairIn2dList
        // FIXME replace `BindingList` type for a List-like generic type.
        public static (int groupIndex, int childIndex) FindGroupIndexPairIn2dList<T>(IList<BindingList<T>> source, int targetIndex)
        {
            int groupIndex = 0, childIndex = 0, total = 0;

            for (; groupIndex < source.Count; groupIndex++)
            {
                for (childIndex = 0; childIndex < source[groupIndex].Count; childIndex++)
                {
                    if (total == targetIndex) return (groupIndex, childIndex);
                    total++;
                }
            }

            // FIXME prevent invalid targetIndex.
            // if this return be called, means expected index is not found in source
            // this line should not be called.
            return (groupIndex, childIndex);
        }
    }
}
