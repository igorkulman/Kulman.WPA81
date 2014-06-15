using Kulman.WPA81.Converters.Abstract;

namespace Kulman.WPA81.Converters
{
    public class CountToVisibilityConverter: BaseVisibilityConverter<int>
    {
        public bool IsInverted { get; set; }

        protected override bool? ConvertToVisibility(int value)
        {
            return (IsInverted) ? value==0 : value > 0;
        }
    }
}
