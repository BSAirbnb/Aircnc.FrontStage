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
        /// <summary>
        /// 轉不回來的加密方法
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns></returns>
        public static string SHA256Encrypt(this string strSource)
        {
            byte[] source = Encoding.Default.GetBytes(strSource);
            byte[] crypto = new SHA256CryptoServiceProvider().ComputeHash(source);
            string result = crypto.Aggregate(string.Empty, (current, t) => current + t.ToString("X2"));
            return result.ToUpper();
        }
    }
}
