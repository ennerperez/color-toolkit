using Platform.Support.Drawing;
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

            panel50.BackColor = Color.LightenBy(85);
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

        private void Panel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.Color = (sender as Control).BackColor;
                mainForm.Activate();
            }
        }

        private void ComboBoxColorMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxColorMode.SelectedIndex)
            {
                case 1:

                    labelPrimary.Text = ColorHelper.RGB(panelPrimary.BackColor).ToUpper();

                    // LIGHT

                    //000-255-
                    //000-001
                    //(0.13*255)

                    label50.Text = ColorHelper.RGB(panel50.BackColor);
                    label100.Text = ColorHelper.RGB(panel100.BackColor);
                    label200.Text = ColorHelper.RGB(panel200.BackColor);
                    label300.Text = ColorHelper.RGB(panel300.BackColor);
                    label400.Text = ColorHelper.RGB(panel400.BackColor);

                    // BASE COLOR

                    label500.Text = ColorHelper.RGB(panel500.BackColor);

                    // DARK

                    label600.Text = ColorHelper.RGB(panel600.BackColor);
                    label700.Text = ColorHelper.RGB(panel700.BackColor);
                    label800.Text = ColorHelper.RGB(panel800.BackColor);
                    label900.Text = ColorHelper.RGB(panel900.BackColor);

                    // OTHERS

                    labelA100.Text = ColorHelper.RGB(panelA100.BackColor);
                    labelA200.Text = ColorHelper.RGB(panelA200.BackColor);
                    labelA400.Text = ColorHelper.RGB(panelA400.BackColor);
                    labelA700.Text = ColorHelper.RGB(panelA700.BackColor);

                    break;

                case 2:

                    labelPrimary.Text = ColorHelper.HSB(panelPrimary.BackColor.ToHSB());

                    // LIGHT

                    //000-255-
                    //000-001
                    //(0.13*255)

                    label50.Text = ColorHelper.HSB(panel50.BackColor.ToHSB());
                    label100.Text = ColorHelper.HSB(panel100.BackColor.ToHSB());
                    label200.Text = ColorHelper.HSB(panel200.BackColor.ToHSB());
                    label300.Text = ColorHelper.HSB(panel300.BackColor.ToHSB());
                    label400.Text = ColorHelper.HSB(panel400.BackColor.ToHSB());

                    // BASE COLOR

                    label500.Text = ColorHelper.HSB(panel500.BackColor.ToHSB());

                    // DARK

                    label600.Text = ColorHelper.HSB(panel600.BackColor.ToHSB());
                    label700.Text = ColorHelper.HSB(panel700.BackColor.ToHSB());
                    label800.Text = ColorHelper.HSB(panel800.BackColor.ToHSB());
                    label900.Text = ColorHelper.HSB(panel900.BackColor.ToHSB());

                    // OTHERS

                    labelA100.Text = ColorHelper.HSB(panelA100.BackColor.ToHSB());
                    labelA200.Text = ColorHelper.HSB(panelA200.BackColor.ToHSB());
                    labelA400.Text = ColorHelper.HSB(panelA400.BackColor.ToHSB());
                    labelA700.Text = ColorHelper.HSB(panelA700.BackColor.ToHSB());

                    break;

                default:

                    labelPrimary.Text = panelPrimary.BackColor.ToHEX().ToUpper();

                    // LIGHT

                    //000-255-
                    //000-001
                    //(0.13*255)

                    label50.Text = panel50.BackColor.ToHEX().ToUpper();
                    label100.Text = panel100.BackColor.ToHEX().ToUpper();
                    label200.Text = panel200.BackColor.ToHEX().ToUpper();
                    label300.Text = panel300.BackColor.ToHEX().ToUpper();
                    label400.Text = panel400.BackColor.ToHEX().ToUpper();

                    // BASE COLOR

                    label500.Text = panel500.BackColor.ToHEX().ToUpper();

                    // DARK

                    label600.Text = panel600.BackColor.ToHEX().ToUpper();
                    label700.Text = panel700.BackColor.ToHEX().ToUpper();
                    label800.Text = panel800.BackColor.ToHEX().ToUpper();
                    label900.Text = panel900.BackColor.ToHEX().ToUpper();

                    // OTHERS

                    labelA100.Text = panelA100.BackColor.ToHEX().ToUpper();
                    labelA200.Text = panelA200.BackColor.ToHEX().ToUpper();
                    labelA400.Text = panelA400.BackColor.ToHEX().ToUpper();
                    labelA700.Text = panelA700.BackColor.ToHEX().ToUpper();

                    break;
            }
        }

        private void CheckBoxVisible_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBoxVisible.Checked;
        }
    }
}