using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kulman.WPA81.Converters.Abstract;

namespace Kulman.WPA81.Converters
{
    public class InvertedBooleanToVisibilityConverter: BaseVisibilityConverter<bool>
    {
        protected override bool? ConvertToVisibility(bool value)
        {
            return !value;
        }
    }
}
