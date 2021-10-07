using System.Collections.Generic;

namespace CourseCrawler
{
    internal class Department : IDepartment
    {
        public Department(string name, Dictionary<string, ICourseTable> tables)
        {
            _name = name;
            _tables = tables;
        }

        public Department(string name, ICourseTable table)
        {
            _name = name;
            Dictionary<string, ICourseTable> tables = new();
            tables.Add(table.Name, table);
            _tables = tables;
        }

        private readonly string _name;
        private readonly Dictionary<string, ICourseTable> _tables;

        public string Name => _name;

        public Dictionary<string, ICourseTable> CourseTables => _tables;
    }
}
