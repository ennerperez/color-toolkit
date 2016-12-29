using Platform.Support.Drawing;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Pictograms;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Pictograms;

namespace Toolkit.Forms
{
    public partial class FormMain : Form
    {

        private Color color;
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                OnColorChanged(EventArgs.Empty);
            }
        }

        public FormMain()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetEntryAssembly().Location);

            toolStripButtonTopMost.Checked = TopMost;

            toolStripButtonOpen.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.folder_open, 48, Color.White);
            toolStripButtonQSwatch.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.color_lens, 48, Color.White);
            toolStripButtonHistory.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.restore, 48, Color.White);

            toolStripButtonTopMost.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.layers, 48, Color.White);
            toolStripButtonAbout.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.info, 48, Color.White);
            toolStripButtonClose.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.close, 48, Color.White);

            panelColor.BackgroundImage = MaterialDesign.GetImage(MaterialDesign.IconType.colorize, 48, Color.White);

#if DEBUG

            Color = ColorHelper.ToColor("#F44336");
            setColor();

            FormHelper.ExtractResources(panelColor.BackgroundImage, panelColor.Name);
            FormHelper.ExtractResources(toolStripMenu);
#endif

        }

        #region Events

        public event EventHandler ColorChanged;

        private void OnColorChanged(EventArgs e)
        {
            if (ColorChanged != null)
                ColorChanged(this, e);
        }

        #endregion

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            Opacity = 1.0;
        }
        protected override void OnDeactivate(EventArgs e)
        {
            try
            {
                Opacity = 0.25;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            base.OnDeactivate(e);
        }

        #region Drag & Drop

        private bool validData;
        //private Thread getFileThread;

        private bool getFileName(out string filename, DragEventArgs e)
        {
            var ret = false;
            filename = string.Empty;

            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                var data = ((IDataObject)e.Data).GetData("FileName") as Array;
                if (data != null && ((data.Length == 1) && (data.GetValue(0) is string)))
                {
                    filename = ((string[])data)[0];
                    var ext = Path.GetExtension(filename).ToLower();
                    ret = (Program.imageFiles.Contains(ext) || Program.paletteFiles.Contains(ext));
                }
            }
            return ret;
        }

        private void dragDrop(object sender, DragEventArgs e)
        {
            //if (validData)
            //    while (getFileThread.IsAlive)
            //    {
            //        Application.DoEvents();
            //        Thread.Sleep(0);
            //    }
        }
        private void dragEnter(object sender, DragEventArgs e)
        {
            var fileName = string.Empty;
            validData = getFileName(out fileName, e);
            if (validData && !string.IsNullOrEmpty(fileName))
            {
                //getFileThread = new Thread(new ParameterizedThreadStart(loadFile));
                //getFileThread.Start(fileName);
                loadFile(fileName);

                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        #endregion

        private void panelColor_MouseClick(object sender, MouseEventArgs e)
        {
            MouseButtons button = e.Button;
            if (button == MouseButtons.Left)
                Cursor = Cursors.Cross;
        }
        private void panelColor_DoubleClick(object sender, EventArgs e)
        {
            colorDialogPicker.Color = Color;
            if (colorDialogPicker.ShowDialog() == DialogResult.OK)
            {
                Color = colorDialogPicker.Color;
                setColor();
            }
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Cursor = Cursors.Cross;
        }
        private void panelColor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                getScreenColor();
        }
        private void panelColor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Cursor = Cursors.Default;
        }

        private void textBoxHEX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                buttonCopyHEX_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                textBoxHEX.Text = string.Empty;
        }
        private void textBoxHEX_Leave(object sender, EventArgs e)
        {

            if (!textBoxHEX.Text.StartsWith("#")) { textBoxHEX.Text = "#" + textBoxHEX.Text.Trim(); }

            if (!System.Text.RegularExpressions.Regex.IsMatch("#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})", textBoxHEX.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                Color = ColorHelper.ToColor(textBoxHEX.Text);
                setColor();
            }
            else
                textBoxHEX.Text = ColorHelper.ToHEX(System.Drawing.Color.FromArgb((int)textBoxR.Value, (int)textBoxG.Value, (int)textBoxB.Value));

        }

        private void textBoxRGB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                buttonCopyRGB_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
            {
                textBoxR.Value = 0;
                textBoxG.Value = 0;
                textBoxB.Value = 0;
            }
        }
        private void textBoxRGB_Leave(object sender, EventArgs e)
        {
            Color = Color.FromArgb(255, int.Parse(textBoxR.Value.ToString()), int.Parse(textBoxG.Value.ToString()), int.Parse(textBoxB.Value.ToString()));
            setColor();
        }

        private void textBoxHSB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                buttonCopyHSB_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
            {
                textBoxH.Value = 0;
                textBoxS.Value = 0;
                textBoxV.Value = 0;
            }
        }
        private void textBoxHSB_Leave(object sender, EventArgs e)
        {
            Color = ColorHelper.ToColor(new HSB((int)textBoxH.Value, (int)textBoxS.Value, (int)textBoxV.Value));
            setColor();
        }

        private void buttonCopyHEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxHEX.Text);
        }
        private void buttonCopyRGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(String.Join(",", new string[] { textBoxR.Value.ToString(), textBoxG.Value.ToString(), textBoxB.Value.ToString() }));
        }
        private void buttonCopyHSB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(String.Join(",", new string[] { textBoxH.Value.ToString(), textBoxS.Value.ToString(), textBoxV.Value.ToString() }));
        }

        private void labelHEX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buttonCopyHEX_Click(sender, e);
        }
        private void labelRGB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buttonCopyRGB_Click(sender, e);
        }
        private void labelHSB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buttonCopyHSB_Click(sender, e);
        }

        private void getScreenColor()
        {
            Bitmap bitmap = new Bitmap(FormHelper.GetWorkingArea().Width, FormHelper.GetWorkingArea().Height);
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
                Color = bitmap.GetPixel((int)Math.Round((double)bitmap.Size.Width / 2.0), (int)Math.Round((double)bitmap.Size.Height / 2.0));
                setColor();
                Invalidate();
            }
        }
        private void setColor()
        {

            if (Properties.Settings.Default.History == null)
                Properties.Settings.Default.History = new System.Collections.Specialized.StringCollection();

            if (!Properties.Settings.Default.History.Contains(Color.ToArgb().ToString()))
            {
                Properties.Settings.Default.History.Add(Color.ToArgb().ToString());
                Properties.Settings.Default.Save();
            }

            panelColor.BackColor = Color;
            panelColor.BackgroundImage = MaterialDesign.GetImage(MaterialDesign.IconType.colorize, 48, Color.Invert());

            toolStripButtonHistory.Enabled = Properties.Settings.Default.History != null && Properties.Settings.Default.History.Count > 0;

            textBoxHEX.Text = ColorHelper.ToHEX(Color);

            textBoxR.Value = Color.R;
            textBoxG.Value = Color.G;
            textBoxB.Value = Color.B;

            var hsv = ColorHelper.ToHSB(Color);

            textBoxH.Value = (decimal)hsv.Hue360;
            textBoxS.Value = (decimal)hsv.Saturation100;
            textBoxV.Value = (decimal)hsv.Brightness100;

        }
        private void loadFile(object item)
        {
            try
            {
                var file = new FileInfo(item.ToString());
                if (Program.imageFiles.Contains(file.Extension))
                {
                    var image = Image.FromFile(item.ToString());
                    Color = ColorHelper.GetDominantColor(image);
                    setColor();
                }
                else if (Program.paletteFiles.Contains(file.Extension))
                    displayChild(new FormSwatch(item.ToString()), 3);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void displayChild(Form child, int factor = 0)
        {
            if (factor > 0)
            {
                child.Width = this.Width * factor;
                child.Height = this.Height;
            }
            child.StartPosition = FormStartPosition.Manual;
            if (this.DesktopLocation.X > (FormHelper.GetWorkingArea().Width / 2))
                child.Location = new Point(this.Location.X - child.Width - this.Padding.Left, this.Location.Y);
            else
                child.Location = new Point(this.Location.X + this.Width + this.Padding.Left, this.Location.Y);
            child.Show();
        }

        private void openFileDialogMain_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string item in openFileDialogMain.FileNames)
                loadFile(item);
        }

        #region ToolStrip

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogMain.ShowDialog();
        }
        private void toolStripButtonQSwatch_Click(object sender, EventArgs e)
        {
            displayChild(new FormQSwatch(Color), 1);
        }
        private void toolStripButtonHistory_Click(object sender, EventArgs e)
        {
            displayChild(FormHistory.Instance, 3);
        }

        private void toolStripButtonTopMost_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            toolStripButtonTopMost.Checked = TopMost;
            Properties.Settings.Default.TopMost = TopMost;
            Properties.Settings.Default.Save();
        }
        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            var child = new FormAbout();
            child.ShowDialog();
        }
        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

    }
}
