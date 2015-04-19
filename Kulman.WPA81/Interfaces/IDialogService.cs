using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Kulman.WPA81.Interfaces
{
    public interface IDialogService
    {
        /// <summary>
        /// Shows a dialog with given message and ok/cancel buttons. 
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="title">Title</param>
        /// <param name="okText">OK text (optional)</param>
        /// <param name="cancelText">Cancel text (optional)</param>
        /// <returns>True if ok pressed, false otherwise</returns>
        Task<bool> ShowMessageDialog([NotNull] string message, [NotNull] string title, [CanBeNull] string okText = null, [CanBeNull] string cancelText = null);
    }
}