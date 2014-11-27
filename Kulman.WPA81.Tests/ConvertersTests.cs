using System.Globalization;
using Windows.UI.Xaml;
using Kulman.WPA81.Converters;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace Kulman.WPA81.Tests
{
    [TestClass]
    public class ConvertersTests
    {
        [TestMethod]
        public void BooleanToNegateConverterShouldWork()
        {
            var converter = new BooleanNegateConverter();
            Assert.IsTrue((bool)converter.Convert(false,typeof(bool),null,"en-US"));

            Assert.IsFalse((bool)converter.Convert(true, typeof(bool), null, "en-US"));
        }

        [TestMethod]
        public void BooleanToVisibilityConverterShouldWork()
        {
            var converter = new BooleanToVisibilityConverter();
            Assert.AreEqual(Visibility.Visible, (Visibility)converter.Convert(true, typeof(bool), null, "en-US"));
            Assert.AreEqual(Visibility.Collapsed, (Visibility)converter.Convert(false, typeof(bool), null, "en-US"));
        }

        [TestMethod]
        public void InvertedBooleanToVisibilityConverterShouldWork()
        {
            var converter = new InvertedBooleanToVisibilityConverter();
            Assert.AreEqual(Visibility.Collapsed, (Visibility)converter.Convert(true, typeof(bool), null, "en-US"));
            Assert.AreEqual(Visibility.Visible, (Visibility)converter.Convert(false, typeof(bool), null, "en-US"));
        }

        [TestMethod]
        public void BooleanToVisibilityConverterShouldWorkInverterd()
        {
            var converter = new BooleanToVisibilityConverter()
                            {
                                IsInverted = true
                            };
            Assert.AreEqual(Visibility.Collapsed, (Visibility)converter.Convert(true, typeof(bool), null, "en-US"));
            Assert.AreEqual(Visibility.Visible, (Visibility)converter.Convert(false, typeof(bool), null, "en-US"));
        }

        [TestMethod]
        public void LowerCaseConverterShouldWork()
        {
            var s = "hsDkjdsa8dask";
            var converter = new LowerCaseConverter();
            Assert.AreEqual(s.ToLower(), (string)converter.Convert(s, typeof(bool), null, "en-US"));            
        }

        [TestMethod]
        public void UpperCaseConverterShouldWork()
        {
            var s = "hsDkjdsa8dask";
            var converter = new UpperCaseConverter();
            Assert.AreEqual(s.ToUpper(), (string)converter.Convert(s, typeof(bool), null, "en-US"));
        }
    }
}
