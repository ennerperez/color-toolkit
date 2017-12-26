using Platform.Support.Drawing;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Pictograms;
using System.IO;
using System.Reflection;
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
                if (color != value)
                {
                    color = value;
                    OnColorChanged(EventArgs.Empty);
                }
            }
        }

        public FormMain()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Program.Assembly.Location);

            toolStripButtonOpen.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.folder_open, 48, SystemColors.Control);
            toolStripButtonQSwatch.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.color_lens, 48, SystemColors.Control);
            toolStripButtonHistory.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.restore, 48, SystemColors.Control);

            toolStripButtonTopMost.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.layers, 48, SystemColors.Control);
            toolStripButtonAbout.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.info, 48, SystemColors.Control);
            toolStripButtonClose.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.close, 48, SystemColors.Control);

            toolStripButtonUpdates.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.system_update_alt, 48, SystemColors.Control);

            panelColor.BackgroundImage = MaterialDesign.GetImage(MaterialDesign.IconType.colorize, 48, SystemColors.Control);

#if DEBUG

            Color = ColorHelper.ToColor("#F44336");
            SetColor();

            FormHelper.ExtractResources(panelColor.BackgroundImage, panelColor.Name);
            FormHelper.ExtractResources(toolStripMenu);
#endif
        }

        #region Events

        public event EventHandler ColorChanged;

        private void OnColorChanged(EventArgs e)
        {
            SetColor();
            ColorChanged?.Invoke(this, e);
        }

        #endregion Events

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

        private bool GetFileName(out string filename, DragEventArgs e)
        {
            var ret = false;
            filename = string.Empty;

            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                if (((IDataObject)e.Data).GetData("FileName") is Array data && ((data.Length == 1) && (data.GetValue(0) is string)))
                {
                    filename = ((string[])data)[0];
                    var ext = Path.GetExtension(filename).ToLower();
                    ret = (Program.Formats.Contains(ext) || Program.Palettes.Contains(ext));
                }
            }
            return ret;
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            var fileName = string.Empty;
            validData = GetFileName(out fileName, e);
            if (validData && !string.IsNullOrEmpty(fileName))
            {
                LoadFile(fileName);

                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        #endregion Drag & Drop

        private void PanelColor_MouseClick(object sender, MouseEventArgs e)
        {
            MouseButtons button = e.Button;
            if (button == MouseButtons.Left)
                Cursor = Cursors.Cross;
        }

        private void PanelColor_DoubleClick(object sender, EventArgs e)
        {
            colorDialogPicker.Color = Color;
            if (colorDialogPicker.ShowDialog() == DialogResult.OK)
            {
                Color = colorDialogPicker.Color;
                SetColor();
            }
        }

        private void PanelColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Cursor = Cursors.Cross;
        }

        private void PanelColor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                GetScreenColor();
        }

        private void PanelColor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Cursor = Cursors.Default;
        }

        private void TextBoxHEX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                ButtonCopyHEX_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                textBoxHEX.Text = string.Empty;
        }

        private void TextBoxHEX_Leave(object sender, EventArgs e)
        {
            if (!textBoxHEX.Text.StartsWith("#")) { textBoxHEX.Text = "#" + textBoxHEX.Text.Trim(); }

            if (!System.Text.RegularExpressions.Regex.IsMatch("#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})", textBoxHEX.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                Color = ColorHelper.ToColor(textBoxHEX.Text);
                SetColor();
            }
            else
                textBoxHEX.Text = ColorHelper.ToHEX(System.Drawing.Color.FromArgb((int)textBoxR.Value, (int)textBoxG.Value, (int)textBoxB.Value));
        }

        private void TextBoxRGB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                ButtonCopyRGB_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
            {
                textBoxR.Value = 0;
                textBoxG.Value = 0;
                textBoxB.Value = 0;
            }
        }

        private void TextBoxRGB_Leave(object sender, EventArgs e)
        {
            Color = Color.FromArgb(255, int.Parse(textBoxR.Value.ToString()), int.Parse(textBoxG.Value.ToString()), int.Parse(textBoxB.Value.ToString()));
            SetColor();
        }

        private void TextBoxHSB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                ButtonCopyHSB_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
            {
                textBoxH.Value = 0;
                textBoxS.Value = 0;
                textBoxV.Value = 0;
            }
        }

        private void TextBoxHSB_Leave(object sender, EventArgs e)
        {
            Color = ColorHelper.ToColor(new HSB((int)textBoxH.Value, (int)textBoxS.Value, (int)textBoxV.Value));
            SetColor();
        }

        private void ButtonCopyHEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxHEX.Text);
        }

        private void ButtonCopyRGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(String.Join(",", new string[] { textBoxR.Value.ToString(), textBoxG.Value.ToString(), textBoxB.Value.ToString() }));
        }

        private void ButtonCopyHSB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(String.Join(",", new string[] { textBoxH.Value.ToString(), textBoxS.Value.ToString(), textBoxV.Value.ToString() }));
        }

        private void LabelHEX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ButtonCopyHEX_Click(sender, e);
        }

        private void LabelRGB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ButtonCopyRGB_Click(sender, e);
        }

        private void LabelHSB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ButtonCopyHSB_Click(sender, e);
        }

        private void GetScreenColor()
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
                SetColor();
                Invalidate();
            }
        }

        private void SetColor()
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

        private void LoadFile(object item)
        {
            try
            {
                var file = new FileInfo(item.ToString());
                if (Program.Formats.Contains(file.Extension))
                {
                    var image = Image.FromFile(item.ToString());
                    Color = ColorHelper.GetDominantColor(image);
                    SetColor();
                }
                else if (Program.Palettes.Contains(file.Extension))
                    DisplayChild(new FormSwatch(item.ToString()), 3);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DisplayChild(Form child, int factor = 0)
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

        private void OpenFileDialogMain_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string item in openFileDialogMain.FileNames)
                LoadFile(item);
        }

        #region ToolStrip

        private void ToolStripButtonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogMain.ShowDialog();
        }

        private void ToolStripButtonQSwatch_Click(object sender, EventArgs e)
        {
            DisplayChild(new FormQSwatch(Color), 1);
        }

        private void ToolStripButtonHistory_Click(object sender, EventArgs e)
        {
            DisplayChild(FormHistory.Instance, 3);
        }

        private void ToolStripButtonTopMost_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            toolStripButtonTopMost.Checked = TopMost;
            Properties.Settings.Default.TopMost = TopMost;
            Properties.Settings.Default.Save();
        }

        private void ToolStripButtonUpdates_Click(object sender, EventArgs e)
        {
            var checkForUpdates = !toolStripButtonUpdates.Checked;
            toolStripButtonUpdates.Checked = checkForUpdates;
            Properties.Settings.Default.CheckForUpdates = checkForUpdates;
            Properties.Settings.Default.Save();
        }

        private void ToolStripButtonAbout_Click(object sender, EventArgs e)
        {
            var child = new FormAbout();
            child.ShowDialog();
        }

        private void ToolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion ToolStrip

        private async void FormMain_Load(object sender, EventArgs e)
        {
            toolStripButtonUpdates.Checked = Properties.Settings.Default.CheckForUpdates;
            toolStripButtonTopMost.Checked = Properties.Settings.Default.TopMost;

            if (Properties.Settings.Default.CheckForUpdates)
                await GitHubInfo.CheckForUpdateAsync();
        }
    }
}