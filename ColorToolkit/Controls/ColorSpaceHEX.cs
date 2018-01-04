using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Toolkit.Controls
{
    public partial class ColorSpaceHEX : ColorSpaceControl
    {
        public ColorSpaceHEX()
        {
            InitializeComponent();
            InitializeBinding();
        }

        private void InitializeBinding()
        {
            labelTitle.DataBindings.Add("Text", this, "Text");
        }

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Color")
                textBoxHEX.Text = Color.GetHex();
            base.OnPropertyChanged(e);
        }

        private void labelHEX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(textBoxHEX.Text);
        }

        private void textBoxHEX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                labelHEX_LinkClicked(sender, null);
            //else if (e.KeyCode == Keys.Escape)
            //    textBoxHEX.Text = string.Empty;
        }

        private void textBoxHEX_TextChanged(object sender, EventArgs e)
        {
            Color = Color.FromHex(textBoxHEX.Text);
        }
    }
}