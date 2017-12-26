using Platform.Support.Drawing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Toolkit.Forms
{
    internal sealed partial class FormSwatch : Form
    {
        #region Instance Fields

        private IEnumerable<Color> _loadedPalette;

        #endregion Instance Fields

        #region Public Constructors

        public FormSwatch(string file)
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetEntryAssembly().Location);

            LoadFile(file);
        }

        public FormSwatch(List<Color> palette)
        {
            InitializeComponent();
            _loadedPalette = palette;
        }

        #endregion Public Constructors

        #region Overridden Methods

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load"/> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        #endregion Overridden Methods

        #region Event Handlers

        private void LoadFile(string file)
        {
            var selectedFile = new FileInfo(file);

            if (selectedFile != null)
            {
                if (selectedFile.Extension == ".ase")
                    _loadedPalette = Swatch.ReadExchangeFile(selectedFile.FullName);
                else
                    _loadedPalette = Swatch.ReadSwatchFile(selectedFile.FullName);

                Text = string.Format("{0} - {1}", Path.GetFileName(selectedFile.FullName), Application.ProductName);
            }
            else
            {
                _loadedPalette = null;
                Text = Application.ProductName;
            }
        }

        #endregion Event Handlers

        private void FormSwatch_Load(object sender, EventArgs e)
        {
            if (_loadedPalette != null)
                backgroundWorkerLoadColor.RunWorkerAsync(flowLayoutPanelColors);
        }

        private void _color_Click(object sender, EventArgs e)
        {
            Clipboard.SetText((sender as BufferedPanel).BackColor.ToHEX());
        }

        private void FormSwatch_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (backgroundWorkerLoadColor.IsBusy)
                backgroundWorkerLoadColor.CancelAsync();
        }

        private void backgroundWorkerLoadColor_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (!IsDisposed && IsHandleCreated)
            {
                foreach (var color in _loadedPalette)
                {
                    try
                    {
                        var _color = new BufferedPanel()
                        {
                            Width = 32,
                            Height = 32,
                            BorderStyle = BorderStyle.FixedSingle,
                            BackColor = color,
                            Cursor = Cursors.Hand
                        };
                        toolTipColor.SetToolTip(_color, color.ToHEX());
                        _color.Click += _color_Click;

                        object data = new Control[] { _color };
                        (e.Argument as FlowLayoutPanel).Invoke(new AddItemsDelegate(FlowLayoutPanel_Invoke), data);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
            }
        }

        public delegate void AddItemsDelegate(params Control[] data);

        private void FlowLayoutPanel_Invoke(params Control[] data)
        {
            flowLayoutPanelColors.SuspendLayout();
            foreach (Control item in data)
                flowLayoutPanelColors.Controls.Add((item as Control));
            flowLayoutPanelColors.ResumeLayout();
        }
    }
}