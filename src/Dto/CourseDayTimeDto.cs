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
        public static string[] ToStringArray(CourseDayTime times) => Utils.PositiveBooleansToStrNumbers(times.WholeDayList);

        // FromStringArray
        public static CourseDayTime FromStringArray(string[] timeSource)
        {
            if (timeSource == null) return new();

            return new(Utils.StrNumbersToPositiveBooleans(timeSource, Consts.CourseAmountPerDay).ToArray());
        }
    }
}
