using System;
using System.Collections.Generic;
using System.Text;

namespace ColorToolkit
{
    public static class Colors
    {

        public static float[] RGB_HSL(int R, int G, int B)
        {
            float var_R = (R / 255);                     //RGB from 0 to 255
            float var_G = (G / 255);
            float var_B = (B / 255);

            float var_Min = (var_R > var_G ? (var_G > var_B) ? var_B : var_G : var_R);    //Min. value of RGB
            float var_Max = (var_R < var_G ? (var_G < var_B) ? var_B : var_G : var_R);   //Max. value of RGB
            float del_Max = var_Max - var_Min;            //Delta RGB value

            float H = 0;
            float S = 0;
            float L = (var_Max + var_Min) / 2;

            if (del_Max == 0)                     //This is a gray, no chroma...
            {
                H = 0;                        //HSL results from 0 to 1
                S = 0;
            }
            else                                    //Chromatic data...
            {
                if (L < (0.5)) S = del_Max / (var_Max + var_Min);
                else S = del_Max / (2 - var_Max - var_Min);

                float del_R = (((var_Max - var_R) / 6) + (del_Max / 2)) / del_Max;
                float del_G = (((var_Max - var_G) / 6) + (del_Max / 2)) / del_Max;
                float del_B = (((var_Max - var_B) / 6) + (del_Max / 2)) / del_Max;

                if (var_R == var_Max) H = del_B - del_G;
                else if (var_G == var_Max) H = (1 / 3) + del_R - del_B;
                else if (var_B == var_Max) H = (2 / 3) + del_G - del_R;

                if (H < 0) H += 1;
                if (H > 1) H -= 1;
            }

            return new float[] { H, S, L };

        }
        public static int[] HSL_RGB(float H, float S, float L)
        {

            int R = 0;
            int G = 0;
            int B = 0;

            if (S == 0)                       //HSL from 0 to 1
            {
                R = Convert.ToInt16(L * 255);                     //RGB results from 0 to 255
                G = Convert.ToInt16(L * 255);
                B = Convert.ToInt16(L * 255);
            }
            else
            {
                float var_1 = 0;
                float var_2 = 0;

                if (L < (0.5))
                {
                    var_2 = L * (1 + S);
                }
                else
                {
                    var_2 = (L + S) - (S * L);
                }

                var_1 = 2 * L - var_2;

                R = Convert.ToInt16(255 * HUE_RGB(var_1, var_2, H + (1 / 3)));
                G = Convert.ToInt16(255 * HUE_RGB(var_1, var_2, H));
                B = Convert.ToInt16(255 * HUE_RGB(var_1, var_2, H - (1 / 3)));
            }
            return new int[] { R, G, B };

        }
        private static float HUE_RGB(float v1, float v2, float vH)
        {
            if (vH < 0) vH += 1;
            if (vH > 1) vH -= 1;
            if ((6 * vH) < 1) return (v1 + (v2 - v1) * 6 * vH);
            if ((2 * vH) < 1) return (v2);
            if ((3 * vH) < 2) return (v1 + (v2 - v1) * ((2 / 3) - vH) * 6);
            return (v1);
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

    }
}
