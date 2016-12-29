using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Pictograms;
using System.Windows.Forms;

namespace Toolkit
{
    static class Program
    {

        internal static List<string> imageFiles = new List<string>(new string[] { ".bmp", ".jpg", ".jpeg", ".jpe", ".jfif", ".png", ".gif" });
        internal static List<string> paletteFiles = new List<string>(new string[] { ".ase", ".aco" });

        [STAThread]
        static void Main()
        {

#if DEBUG
            ImageHelper.GetEditorIcon(MaterialDesign.GetImage(MaterialDesign.IconType.color_lens, 256, Color.White));
#endif

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FormMain());
        }

    }

}
