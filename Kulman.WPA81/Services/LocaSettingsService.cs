using Windows.Storage;
using Kulman.WPA81.Interfaces;

namespace Kulman.WPA81.Services
{
    /// <summary>
    /// ISettingsService implementation usinng isolated storage settings
    /// </summary>
    public class LocaSettingsService : ISettingsService
    {
        /// <summary>
        /// Gets a storred value for a given key
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>Value</returns>
        public object Get(string key)
        {
            if (ApplicationData.Current.LocalSettings.Values.ContainsKey(key))
            {
                return ApplicationData.Current.LocalSettings.Values[key];
            }

            return null;
        }

        /// <summary>
        /// Save a key-value pair to settings
        /// Overwites existing
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public void Set(string key, object value)
        {
            if (ApplicationData.Current.LocalSettings.Values.ContainsKey(key))
            {
                ApplicationData.Current.LocalSettings.Values[key] = value;
            }
            else
            {
                ApplicationData.Current.LocalSettings.Values.Add(key, value);
            }
        }

        /// <summary>
        /// Deletes value for a given key
        /// </summary>
        /// <param name="key">Key</param>
        public void Clear(string key)
        {
            if (ApplicationData.Current.LocalSettings.Values.ContainsKey(key))
            {
                ApplicationData.Current.LocalSettings.Values.Remove(key);
            }
        }

        /// <summary>
        /// Clears all settings
        /// </summary>
        public void ClearAll()
        {
            ApplicationData.Current.LocalSettings.Values.Clear();
        }
    }
}
