using Platform.Support.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Toolkit.Forms
{
    public partial class FormQSwatch : Form
    {
        public Color Color { get; set; }

        public FormQSwatch(Color color)
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetEntryAssembly().Location);

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
            if (Height > FormHelpers.GetWorkingArea().Height)
            {
                Height = MinimumSize.Height;
            }

            comboBoxColorMode.SelectedIndex = 0;
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender.GetType() != typeof(Label))
            {
                switch (comboBoxColorMode.SelectedIndex)
                {
                    case 1:
                        Clipboard.SetText(ColorHelpers.RGB((sender as Panel).BackColor));
                        break;
                    case 2:
                        Clipboard.SetText(ColorHelpers.HSB((sender as Panel).BackColor.ToHSB()));
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
                        Clipboard.SetText(ColorHelpers.RGB((sender as Label).Parent.BackColor));
                        break;
                    case 2:
                        Clipboard.SetText(ColorHelpers.HSB((sender as Label).Parent.BackColor.ToHSB()));
                        break;
                    default:
                        Clipboard.SetText((sender as Label).Parent.BackColor.ToHEX());
                        break;
                }
            }
        }

        private void comboBoxColorMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxColorMode.SelectedIndex)
            {
                case 1:

                    labelPrimary.Text = ColorHelpers.RGB(panelPrimary.BackColor).ToUpper();

                    // LIGHT

                    //000-255-
                    //000-001
                    //(0.13*255)

                    label50.Text = ColorHelpers.RGB(panel50.BackColor);
                    label100.Text = ColorHelpers.RGB(panel100.BackColor);
                    label200.Text = ColorHelpers.RGB(panel200.BackColor);
                    label300.Text = ColorHelpers.RGB(panel300.BackColor);
                    label400.Text = ColorHelpers.RGB(panel400.BackColor);

                    // BASE COLOR

                    label500.Text = ColorHelpers.RGB(panel500.BackColor);

                    // DARK

                    label600.Text = ColorHelpers.RGB(panel600.BackColor);
                    label700.Text = ColorHelpers.RGB(panel700.BackColor);
                    label800.Text = ColorHelpers.RGB(panel800.BackColor);
                    label900.Text = ColorHelpers.RGB(panel900.BackColor);

                    // OTHERS

                    labelA100.Text = ColorHelpers.RGB(panelA100.BackColor);
                    labelA200.Text = ColorHelpers.RGB(panelA200.BackColor);
                    labelA400.Text = ColorHelpers.RGB(panelA400.BackColor);
                    labelA700.Text = ColorHelpers.RGB(panelA700.BackColor);

                    break;

                case 2:

                    labelPrimary.Text = ColorHelpers.HSB(panelPrimary.BackColor.ToHSB());

                    // LIGHT

                    //000-255-
                    //000-001
                    //(0.13*255)

                    label50.Text = ColorHelpers.HSB(panel50.BackColor.ToHSB());
                    label100.Text = ColorHelpers.HSB(panel100.BackColor.ToHSB());
                    label200.Text = ColorHelpers.HSB(panel200.BackColor.ToHSB());
                    label300.Text = ColorHelpers.HSB(panel300.BackColor.ToHSB());
                    label400.Text = ColorHelpers.HSB(panel400.BackColor.ToHSB());

                    // BASE COLOR

                    label500.Text = ColorHelpers.HSB(panel500.BackColor.ToHSB());

                    // DARK

                    label600.Text = ColorHelpers.HSB(panel600.BackColor.ToHSB());
                    label700.Text = ColorHelpers.HSB(panel700.BackColor.ToHSB());
                    label800.Text = ColorHelpers.HSB(panel800.BackColor.ToHSB());
                    label900.Text = ColorHelpers.HSB(panel900.BackColor.ToHSB());

                    // OTHERS

                    labelA100.Text = ColorHelpers.HSB(panelA100.BackColor.ToHSB());
                    labelA200.Text = ColorHelpers.HSB(panelA200.BackColor.ToHSB());
                    labelA400.Text = ColorHelpers.HSB(panelA400.BackColor.ToHSB());
                    labelA700.Text = ColorHelpers.HSB(panelA700.BackColor.ToHSB());

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

        private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBoxVisible.Checked;
        }
    }
}
