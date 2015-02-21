using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.DataProtection;

namespace Kulman.WPA81.Code
{
    public static class DataProtectionExtensions
    {
        public static async Task<string> ProtectAsync(this string clearText, string scope = "LOCAL=user")
        {
            if (clearText == null)
                throw new ArgumentNullException("clearText");
            if (scope == null)
                throw new ArgumentNullException("scope");

            var clearBuffer = CryptographicBuffer.ConvertStringToBinary(clearText, BinaryStringEncoding.Utf8);
            var provider = new DataProtectionProvider(scope);
            var encryptedBuffer = await provider.ProtectAsync(clearBuffer);
            return CryptographicBuffer.EncodeToBase64String(encryptedBuffer);
        }

        public static async Task<string> UnprotectAsync(this string encryptedText)
        {
            if (encryptedText == null)
                throw new ArgumentNullException("encryptedText");

            var encryptedBuffer = CryptographicBuffer.DecodeFromBase64String(encryptedText);
            var provider = new DataProtectionProvider();
            var clearBuffer = await provider.UnprotectAsync(encryptedBuffer);
            return CryptographicBuffer.ConvertBinaryToString(BinaryStringEncoding.Utf8, clearBuffer);
        }
    }
}
