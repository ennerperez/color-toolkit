using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorToolkit
{
    public partial class FormQSwatch : Form
    {
        public Color Color { get; set; }

        public FormQSwatch(Color color)
        {
            InitializeComponent();
            this.Color = color;
        }

        private void FormSwatches_Load(object sender, EventArgs e)
        {
            this.panelPrimary.BackColor = this.Color;
            this.labelPrimary.Text = Colors.ToHEX(this.panelPrimary.BackColor).ToUpper();

            // LIGHT

            //000-255-
            //000-001
            //(0.13*255)

            this.panel50.BackColor =  Colors.LightenBy(this.Color, 85);
            this.label50.Text = Colors.ToHEX(this.panel50.BackColor).ToUpper();

            this.panel100.BackColor = Colors.LightenBy(this.Color, 70);
            this.label100.Text = Colors.ToHEX(this.panel100.BackColor).ToUpper();

            this.panel200.BackColor = Colors.LightenBy(this.Color, 50);
            this.label200.Text = Colors.ToHEX(this.panel200.BackColor).ToUpper();

            this.panel300.BackColor = Colors.LightenBy(this.Color, 31);
            this.label300.Text = Colors.ToHEX(this.panel300.BackColor).ToUpper();

            this.panel400.BackColor = Colors.LightenBy(this.Color, 13);
            this.label400.Text = Colors.ToHEX(this.panel400.BackColor).ToUpper();


            // BASE COLOR
            this.panel500.BackColor = this.Color;
            this.label500.Text = Colors.ToHEX(this.panel500.BackColor).ToUpper();

            // DARK

            this.panel600.BackColor = Colors.DarkenBy(this.Color, 3);
            this.label600.Text = Colors.ToHEX(this.panel600.BackColor).ToUpper();

            this.panel700.BackColor = Colors.DarkenBy(this.Color, 18);
            this.label700.Text = Colors.ToHEX(this.panel700.BackColor).ToUpper();

            this.panel800.BackColor = Colors.DarkenBy(this.Color, 36);
            this.label800.Text = Colors.ToHEX(this.panel800.BackColor).ToUpper();

            this.panel900.BackColor = Colors.DarkenBy(this.Color, 48);
            this.label900.Text = Colors.ToHEX(this.panel900.BackColor).ToUpper();

            // OTHERS

            this.panelA100.BackColor = Colors.DarkenBy(this.panel100.BackColor, 10);
            this.labelA100.Text = Colors.ToHEX(this.panelA100.BackColor).ToUpper();

            this.panelA200.BackColor = Colors.DarkenBy(this.panel200.BackColor, 30);
            this.labelA200.Text = Colors.ToHEX(this.panelA200.BackColor).ToUpper();

            this.panelA400.BackColor = Colors.DarkenBy(this.panel400.BackColor, 45);
            this.labelA400.Text = Colors.ToHEX(this.panelA400.BackColor).ToUpper();

            this.panelA700.BackColor = Colors.DarkenBy(this.panel700.BackColor, 60);
            this.labelA700.Text = Colors.ToHEX(this.panelA700.BackColor).ToUpper();

            // Resolution fix
            if (this.Height > Program.GetWorkingArea().Height)
            {
                this.Height = this.MinimumSize.Height;
            }


        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText( Colors.ToHEX((sender as Panel).BackColor));
        }



    }
}
