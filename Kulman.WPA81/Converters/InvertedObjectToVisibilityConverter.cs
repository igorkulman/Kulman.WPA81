using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kulman.WPA81.Converters.Abstract;

namespace Kulman.WPA81.Converters
{
    public class InvertedObjectToVisibilityConverter: BaseVisibilityConverter<object>
    {
        protected override bool? ConvertToVisibility(object value)
        {
            if (value is string)
            {
                return String.IsNullOrWhiteSpace((string)value);
            }

            if (value is IEnumerable)
            {
                return !((IEnumerable)value).Cast<object>().Any();
            }

            return value == null;
        }
    }
}
