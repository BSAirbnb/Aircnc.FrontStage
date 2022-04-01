using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Common
{
    public static class Encryption
    {
        public static string SHA256Encrypt(this string ogSource)
        {
            byte[] source = Encoding.Default.GetBytes(ogSource);
            byte[] crypto = new SHA256CryptoServiceProvider().ComputeHash(source);
            string result = crypto.Aggregate(string.Empty, (current, t) => current + t.ToString("X2"));
            return result.ToUpper();
        }
    }
}
