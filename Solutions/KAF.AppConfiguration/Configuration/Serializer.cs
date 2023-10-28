using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;


namespace KAF.AppConfiguration.Configuration
{
    public static class Serializer
    {
        /// <summary>
        /// Serialize<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream"></param>
        /// <param name="target"></param>
        [DebuggerStepThrough()]
        public static void Serialize<T>(Stream stream, T target) where T : class
        {
            byte[] cipherBytes = Crypto.Encrypt<T>(target);
            stream.Write(cipherBytes, 0, cipherBytes.Length);
        }
        /// <summary>
        /// Serialize<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="file"></param>
        /// <param name="target"></param>
        [DebuggerStepThrough()]
        public static void Serialize<T>(string file, T target) where T : class
        {
            using (FileStream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                Serialize<T>(stream, target);
            }
        }
        /// <summary>
        /// Deserialize<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static T Deserialize<T>(Stream stream) where T : class
        {
            byte[] cipherBytes = new byte[stream.Length];
            stream.Read(cipherBytes, 0, cipherBytes.Length);

            return Crypto.Decrypt<T>(cipherBytes) as T;
        }
        /// <summary>
        ///  Deserialize<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="file"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static T Deserialize<T>(string file) where T : class
        {
            if (File.Exists(file))
            {
                using (FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    return Deserialize<T>(stream) as T;
                }
            }

            return null;
        }
        /// <summary>
        /// ToBytes<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static byte[] ToBytes<T>(T target) where T : class
        {
            using (MemoryStream ms = new MemoryStream())
            {
                (new BinaryFormatter()).Serialize(ms, target);

                ms.Seek(0, SeekOrigin.Begin);

                return ms.ToArray();
            }
        }
        /// <summary>
        /// FromBytes<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        public static T FromBytes<T>(byte[] array) where T : class
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(array, 0, array.Length);
                ms.Seek(0, SeekOrigin.Begin);

                return (new BinaryFormatter()).Deserialize(ms) as T;
            }
        }
        /// <summary>
        /// ToXml<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string ToXml<T>(T target) where T : class
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (TextWriter tw = new StreamWriter(ms))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(ms, target);
                    ms.Seek(0, SeekOrigin.Begin);

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(ms);

                    return xmlDoc.OuterXml;

                }
            }
        }
        /// <summary>
        /// ToXmlFile<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target"></param>
        /// <param name="filePath"></param>
        public static void ToXmlFile<T>(T target, string filePath) where T : class
        {
            using (TextWriter tw = new StreamWriter(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(tw, target);
            }
        }
        /// <summary>
        /// FromXml<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T FromXml<T>(string xml) where T : class
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (TextWriter tw = new StreamWriter(ms))
                {
                    tw.Write(xml);
                }

                ms.Seek(0, SeekOrigin.Begin);

                XmlSerializer serializer = new XmlSerializer(typeof(T));

                return serializer.Deserialize(ms) as T;
            }
        }
    }
}
