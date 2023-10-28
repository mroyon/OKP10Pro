using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace KAF.AppConfiguration.Configuration
{
    public class clsConversion
    {
        /// <summary>
        /// image to byte array
        /// </summary>
        /// <method name="imageToByteArray" type="byte[]"></method>
        /// <param name="imageIn" type="System.Drawing.Image"></param>
        /// <returns>byte[]</returns>
        /// <remarks>convert image to byte array</remarks>
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();

        }


    }
}
