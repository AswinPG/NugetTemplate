using Android.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(Plugin.ImageResizer.ImageResizer))]
namespace Plugin.ImageResizer
{
    /// <summary>
    /// Interface for Feature1
    /// </summary>
    public class ImageResizer : IImageResizer
    {
        public byte[] Resize(float toHeight, float toWidth, byte[] Image)
        {
            Bitmap originalImage = BitmapFactory.DecodeByteArray(Image, 0, Image.Length);
            Bitmap resizedImage = Bitmap.CreateScaledBitmap(originalImage, (int)toWidth, (int)toHeight, false);

            using (MemoryStream ms = new MemoryStream())
            {
                resizedImage.Compress(Bitmap.CompressFormat.Jpeg, 100, ms);
                return ms.ToArray();
            }
        }



        public byte[] ResizeHeight(float toHeight, byte[] Image)
        {
            Bitmap originalImage = BitmapFactory.DecodeByteArray(Image, 0, Image.Length);
            float toWidth = (Convert.ToSingle(originalImage.Width) / Convert.ToSingle(originalImage.Height)) * toHeight;
            Bitmap resizedImage = Bitmap.CreateScaledBitmap(originalImage, (int)toWidth, (int)toHeight, false);

            using (MemoryStream ms = new MemoryStream())
            {
                resizedImage.Compress(Bitmap.CompressFormat.Jpeg, 100, ms);
                return ms.ToArray();
            }
        }

        public byte[] ResizeWidth(float toWidth, byte[] Image)
        {
            Bitmap originalImage = BitmapFactory.DecodeByteArray(Image, 0, Image.Length);
            float toHeight = (Convert.ToSingle(originalImage.Height) / Convert.ToSingle(originalImage.Width)) * toWidth;
            Bitmap resizedImage = Bitmap.CreateScaledBitmap(originalImage, (int)toWidth, (int)toHeight, false);

            using (MemoryStream ms = new MemoryStream())
            {
                resizedImage.Compress(Bitmap.CompressFormat.Jpeg, 100, ms);
                return ms.ToArray();
            }
        }
    }
}
