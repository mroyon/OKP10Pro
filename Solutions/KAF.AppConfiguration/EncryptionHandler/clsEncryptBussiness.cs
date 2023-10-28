using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;


namespace KAF.AppConfiguration.EncryptionHandler
{
    public class Encryptor
    {
        EncryptEngine engin;
        public byte[] IV;

        /// <summary>   Constructor. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <param name="algID">    The Algorithm Identifier to encryptor. </param>
        /// <param name="key">      The key to encryptor. </param>

        public Encryptor(EncryptionAlgorithm algID, string key)
        {
            engin = new EncryptEngine(algID, key);
        }

        /// <summary>   Gets or sets the encrypt engine. </summary>
        ///
        /// <value> The encrypt engine. </value>

        public EncryptEngine EncryptEngine
        {
            get
            {
                return engin;
            }
            set
            {
                engin = value;
            }
        }

        /// <summary>   Encrypts. </summary>
        /// <remarks>   User, 2/1/2017. </remarks>
        /// <param name="MainString">   The main string. </param>
        /// <returns>   A string. </returns>

        public string Encrypt(string MainString)
        {
            MemoryStream memory = new MemoryStream();
            CryptoStream stream = new CryptoStream(memory, engin.GetCryptTransform(), CryptoStreamMode.Write);
            StreamWriter streamwriter = new StreamWriter(stream);
            streamwriter.WriteLine(MainString);
            streamwriter.Close();
            stream.Close();
            IV = engin.Vector;
            byte[] buffer = memory.ToArray();
            memory.Close();
            return Convert.ToBase64String(buffer);

        }
    }
}
