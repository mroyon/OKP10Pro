namespace KAF.AppConfiguration
{
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;

    public class TrippleDESCryptoService
    {
        private string _IntialzationVector;
        private string _SecretKey;

        /// <summary>   Constructor. </summary>
        /// <remarks>   2/1/2017. </remarks>
        /// <param name="SecretKey">            The secret key. </param>
        /// <param name="IntialzationVector">   The intialzation vector. </param>

        public TrippleDESCryptoService(string SecretKey, string IntialzationVector)
        {
            this._SecretKey = SecretKey;
            this._IntialzationVector = IntialzationVector;
        }

        /// <summary>   Decrypt data. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="DecryptData" type="string"> DecryptData. </method>
        /// <param name="valueToDecrypt" type="string">   The value to decrypt to decrypt data. </param>
        /// <returns>   A string. </returns>

        public string DecryptData(string valueToDecrypt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(this._SecretKey);
            byte[] buffer = Convert.FromBase64String(valueToDecrypt);
            byte[] rgbIV = Encoding.UTF8.GetBytes(this._IntialzationVector);
            TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
            MemoryStream stream = new MemoryStream();
            ICryptoTransform transform = provider.CreateDecryptor(bytes, rgbIV);
            CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
            stream2.Write(buffer, 0, buffer.Length);
            stream2.FlushFinalBlock();
            byte[] buffer4 = stream.ToArray();
            string str = "";
            foreach (byte num in buffer4)
            {
                str = str + Convert.ToChar(num);
            }
            stream.Close();
            stream2.Close();
            return str;
        }

        /// <summary>   Encrypt data. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="EncryptData" type="string"> EncryptData. </method>
        /// <param name="valueToEncrypt" type="string">   The value to encrypt to encrypt data. </param>
        /// <returns>   A string. </returns>

        public string EncryptData(string valueToEncrypt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(this._SecretKey);
            byte[] buffer = Encoding.UTF8.GetBytes(valueToEncrypt);
            byte[] rgbIV = Encoding.UTF8.GetBytes(this._IntialzationVector);
            TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
            MemoryStream stream = new MemoryStream();
            ICryptoTransform transform = provider.CreateEncryptor(bytes, rgbIV);
            CryptoStream stream2 = null;
            stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
            stream2.Write(buffer, 0, buffer.Length);
            stream2.FlushFinalBlock();
            byte[] inArray = stream.ToArray();
            stream.Close();
            stream2.Close();
            return Convert.ToBase64String(inArray);
        }
    }
}

