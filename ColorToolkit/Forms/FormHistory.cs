using Platform.Support.Drawing;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Toolkit.Forms
{
    public partial class FormHistory : Form
    {
        private static FormHistory instance;

        private FormHistory()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Program.Assembly.Location);
        }

        public static FormHistory Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new FormHistory();
                return instance;
            }
        }

        private void FormSwatches_Load(object sender, EventArgs e)
        {
            foreach (var item in Properties.Settings.Default.History)
            {
                var color = Color.FromArgb(int.Parse(item));

                var labelColor = new Label
                {
                    //
                    // labelColor
                    //
                    Dock = DockStyle.Right,
                    AutoSize = true,
                    Text = color.ToHEX().ToUpper(),
                    ForeColor = color.Invert(),
                };
                labelColor.MouseClick += new MouseEventHandler(Panel_MouseClick);
                labelColor.MouseDoubleClick += new MouseEventHandler(Panel_MouseDoubleClick);

                var panelItem = new BufferedPanel()
                {
                    //
                    // panelItem
                    //
                    Cursor = Cursors.Hand,
                    Dock = DockStyle.Top,
                    Padding = new Padding(6),
                    Size = new Size(192, 32),
                    BackColor = color
                };

                panelItem.Controls.Add(labelColor);
                panelItem.MouseClick += new MouseEventHandler(Panel_MouseClick);
                panelItem.MouseDoubleClick += new MouseEventHandler(Panel_MouseDoubleClick);

                this.Controls.Add(panelItem);
            }

            panelOptions.SendToBack();

            // Resolution fix
            if (Height > FormHelper.GetWorkingArea().Height)
                Height = MinimumSize.Height;

            comboBoxColorMode.SelectedIndex = 0;
        }

        private void Panel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.Color = (sender as Control).BackColor;
                mainForm.Activate();
            }
        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender.GetType() != typeof(Label))
            {
                switch (comboBoxColorMode.SelectedIndex)
                {
                    case 1:
                        Clipboard.SetText(ColorHelper.RGB((sender as Panel).BackColor));
                        break;

                    case 2:
                        Clipboard.SetText(ColorHelper.HSB((sender as Panel).BackColor.ToHSB()));
                        break;

                    default:
                        Clipboard.SetText((sender as Panel).BackColor.ToHEX());
                        break;
                }
            }
            else
            {
                switch (comboBoxColorMode.SelectedIndex)
                {
                    case 1:
                        Clipboard.SetText(ColorHelper.RGB((sender as Label).Parent.BackColor));
                        break;

                    case 2:
                        Clipboard.SetText(ColorHelper.HSB((sender as Label).Parent.BackColor.ToHSB()));
                        break;

                    default:
                        Clipboard.SetText((sender as Label).Parent.BackColor.ToHEX());
                        break;
                }
            }
        }

        private void ComboBoxColorMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in this.Controls.OfType<Panel>().Where(x => x != panelOptions))
            {
                var label = item.Controls.OfType<Label>().First();
                switch (comboBoxColorMode.SelectedIndex)
                {
                    case 1:
                        label.Text = ColorHelper.RGB(item.BackColor).ToUpper();
                        break;

                    case 2:
                        label.Text = ColorHelper.HSB(item.BackColor.ToHSB());
                        break;

                    default:
                        label.Text = item.BackColor.ToHEX().ToUpper();
                        break;
                }
            }
        }

        private void CheckBoxVisible_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBoxVisible.Checked;
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.Controls.OfType<Panel>().Where(x => x != panelOptions).All(c =>
            {
                c.Dispose();
                c = null;
                return true;
            });
            this.Controls.Clear();
            this.Controls.Add(panelOptions);

            FormSwatches_Load(sender, e);
            this.ResumeLayout();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.History.Clear();
            Properties.Settings.Default.Save();
            buttonRefresh.PerformClick();
        }
    }
}