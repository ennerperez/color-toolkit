using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace System
{
    namespace Drawing
    {

        public static class Colors
        {
            public static string ToHEX(System.Drawing.Color source)
            {
                //return Colors.RGB_HEX((int)source.R, (int)source.G, (int)source.B);
                return ColorTranslator.ToHtml(source);
            }
            public static Color FromHEX(string hex)
            {
                return ColorTranslator.FromHtml(hex);
            }

            public static string ToRGB(System.Drawing.Color source)
            {
                return string.Join(",", new string[] { source.R.ToString(), source.G.ToString(), source.B.ToString()} );
            }
            public static string ToRGBA(System.Drawing.Color source)
            {
                return string.Join(",", new string[] { source.R.ToString(), source.G.ToString(), source.B.ToString(), source.A.ToString() });
            }

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
                return ChangeColorBrightness(color, (float)(percent / 100.0));
            }
            public static Color DarkenBy(Color color, int percent)
            {
                return ChangeColorBrightness(color, (float)(-1 * percent / 100.0));
            }

            public static Color GetDominantColor(Image image)
            {
                //Used for tally
                int r = 0;
                int g = 0;
                int b = 0;

                int total = 0;

                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        Color clr = (image as Bitmap).GetPixel(x, y);

                        r += clr.R;
                        g += clr.G;
                        b += clr.B;

                        total++;
                    }
                }

                //Calculate average
                r /= total;
                g /= total;
                b /= total;

                return Color.FromArgb(r, g, b);
            }

            public static List<Color> GetPalette(Image image)
            {

                List<Color> colors;
                using (var b = new Bitmap(image))
                {
                    var bd = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                    byte[] arr = new byte[bd.Width * bd.Height * 3];
                    colors = new List<Color>();
                    Marshal.Copy(bd.Scan0, arr, 0, arr.Length);
                    b.UnlockBits(bd);

                    for (int i = 0; i < ((bd.Width * bd.Height)); i++)
                    {
                        var start = i * 3;
                        colors.Add(Color.FromArgb(arr[start], arr[start + 1], arr[start + 2]));
                    }
                }
                
                return colors;

            }
                        
        }

    }
}
