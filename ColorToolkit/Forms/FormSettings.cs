using System;
using System.Drawing;
using System.Windows.Forms;

namespace Toolkit.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            InitializeBinding();
            Icon = Icon.ExtractAssociatedIcon(Program.Assembly.Location);
        }

        private void InitializeBinding()
        {
            trackBarOpacity.Value = (int)(Properties.Settings.Default.Opacity * 100);
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Opacity = trackBarOpacity.Value / 100.0;
            Properties.Settings.Default.CheckForUpdates = checkBoxCheckForUpdates.Checked;
            Properties.Settings.Default.Save();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}