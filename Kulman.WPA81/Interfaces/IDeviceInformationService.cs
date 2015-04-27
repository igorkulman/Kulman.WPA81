using System;
using System.Threading.Tasks;
using Windows.Storage;
using JetBrains.Annotations;

namespace Kulman.WPA81.Interfaces
{
    public interface IDeviceInformationService
    {
        /// <summary>
        /// Gets the amount of free space in bytes in given folder. Typically used with ApplicationData.Current.LocalFolder
        /// </summary>
        /// <param name="folder">Folder (use ApplicationData.Current.LocalFolder when in doubt)</param>
        /// <returns>Free space in bytes</returns>
        [NotNull]
        Task<UInt64> GetFreeSpace([NotNull] StorageFolder folder);
    }
}
