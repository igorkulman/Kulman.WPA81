using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Kulman.WPA81.Interfaces
{
    /// <summary>
    /// Interface for Windows Phone Store service
    /// </summary>
    public interface IWindowsPhoneStoreService
    {
        /// <summary>
        /// Checks if a product is purchased
        /// </summary>
        /// <param name="productId">Product id</param>
        /// <returns>True if the product is purchased</returns>
        bool IsPurchased([NotNull] string productId);

        /// <summary>
        /// Tries to purchase a product
        /// </summary>
        /// <param name="productId">Product id</param>
        /// <returns>True on success, false otherwise</returns>
        Task<bool> Purchase([NotNull] string productId);

        /// <summary>
        /// Gets the price of a product
        /// </summary>
        /// <param name="productId">Product id</param>
        /// <returns>Product price</returns>
        [CanBeNull]
        Task<string> GetPrice([NotNull] string productId);        
    }
}
