using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace MultiLayered_Encryptor_App {
    // RSA Algorithm
    class CipherAlgorithms {
        public static UnicodeEncoding ByteConverter = new UnicodeEncoding();
        public static RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        public static byte[] plaintext;
        public static byte[] encryptedtext;
        public static string key;
        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding) {
            try {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider()) {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e) {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding) {
            try {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider()) {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e) {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
