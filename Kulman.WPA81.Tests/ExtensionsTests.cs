using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kulman.WPA81.Code;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

#if WINDOWS_PHONE_APP
namespace Kulman.WPA81.Tests
#else
namespace Kulman.WPA81.Tests.Windows
#endif
{
    [TestClass]
    public class ExtensionsTests
    {
        [TestMethod]
        public async Task DataProtectionExtensionsShouldWork()
        {
            const string s = "test string";

            var encrypted = await s.ProtectAsync();
            Assert.AreNotEqual(s, encrypted);

            var clear = await encrypted.UnprotectAsync();
            Assert.AreEqual(s,clear);
        }
    }
}
