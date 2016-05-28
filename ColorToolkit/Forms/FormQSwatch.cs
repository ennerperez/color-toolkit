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

            this.Color = color;
        }

        private void FormSwatches_Load(object sender, EventArgs e)
        {
            this.panelPrimary.BackColor = this.Color;
            this.panelPrimaryInternal.BackColor = this.panelPrimary.BackColor;
            
            // LIGHT

            //000-255-
            //000-001
            //(0.13*255)

            this.panel50.BackColor = Helpers.LightenBy(this.Color, 85);
            this.panel100.BackColor = Helpers.LightenBy(this.Color, 70);
            this.panel200.BackColor = Helpers.LightenBy(this.Color, 50);
            this.panel300.BackColor = Helpers.LightenBy(this.Color, 31);
            this.panel400.BackColor = Helpers.LightenBy(this.Color, 13);
            
            // BASE COLOR

            this.panel500.BackColor = this.Color;

            // DARK

            this.panel600.BackColor = Helpers.DarkenBy(this.Color, 3);
            this.panel700.BackColor = Helpers.DarkenBy(this.Color, 18);
            this.panel800.BackColor = Helpers.DarkenBy(this.Color, 36);
            this.panel900.BackColor = Helpers.DarkenBy(this.Color, 48);

            // OTHERS

            this.panelA100.BackColor = Helpers.DarkenBy(this.panel100.BackColor, 10);
            this.panelA200.BackColor = Helpers.DarkenBy(this.panel200.BackColor, 30);
            this.panelA400.BackColor = Helpers.DarkenBy(this.panel400.BackColor, 45);
            this.panelA700.BackColor = Helpers.DarkenBy(this.panel700.BackColor, 60);

            // Resolution fix
            if (this.Height > Program.GetWorkingArea().Height)
            {
                this.Height = this.MinimumSize.Height;
            }

            this.comboBoxColorMode.SelectedIndex = 0;
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender.GetType() != typeof(Label)) {
                switch (this.comboBoxColorMode.SelectedIndex)
                {
                    case 1:
                        Clipboard.SetText(Helpers.ToRGB((sender as Panel).BackColor)); 
                        break;
                    default:
                        Clipboard.SetText(Helpers.ToHEX((sender as Panel).BackColor));
                        break;
                }
            }
            else
            {
                switch (this.comboBoxColorMode.SelectedIndex)
                {
                    case 1:
                        Clipboard.SetText(Helpers.ToRGB((sender as Label).Parent.BackColor));
                        break;
                    default:
                        Clipboard.SetText(Helpers.ToHEX((sender as Label).Parent.BackColor)); 
                        break;
                }
            }
        }

        private void comboBoxColorMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxColorMode.SelectedIndex)
            {
                case 1:

                    this.labelPrimary.Text = Helpers.ToRGB(this.panelPrimary.BackColor).ToUpper();

                    // LIGHT

                    //000-255-
                    //000-001
                    //(0.13*255)

                    this.label50.Text = Helpers.ToRGB(this.panel50.BackColor);
                    this.label100.Text = Helpers.ToRGB(this.panel100.BackColor);
                    this.label200.Text = Helpers.ToRGB(this.panel200.BackColor);
                    this.label300.Text = Helpers.ToRGB(this.panel300.BackColor);
                    this.label400.Text = Helpers.ToRGB(this.panel400.BackColor);

                    // BASE COLOR

                    this.label500.Text = Helpers.ToRGB(this.panel500.BackColor).ToUpper();

                    // DARK

                    this.label600.Text = Helpers.ToRGB(this.panel600.BackColor).ToUpper();
                    this.label700.Text = Helpers.ToRGB(this.panel700.BackColor).ToUpper();
                    this.label800.Text = Helpers.ToRGB(this.panel800.BackColor).ToUpper();
                    this.label900.Text = Helpers.ToRGB(this.panel900.BackColor).ToUpper();

                    // OTHERS

                    this.labelA100.Text = Helpers.ToRGB(this.panelA100.BackColor).ToUpper();
                    this.labelA200.Text = Helpers.ToRGB(this.panelA200.BackColor).ToUpper();
                    this.labelA400.Text = Helpers.ToRGB(this.panelA400.BackColor).ToUpper();
                    this.labelA700.Text = Helpers.ToRGB(this.panelA700.BackColor).ToUpper();

                    break;
                default:

                    this.labelPrimary.Text = Helpers.ToHEX(this.panelPrimary.BackColor).ToUpper();

                    // LIGHT

                    //000-255-
                    //000-001
                    //(0.13*255)

                    this.label50.Text = Helpers.ToHEX(this.panel50.BackColor).ToUpper();
                    this.label100.Text = Helpers.ToHEX(this.panel100.BackColor).ToUpper();
                    this.label200.Text = Helpers.ToHEX(this.panel200.BackColor).ToUpper();
                    this.label300.Text = Helpers.ToHEX(this.panel300.BackColor).ToUpper();
                    this.label400.Text = Helpers.ToHEX(this.panel400.BackColor).ToUpper();

                    // BASE COLOR

                    this.label500.Text = Helpers.ToHEX(this.panel500.BackColor).ToUpper();

                    // DARK

                    this.label600.Text = Helpers.ToHEX(this.panel600.BackColor).ToUpper();
                    this.label700.Text = Helpers.ToHEX(this.panel700.BackColor).ToUpper();
                    this.label800.Text = Helpers.ToHEX(this.panel800.BackColor).ToUpper();
                    this.label900.Text = Helpers.ToHEX(this.panel900.BackColor).ToUpper();

                    // OTHERS

                    this.labelA100.Text = Helpers.ToHEX(this.panelA100.BackColor).ToUpper();
                    this.labelA200.Text = Helpers.ToHEX(this.panelA200.BackColor).ToUpper();
                    this.labelA400.Text = Helpers.ToHEX(this.panelA400.BackColor).ToUpper();
                    this.labelA700.Text = Helpers.ToHEX(this.panelA700.BackColor).ToUpper();

                    break;
            }
        }

        private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = this.checkBoxVisible.Checked;
        }
    }
}
