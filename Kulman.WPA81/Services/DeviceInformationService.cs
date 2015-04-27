using System;
using System.Threading.Tasks;
using Windows.Storage;
using JetBrains.Annotations;
using Kulman.WPA81.Interfaces;

namespace Kulman.WPA81.Services
{
    public class DeviceInformationService : IDeviceInformationService
    {
        /// <summary>
        /// Gets the amount of free space in bytes in given folder. Typically used with ApplicationData.Current.LocalFolder
        /// </summary>
        /// <param name="folder">Folder (use ApplicationData.Current.LocalFolder when in doubt)</param>
        /// <returns>Free space in bytes</returns>
        [NotNull]
        public async Task<ulong> GetFreeSpace([NotNull] StorageFolder folder)
        {
            var retrievedProperties = await folder.Properties.RetrievePropertiesAsync(new string[] {"System.FreeSpace"});
            return (UInt64)retrievedProperties["System.FreeSpace"];
        }
    }
}
