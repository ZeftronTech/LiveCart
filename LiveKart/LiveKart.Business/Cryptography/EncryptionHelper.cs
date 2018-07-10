using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using LiveKart.LogService;

namespace LiveKart.Business.Cryptography
{
    public class EncryptionHelper
    {
        static ILogService logging = new FileLogService(typeof(EncryptionHelper));

        public static string Encrypt(string password)
        {
            byte[] V = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            return Encrypt(password, GetSecretKey(password), V);
        }

        public static string Decrypt(string password)
        {
            byte[] V = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            return Decrypt(password, GetSecretKey(password), V);
        }

        public static bool VeryfyPassword(string password, string encryptedPassword)
        {
            if (Encrypt(password) == encryptedPassword)
                return true;
            else
                return false;

        }

        private static string Encrypt(string Text, byte[] key, byte[] VectorBytes)
        {
            try
            {

                byte[] TextBytes = Encoding.UTF8.GetBytes(Text);
                RijndaelManaged rijKey = new RijndaelManaged();
                rijKey.Mode = CipherMode.CBC;
                ICryptoTransform encryptor = rijKey.CreateEncryptor(key, VectorBytes);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(TextBytes, 0, TextBytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] cipherTextBytes = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
                string cipherText = Convert.ToBase64String(cipherTextBytes);
                return cipherText;
            }
            catch (Exception e)
            {
                logging.Error(e.ToString());
                return string.Empty;
            }
        }

        private static string Decrypt(string Text, byte[] keyBytes, byte[] VectorBytes)
        {
            try
            {
                byte[] TextBytes = Convert.FromBase64String(Text);
                RijndaelManaged rijKey = new RijndaelManaged();
                rijKey.Mode = CipherMode.CBC;
                ICryptoTransform decryptor = rijKey.CreateDecryptor(keyBytes, VectorBytes);
                MemoryStream memoryStream = new MemoryStream(TextBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] pTextBytes = new byte[TextBytes.Length];
                int decryptedByteCount = cryptoStream.Read(pTextBytes, 0, pTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                string plainText = Encoding.UTF8.GetString(pTextBytes, 0, decryptedByteCount);
                return plainText;
            }
            catch (Exception e)
            {
                logging.Error(e.ToString());
                return string.Empty;
            }
        }

        private static byte[] GetSecretKey(string password)
        {
            string secretKey = "dr0!sys";   // need to replace with some string from client side
            byte[] salt = { 0, 0, 0, 0, 0, 0, 0, 0 };
            PasswordDeriveBytes cdk = new PasswordDeriveBytes(secretKey, salt);
            return cdk.CryptDeriveKey("RC2", "SHA1", 128, salt);
        }
    }
}
