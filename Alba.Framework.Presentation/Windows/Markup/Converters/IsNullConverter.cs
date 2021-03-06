﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Alba.Framework.Windows.Markup
{
    [ValueConversion (typeof(object), typeof(bool))]
    public class IsNullConverter : IValueConverter
    {
        public object Convert (object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (ReferenceEquals(value, DependencyProperty.UnsetValue))
                return DependencyProperty.UnsetValue;
            return ReferenceEquals(value, null);
        }

        public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}