//Jesus Christ is the Lord
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace app1Aleluya
{
    //Thank You Jesus for http://stackoverflow.com/questions/273452/using-aes-encryption-in-c-sharp
    public static class CryptAleluya
    {
        #region Settings

        private static int _iterations = 2;
        private static int _keySize = 256;

        private static string _hash = "SHA1";
        private static string _salt =   "aselrias38490a32"; // Random
        private static string _vector = "8947az34awl34kjq"; // Random

        #endregion

        public static byte[] Encrypt(byte[] value, string password)
        {
            return EncryptAleluya<AesManaged>(value,  password);
        }
        public static byte[] EncryptAleluya<T>(byte[] value, string password)
                where T : SymmetricAlgorithm, new()
        {
            ASCIIEncoding encAleluya = new ASCIIEncoding();
            UTF8Encoding enc8Aleluya = new UTF8Encoding();

            //Set random 16 byte salt and vector



            byte[] vectorBytes  = new byte[16];// encAleluya.GetBytes(_vector);
            byte[] saltBytes    = new byte[16];// encAleluya.GetBytes(_salt);
            Random rndAleluya = new Random();
            rndAleluya.NextBytes(vectorBytes);
            rndAleluya.NextBytes(saltBytes);
            //Form1.quickAlertAleluya("HALLELUJAH - " + Convert.ToBase64String(vectorBytes) + " - " + Convert.ToBase64String(saltBytes), "Aleluya");
            byte[] valueBytes   = value;// enc8Aleluya.GetBytes(value);

            byte[] encrypted;
            using (T cipher = new T())
            {
                PasswordDeriveBytes _passwordBytes =
                  new PasswordDeriveBytes(password, saltBytes, _hash, _iterations);

                byte[] keyBytes = _passwordBytes.GetBytes(_keySize / 8);

                cipher.Mode = CipherMode.CBC;

                using (ICryptoTransform encryptor = cipher.CreateEncryptor(keyBytes, vectorBytes))
                {
                    using (MemoryStream to = new MemoryStream())
                    {
                        using (CryptoStream writer = new CryptoStream(to, encryptor, CryptoStreamMode.Write))
                        {
                            writer.Write(valueBytes, 0, valueBytes.Length);
                            writer.FlushFinalBlock();
                            encrypted = to.ToArray();
                        }
                    }
                }
                cipher.Clear();
            }

            List<byte> listAleluya = new List<byte>();
            listAleluya.AddRange(vectorBytes);
            listAleluya.AddRange(saltBytes);
            listAleluya.AddRange(encrypted);
            return listAleluya.ToArray();// Convert.ToBase64String(encrypted);
        }

        public static byte[] Decrypt(byte[] value, string password)
        {
            return Decrypt<AesManaged>(value, password);
        }
       
        public static byte[] Decrypt<T>(byte[] value, string password) where T : SymmetricAlgorithm, new()
        {
            ASCIIEncoding encAleluya = new ASCIIEncoding();
            UTF8Encoding enc8Aleluya = new UTF8Encoding();

            ArraySegment<byte> segmentAleluya = new ArraySegment<byte>(value);
            byte[] vectorBytes = segmentAleluya.Take(16).ToArray();// new ArraySegment<byte>(value, 0, 16).Array;//_vector);
            byte[] saltBytes = segmentAleluya.Skip(16).Take(16).ToArray();//new ArraySegment<byte>(value,16,16).Array;//_salt);
            byte[] valueBytes = segmentAleluya.Skip(32).ToArray();//new ArraySegment<byte>(value, 32, value.Length - 32).Array;//Convert.FromBase64String(value);

            //Form1.quickAlertAleluya("Hallelujah - "+ BitConverter.ToInt64(value, 0) + " Aleluya - "+ value.Length  + Convert.ToBase64String(vectorBytes) + " - " + Convert.ToBase64String(saltBytes) + " - " , "Aleluya");
            byte[] decrypted;

            int decryptedByteCount = 0;

            using (T cipher = new T())
            {
                PasswordDeriveBytes _passwordBytes = new PasswordDeriveBytes(password, saltBytes, _hash, _iterations);
                byte[] keyBytes = _passwordBytes.GetBytes(_keySize / 8);

                cipher.Mode = CipherMode.CBC;
                cipher.Padding = PaddingMode.Zeros;
                try
                {
                    using (ICryptoTransform decryptor = cipher.CreateDecryptor(keyBytes, vectorBytes))
                    {
                        using (MemoryStream from = new MemoryStream(valueBytes))
                        {
                            using (CryptoStream reader = new CryptoStream(from, decryptor, CryptoStreamMode.Read))
                            {
                                decrypted = new byte[valueBytes.Length];
                                decryptedByteCount = reader.Read(decrypted, 0, decrypted.Length);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Form1.quickAlertAleluya(ex.ToString() , "Aleluya");
                    return null;
                }

                cipher.Clear();
            }
            return decrypted;// Encoding.UTF8.GetString(decrypted, 0, decryptedByteCount);
        }

    }
}