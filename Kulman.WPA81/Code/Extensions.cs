using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;

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

        /// <summary>
        /// Toggles visibility of a framework element
        /// </summary>
        /// <param name="elem">Framewotk element</param>
        public static void ToggleVisibility(this FrameworkElement elem)
        {
            elem.Visibility = elem.Visibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
        }

        /// <summary>
        /// Executes given action on each item in the collection
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="enumeration">Collection of items</param>
        /// <param name="action">Action to execute</param>
        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        {
            foreach (T item in enumeration)
            {
                action(item);
            }
        }
    }
}
