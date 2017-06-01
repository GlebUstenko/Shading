using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Helpers
{
    public static class BitmapHelper
    {
        struct Pixel : IEquatable<Pixel>
        {
            
// ReSharper disable UnassignedField.Compiler
            public byte Blue;
            public byte Green;
            public byte Red;

            public bool Equals(Pixel other)
            {
                return Red == other.Red && Green == other.Green && Blue == other.Blue;
            }
        }

        public static Color[,] GetPixels(Bitmap two)
        {
            return ProcessBitmap(two, pixel => Color.FromArgb(pixel.Red, pixel.Green, pixel.Blue));
        }

        public static float[,] GetBrightness(Bitmap two)
        {
            return ProcessBitmap(two, pixel => Color.FromArgb(pixel.Red, pixel.Green, pixel.Blue).GetBrightness());
        }

        private static unsafe T[,] ProcessBitmap<T>(Bitmap bitmap, Func<Pixel, T> func)
        {
            var lockBits = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly,
                                       bitmap.PixelFormat);
            int padding = lockBits.Stride - (bitmap.Width*sizeof (Pixel));

            int width = bitmap.Width;
            int height = bitmap.Height;

            var result = new T[height, width];

            var ptr = (byte*) lockBits.Scan0;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    var pixel = (Pixel*) ptr;
                    result[i, j] = func(*pixel);
                    ptr += sizeof (Pixel);
                }
                ptr += padding;
            }

            bitmap.UnlockBits(lockBits);

            return result;
        }
    }
}
