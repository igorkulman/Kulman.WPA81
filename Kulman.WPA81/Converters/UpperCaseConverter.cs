using System;
using Kulman.WPA81.Converters.Abstract;

namespace Kulman.WPA81.Converters
{
    /// <summary>
    /// Converts give string to upper case
    /// </summary>
    public class UpperCaseConverter : BaseConverter<string, string>
    {
        public override string Convert(string value)
        {
            if (String.IsNullOrEmpty(value)) return null;

            return value.ToUpper();
        }
    }
}
