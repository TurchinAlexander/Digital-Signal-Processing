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
            //Bitmap resultImage = MedianFilter(image, 3 * 3);
            Bitmap resultImage = GaussFilter(image, 5);
            //Bitmap resultImage = SobelFilter(image);

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

        public static Bitmap MedianFilter(Bitmap sourceBitmap, int matrixSize)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            int filterOffset = (matrixSize - 1) / 2;
            int middle = (int)Math.Pow(matrixSize, 2) / 2;

            List<byte> alpha = new List<byte>();
            List<byte> red = new List<byte>();
            List<byte> green = new List<byte>();
            List<byte> blue = new List<byte>();

            for (int offsetY = filterOffset; offsetY < sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX < sourceBitmap.Width - filterOffset; offsetX++)
                {
                    var byteOffset = offsetY * sourceData.Stride + offsetX * 4;

                    alpha.Clear();
                    red.Clear();
                    green.Clear();
                    blue.Clear();

                    for (int filterY = -filterOffset; filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset; filterX <= filterOffset; filterX++)
                        {
                            var calcOffset = byteOffset + (filterX * 4) + (filterY * sourceData.Stride);

                            alpha.Add(pixelBuffer[calcOffset]);
                            red.Add(pixelBuffer[calcOffset + 1]);
                            green.Add(pixelBuffer[calcOffset + 2]);
                            blue.Add(pixelBuffer[calcOffset + 3]);
                        }
                    }

                    alpha.Sort();
                    red.Sort();
                    green.Sort();
                    blue.Sort();

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

        public static Bitmap GaussFilter(Bitmap sourceBitmap, double sigma)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] tempBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            int matrixSize = (int) Math.Ceiling(3 * sigma);

            int filterOffset = matrixSize;
            int calcOffset = 0;

            int byteOffset = 0;

            int matrixOffset = 0;

            double[] gaussMatrix = new double[2 * matrixSize];
            double s2 = 2 * sigma * sigma;

            gaussMatrix[matrixSize] = 1;

            for (int i = 0; i < 2 * matrixSize; i++)
            {
                gaussMatrix[i] = Math.Exp(-i * i / s2);
                //gaussMatrix[i - matrixSize - 1] = gaussMatrix[i];
            }

            //List<int> neighbourPixels = new List<int>();

            byte[] middlePixel;

            //Горизонтальное размытие
            for (int offsetY = filterOffset; offsetY < sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX < sourceBitmap.Width - filterOffset; offsetX++)
                {
                    byteOffset = offsetY * sourceData.Stride + offsetX * 4;

                    //neighbourPixels.Clear();
                    double alpha = 0;
                    double red = 0;
                    double green = 0;
                    double blue = 0;
                    double sum = 0;

                    for (int i = -matrixSize; i < matrixSize; i++)
                    {
                        matrixOffset = matrixSize + i;

                        calcOffset = byteOffset + (i * 4);

                        alpha += pixelBuffer[calcOffset] * gaussMatrix[matrixOffset];
                        red += pixelBuffer[calcOffset + 1] * gaussMatrix[matrixOffset];
                        green += pixelBuffer[calcOffset + 2] * gaussMatrix[matrixOffset];
                        blue += pixelBuffer[calcOffset + 3] * gaussMatrix[matrixOffset];

                        sum += gaussMatrix[matrixOffset];
                    }

                    byte resAlpha = Convert.ToByte(alpha / sum);
                    byte resRed = Convert.ToByte(red / sum);
                    byte resGreen = Convert.ToByte(green / sum);
                    byte resBlue = Convert.ToByte(blue / sum);

                    tempBuffer[byteOffset] = resAlpha;
                    tempBuffer[byteOffset + 1] = resRed;
                    tempBuffer[byteOffset + 2] = resGreen;
                    tempBuffer[byteOffset + 3] = resBlue;
                }
            }

            //Вертикальное размытие
            for (int offsetX = filterOffset; offsetX < sourceBitmap.Width - filterOffset; offsetX++)
            {
                for (int offsetY = filterOffset; offsetY < sourceBitmap.Height - filterOffset; offsetY++)
                {
                    byteOffset = offsetY * sourceData.Stride + offsetX * 4;

                    //neighbourPixels.Clear();
                    double alpha = 0;
                    double red = 0;
                    double green = 0;
                    double blue = 0;
                    double sum = 0;

                    for (int i = -matrixSize; i < matrixSize; i++)
                    {
                        calcOffset = byteOffset + (i * sourceData.Stride);

                        matrixOffset = matrixSize + i;

                        alpha += tempBuffer[calcOffset] * gaussMatrix[matrixOffset];
                        red += tempBuffer[calcOffset + 1] * gaussMatrix[matrixOffset];
                        green += tempBuffer[calcOffset + 2] * gaussMatrix[matrixOffset];
                        blue += tempBuffer[calcOffset + 3] * gaussMatrix[matrixOffset];

                        sum += gaussMatrix[matrixOffset];
                    }
                    

                    byte resAlpha = Convert.ToByte(alpha / sum);
                    byte resRed = Convert.ToByte(red / sum);
                    byte resGreen = Convert.ToByte(green / sum);
                    byte resBlue = Convert.ToByte(blue / sum);

                    resultBuffer[byteOffset] = resAlpha;
                    resultBuffer[byteOffset + 1] = resRed;
                    resultBuffer[byteOffset + 2] = resGreen;
                    resultBuffer[byteOffset + 3] = resBlue;
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);

            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public static Bitmap SobelFilter(Bitmap sourceBitmap)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            int[,] matrix = new int[3, 3]
           {
                {1, 2, 1},
                {0, 0, 0},
                {-1, -2, -1}
           };

            int filterOffset = 1;

            for (int offsetY = filterOffset; offsetY < sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX < sourceBitmap.Width - filterOffset; offsetX++)
                {
                    var byteOffset = offsetY * sourceData.Stride + offsetX * 4;

                    double dxR = 0;
                    double dyR = 0;

                    for (int filterY = -filterOffset; filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset; filterX <= filterOffset; filterX++)
                        {
                            var calcOffset = byteOffset + (filterX * 4) + (filterY * sourceData.Stride);

                            int matrixOffsetX = filterOffset + filterX;
                            int matrixOffsetY = filterOffset + filterY;
                            
                            double r = pixelBuffer[calcOffset] * 0.299;
                            double g = pixelBuffer[calcOffset + 1] * 0.587;
                            double b = pixelBuffer[calcOffset + 2] * 0.114;

                            dxR += matrix[matrixOffsetY, matrixOffsetX] * (r + g + b);
                            dyR += matrix[matrixOffsetX, matrixOffsetY] * (r + g + b);
                        }
                    }
                    byte res = (byte)Math.Sqrt(Math.Pow(dxR, 2) + Math.Pow(dyR, 2));
                    //byte res = (byte) Math.Ceiling(Math.Sqrt(Math.Pow(dxR, 2) + Math.Pow(dyR, 2)));

                    resultBuffer[byteOffset] = res;
                    resultBuffer[byteOffset + 1] = res;
                    resultBuffer[byteOffset + 2] = res;
                    resultBuffer[byteOffset + 3] = 255;

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
