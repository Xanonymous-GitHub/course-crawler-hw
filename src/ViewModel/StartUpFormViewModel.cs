using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal sealed class StartUpFormViewModel : Bindable
    {
        public StartUpFormViewModel()
        {
            _acceptToOpenSelectCourseForm = true;
            _acceptToOpenCourseManagementForm = true;
        }

        private bool _acceptToOpenSelectCourseForm;
        private bool _acceptToOpenCourseManagementForm;

        public bool AcceptToOpenSelectCourseForm
        {
            get => _acceptToOpenSelectCourseForm;
            set => SetField(ref _acceptToOpenSelectCourseForm, value);
        }

        public bool AcceptToOpenCourseManagementForm
        {
            get => _acceptToOpenCourseManagementForm;
            set => SetField(ref _acceptToOpenCourseManagementForm, value);
        }
    }
}
