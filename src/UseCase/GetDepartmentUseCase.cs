using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal sealed class GetDepartmentUseCase : IUseCase<Department>
    {
        public GetDepartmentUseCase(string departmentName)
        {
            _departmentName = departmentName;
        }

        private readonly string _departmentName;

        private readonly Store _store = Store.Instance;

        public Department Do()
        {
            bool hasDepartment = _store.Exist(_departmentName);
            return hasDepartment ? _store.Use<Department>(_departmentName) : null;
        }
    }
}
