using System;
using System.Windows;
using System.Globalization;
using System.Windows.Data;
using AmadeusW.DemoApplication;

namespace AmadeusW.DemoApplication.Converters
{
    [ValueConversion(typeof(ApplicationSteps), typeof(Visibility))]
    class StepToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is ApplicationSteps))
            {
                return Visibility.Collapsed;
            }

            ApplicationSteps visibleStep = (ApplicationSteps)value;
            String stepName = parameter.ToString();

            if (visibleStep.ToString() == parameter.ToString())
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Collapsed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is Visibility))
            {
                return 0;
            }
            Visibility stepVisibility = (Visibility)value;
            String stepName = parameter.ToString();

            if (stepVisibility == Visibility.Visible && stepName == "FirstStep")
            {
                return 1;
            }
            else if (stepVisibility == Visibility.Visible && stepName == "SecondStep")
            {
                return 2;
            }
            else if (stepVisibility == Visibility.Visible && stepName == "ThirdStep")
            {
                return 3;
            }
            else if (stepVisibility == Visibility.Visible && stepName == "FourthStep")
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
    }
}
