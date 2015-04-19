using System;
using JetBrains.Annotations;
using Kulman.WPA81.Converters.Abstract;

namespace Kulman.WPA81.Converters
{
    /// <summary>
    /// Converts give string to lower case
    /// </summary>
    public class LowerCaseConverter: BaseConverter<string,string>
    {
        [ContractAnnotation("null => null")]
        public override string Convert([CanBeNull] string value)
        {
            if (String.IsNullOrEmpty(value)) return null;

            return value.ToLower();
        }
    }
}
