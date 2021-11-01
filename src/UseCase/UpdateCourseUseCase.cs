using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal sealed class UpdateCourseUseCase : IUseCase<bool>
    {
        public UpdateCourseUseCase(int dataSourceIndex)
        {

        }

        public bool Do()
        {
            return false;
        }
    }
}
