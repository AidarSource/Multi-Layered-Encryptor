using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace MultiLayered_Encryptor_App.Algorithms {
    class RijndaelAlgorithm {
        public static string Encrypt(string plainText, string passPhrase, string salt, string initVector) {
            //Create instance of RijndaelManaged
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };

            //iterations to derive key
            int keyIterations = 10000;

            //Convert the cipher text to UTF Bytes
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            //Hash the user passphrase with the salt provided to create a key
            byte[] keyBytes = new Rfc2898DeriveBytes(passPhrase, Encoding.ASCII.GetBytes(salt), keyIterations).GetBytes(256 / 8);

            //Starts the Encryption using the Key and Inititalisation Vector 
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(initVector));

            byte[] cipherTextBytes;

            //Creates a MemoryStream to do the encryption in
            using (var memoryStream = new MemoryStream()) {
                //Creates the new Cryptology Stream --> Outputs to Memory Stream
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)) {
                    //Writes the string in the Cryptology Stream
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    //Takes the MemoryStream and puts it to an array
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            //Converts the array from Base 64 to a string and returns
            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string Decrypt(string encryptedText, string passPhrase, string salt, string initVector) {


            //Create instance of RijndaelManaged
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };

            //iterations to derive key
            int keyIterations = 10000;

            //Convert the plain text to UTF Bytes
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);

            //Hash the user passphrase with the salt provided to create a key
            byte[] keyBytes = new Rfc2898DeriveBytes(passPhrase, Encoding.ASCII.GetBytes(salt), keyIterations).GetBytes(256 / 8);

            //Starts the Deryption using the Key and Inititalisation Vector 
            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(initVector));

            int decryptedByteCount = 0;

            //Creates a MemoryStream to do the decryption in, with the encrypted value
            using (var memoryStream = new MemoryStream(cipherTextBytes)) {
                //Read the new memory stream and read it in the cryptology stream
                using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)) {
                    decryptedByteCount = cryptoStream.Read(cipherTextBytes, 0, cipherTextBytes.Length);
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }

            return Encoding.UTF8.GetString(cipherTextBytes, 0, decryptedByteCount).TrimEnd('\0');

        }
    }
}
