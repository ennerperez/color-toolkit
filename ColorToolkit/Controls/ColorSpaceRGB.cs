using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Toolkit.Controls
{
    public partial class ColorSpaceRGB : ColorSpaceControl
    {
        public ColorSpaceRGB()
        {
            InitializeComponent();
            InitializeBinding();
        }

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Color")
            {
                numericUpDownR.ValueChanged -= textBoxC_ValueChanged;
                numericUpDownR.Value = Color.R;
                numericUpDownR.ValueChanged += textBoxC_ValueChanged;
                numericUpDownG.ValueChanged -= textBoxC_ValueChanged;
                numericUpDownG.Value = Color.G;
                numericUpDownG.ValueChanged += textBoxC_ValueChanged;
                numericUpDownB.ValueChanged -= textBoxC_ValueChanged;
                numericUpDownB.Value = Color.B;
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
            Clipboard.SetText(String.Join(",", new string[] { numericUpDownR.Value.ToString(), numericUpDownG.Value.ToString(), numericUpDownB.Value.ToString() }));
        }

        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                labelTitle_LinkClicked(sender, null);
            //else if (e.KeyCode == Keys.Escape)
            //{
            //    numericUpDownR.Value = 0;
            //    numericUpDownG.Value = 0;
            //    numericUpDownB.Value = 0;
            //}
        }

        private void textBoxC_ValueChanged(object sender, EventArgs e)
        {
            Color = Color.FromArgb((int)numericUpDownR.Value, (int)numericUpDownG.Value, (int)numericUpDownB.Value);
        }
    }
}