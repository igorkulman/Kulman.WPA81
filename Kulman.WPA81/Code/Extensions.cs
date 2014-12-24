using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Kulman.WPA81.Code
{
    /// <summary>
    /// Useful extension methods
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Add a range of items to a hash set
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="set">Hash set to add to</param>
        /// <param name="items">Collection of items</param>
        public static void AddRange<T>(this HashSet<T> set, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                set.Add(item);
            }
        }

        /// <summary>
        /// Adds a range of items to an observable collection
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="collection">Collection to add to</param>
        /// <param name="items">Collection of items</param>
        public static void AddRange<T>(this ObservableCollection<T> collection, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                collection.Add(item);
            }
        }
    }
}
