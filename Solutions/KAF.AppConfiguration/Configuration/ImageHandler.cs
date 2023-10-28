using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
namespace KAF.AppConfiguration.Configuration
{
    public class ImageHandler
    {
        /// <summary>
        /// ImageHandler
        /// </summary>
        public ImageHandler()
        {

        }
        /// <summary>
        /// Str To Byte Array
        /// </summary>
        /// <param name="str" type="string"></param>
        /// <returns></returns>
        public byte[] StrToByteArray(string str)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            return encoding.GetBytes(str);
        }
        /// <summary>
        /// Byte Array To Sring
        /// </summary>
        /// <method name="ByteArrayToSring" type="string"></method>
        /// <param name="bt" type="byte[]"></param>
        /// <returns></returns>
        public string ByteArrayToSring(Byte[] bt)
        {
            string str;
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            str = enc.GetString(bt);
            return str;
        }
        /// <summary>
        /// Resize Image
        /// </summary>
        /// <method name="ResizeImage" type="Image"></method>
        /// <param name="img" type="Image"></param>
        /// <param name="NewWidth" type="int"></param>
        /// <param name="NewHeight" type="int"></param>
        /// <returns></returns>
        public Image ResizeImage(Image img, int NewWidth, int NewHeight)
        {
            return resizeImage(img, NewWidth, NewHeight);
        }
        /// <summary>
        /// resize Image
        /// </summary>
        /// <method name="resizeImage" type="Image"></method>
        /// <param name="imgToResize" type="Image"></param>
        /// <param name="NewWidth" type="int"></param>
        /// <param name="NewHeight" type="int"></param>
        /// <returns></returns>
        private Image resizeImage(Image imgToResize, int NewWidth, int NewHeight)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)NewWidth / (float)sourceWidth);
            nPercentH = ((float)NewHeight / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }
        /// <summary>
        /// Crop Image
        /// </summary>
        /// <method name="CropImage" type="Image"></method>
        /// <param name="img" type="Image"></param>
        /// <param name="cropX" type="int"></param>
        /// <param name="cropY" type="int"></param>
        /// <param name="cropHeight" type="int"></param>
        /// <param name="cropWidth" type="int"></param>
        /// <returns></returns>
        public Image CropImage(Image img, int cropX, int cropY, int cropHeight, int cropWidth)
        {
            return this.cropImage(img, new Rectangle(cropX, cropY, cropWidth, cropHeight));
        }
        /// <summary>
        /// crop Image
        /// </summary>
        /// <method name="cropImage" type="Image"></method>
        /// <param name="img" type="Image"></param>
        /// <param name="cropArea" type="Rectangle"></param>
        /// <returns></returns>
        private Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,
                                            bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }
        /// <summary>
        /// Convert Image To Byte Array
        /// </summary>
        /// <method name="ConvertImageToByteArray" type="byte[]"></method>
        /// <param name="imageToConvert" type="Image"></param>
        /// <param name="formatOfImage" type="ImageFormat"></param>
        /// <returns></returns>
        private static byte[] ConvertImageToByteArray(System.Drawing.Image imageToConvert, ImageFormat formatOfImage)
        {
            byte[] Ret;

            try
            {

                using (MemoryStream ms = new MemoryStream())
                {
                    imageToConvert.Save(ms, formatOfImage);
                    Ret = ms.ToArray();
                }
            }
            catch (Exception) { throw; }

            return Ret;
        }
        /// <summary>
        /// Convert Byte Array To Image
        /// </summary>
        /// <method name="ConvertByteArrayToImage" type="Image"></method>
        /// <param name="imageByteArray" type="byte[]"></param>
        /// <param name="formatOfImage" type="ImageFormat"></param>
        /// <returns></returns>
        private static Image ConvertByteArrayToImage(byte[] imageByteArray, ImageFormat formatOfImage)
        {
            System.Drawing.Image newImage;


            try
            {
                using (MemoryStream ms = new MemoryStream(imageByteArray, 0, imageByteArray.Length))
                {

                    ms.Write(imageByteArray, 0, imageByteArray.Length);

                    newImage = Image.FromStream(ms, true);

                    // work with image here. 

                    // You'll need to keep the MemoryStream open for 
                    // as long as you want to work with your new image. 

                }
            }
            catch (Exception) { throw; }

            return newImage;
        }

    }
}
