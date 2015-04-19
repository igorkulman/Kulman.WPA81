using System;
using System.Collections;
using System.Linq;
using JetBrains.Annotations;
using Kulman.WPA81.Converters.Abstract;

namespace Kulman.WPA81.Converters
{
    public class ObjectToVisibilityConverter : BaseVisibilityConverter<object>
    {
        protected override bool? ConvertToVisibility([CanBeNull] object value)
        {
            if (value is string)
            {
                return !String.IsNullOrWhiteSpace((string)value);
            }

            if (value is IEnumerable)
            {
                return ((IEnumerable)value).Cast<object>().Any();
            }

            return value != null;
        }
    }
}
