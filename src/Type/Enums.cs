using System;
using System.Collections.Generic;
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

    internal enum CourseManagementFormDisplayStatus
    {
        NotSpecifiedCourseToBeEdited = 0,
        EditingFiledsNotChangedOrSaved = 1,
        EditingCourseButInvalid = 2,
        EditingCourseAndValid = 3,
        EditingNewCourseButInvalid = 4,
        EditingNewCourseAndValid = 5,
    }
}
