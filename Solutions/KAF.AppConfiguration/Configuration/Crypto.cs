using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;

using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace KAF.AppConfiguration.Configuration
{
    public static class Crypto
    {
        #region Public Methods
        /// <summary>
        /// Generate Random Key
        /// </summary>
        /// <method name="GenerateRandomKey" type="byte[]"></method>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static byte[] GenerateRandomKey()
        {
            using (SymmetricAlgorithm algorithm = new RijndaelManaged())
            {
                algorithm.IV = new byte[algorithm.IV.Length];

                return algorithm.Key;
            }
        }
        /// <summary>
        /// Encrypt byte[] data
        /// </summary>
        /// <method name="Encrypt" type="byte[]"></method>
        /// <param name="key" type="byte[]"></param>
        /// <param name="plainBytes" type="byte[]"></param>
        /// <returns>byte[]</returns>
        /// <remarks>encrypt data</remarks>
        [DebuggerStepThrough()]
        public static byte[] Encrypt(byte[] key,
        byte[] plainBytes)
        {
            using (SymmetricAlgorithm crypto = CreateAlgorithm(key))
            {
                return Read(crypto.CreateEncryptor(), plainBytes);
            }
        }
        /// <summary>
        /// decrypt data
        /// </summary>
        /// <method name="Decrypt" type="byte[]"></method>
        /// <param name="key" type="byte[]"></param>
        /// <param name="cipherBytes" type="byte[]"></param>
        /// <returns>byte[]</returns>
        [DebuggerStepThrough()]
        public static byte[] Decrypt(byte[] key,
        byte[] cipherBytes)
        {
            using (SymmetricAlgorithm crypto = CreateAlgorithm(key))
            {
                return Read(crypto.CreateDecryptor(), cipherBytes);
            }
        }
        /// <summary>
        /// Encrypt <T> type data
        /// </summary>
        /// <method name="Encrypt<T>" type="byte[]"></method>
        /// <typeparam name="T" type= T></typeparam>
        /// <param name="plain"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static byte[] Encrypt<T>(T plain) where T : class
        {
            if (!plain.GetType().IsSerializable)
            {
                throw new SerializationException("Object is not serializable.");
            }

            using (MemoryStream ms = new MemoryStream())
            {
                using (SymmetricAlgorithm crypto = CreateAlgorithm())
                {
                    using (CryptoStream cs = new CryptoStream(ms, crypto.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        (new BinaryFormatter()).Serialize(cs, plain);

                        cs.FlushFinalBlock();

                        using (KeyedHashAlgorithm hash = CreateHashAlgorithm())
                        {
                            hash.Key = crypto.Key;
                            ms.Seek(0, SeekOrigin.Begin);
                            hash.ComputeHash(ms);
                            ms.Write(hash.Hash, 0, hash.Hash.Length);
                        }
                    }
                }

                return ms.ToArray();
            }
        }
        /// <summary>
        /// Decrypt <T> type 
        /// </summary>
        /// <method name="Decrypt<T>" type="T"></method>
        /// <typeparam name="T" type="T"></typeparam>
        /// <param name="cipher" type="byte[]"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static T Decrypt<T>(byte[] cipher) where T : class
        {
            using (SymmetricAlgorithm crypto = CreateAlgorithm())
            {
                using (KeyedHashAlgorithm hash = CreateHashAlgorithm())
                {
                    hash.Key = crypto.Key;

                    int hashSizeInBytes = (hash.HashSize / 8);

                    byte[] data = new byte[cipher.Length - hashSizeInBytes];

                    Buffer.BlockCopy(cipher, 0, data, 0, data.Length);

                    byte[] DAC = new byte[hashSizeInBytes];

                    Buffer.BlockCopy(cipher, data.Length, DAC, 0, DAC.Length);

                    hash.ComputeHash(data, 0, data.Length);

                    if (!CompareByteArray(hash.Hash, DAC))
                    {
                        throw new CryptographicException("Object hash does not match!");
                    }

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, crypto.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(data, 0, data.Length);
                            cs.FlushFinalBlock();
                            ms.Seek(0, SeekOrigin.Begin);

                            return (new BinaryFormatter()).Deserialize(ms) as T;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Create RSA
        /// </summary>
        /// <method name="CreateRSA" type="RSACryptoServiceProvider"></method>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static RSACryptoServiceProvider CreateRSA()
        {
            CspParameters parms = new CspParameters();

            parms.Flags = CspProviderFlags.UseMachineKeyStore;

            return new RSACryptoServiceProvider(parms);
        }
        /// <summary>
        /// CreateRSA
        /// </summary>
        /// <method name="CreateRSA" type="RSACryptoServiceProvider"></method>
        /// <param name="key" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static RSACryptoServiceProvider CreateRSA(string key)
        {
            RSACryptoServiceProvider csp = CreateRSA();

            csp.FromXmlString(key);

            return csp;
        }
        /// <summary>
        /// Sign
        /// </summary>
        /// <method name="Sign" type="void"></method>
        /// <param name="plainData" type="string"></param>
        /// <param name="signedData" type="string"></param>
        /// <param name="publicKey" type="string"></param>
        [DebuggerStepThrough()]
        public static void Sign(string plainData, out string signedData, out string publicKey)
        {
            signedData = publicKey = null;

            using (RSACryptoServiceProvider rsa = CreateRSA())
            {
                signedData = Sign(rsa.ToXmlString(true), plainData);
                publicKey = rsa.ToXmlString(false);
            }
        }
        /// <summary>
        /// Sign
        /// </summary>
        /// <method name="Sign" type="string"></method>
        /// <param name="privateKey" type="string"></param>
        /// <param name="cipherData" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static string Sign(string privateKey,
        string cipherData)
        {
            using (RSACryptoServiceProvider rsa = CreateRSA(privateKey))
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(cipherData);

                SignedXml signDoc = new SignedXml(doc);
                signDoc.SigningKey = rsa;
                signDoc.SignedInfo.CanonicalizationMethod = SignedXml.XmlDsigCanonicalizationUrl;

                Reference reference = new Reference(string.Empty);
                reference.AddTransform(new XmlDsigEnvelopedSignatureTransform(false));
                signDoc.AddReference(reference);
                signDoc.ComputeSignature();

                XmlElement xelSign = signDoc.GetXml();

                doc.DocumentElement.AppendChild(xelSign);

                return doc.OuterXml;
            }
        }
        /// <summary>
        /// IsTampered
        /// </summary>
        /// <method name="IsTampered" type="bool"></method>
        /// <param name="publicKey" type="string"></param>
        /// <param name="signedData" type="string"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static bool IsTampered(string publicKey,
        string signedData)
        {
            using (RSACryptoServiceProvider csp = CreateRSA(publicKey))
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(signedData);

                SignedXml signDoc = new SignedXml(doc);

                XmlElement xelSignature = doc.GetElementsByTagName("Signature", SignedXml.XmlDsigNamespaceUrl)[0] as XmlElement;

                signDoc.LoadXml(xelSignature);

                return !signDoc.CheckSignature(csp);
            }
        }

        #endregion

        #region Helper Methods
        /// <summary>
        /// CreateHashAlgorithm
        /// </summary>
        /// <method name="CreateHashAlgorithm" type="KeyedHashAlgorithm"></method>
        /// <returns></returns>
        [DebuggerStepThrough()]
        private static KeyedHashAlgorithm CreateHashAlgorithm()
        {
            return HMACSHA1.Create();
        }
        /// <summary>
        /// CreateAlgorithm
        /// </summary>
        /// <method name="CreateAlgorithm" type="SymmetricAlgorithm"></method>
        /// <returns></returns>
        [DebuggerStepThrough()]
        private static SymmetricAlgorithm CreateAlgorithm()
        {
            return CreateAlgorithm(new byte[] { 4, 93, 171, 3, 85, 23, 41, 34, 216, 14, 78, 156, 78, 3, 103, 154, 9, 150, 65, 54, 226, 95, 68, 79, 159, 36, 246, 57, 177, 107, 116, 8 });
        }
        /// <summary>
        /// CreateAlgorithm
        /// </summary>
        /// <method name="CreateAlgorithm" type="SymmetricAlgorithm"></method>
        /// <param name="key" type="byte[]"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        private static SymmetricAlgorithm CreateAlgorithm(byte[] key)
        {
            SymmetricAlgorithm algorithm = new RijndaelManaged();

            algorithm.Key = key;
            algorithm.IV = new byte[algorithm.IV.Length];

            return algorithm;
        }
        /// <summary>
        /// CompareByteArray
        /// </summary>
        /// <method name="CompareByteArray" type="bool"></method>
        /// <param name="array1" type="byte[]"></param>
        /// <param name="array2" type="byte[]"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        private static bool CompareByteArray(byte[] array1,
        byte[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }
        /// <summary>
        /// Read
        /// </summary>
        /// <method name="Read" type="byte[]"></method>
        /// <param name="transformer" type="ICryptoTransform"></param>
        /// <param name="data" type="byte[]"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        private static byte[] Read(ICryptoTransform transformer,
        byte[] data)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transformer, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(data, 0, data.Length);
                    cryptoStream.FlushFinalBlock();

                    return memoryStream.ToArray();
                }
            }
        }
        /// <summary>
        /// CreateCsp
        /// </summary>
        /// <method name="CreateCsp" type="RSACryptoServiceProvider"></method>
        /// <returns></returns>
        private static RSACryptoServiceProvider CreateCsp()
        {
            CspParameters parms = new CspParameters(1);

            parms.Flags = CspProviderFlags.UseMachineKeyStore;

            return new RSACryptoServiceProvider(parms);
        }
        /// <summary>
        /// CreateCsp
        /// </summary>
        /// <method name="CreateCsp" type="RSACryptoServiceProvider"></method>
        /// <param name="key" type="string"></param>
        /// <returns></returns>
        private static RSACryptoServiceProvider CreateCsp(string key)
        {
            RSACryptoServiceProvider csp = CreateCsp();

            csp.FromXmlString(key);

            return csp;
        }

        #endregion
    }
}
