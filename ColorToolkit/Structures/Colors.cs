using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;

namespace ColorToolkit
{
    public static class Colors
    {

        public static long[] RGB_HSL(int R, int G, int B)
        {
            long lMin;
            long lMax;
            long lDelta;
            float nTemp;
            
            lMax = (R > G ? (R > B ? R : B) : (G > B? G : B));
            lMin = (R < G ? (R < B ? R : B) : (G < B? G : B));

            long L = (lMax * 100) / 255;
            long S = 0;
            long H = 0;

            if (lMax > 0)
            {
                lDelta = lMax - lMin;
                S = (lDelta / lMax) * 100;
                if (lDelta > 0)
                {
                    if (lMax == R)
                    {
                        nTemp = (G - B) / lDelta;
                    }
                    else if (lMax == G)
                    {
                        nTemp = 2 + (B - R) / lDelta;
                    }
                    else
                    {
                        nTemp = 4 + (R - G) / lDelta;
                    }
                    H = (long)nTemp * 60;
                    if (H < 0)
                    {
                        H = H + 360;
                    }
                }
            }

            return new long[] { H, S, L };

        }
        public static long[] HSL_RGB(long H, long S, long L)
        {

            long R = 0;
            long G = 0;
            long B = 0;

            float nH;
            float nS;
            float nL;
            float nF;
            float nP;
            float nQ;
            float nT;
            long lH;

            if (S > 0)
            {

                nH = H / 60;
                nL = L / 100;
                nS = S / 100;

                lH = (int)nH;
                nF = nH - lH;
                nP = nL * (1 - nS);
                nQ = nL * (1 - nS * nF);
                nT = nL * (1 - nS * (1 - nF));
                switch (lH)
                {
                    case 0:
                        R = (long)(nL * 255);
                        G = (long)(nT * 255);
                        B = (long)(nP * 255);
                        break;             
                    case 1:
                        R = (long)(nQ * 255);
                        G = (long)(nL * 255);
                        B = (long)(nP * 255);
                        break;
                    case 2:
                        R = (long)(nP * 255);
                        G = (long)(nL * 255);
                        B = (long)(nT * 255);
                        break;
                    case 3:
                        R = (long)(nP * 255);
                        G = (long)(nQ * 255);
                        B = (long)(nL * 255);
                        break;
                    case 4:
                        R = (long)(nT * 255);
                        G = (long)(nP * 255);
                        B = (long)(nL * 255);
                        break;
                    case 5:
                        R = (long)(nL * 255);
                        G = (long)(nP * 255);
                        B = (long)(nQ * 255);
                        break;
                }
            }
            else
            {
                R = (L * 255) / 100;
                G = R;
                B = R;
            }

            return new long[] { R, G, B };

        }
        

        public static float[] RGB_HSV(int R, int G, int B)
        {

            float H = 0;
            float S = 0;
            float V = 0;

            float var_R = ((float)R / 255);                     //RGB from 0 to 255
            float var_G = ((float)G / 255);
            float var_B = ((float)B / 255);

            float var_Min = (var_R > var_G ? (var_G > var_B) ? var_B : var_G : var_R); //Min. value of RGB
            float var_Max = (var_R < var_G ? (var_G < var_B) ? var_B : var_G : var_R); //Max. value of RGB
            float del_Max = var_Max - var_Min;            //Delta RGB value 

            V = var_Max;

            if (del_Max == 0)                     //This is a gray, no chroma...
            {
                H = 0;                                //HSV results from 0 to 1
                S = 0;
            }
            else                                    //Chromatic data...
            {
                S = del_Max / var_Max;

                float del_R = (((var_Max - var_R) / 6) + (del_Max / 2)) / del_Max;
                float del_G = (((var_Max - var_G) / 6) + (del_Max / 2)) / del_Max;
                float del_B = (((var_Max - var_B) / 6) + (del_Max / 2)) / del_Max;

                if (var_R == var_Max) H = del_B - del_G;
                else if (var_G == var_Max) H = (1 / 3) + del_R - del_B;
                else if (var_B == var_Max) H = (2 / 3) + del_G - del_R;

                if (H < 0) H += 1;
                if (H > 1) H -= 1;
            }

            return new float[] { H, S, V };

        }
        public static int[] HSV_RGB(float H, float S, float V)
        {

            int R = 0;
            int G = 0;
            int B = 0;

            int var_i = 0;
            int var_1 = 0;
            int var_2 = 0;
            int var_3 = 0;

            int var_r = 0;
            int var_g = 0;
            int var_b = 0;

            if (S == 0)                       //HSV from 0 to 1
            {
                R = Convert.ToInt16(V * 255);
                G = Convert.ToInt16(V * 255);
                B = Convert.ToInt16(V * 255);
            }
            else
            {
                float var_h = H * 6;
                if (var_h == 6) var_h = 0;      //H must be < 1
                var_i = Convert.ToInt16(var_h);             //Or ... var_i = floor( var_h )
                var_1 = Convert.ToInt16(V * (1 - S));
                var_2 = Convert.ToInt16(V * (1 - S * (var_h - var_i)));
                var_3 = Convert.ToInt16(V * (1 - S * (1 - (var_h - var_i))));

                if (var_i == 0) { var_r = Convert.ToInt16(V); var_g = var_3; var_b = var_1; }
                else if (var_i == 1) { var_r = var_2; var_g = Convert.ToInt16(V); var_b = var_1; }
                else if (var_i == 2) { var_r = var_1; var_g = Convert.ToInt16(V); var_b = var_3; }
                else if (var_i == 3) { var_r = var_1; var_g = var_2; var_b = Convert.ToInt16(V); }
                else if (var_i == 4) { var_r = var_3; var_g = var_1; var_b = Convert.ToInt16(V); }
                else { var_r = Convert.ToInt16(V); var_g = var_1; var_b = var_2; }

                R = var_r * 255;                 //RGB results from 0 to 255
                G = var_g * 255;
                B = var_b * 255;
            }

            return new int[] { R, G, B };

        }
        
        public static int[] RGB_CMY(int R, int G, int B)
        {
            return new int[] { 1 - (R / 255), 1 - (G / 255), 1 - (B / 255) };
        }
        public static int[] CMY_RGB(int C, int M, int Y)
        {
            return new int[] { (1 - C) * 255, (1 - M) * 255, (1 - Y) * 255 };
        }

        public static int[] CMY_CMYK(int C, int M, int Y)
        {
            int var_K = 1;

            if (C < var_K) var_K = C;
            if (M < var_K) var_K = M;
            if (Y < var_K) var_K = Y;
            if (var_K == 1)
            { //Black
                C = 0;
                M = 0;
                Y = 0;
            }
            else
            {
                C = (C - var_K) / (1 - var_K);
                M = (M - var_K) / (1 - var_K);
                Y = (Y - var_K) / (1 - var_K);
            }
            int K = var_K;

            return new int[] { C, Y, M, K };

        }
        public static int[] CMYK_CMY(int C, int M, int Y, int K)
        {
            return new int[] { (C * (1 - K) + K), (M * (1 - K) + K), (Y * (1 - K) + K) };
        }

               
        public static string RGB_HEX(int r, int g, int b)
        {
            return "#" + ColorTranslator.FromHtml(string.Format("#{0:X2}{1:X2}{2:X2}", r, g, b)).Name.Remove(0, 2);
        }
        public static int[] HEX_RGB(string hex, int alpha = 255)
        {
            Color result = default(Color);
            if (!hex.StartsWith("#")) { hex = "#" + hex; }
            try
            {
                result = ColorTranslator.FromHtml(hex);
            }
            catch //(Exception ex)       
            {
                throw new Exception("Hexadecimal string is not a valid color format");
            }
            return new int[] {result.R, result.G, result.B};
        }



    }

    public static class ExtensionMethods
    {

        public static string ToHEX(System.Drawing.Color source)
        {
            return Colors.RGB_HEX((int)source.R, (int)source.G, (int)source.B);
        }

        public static System.Drawing.Color FromHEX(string hex)
        {
            int[] rgb = Colors.HEX_RGB(hex);
            return System.Drawing.Color.FromArgb(rgb[0], rgb[1], rgb[2]);
        }

        /// <summary>
        /// Creates color with corrected brightness.
        /// </summary>
        /// <param name="color">Color to correct.</param>
        /// <param name="correctionFactor">The brightness correction factor. Must be between -1 and 1. 
        /// Negative values produce darker colors.</param>
        /// <returns>
        /// Corrected <see cref="Color"/> structure.
        /// </returns>
        public static Color ChangeColorBrightness(Color color, float correctionFactor)
        {
            float red = (float)color.R;
            float green = (float)color.G;
            float blue = (float)color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }

        public static Color LightenBy(Color color, int percent)
        {
            return ChangeColorBrightness( color, (float)(percent / 100.0));
        }

        public static Color DarkenBy(Color color, int percent)
        {
            return ChangeColorBrightness(color,  (float)(-1 * percent / 100.0));
        }

        public static Color GetDominantColor(Image bmp)
        {
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int i = 0;
            checked
            {
                while (i < bmp.Width)
                {
                    int j = 0;
                    while (j < bmp.Height)
                    {
                        Color pixel = new Bitmap(bmp).GetPixel(i, j);
                        num += (int)pixel.R;
                        num2 += (int)pixel.G;
                        num3 += (int)pixel.B;
                        Math.Max(Interlocked.Increment(ref num4), num4 - 1);
                        Math.Max(Interlocked.Increment(ref j), j - 1);
                    }
                    Math.Max(Interlocked.Increment(ref i), i - 1);
                }
                num = (int)Math.Round((double)num / (double)num4);
                num2 = (int)Math.Round((double)num2 / (double)num4);
                num3 = (int)Math.Round((double)num3 / (double)num4);
                return Color.FromArgb(num, num2, num3);
            }
        }


    }

}
