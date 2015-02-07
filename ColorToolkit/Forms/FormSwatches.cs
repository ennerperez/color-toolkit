using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorToolkit
{
    public partial class FormSwatches : Form
    {
        public Color Color { get; set; }

        public FormSwatches(Color color)
        {
            InitializeComponent();
            this.Color = color;
        }

        private void FormSwatches_Load(object sender, EventArgs e)
        {
            this.panelPrimary.BackColor = this.Color;
            this.labelPrimary.Text = ExtensionMethods.ToHEX(this.panelPrimary.BackColor).ToUpper();

            // LIGHT

            this.panel50.BackColor = ExtensionMethods.LightenBy(this.Color, 90);
            this.label50.Text = ExtensionMethods.ToHEX(this.panel50.BackColor).ToUpper();

            this.panel100.BackColor = ExtensionMethods.LightenBy(this.Color, 60);
            this.label100.Text = ExtensionMethods.ToHEX(this.panel100.BackColor).ToUpper();

            this.panel200.BackColor = ExtensionMethods.LightenBy(this.Color, 45);
            this.label200.Text = ExtensionMethods.ToHEX(this.panel200.BackColor).ToUpper();

            this.panel300.BackColor = ExtensionMethods.LightenBy(this.Color, 30);
            this.label300.Text = ExtensionMethods.ToHEX(this.panel300.BackColor).ToUpper();

            this.panel400.BackColor = ExtensionMethods.LightenBy(this.Color, 10);
            this.label400.Text = ExtensionMethods.ToHEX(this.panel400.BackColor).ToUpper();

            // BASE COLOR
            this.panel500.BackColor = ExtensionMethods.ChangeColorBrightness(this.Color, 0.0f);
            this.label500.Text = ExtensionMethods.ToHEX(this.panel500.BackColor).ToUpper();

            // DARK

            this.panel600.BackColor = ExtensionMethods.DarkenBy(this.Color, 10);
            this.label600.Text = ExtensionMethods.ToHEX(this.panel600.BackColor).ToUpper();

            this.panel700.BackColor = ExtensionMethods.DarkenBy(this.Color, 20);
            this.label700.Text = ExtensionMethods.ToHEX(this.panel700.BackColor).ToUpper();

            this.panel800.BackColor = ExtensionMethods.DarkenBy(this.Color, 30);
            this.label800.Text = ExtensionMethods.ToHEX(this.panel800.BackColor).ToUpper();

            this.panel900.BackColor = ExtensionMethods.DarkenBy(this.Color, 40);
            this.label900.Text = ExtensionMethods.ToHEX(this.panel900.BackColor).ToUpper();

            // OTHERS

            this.panelA100.BackColor = ExtensionMethods.DarkenBy(this.panel100.BackColor, 10);
            this.labelA100.Text = ExtensionMethods.ToHEX(this.panelA100.BackColor).ToUpper();

            this.panelA200.BackColor = ExtensionMethods.DarkenBy(this.panel200.BackColor, 30);
            this.labelA200.Text = ExtensionMethods.ToHEX(this.panelA200.BackColor).ToUpper();

            this.panelA400.BackColor = ExtensionMethods.DarkenBy(this.panel400.BackColor, 45);
            this.labelA400.Text = ExtensionMethods.ToHEX(this.panelA400.BackColor).ToUpper();

            this.panelA700.BackColor = ExtensionMethods.DarkenBy(this.panel700.BackColor, 60);
            this.labelA700.Text = ExtensionMethods.ToHEX(this.panelA700.BackColor).ToUpper();

            // Resolution fix
            if (this.Height > Program.GetWorkingArea().Height)
            {
                this.Height = this.MinimumSize.Height;
            }


        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText( ExtensionMethods.ToHEX((sender as Panel).BackColor));
        }



    }
}
