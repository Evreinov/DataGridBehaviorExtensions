﻿using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace DataGridBehaviorExtensions.Infrastructure.Converters;

[ValueConversion(typeof(bool), typeof(Visibility))]
public class BooleanToVisibilityConverter : IValueConverter
{

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if ((Visibility)value == Visibility.Visible) return true; return false;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if ((bool)value) return Visibility.Visible; return Visibility.Collapsed;
    }
}