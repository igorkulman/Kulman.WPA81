using System;
using System.Reflection;
using Windows.UI.Xaml.Data;

namespace Kulman.WPA81.Converters.Abstract
{
    public abstract class BaseConverterWithParameter<TFrom, TParam, TTo> : IValueConverter
    {
        public abstract TTo Convert(TFrom value, TParam parameter);

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            TParam p = parameter != null ? (TParam) parameter : default(TParam);

            if (value == null && !typeof(TFrom).GetTypeInfo().IsValueType)
            {
                bool nullable;

                if (typeof(TFrom).GetTypeInfo().IsValueType)
                {
                    nullable = Nullable.GetUnderlyingType(typeof(TFrom)) != null;
                }
                else
                {
                    nullable = true;
                }

                if (nullable)
                {
                    return Convert(default(TFrom),p);
                }
            }

            if (value is TFrom)
            {
                return Convert((TFrom)value,p);
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotSupportedException();
        }
    }
}
