using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Toolkit.Controls
{
    public partial class ColorSpaceCMYK : ColorSpaceControl
    {
        public ColorSpaceCMYK()
        {
            InitializeComponent();
            InitializeBinding();
        }

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Color")
            {
                numericUpDownC.ValueChanged -= textBoxC_ValueChanged;
                numericUpDownC.Value = (int)Color.GetCyan();
                numericUpDownC.ValueChanged += textBoxC_ValueChanged;
                numericUpDownM.ValueChanged -= textBoxC_ValueChanged;
                numericUpDownM.Value = (int)Color.GetMagenta();
                numericUpDownM.ValueChanged += textBoxC_ValueChanged;
                numericUpDownY.ValueChanged -= textBoxC_ValueChanged;
                numericUpDownY.Value = (int)Color.GetYellow();
                numericUpDownY.ValueChanged += textBoxC_ValueChanged;
                numericUpDownK.ValueChanged -= textBoxC_ValueChanged;
                numericUpDownK.Value = (int)Color.GetKey();
                numericUpDownK.ValueChanged += textBoxC_ValueChanged;
            }
            base.OnPropertyChanged(e);
        }

        private void InitializeBinding()
        {
            labelTitle.DataBindings.Add("Text", this, "Text");
        }

        private void labelTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(String.Join(",", new string[] { numericUpDownC.Value.ToString(), numericUpDownM.Value.ToString(), numericUpDownY.Value.ToString(), numericUpDownK.Value.ToString() }));
        }

        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                labelTitle_LinkClicked(sender, null);
            //else if (e.KeyCode == Keys.Escape)
            //{
            //    numericUpDownC.Value = 0;
            //    numericUpDownM.Value = 0;
            //    numericUpDownY.Value = 0;
            //    numericUpDown6.Value = 0;
            //}
        }

        private void textBoxC_ValueChanged(object sender, EventArgs e)
        {
            Color = Color.FromCmyk((float)(numericUpDownC.Value / 100), (float)(numericUpDownM.Value / 100), (float)(numericUpDownY.Value / 100), (float)(numericUpDownK.Value / 100));
        }
    }
}