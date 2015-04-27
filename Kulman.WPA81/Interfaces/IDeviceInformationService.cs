using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Storage;
using JetBrains.Annotations;

namespace Kulman.WPA81.Interfaces
{
    public interface IDeviceInformationService
    {
        /// <summary>
        /// Gets the amount of free space in bytes in given folder. Typically used with ApplicationData.Current.LocalFolder
        /// </summary>
        /// <param name="folder">Folder</param>
        /// <returns>Free space in bytes</returns>
        Task<UInt64> GetFreeSpace([NotNull] StorageFolder folder);
    }
}
