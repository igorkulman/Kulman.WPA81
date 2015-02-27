using System.Threading.Tasks;
using Windows.Storage;
using Kulman.WPA81.Interfaces;
using Kulman.WPA81.Services;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace Kulman.WPA81.Tests
{
    [TestClass]
    public class DeviceInformationServiceTests
    {
        private IDeviceInformationService _deviceInformationService;

        [TestInitialize]
        public void Init()
        {
            _deviceInformationService=new DeviceInformationService();
        }

        [TestMethod]
        public async Task FreeSpaceInforShouldBeFetched()
        {
            var folders = new []{ApplicationData.Current.LocalFolder, ApplicationData.Current.RoamingFolder, KnownFolders.PicturesLibrary, KnownFolders.MusicLibrary};
            foreach (var storageFolder in folders)
            {
                var freeSpace = await _deviceInformationService.GetFreeSpace(storageFolder);
                Assert.IsTrue(freeSpace > 0);
            }
        }
    }
}
