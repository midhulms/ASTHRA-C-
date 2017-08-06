        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
       using System.IO;

namespace ASTHRA
{
   //class aes
  

   
//

         // Convert strings into byte arrays.
        // Let us assume that strings only contain ASCII codes.
        // If strings include Unicode characters, use Unicode, UTF7, or UTF8 
        // encoding.
        ///private static byte[] enypt = Encoding.ASCII.GetBytes("jasdh7834y8hfeur73rsharks214");
       // /// <summary>
        /// Encrypt the given string using AES.  The string can be decrypted using 
        /// DecryptStringAES().  The sharedSecret parameters must match.
        /// </summary>
        /// <param name="plainText">The text to encrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for encryption.</param>
       // public static string EncryptStringAES(string plainText, string sharedSecret)
       // {
//if (string.IsNullOrEmpty(plainText))
     ///           throw new ArgumentNullException("plainText");
     ///       if (string.IsNullOrEmpty(sharedSecret))
    ////            throw new ArgumentNullException("sharedSecret");
     //     // Create uninitialized Rijndael encryption object.
    //   //    string outStr = null;                       // Encrypted string to return
   // //        //This class here the Rijndael is what will have most all of the methods we need to do aes encryption.  
	//When this is called it will create both a key and Initialization Vector to use.
         ////   RijndaelManaged aesAlg = null;  
            // RijndaelManaged object used to encrypt the data.  
            
        ///    try{
                //create a key from the password and salt, use 32K iterations 
                // generate the key from the shared secret and the salt
//Rfc2898DeriveBytes takes a password, a salt, and an iteration count, and then generates keys through calls to the GetBytes method.

//RFC 2898 includes methods for creating a key and initialization vector (IV) from a password and salt. You can use PBKDF2,
 //a password-based key derivation function, to derive keys using a pseudo-random function that allows keys of virtually
 //unlimited length to be generated. The Rfc2898DeriveBytes class can be used to produce a derived key from a base key 
 //and other parameters. In a password-based key derivation function, the base key is a password and the other parameters 
 //are a salt value and an iteration count.

//For more information about PBKDF2, see RFC 2898, "PKCS #5: Password-Based Cryptography Specification Version 2.0,
   //" available on the Request for Comments Web site. See section 5.2, "PBKDF2," for complete details.

              ////  Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, enypt);
             //  // Create a RijndaelManaged object
             //   aesAlg = new RijndaelManaged();
             ////   aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
//
           ///     // Create a decryptor to perform the stream transform.
                // Generate decryptor from the existing key bytes and initialization 
                // vector. Key size will be defined based on the number of the key 
                // bytes.
           ///     ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
             // Create the streams used for encryption.
             // Define memory stream which will be used to hold encrypted data.
              /////  using (MemoryStream msEncrypt = new MemoryStream())
           ////    { // prepend the IV
          ////          msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
            //        msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
          /// ///       {
            ///////           using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
            //            {
         ///                   //Write all data to the stream.
            ///                swEncrypt.Write(plainText);
               //         }
//   ///      }
 //   /  //  /            outStr = Convert.ToBase64String(msEncrypt.ToArray());
 //       ///        }
     // / ////     }
        ///    finally
 /////           {
       //         // Clear the RijndaelManaged object.
        ///        if (aesAlg != null)
             ///       aesAlg.Clear();
         ///   }

            // Return the encrypted bytes from the memory stream.
       ///     return outStr;
        ///}

        /// <summary>
        /// Decrypt the given string.  Assumes the string was encrypted using 
        /// EncryptStringAES(), using an identical sharedSecret.
        /// </summary>
        /// <param name="cipherText">The text to decrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for decryption.</param>
      ///  public static string DecryptStringAES(string cipherText, string sharedSecret)
      ///  {
       ////     if (string.IsNullOrEmpty(cipherText))
       ////         throw new ArgumentNullException("cipherText");
        ////    if (string.IsNullOrEmpty(sharedSecret))
          ////      throw new ArgumentNullException("sharedSecret");

            // Declare the RijndaelManaged object
            // used to decrypt the data.
          ////  RijndaelManaged aesAlg = null;

            // Declare the string used to hold
            // the decrypted text.
         ////   string plaintext = null;
////
        ////    try
        ////    {
                // generate the key from the shared secret and the salt
         ////       Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // Create the streams used for decryption.                
          ////      byte[] bytes = Convert.FromBase64String(cipherText);
           ///     using (MemoryStream msDecrypt = new MemoryStream(bytes))
           ///     {
                    // Create a RijndaelManaged object
                    // with the specified key and IV.
              ////      aesAlg = new RijndaelManaged();
               ///     aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                    // Get the initialization vector from the encrypted stream
         ////           aesAlg.IV = ReadByteArray(msDecrypt);
                    // Create a decrytor to perform the stream transform.
      ////              ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
     ///               using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
      ///              {
        /////                using (StreamReader srDecrypt = new StreamReader(csDecrypt))

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
        ////                    plaintext = srDecrypt.ReadToEnd();
    ////                }
      ////          }
   /// ////        }
   ////         finally
    ///        {
                // Clear the RijndaelManaged object.
 /////               if (aesAlg != null)
      ////              aesAlg.Clear();
 ////           }
/////
    /////        return plaintext;
    ///    }

   ////     private static byte[] ReadByteArray(Stream s)
   ////     {
 ////           byte[] rawLength = new byte[sizeof(int)];
  ////          if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
 ////           {
   ///             throw new SystemException("Stream did not contain properly formatted byte array");
/// ////           }
///
////            byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
 /////           if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
 ///           {
  ///              throw new SystemException("Did not read byte array properly");
  //          }
///
   ///         return buffer;
  ///      }
/////    }
  }



