using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorToolkit
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            this.Opacity = 1.0;
        }
        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            this.Opacity = 0.25;
        }

        public Color Color { get; set; }

        private void panelColor_MouseClick(object sender, MouseEventArgs e)
        {
            MouseButtons button = e.Button;
            if (button == MouseButtons.Right)
            {
                if (this.colorDialogPicker.ShowDialog() == DialogResult.OK)
                {
                    this.Color = this.colorDialogPicker.Color;
                    this.setColor();
                }
            }
            else
            {
                if (button == MouseButtons.Left)
                {
                    this.Cursor = Cursors.Cross;
                }
            }
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Cursor = Cursors.Cross;
            }
        }
        private void panelColor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.getScreenColor();
            }
        }
        private void panelColor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void textBoxHEX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.buttonCopyHEX.PerformClick();
            }
            else
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.textBoxHEX.Text = string.Empty;
                }
            }
        }
        private void textBoxHEX_Leave(object sender, EventArgs e)
        {
            this.Color = General.FromHex(this.textBoxHEX.Text, 255);
            this.setColor();
        }

        private void textBoxRGB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.buttonCopyRGB.PerformClick();
            }
            else
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.textBoxR.Value = 0;
                    this.textBoxG.Value = 0;
                    this.textBoxB.Value = 0;
                }
            }
        }
        private void textBoxRGB_Leave(object sender, EventArgs e)
        {
            this.Color = Color.FromArgb(255, int.Parse(this.textBoxR.Value.ToString()), int.Parse(this.textBoxG.Value.ToString()), int.Parse(this.textBoxB.Value.ToString()));
            this.setColor();
        }

        private void textBoxHSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.buttonCopyRGB.PerformClick();
            }
            else
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.textBoxH.Value = 0;
                    this.textBoxS.Value = 0;
                    this.textBoxV.Value = 0;
                }
            }
        }
        private void textBoxHSV_Leave(object sender, EventArgs e)
        {
            int[] _RGB = Colors.HSV_RGB((float)(this.textBoxH.Value), (float)(this.textBoxS.Value), (float)(this.textBoxV.Value));
            this.Color = Color.FromArgb(_RGB[0], _RGB[1], _RGB[2]);
            this.setColor();
        }

        private void buttonCopiarHEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textBoxHEX.Text);
        }
        private void buttonCopiarRGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(String.Join(",", new string[] { this.textBoxR.Value.ToString(), this.textBoxG.Value.ToString(), this.textBoxB.Value.ToString() }));
        }
        private void buttonCopiarHSV_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(String.Join(",", new string[] { this.textBoxH.Value.ToString(), this.textBoxS.Value.ToString(), this.textBoxV.Value.ToString() }));
        }

        private void getScreenColor()
        {
            Bitmap bitmap = new Bitmap(General.GetWorkingArea()[0], General.GetWorkingArea()[1]);
            Point mousePosition = Control.MousePosition;
            checked
            {
                mousePosition.X = (int)Math.Round(unchecked((double)mousePosition.X - (double)bitmap.Width / 2.0));
                mousePosition.Y = (int)Math.Round(unchecked((double)mousePosition.Y - (double)bitmap.Height / 2.0));
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    Graphics arg_A4_0 = graphics;
                    Point arg_A4_1 = mousePosition;
                    Point upperLeftDestination = new Point(0, 0);
                    arg_A4_0.CopyFromScreen(arg_A4_1, upperLeftDestination, bitmap.Size);
                }
                this.Color = bitmap.GetPixel((int)Math.Round((double)bitmap.Size.Width / 2.0), (int)Math.Round((double)bitmap.Size.Height / 2.0));
                this.setColor();
                this.Invalidate();
            }
        }
        private void setColor()
        {
            this.panelColor.BackColor = this.Color;
            this.textBoxHEX.Text = General.ToHex(this.Color);

            this.textBoxR.Value = this.Color.R;
            this.textBoxG.Value = this.Color.G;
            this.textBoxB.Value = this.Color.B;

            //float[] _HSV = Colors.RGB_HSV(this.Color.R, this.Color.G, this.Color.B);

            //this.textBoxH.Value = Convert.ToDecimal(_HSV[0]);
            //this.textBoxS.Value = Convert.ToDecimal(_HSV[1]);
            //this.textBoxV.Value = Convert.ToDecimal(_HSV[2]);
        }

    }
}


public static class General
{

    public static int[] GetWorkingArea()
    {
        int minx, miny, maxx, maxy;
        minx = miny = int.MaxValue;
        maxx = maxy = int.MinValue;

        foreach (Screen screen in Screen.AllScreens)
        {
            var bounds = screen.Bounds;
            minx = Math.Min(minx, bounds.X);
            miny = Math.Min(miny, bounds.Y);
            maxx = Math.Max(maxx, bounds.Right);
            maxy = Math.Max(maxy, bounds.Bottom);
        }

        return new int[] { maxx - minx, maxy - miny };
    }

    public static Color FromHex(string hex, int alpha = 255)
    {
        Color result = default(Color);
        try
        {
            result = ColorTranslator.FromHtml(hex);
        }
        catch //(Exception ex)       
        {
            throw new Exception("Hexadecimal string is not a valid color format");
        }
        return result;
    }

    public static string ToHex(Color source)
    {
        return General.ToHex((int)source.R, (int)source.G, (int)source.B);
    }
    public static string ToHex(int r, int g, int b)
    {
        return "#" + ColorTranslator.FromHtml(string.Format("#{0:X2}{1:X2}{2:X2}", r, g, b)).Name.Remove(0, 2);
    }


}