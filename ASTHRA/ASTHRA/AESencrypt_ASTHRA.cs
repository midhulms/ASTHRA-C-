
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace ASTHRA
{   
     class AESencrypt_ASTHRA
        {
         
        private static byte[] enypt = Encoding.ASCII.GetBytes("ldkbempycavwuqotxzghinj5379048216");
       
        public static string EncryptStrAES(string hideText, string passw)
        {
            if (string.IsNullOrEmpty(hideText))
                throw new ArgumentNullException("text");
            if (string.IsNullOrEmpty(passw))
                throw new ArgumentNullException("password");
         
           string encryptstring = null;                     
           
            RijndaelManaged asthraAES = null;  
            
            
            try{
                

                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(passw, enypt);
              
                 asthraAES= new RijndaelManaged();
                 asthraAES.Key = key.GetBytes(asthraAES.KeySize / 8);


                 ICryptoTransform encryptor = asthraAES.CreateEncryptor(asthraAES.Key, asthraAES.IV);
            
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    msEncrypt.Write(BitConverter.GetBytes(asthraAES.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(asthraAES.IV, 0, asthraAES.IV.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                       using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(hideText);
                        }
                    }
                    encryptstring = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            finally
            {

                if (asthraAES != null)
                    asthraAES.Clear();
            }

           
            return encryptstring;
        }

       
        public static string DecryptStringAES(string cipherText, string passw)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException("cipherText");
            if (string.IsNullOrEmpty(passw))
                throw new ArgumentNullException("sharedSecret");

           
            RijndaelManaged AES = null;

           
            string plaintext = null;

            try
            {

                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(passw, enypt);

                            
                byte[] bytes = Convert.FromBase64String(cipherText);
                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {

                    AES = new RijndaelManaged();
                    AES.Key = key.GetBytes(AES.KeySize / 8);

                    AES.IV = ReadByteArray(msDecrypt);

                    ICryptoTransform decryptor = AES.CreateDecryptor(AES.Key, AES.IV);
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))

                           
                            plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
            finally
            {

                if (AES != null)
                    AES.Clear();
            }

            return plaintext;
        }

        private static byte[] ReadByteArray(Stream s)
        {
            byte[] rawLength = new byte[sizeof(int)];
            if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
            {
                throw new SystemException("Stream did not contain properly formatted byte array");
            }

            byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                throw new SystemException("Did not read byte array properly");
            }

            return buffer;
        }
    }
}

