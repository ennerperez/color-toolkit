﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Platform.Support.Drawing
{

    public static partial class ColorHelpers
    {
        public static Color ToColor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }
        public static string RGB(Color source)
        {
            return string.Join(",", new string[] { source.R.ToString(), source.G.ToString(), source.B.ToString() });
        }
        public static string RGBA(Color source)
        {
            return string.Join(",", new string[] { source.R.ToString(), source.G.ToString(), source.B.ToString(), source.A.ToString() });
        }

    }

    public static partial class ColorExtensions
    {

        public static void FromHex(this Color @this, string hex, int alpha = 255)
        {
            @this = ColorHelpers.ToColor(hex, alpha);
        }

        public static string ToRGB(this Color @this)
        {
            return ColorHelpers.RGB(@this);
        }
        public static string ToRGBA(this Color @this)
        {
            return ColorHelpers.RGBA(@this);
        }

    }
}
