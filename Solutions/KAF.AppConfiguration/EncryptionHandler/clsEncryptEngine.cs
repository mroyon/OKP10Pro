using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace KAF.AppConfiguration.EncryptionHandler
{
    public enum EncryptionAlgorithm
    {
        DES = 0, Rc2, Rijndael, TripleDes
    }
    public class EncryptEngine
    {
        bool bWithKey = false;
        EncryptionAlgorithm AlgoritmID;
        string keyword = "";
        public byte[] Vector;

        /// <summary>   Constructor. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <param name="AlgID">    The Algorithm Identifier to encrypt engine. </param>
        /// <param name="Key">      The key to encrypt engine. </param>

        public EncryptEngine(EncryptionAlgorithm AlgID, string Key)
        {
            if (Key.Length == 0)
                bWithKey = false;
            else
                bWithKey = true;

            keyword = Key;
            AlgoritmID = AlgID;
        }

        /// <summary>   Gets or sets the encryption algorithm. </summary>
        /// <value> The encryption algorithm. </value>

        public EncryptionAlgorithm EncryptionAlgorithm
        {
            get
            {
                return AlgoritmID;
            }
            set
            {
                AlgoritmID = value;
            }
        }

        /// <summary>   Gets crypt transform. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="GetCryptTransform">   GetCryptTransform. </method>
        /// <exception cref="CryptographicException">   Thrown when a Cryptographic error condition
        ///                                             occurs. </exception>
        /// <returns>   The crypt transform. </returns>

        public ICryptoTransform GetCryptTransform()
        {
            byte[] key = Encoding.ASCII.GetBytes(keyword);

            switch (AlgoritmID)
            {
                case EncryptionAlgorithm.DES:
                    DES des = new DESCryptoServiceProvider();
                    des.Mode = CipherMode.CBC;
                    if (bWithKey) des.Key = key;
                    Vector = des.IV;
                    return des.CreateEncryptor();
                case EncryptionAlgorithm.Rc2:
                    RC2 rc = new RC2CryptoServiceProvider();
                    rc.Mode = CipherMode.CBC;
                    if (bWithKey) rc.Key = key;
                    Vector = rc.IV;
                    return rc.CreateEncryptor();
                case EncryptionAlgorithm.Rijndael:
                    Rijndael rj = new RijndaelManaged();
                    rj.Mode = CipherMode.CBC;
                    if (bWithKey) rj.Key = key;
                    Vector = rj.IV;
                    return rj.CreateEncryptor();
                case EncryptionAlgorithm.TripleDes:
                    TripleDES tDes = new TripleDESCryptoServiceProvider();
                    tDes.Mode = CipherMode.CBC;
                    if (bWithKey) tDes.Key = key;
                    Vector = tDes.IV;
                    return tDes.CreateEncryptor();
                default:
                    throw new CryptographicException("Algorithm " + AlgoritmID + " Not Supported!");
            }
        }

        /// <summary>   Validates the key size. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="ValidateKeySize" type="static bool"> ValidateKeySize. </method>
        /// <exception cref="CryptographicException">   Thrown when a Cryptographic error condition
        ///                                             occurs. </exception>
        /// <param name="algID" type="EncryptionAlgorithm">    The Algorithm Identifier to validate key size. </param>
        /// <param name="Lenght" type="int">   The lenght to validate key size. </param>
        /// <returns>   True if it succeeds, false if it fails. </returns>

        public static bool ValidateKeySize(EncryptionAlgorithm algID, int Lenght)
        {
            switch (algID)
            {
                case EncryptionAlgorithm.DES:
                    DES des = new DESCryptoServiceProvider();
                    return des.ValidKeySize(Lenght);
                case EncryptionAlgorithm.Rc2:
                    RC2 rc = new RC2CryptoServiceProvider();
                    return rc.ValidKeySize(Lenght);
                case EncryptionAlgorithm.Rijndael:
                    Rijndael rj = new RijndaelManaged();
                    return rj.ValidKeySize(Lenght);
                case EncryptionAlgorithm.TripleDes:
                    TripleDES tDes = new TripleDESCryptoServiceProvider();
                    return tDes.ValidKeySize(Lenght);
                default:
                    throw new CryptographicException("Algorithm " + algID + " Not Supported!");
            }
        }
    }
}
