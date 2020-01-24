﻿using AgentRecruiter.ViewModels;

using dotMorten.Xamarin.Forms;

using System;
using System.Globalization;

using Xamarin.Forms;

namespace AgentRecruiter.Converters
{

    public class AutoSuggestBoxQuerySubmittedEventArgsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var eventArgs = value as AutoSuggestBoxQuerySubmittedEventArgs;
            return new QuerySubmitArgs(eventArgs.ChosenSuggestion, eventArgs.QueryText);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
