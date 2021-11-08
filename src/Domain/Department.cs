using System.Collections.Generic;

namespace CourseCrawler
{
    public class Department : Bindable, IDepartment
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

        private string _name;
        private Dictionary<string, ICourseTable> _tables;

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public Dictionary<string, ICourseTable> CourseTables
        {
            get => _tables;
            set => SetField(ref _tables, value);
        }
    }
}
