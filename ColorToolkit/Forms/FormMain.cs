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
            if (!this.textBoxHEX.Text.StartsWith("#")) { this.textBoxHEX.Text = "#" + this.textBoxHEX.Text.Trim(); }
            this.Color = ExtensionMethods.FromHEX(this.textBoxHEX.Text);
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
                    this.textBoxL.Value = 0;
                }
            }
        }
        private void textBoxHSV_Leave(object sender, EventArgs e)
        {
            //long[] _RGB = Colors.HSL_RGB((long)(this.textBoxH.Value), (long)(this.textBoxS.Value), (long)(this.textBoxL.Value));
            //this.Color = Color.FromArgb((int)_RGB[0], (int)_RGB[1], (int)_RGB[2]);

            HSLColor _HSL = new HSLColor((double)(this.textBoxH.Value), (double)(this.textBoxS.Value), (double)(this.textBoxL.Value));
            this.Color = _HSL;
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
        private void buttonCopiarHSL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(String.Join(",", new string[] { this.textBoxH.Value.ToString(), this.textBoxS.Value.ToString(), this.textBoxL.Value.ToString() }));
        }

        private void getScreenColor()
        {
            Bitmap bitmap = new Bitmap(Program.GetWorkingArea().Width, Program.GetWorkingArea().Height);
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
            this.textBoxHEX.Text = ExtensionMethods.ToHEX(this.Color);

            this.textBoxR.Value = this.Color.R;
            this.textBoxG.Value = this.Color.G;
            this.textBoxB.Value = this.Color.B;

            HSLColor _HSL = new HSLColor(this.Color);

           // long[] _HSL = Colors.RGB_HSL(this.Color.R, this.Color.G, this.Color.B);

            this.textBoxH.Value = (int)_HSL.Hue;
            this.textBoxS.Value = (int)_HSL.Saturation;
            this.textBoxL.Value = (int)_HSL.Luminosity;
        }

        private void buttonSwatches_Click(object sender, EventArgs e)
        {
            FormSwatches _FormSwatches = new FormSwatches(this.Color);
            _FormSwatches.Show();
        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            this.openFileDialogPicture.ShowDialog();
        }

        private void openFileDialogPicture_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                Bitmap bmp = (Bitmap)Image.FromFile(this.openFileDialogPicture.FileName);
                this.Color = ExtensionMethods.GetDominantColor(bmp);
                this.setColor();
            }
            catch 
            {
            }
        }

    }
}
