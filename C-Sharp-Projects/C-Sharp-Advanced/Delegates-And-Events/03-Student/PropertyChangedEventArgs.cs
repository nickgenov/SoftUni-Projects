﻿using System;

namespace _03_Student
{
    public class PropertyChangedEventArgs : EventArgs
    {
        public PropertyChangedEventArgs(string propertyName, dynamic oldValue, dynamic newValue)
        {
            this.PropertyName = propertyName;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string PropertyName { get; set; }
        public dynamic OldValue { get; set; }
        public dynamic NewValue { get; set; }
    }
}
