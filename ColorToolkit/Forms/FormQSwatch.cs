using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Toolkit.Forms
{
    public partial class FormQSwatch : Form
    {
        public Color Color { get; set; }

        public FormQSwatch(Color color)
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Program.Assembly.Location);

            Color = color;
        }

        private void FormSwatches_Load(object sender, EventArgs e)
        {
            panelPrimary.BackColor = Color;
            panelPrimaryInternal.BackColor = panelPrimary.BackColor;

            // LIGHT

            //000-255-
            //000-001
            //(0.13*255)

            panel050.BackColor = Color.LightenBy(85);
            panel100.BackColor = Color.LightenBy(70);
            panel200.BackColor = Color.LightenBy(50);
            panel300.BackColor = Color.LightenBy(31);
            panel400.BackColor = Color.LightenBy(13);

            // BASE COLOR

            panel500.BackColor = Color;

            // DARK

            panel600.BackColor = Color.DarkenBy(3);
            panel700.BackColor = Color.DarkenBy(18);
            panel800.BackColor = Color.DarkenBy(36);
            panel900.BackColor = Color.DarkenBy(48);

            // OTHERS

            panelA100.BackColor = panel100.BackColor.DarkenBy(10);
            panelA200.BackColor = panel200.BackColor.DarkenBy(30);
            panelA400.BackColor = panel400.BackColor.DarkenBy(45);
            panelA700.BackColor = panel700.BackColor.DarkenBy(60);

            // Resolution fix
            if (Height > FormHelper.GetWorkingArea().Height)
                Height = MinimumSize.Height;

            comboBoxColorMode.SelectedIndex = 0;
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender.GetType() != typeof(Label))
            {
                switch (comboBoxColorMode.SelectedIndex)
                {
                    case 1:
                        Clipboard.SetText((sender as Panel).BackColor.GetRgb());
                        break;

                    case 2:
                        Clipboard.SetText((sender as Panel).BackColor.GetHsb());
                        break;

                    case 3:
                        Clipboard.SetText((sender as Panel).BackColor.GetCmyk());
                        break;

                    default:
                        Clipboard.SetText((sender as Panel).BackColor.GetHex());
                        break;
                }
            }
            else
            {
                switch (comboBoxColorMode.SelectedIndex)
                {
                    case 1:
                        Clipboard.SetText((sender as Label).Parent.BackColor.GetRgb());
                        break;

                    case 2:
                        Clipboard.SetText((sender as Label).Parent.BackColor.GetHsb());
                        break;

                    case 3:
                        Clipboard.SetText((sender as Label).Parent.BackColor.GetCmyk());
                        break;

                    default:
                        Clipboard.SetText((sender as Label).Parent.BackColor.GetHex());
                        break;
                }
            }
        }

        private void panel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.Color = (sender as Control).BackColor;
                mainForm.Activate();
            }
        }

        private void comboBoxColorMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxColorMode.SelectedIndex)
            {
                case 1:

                    labelPrimary.Text = panelPrimary.BackColor.GetRgb();

                    // LIGHT

                    //000-255-
                    //000-001
                    //(0.13*255)

                    label050.Text = panel050.BackColor.GetRgb();
                    label100.Text = panel100.BackColor.GetRgb();
                    label200.Text = panel200.BackColor.GetRgb();
                    label300.Text = panel300.BackColor.GetRgb();
                    label400.Text = panel400.BackColor.GetRgb();

                    // BASE COLOR

                    label500.Text = panel500.BackColor.GetRgb();

                    // DARK

                    label600.Text = panel600.BackColor.GetRgb();
                    label700.Text = panel700.BackColor.GetRgb();
                    label800.Text = panel800.BackColor.GetRgb();
                    label900.Text = panel900.BackColor.GetRgb();

                    // OTHERS

                    labelA100.Text = panelA100.BackColor.GetRgb();
                    labelA200.Text = panelA200.BackColor.GetRgb();
                    labelA400.Text = panelA400.BackColor.GetRgb();
                    labelA700.Text = panelA700.BackColor.GetRgb();

                    break;

                case 2:

                    labelPrimary.Text = panelPrimary.BackColor.GetHsb();

                    // LIGHT

                    //000-255-
                    //000-001
                    //(0.13*255)

                    label050.Text = panel050.BackColor.GetHsb();
                    label100.Text = panel100.BackColor.GetHsb();
                    label200.Text = panel200.BackColor.GetHsb();
                    label300.Text = panel300.BackColor.GetHsb();
                    label400.Text = panel400.BackColor.GetHsb();

                    // BASE COLOR

                    label500.Text = panel500.BackColor.GetHsb();

                    // DARK

                    label600.Text = panel600.BackColor.GetHsb();
                    label700.Text = panel700.BackColor.GetHsb();
                    label800.Text = panel800.BackColor.GetHsb();
                    label900.Text = panel900.BackColor.GetHsb();

                    // OTHERS

                    labelA100.Text = panelA100.BackColor.GetHsb();
                    labelA200.Text = panelA200.BackColor.GetHsb();
                    labelA400.Text = panelA400.BackColor.GetHsb();
                    labelA700.Text = panelA700.BackColor.GetHsb();

                    break;

                case 3:

                    labelPrimary.Text = panelPrimary.BackColor.GetCmyk();

                    // LIGHT

                    //000-255-
                    //000-001
                    //(0.13*255)

                    label050.Text = panel050.BackColor.GetCmyk();
                    label100.Text = panel100.BackColor.GetCmyk();
                    label200.Text = panel200.BackColor.GetCmyk();
                    label300.Text = panel300.BackColor.GetCmyk();
                    label400.Text = panel400.BackColor.GetCmyk();

                    // BASE COLOR

                    label500.Text = panel500.BackColor.GetCmyk();

                    // DARK

                    label600.Text = panel600.BackColor.GetCmyk();
                    label700.Text = panel700.BackColor.GetCmyk();
                    label800.Text = panel800.BackColor.GetCmyk();
                    label900.Text = panel900.BackColor.GetCmyk();

                    // OTHERS

                    labelA100.Text = panelA100.BackColor.GetCmyk();
                    labelA200.Text = panelA200.BackColor.GetCmyk();
                    labelA400.Text = panelA400.BackColor.GetCmyk();
                    labelA700.Text = panelA700.BackColor.GetCmyk();

                    break;

                default:

                    labelPrimary.Text = panelPrimary.BackColor.GetHex();

                    // LIGHT

                    //000-255-
                    //000-001
                    //(0.13*255)

                    label050.Text = panel050.BackColor.GetHex();
                    label100.Text = panel100.BackColor.GetHex();
                    label200.Text = panel200.BackColor.GetHex();
                    label300.Text = panel300.BackColor.GetHex();
                    label400.Text = panel400.BackColor.GetHex();

                    // BASE COLOR

                    label500.Text = panel500.BackColor.GetHex();

                    // DARK

                    label600.Text = panel600.BackColor.GetHex();
                    label700.Text = panel700.BackColor.GetHex();
                    label800.Text = panel800.BackColor.GetHex();
                    label900.Text = panel900.BackColor.GetHex();

                    // OTHERS

                    labelA100.Text = panelA100.BackColor.GetHex();
                    labelA200.Text = panelA200.BackColor.GetHex();
                    labelA400.Text = panelA400.BackColor.GetHex();
                    labelA700.Text = panelA700.BackColor.GetHex();

                    break;
            }
        }

        private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBoxVisible.Checked;
        }
    }
}