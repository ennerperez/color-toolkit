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
#if DEBUG
            this.Color = Colors.FromHEX("#F44336");
            setColor();
#endif
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            this.Opacity = 1.0;
        }
        protected override void OnDeactivate(EventArgs e)
        {
            try
            {
                this.Opacity = 0.25;
            }
            catch (Exception)
            {
            }
            
            base.OnDeactivate(e);
        }

        public Color Color { get; set; }

        private void panelColor_MouseClick(object sender, MouseEventArgs e)
        {
            MouseButtons button = e.Button;
            if (button == MouseButtons.Left)
            {
                this.Cursor = Cursors.Cross;
            }
        }
        private void panelColor_DoubleClick(object sender, EventArgs e)
        {
            this.colorDialogPicker.Color = this.Color;
            if (this.colorDialogPicker.ShowDialog() == DialogResult.OK)
            {
                this.Color = this.colorDialogPicker.Color;
                this.setColor();
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

            if (!System.Text.RegularExpressions.Regex.IsMatch("#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})", this.textBoxHEX.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                this.Color = Colors.FromHEX(this.textBoxHEX.Text);
                this.setColor();
            }
            else
            {
                this.textBoxHEX.Text = Colors.ToHEX(System.Drawing.Color.FromArgb((int)this.textBoxR.Value, (int)this.textBoxG.Value, (int)this.textBoxB.Value));
            }

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

        private void buttonCopiarHEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textBoxHEX.Text);
        }
        private void buttonCopiarRGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(String.Join(",", new string[] { this.textBoxR.Value.ToString(), this.textBoxG.Value.ToString(), this.textBoxB.Value.ToString() }));
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
            this.textBoxHEX.Text = Colors.ToHEX(this.Color);

            this.textBoxR.Value = this.Color.R;
            this.textBoxG.Value = this.Color.G;
            this.textBoxB.Value = this.Color.B;
        }

        private void buttonQSwatch_Click(object sender, EventArgs e)
        {
            FormQSwatch _FormQSwatch = new FormQSwatch(this.Color);
            _FormQSwatch.Show();
        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            this.openFileDialogPicture.ShowDialog();
        }

        private void openFileDialogPicture_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string item in this.openFileDialogPicture.FileNames)
            {
                try
                {
                    Image file = Image.FromFile(item);
                    this.Color = Colors.GetDominantColor(file);
                    this.setColor();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void buttonOpenSwatch_Click(object sender, EventArgs e)
        {
            this.openFileDialogSwatch.ShowDialog();
        }

        private void openFileDialogSwatch_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string item in this.openFileDialogSwatch.FileNames)
            {
                try
                {
                    FormSwatch _FormSwatch = new FormSwatch(item);
                    _FormSwatch.Show();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout _FormAbout = new FormAbout();
            _FormAbout.ShowDialog();
        }


    }
}
