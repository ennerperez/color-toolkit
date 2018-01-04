using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Toolkit.Controls
{
    public partial class ColorSpaceHSB : ColorSpaceControl
    {
        public ColorSpaceHSB()
        {
            InitializeComponent();
            InitializeBinding();
        }

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Color")
            {
                numericUpDownH.ValueChanged -= textBoxC_ValueChanged;
                numericUpDownH.Value = (int)Color.GetHue();
                numericUpDownH.ValueChanged += textBoxC_ValueChanged;
                numericUpDownS.ValueChanged -= textBoxC_ValueChanged;
                numericUpDownS.Value = (int)Color.GetRelativeSaturation();
                numericUpDownS.ValueChanged += textBoxC_ValueChanged;
                numericUpDownB.ValueChanged -= textBoxC_ValueChanged;
                numericUpDownB.Value = (int)Color.GetRelativeBrightness();
                numericUpDownB.ValueChanged += textBoxC_ValueChanged;
            }
            base.OnPropertyChanged(e);
        }

        private void InitializeBinding()
        {
            labelTitle.DataBindings.Add("Text", this, "Text");
        }

        private void labelTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(String.Join(",", new string[] { ((int)numericUpDownH.Value).ToString(), ((int)numericUpDownS.Value).ToString(), ((int)numericUpDownB.Value).ToString() }));
        }

        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                labelTitle_LinkClicked(sender, null);
            //else if (e.KeyCode == Keys.Escape)
            //{
            //    numericUpDownH.Value = 0;
            //    numericUpDownS.Value = 0;
            //    numericUpDownB.Value = 0;
            //}
        }

        private void textBoxC_ValueChanged(object sender, EventArgs e)
        {
            Color = Color.FromHsb((float)(numericUpDownH.Value), (float)(numericUpDownS.Value / 100), (float)(numericUpDownB.Value / 100));
        }
    }
}