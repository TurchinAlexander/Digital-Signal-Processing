using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace ImageFiltering
{
    class Program
    {
        static void Main(string[] args)
        {
            string targetFile = ConfigurationManager.AppSettings.Get("Target");
            string destinationFile = ConfigurationManager.AppSettings.Get("Destination");

            Bitmap image = Load(targetFile);
            Bitmap resultImage = MedianFilter(image, 9);

            resultImage.Save(destinationFile);
        }

        public static Bitmap Load(string fileName)
        {

            using (Stream BitmapStream = System.IO.File.Open(fileName, System.IO.FileMode.Open))
            {
                Image img = Image.FromStream(BitmapStream);

                return new Bitmap(img);
            }
        }

        public static Bitmap MedianFilter(Bitmap sourceBitmap, int matrixSize, int bias = 0,
            bool grayscale = false)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            if (grayscale == true)
            {
                float rgb = 0;

                for (int k = 0; k < pixelBuffer.Length; k += 4)
                {
                    rgb = pixelBuffer[k] * 0.11f;
                    rgb += pixelBuffer[k + 1] * 0.59f;
                    rgb += pixelBuffer[k + 2] * 0.3f;

                    pixelBuffer[k] = (byte) rgb;
                    pixelBuffer[k + 1] = pixelBuffer[k];
                    pixelBuffer[k + 2] = pixelBuffer[k];
                    pixelBuffer[k + 3] = 255;
                }
            }

            int filterOffset = (matrixSize - 1) / 2;
            int middle = (int)Math.Pow(matrixSize, 2) / 2;
            int calcOffset = 0;

            int byteOffset = 0;

            //List<int> neighbourPixels = new List<int>();
            List<byte> alpha = new List<byte>();
            List<byte> red = new List<byte>();
            List<byte> green = new List<byte>();
            List<byte> blue = new List<byte>();

            byte[] middlePixel;

            for (int offsetY = filterOffset; offsetY < sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX < sourceBitmap.Width - filterOffset; offsetX++)
                {
                    byteOffset = offsetY * sourceData.Stride + offsetX * 4;

                    //neighbourPixels.Clear();
                    alpha.Clear();
                    red.Clear();
                    green.Clear();
                    blue.Clear();

                    for (int filterY = -filterOffset; filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset; filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset + (filterX * 4) + (filterY * sourceData.Stride);

                            //neighbourPixels.Add(BitConverter.ToInt32(pixelBuffer, calcOffset));
                            alpha.Add(pixelBuffer[calcOffset]);
                            red.Add(pixelBuffer[calcOffset + 1]);
                            green.Add(pixelBuffer[calcOffset + 2]);
                            blue.Add(pixelBuffer[calcOffset + 3]);
                        }
                    }

                    //neighbourPixels.Sort();
                    alpha.Sort();
                    red.Sort();
                    green.Sort();
                    blue.Sort();

                    //middlePixel = BitConverter.GetBytes(neighbourPixels[filterOffset]);

                    //resultBuffer[byteOffset] = middlePixel[0];
                    //resultBuffer[byteOffset + 1] = middlePixel[1];
                    //resultBuffer[byteOffset + 2] = middlePixel[2];
                    //resultBuffer[byteOffset + 3] = middlePixel[3];

                    resultBuffer[byteOffset] = alpha[middle];
                    resultBuffer[byteOffset + 1] = red[middle];
                    resultBuffer[byteOffset + 2] = green[middle];
                    resultBuffer[byteOffset + 3] = blue[middle];
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);

            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }
    }
}
