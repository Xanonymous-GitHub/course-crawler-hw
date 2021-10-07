using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal enum CourseType
    {
        NoType = 0,
        DeptRequired = 1, // ○
        UniversityRequired = 2, // △
        CommonElective = 3, // ☆
        DeptMajorRequired = 4, // ●
        UniversityMajorRequired = 5, // ▲
        MajorElective = 6, // ★
    }

    internal enum CourseLanguage
    {
        NotSet = 0,
        TW = 1,
        EN = 2,
    }
}
