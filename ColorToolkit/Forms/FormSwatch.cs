using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Pictograms;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Pictograms;
using Toolkit.Models;

namespace Toolkit.Forms
{
    internal sealed partial class FormSwatch : Form
    {
        public string File { get; private set; }
        public SortedList<int, Color> Palette { get; private set; }

        public FormSwatch()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Program.Assembly.Location);

            Palette = new SortedList<int, Color>();
        }

        public FormSwatch(string file) : this()
        {
            File = file;
        }

        public FormSwatch(IEnumerable<Color> colors) : this()
        {
            var index = 0;
            foreach (var item in colors)
            {
                Palette.Add(index, item);
                index++;
            }
        }

        private void FormSwatch_Load(object sender, EventArgs e)
        {
            comboBoxTileSize.SelectedItem = "32";

            if (!string.IsNullOrEmpty(File))
                loadFrom(File);
        }

        private Control buildColorBox(KeyValuePair<int, Color> item)
        {
            var _color = new BufferedPanel()
            {
                Tag = item.Key,
                Width = int.Parse(comboBoxTileSize.SelectedItem.ToString()),
                Height = int.Parse(comboBoxTileSize.SelectedItem.ToString()),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = item.Value,
                Cursor = Cursors.Hand,
                ContextMenuStrip = string.IsNullOrEmpty(File) ? contextMenuStripColor : null
            };
            toolTipColor.SetToolTip(_color, item.Value.GetHex());
            _color.Click += _color_Click;
            _color.DoubleClick += _color_DoubleClick;
            return _color;
        }

        private void loadFrom(string file)
        {
            var selectedFile = new FileInfo(file);

            if (selectedFile != null)
            {
                IEnumerable<Color> colors = null;
                if (selectedFile.Extension == ".json")
                {
                    try
                    {
                        var data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(System.IO.File.ReadAllText(file));
                        colors = (from item in data
                                  let color = Color.Empty
                                  select color.FromHex(item));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (selectedFile.Extension == ".ase")
                    colors = Swatch.ReadExchangeFile(selectedFile.FullName);
                else
                    colors = Swatch.ReadSwatchFile(selectedFile.FullName);

                if (colors.Any())
                {
                    var index = 0;
                    foreach (var item in colors)
                    {
                        Palette.Add(index, item);
                        index++;
                    }
                }

                Text = Path.GetFileName(selectedFile.FullName);
            }
        }

        private void _color_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            if (mainForm != null)
                mainForm.Color = (sender as Control).BackColor;
        }

        private void _color_DoubleClick(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            if (mainForm != null)
                mainForm.displayChild(new FormQSwatch((sender as Control).BackColor), 2);
        }

        private void FormSwatch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Palette.Clear();
            Palette = null;
            GC.Collect();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var control = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl;
            var index = control.Parent.Controls.IndexOf(control);
            Palette.RemoveAt(index - 1);
            control.Parent.Controls.RemoveAt(index);
        }

        private void FormSwatch_Shown(object sender, EventArgs e)
        {
            flowLayoutPanelColors.SuspendLayout();
            if (!string.IsNullOrEmpty(File))
                foreach (var item in Palette)
                    flowLayoutPanelColors.Invoke(new Action(() => { flowLayoutPanelColors.Controls.Add(buildColorBox(item)); }));
            else
            {
                var _color = new BufferedPanel()
                {
                    Width = int.Parse(comboBoxTileSize.SelectedItem.ToString()),
                    Height = int.Parse(comboBoxTileSize.SelectedItem.ToString()),
                    BorderStyle = BorderStyle.FixedSingle,
                };
                _color.SetImage<MaterialDesign>(MaterialDesign.IconType.colorize);
                _color.BackgroundImageLayout = ImageLayout.Center;
                _color.MouseClick += panelColor_MouseClick;
                _color.MouseMove += panelColor_MouseDown;
                _color.MouseUp += panelColor_MouseUp;

                flowLayoutPanelColors.Invoke(new Action(() => { flowLayoutPanelColors.Controls.Add(_color); }));
            }

            flowLayoutPanelColors.ResumeLayout();
        }

        private void _color_Click_Add(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            if (mainForm != null)
            {
                Palette.Add(Palette.Count, mainForm.Color);
                flowLayoutPanelColors.Invoke(new Action(() => { flowLayoutPanelColors.Controls.Add(buildColorBox(Palette.Last())); }));
            }
        }

        #region Color Picker

        private void panelColor_MouseClick(object sender, MouseEventArgs e)
        {
            MouseButtons button = e.Button;
            if (button == MouseButtons.Left)
                Cursor = Cursors.Cross;
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Cursor = Cursors.Cross;
        }

        private void panelColor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.Default;
                var color = getScreenColor();
                Palette.Add(Palette.Count, color);
                flowLayoutPanelColors.Invoke(new Action(() => { flowLayoutPanelColors.Controls.Add(buildColorBox(Palette.Last())); }));
            }
        }

        private Color getScreenColor()
        {
            var color = Color.Empty;
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
                    color = bitmap.GetPixel((int)Math.Round((double)bitmap.Size.Width / 2.0), (int)Math.Round((double)bitmap.Size.Height / 2.0));
                }
            }
            return color;
        }

        #endregion Color Picker

        private void FormSwatch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(File) && Palette.Any())
            {
                if (MessageBox.Show(Messages.ConfirmExit, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    if (saveFileDialogSave.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            switch (Path.GetExtension(saveFileDialogSave.FileName))
                            {
                                case ".json":
                                    var colors = from item in Palette
                                                 select item.Value.GetHex();
                                    System.IO.File.WriteAllText(saveFileDialogSave.FileName, Newtonsoft.Json.JsonConvert.SerializeObject(colors));
                                    break;

                                default:
                                    break;
                            }
                            File = Path.GetFileName(saveFileDialogSave.FileName);
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBoxVisible.Checked;
        }

        private void comboBoxTileSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanelColors.SuspendLayout();
            foreach (Control item in flowLayoutPanelColors.Controls)
                item.Size = new Size(int.Parse(comboBoxTileSize.SelectedItem.ToString()), int.Parse(comboBoxTileSize.SelectedItem.ToString()));

            if (string.IsNullOrEmpty(File))
            {
                var pipe = flowLayoutPanelColors.Controls.OfType<BufferedPanel>().FirstOrDefault();
                if (pipe != null)
                    pipe.SetImage<MaterialDesign>(MaterialDesign.IconType.colorize);
            }

            flowLayoutPanelColors.ResumeLayout();
        }
    }
}