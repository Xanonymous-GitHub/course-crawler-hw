using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal class Store
    {
        private Store() 
        {
            _courses = new();
        }

        private static readonly Lazy<Store> lazy = new Lazy<Store>(() => new Store());

        private readonly List<Course> _courses = null;

        public static Store Instance 
        {
            get => lazy.Value;
        }

        public List<Course> Courses => _courses;
    }
}
