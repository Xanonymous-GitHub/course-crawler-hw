using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal class CourseDayTime : Bindable, ICourseDayTime
    {
        public CourseDayTime()
        {
            _one = false; 
            _two = false; 
            _three = false; 
            _four = false; 
            _n = false; 
            _five = false; 
            _six = false; 
            _seven = false; 
            _eight = false; 
            _nine = false; 
            _a = false; 
            _b = false; 
            _c = false; 
            _d = false;
        }

        public CourseDayTime(params bool[] times)
        {
            _one = times[0];
            _two = times[1];
            _three = times[2];
            _four = times[3];
            _n = times[4];
            _five = times[5];
            _six = times[6];
            _seven = times[7];
            _eight = times[8];
            _nine = times[9];
            _a = times[10];
            _b = times[11];
            _c = times[12];
            _d = times[13];
        }

        private bool _one, _two, _three, _four, _n, _five, _six, _seven, _eight, _nine, _a, _b, _c, _d;
        public bool One
        {
            get => _one;
            set => SetField(ref _one, value);
        }
        public bool Two
        {
            get => _two;
            set => SetField(ref _two, value);
        }
        public bool Three
        {
            get => _three;
            set => SetField(ref _three, value);
        }
        public bool Four
        {
            get => _four;
            set => SetField(ref _four, value);
        }
        public bool N
        {
            get => _n;
            set => SetField(ref _n, value);
        }
        public bool Five
        {
            get => _five;
            set => SetField(ref _five, value);
        }
        public bool Six
        {
            get => _six;
            set => SetField(ref _six, value);
        }
        public bool Seven
        {
            get => _seven;
            set => SetField(ref _seven, value);
        }
        public bool Eight
        {
            get => _eight;
            set => SetField(ref _eight, value);
        }
        public bool Nine
        {
            get => _nine;
            set => SetField(ref _nine, value);
        }
        public bool A
        {
            get => _a;
            set => SetField(ref _a, value);
        }
        public bool B
        {
            get => _b;
            set => SetField(ref _b, value);
        }
        public bool C
        {
            get => _c;
            set => SetField(ref _c, value);
        }
        public bool D
        {
            get => _d;
            set => SetField(ref _d, value);
        }

        public List<bool> WholeDayList => new() { One, Two, Three, Four, N, Five, Six, Seven, Eight, Nine, A, B, C, D };
    }
}
