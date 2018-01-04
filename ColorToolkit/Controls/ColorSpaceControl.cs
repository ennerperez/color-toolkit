using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Toolkit.Controls
{
    public class ColorSpaceControl : UserControl, INotifyPropertyChanged
    {
        [Bindable(true)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override string Text { get; set; }

        private Color color;

        [Bindable(true)]
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                if (color != value)
                {
                    color = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Color"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
            if (e.PropertyName == "Color")
                ColorChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler ColorChanged;
    }
}