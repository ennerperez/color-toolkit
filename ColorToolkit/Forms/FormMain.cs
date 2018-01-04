using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Pictograms;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Pictograms;

namespace Toolkit.Forms
{
    public partial class FormMain : Form, INotifyPropertyChanged
    {
        private Color color = Color.Black;

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
                    OnPropertyChanged(new PropertyChangedEventArgs("Color"));
                }
            }
        }

        public FormMain()
        {
            InitializeComponent();
            InitializeBinding();

            Icon = Icon.ExtractAssociatedIcon(Program.Assembly.Location);

            // openFileDialogMain
            openFileDialogMain.DefaultExt = Program.Formats.FirstOrDefault();

            // Icons
            toolStripButtonFile.SetImage(MaterialDesign.Instance, Program.Icon, 48, SystemColors.Control);

            newToolStripMenuItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.insert_drive_file, 48, toolStripMenu.BackColor);
            openToolStripMenuItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.folder_open, 48, toolStripMenu.BackColor);
            saveToolStripMenuItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.save, 48, toolStripMenu.BackColor);
            saveAsToolStripMenuItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.save, 48, toolStripMenu.BackColor);

            toolStripButtonQSwatch.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.list, 48, SystemColors.Control);
            toolStripButtonHistory.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.restore, 48, SystemColors.Control);

            toolStripButtonTopMost.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.layers, 48, SystemColors.Control);
            toolStripButtonAbout.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.info, 48, SystemColors.Control);

            panelColor.BackgroundImage = MaterialDesign.GetImage(MaterialDesign.IconType.colorize, 48, SystemColors.Control);

#if DEBUG
            FormHelper.ExtractResources(panelColor.BackgroundImage, panelColor.Name);
            FormHelper.ExtractResources(toolStripMenu);
#endif
        }

        private void InitializeBinding()
        {
            panelColor.DataBindings.Add("BackColor", this, "Color", true, DataSourceUpdateMode.OnPropertyChanged);
            colorSpaceHEX.DataBindings.Add("Color", this, "Color", true, DataSourceUpdateMode.OnPropertyChanged);
            colorSpaceRGB.DataBindings.Add("Color", this, "Color", true, DataSourceUpdateMode.OnPropertyChanged);
            colorSpaceHSB.DataBindings.Add("Color", this, "Color", true, DataSourceUpdateMode.OnPropertyChanged);
            colorSpaceCMYK.DataBindings.Add("Color", this, "Color", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Color")
                setColor();

            PropertyChanged?.Invoke(this, e);
        }

        #endregion INotifyPropertyChanged

        private async void FormMain_Load(object sender, EventArgs e)
        {
            toolStripButtonTopMost.Checked = Properties.Settings.Default.TopMost;

            if (Properties.Settings.Default.CheckForUpdates)
                await GitHubInfo.CheckForUpdateAsync();

#if DEBUG
            Color = Color.FromHex("#F44336");
#endif
        }

        protected override void OnActivated(EventArgs e)
        {
            Opacity = 1.0;
            base.OnActivated(e);
        }

        protected override void OnDeactivate(EventArgs e)
        {
            try
            {
                Opacity = Properties.Settings.Default.Opacity;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            base.OnDeactivate(e);
        }

        #region Drag & Drop

        private bool validData;

        private bool getFileName(out string filename, DragEventArgs e)
        {
            var ret = false;
            filename = string.Empty;

            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                if (((IDataObject)e.Data).GetData("FileName") is Array data && ((data.Length == 1) && (data.GetValue(0) is string)))
                {
                    filename = ((string[])data)[0];
                    var ext = Path.GetExtension(filename).ToLower();
                    ret = (Program.Formats.Contains(ext) || Program.Palettes.Contains(ext));
                }
            return ret;
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            var fileName = string.Empty;
            validData = getFileName(out fileName, e);
            if (validData && !string.IsNullOrEmpty(fileName))
            {
                loadFile(fileName);
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        #endregion Drag & Drop

        #region Color Picker

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
                Color = colorDialogPicker.Color;
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

        private void getScreenColor()
        {
            using (var bitmap = new Bitmap(1, 1))
            {
                var mousePosition = Control.MousePosition;
                checked
                {
                    mousePosition.X = (int)Math.Round(unchecked((double)mousePosition.X - (double)bitmap.Width / 2.0));
                    mousePosition.Y = (int)Math.Round(unchecked((double)mousePosition.Y - (double)bitmap.Height / 2.0));
                    using (var graphics = Graphics.FromImage(bitmap))
                    {
                        var arg_A4_0 = graphics;
                        var arg_A4_1 = mousePosition;
                        var upperLeftDestination = new Point(0, 0);
                        arg_A4_0.CopyFromScreen(arg_A4_1, upperLeftDestination, bitmap.Size);
                    }
                    Color = bitmap.GetPixel((int)Math.Round((double)bitmap.Size.Width / 2.0), (int)Math.Round((double)bitmap.Size.Height / 2.0));
                    Invalidate();
                }
            }
        }

        #endregion Color Picker

        private void setColor()
        {
            if (Properties.Settings.Default.History == null)
                Properties.Settings.Default.History = new System.Collections.Specialized.StringCollection();

            if (!Properties.Settings.Default.History.Contains(Color.ToArgb().ToString()))
            {
                Properties.Settings.Default.History.Add(Color.ToArgb().ToString());
                Properties.Settings.Default.Save();
            }

            panelColor.BackgroundImage = MaterialDesign.GetImage(MaterialDesign.IconType.colorize, 48, Color.Invert());

            toolStripButtonHistory.Enabled = Properties.Settings.Default.History != null && Properties.Settings.Default.History.Count > 0;
        }

        private void loadFile(object item)
        {
            try
            {
                var file = new FileInfo(item.ToString());
                if (Program.Formats.Contains(file.Extension))
                {
                    var image = Image.FromFile(item.ToString());
                    Color = image.GetDominantColor();
                }
                else if (Program.Palettes.Contains(file.Extension))
                    displayChild(new FormSwatch(item.ToString()), 2);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        internal void displayChild(Form child, int factor = 0)
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var palette = new List<Color>();
            displayChild(new FormSwatch(palette), 2);
        }

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
            displayChild(FormHistory.Instance, 2);
        }

        private void toolStripButtonTopMost_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            toolStripButtonTopMost.Checked = TopMost;
            Properties.Settings.Default.TopMost = TopMost;
            Properties.Settings.Default.Save();
        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            var topMost = TopMost;
            if (topMost) TopMost = false;
            var child = new FormSettings();
            child.ShowDialog();
            TopMost = topMost;
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            var child = new FormAbout();
            child.ShowDialog();
        }

        #endregion ToolStrip

        private void colorSpace_ColorChanged(object sender, EventArgs e)
        {
            Color = (sender as Controls.ColorSpaceControl).Color;
        }
    }
}