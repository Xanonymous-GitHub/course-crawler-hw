﻿using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CourseCrawler
{
    public abstract class Bindable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // NotifyPropertyChanged
        private void NotifyPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new(propertyName));

        // SetField
        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            NotifyPropertyChanged(propertyName);
            return true;
        }
    }
}
