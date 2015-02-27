using System;
using System.Threading.Tasks;
using Windows.Storage;
using Kulman.WPA81.Interfaces;

namespace Kulman.WPA81.Services
{
    public class DeviceInformationService : IDeviceInformationService
    {
        /// <summary>
        /// Gets the amount of free space in bytes in given folder. Typically used with ApplicationData.Current.LocalFolder
        /// </summary>
        /// <param name="folder">Folder</param>
        /// <returns>Free space in bytes</returns>
        public async Task<ulong> GetFreeSpace(StorageFolder folder)
        {
            var retrivedProperties = await folder.Properties.RetrievePropertiesAsync(new string[] {"System.FreeSpace"});
            return (UInt64) retrivedProperties["System.FreeSpace"];
        }
    }
}
