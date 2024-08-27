using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLTK_NRO
{
    internal class Security
    {
        string hash = "T4i@3d4ng";
        public string Encrypt(string pwd)
        {
            string textResult;
            byte[] keyHash = Encoding.UTF8.GetBytes(hash);
            byte[] dataPwd = Encoding.UTF8.GetBytes(pwd);
            using (HMACSHA512 hmac = new HMACSHA512(keyHash))
            {
                byte[] hashValue = hmac.ComputeHash(dataPwd);
                textResult = BitConverter.ToString(hashValue, 0, hashValue.Length).Replace("-", "");
            }

            return textResult;
        }
        private byte[] encryptionKey;
        private byte[] encryptionIV;
        public string EncryptV2(string pwd)
        {
            string textResult;
            byte[] data = Encoding.UTF8.GetBytes(pwd);
            using (Aes aes = Aes.Create())
            {
                aes.GenerateKey();
                aes.GenerateIV();
                encryptionKey = aes.Key;
                encryptionIV = aes.IV;
                using (ICryptoTransform cryptoTransform = aes.CreateEncryptor())
                {
                    byte[] encryptData = cryptoTransform.TransformFinalBlock(data, 0, data.Length);
                    textResult = Convert.ToBase64String(encryptData);
                }
            }
            return textResult;
        }
        public string DecryptV2(string pwd)
        {
            string textResult;
            byte[] encryptData = Convert.FromBase64String(pwd);
            using (Aes aes = Aes.Create())
            {
                aes.Key = encryptionKey;
                aes.IV = encryptionIV;

                using (ICryptoTransform decryption = aes.CreateDecryptor())
                {
                    byte[] decryptData = decryption.TransformFinalBlock(encryptData, 0, encryptData.Length);
                    textResult = Encoding.UTF8.GetString(decryptData);
                }
            }
            return textResult;
        }
    }
}
