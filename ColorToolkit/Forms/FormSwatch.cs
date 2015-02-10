using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


internal sealed partial class FormSwatch : Form
{

    #region Instance Fields

    private List<Color> _loadedPalette;

    #endregion

    #region Public Constructors

    public FormSwatch(string file)
    {
        InitializeComponent();
        this.LoadFile(file);
    }

    public FormSwatch(List<Color> palette)
    {
        InitializeComponent();
        this._loadedPalette = palette;
    }

    #endregion

    #region Overridden Methods

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Form.Load"/> event.
    /// </summary>
    /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        //this.AddFiles("aco");
    }

    #endregion


    #region Event Handlers

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void LoadFile(string file)
    {
        FileInfo selectedFile = new System.IO.FileInfo(file);


        if (selectedFile != null)
        {
            if (selectedFile.Extension == ".ase")
            {
                _loadedPalette = Swatch.ReadExchangeFile(selectedFile.FullName);
            }
            else
            {
                _loadedPalette = Swatch.ReadSwatchFile(selectedFile.FullName);
            }

            this.Text = string.Format("{0} - {1}", Path.GetFileName(selectedFile.FullName), Application.ProductName);
        }
        else
        {
            _loadedPalette = null;
            this.Text = Application.ProductName;
        }

    }


    #endregion

    private void FormSwatch_Load(object sender, EventArgs e)
    {
        if (_loadedPalette != null)
        {
            this.backgroundWorkerLoadColor.RunWorkerAsync(this.flowLayoutPanelColors);
        }

    }

    private void _color_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(Colors.ToHEX((sender as BufferedPanel).BackColor));
    }

    private void FormSwatch_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (backgroundWorkerLoadColor.IsBusy) backgroundWorkerLoadColor.CancelAsync();
    }

    private void backgroundWorkerLoadColor_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        if (!this.IsDisposed && this.IsHandleCreated)
        {
            foreach (Color color in _loadedPalette)
            {
                try
                {
                    BufferedPanel _color = new BufferedPanel();
                    _color.Width = 32;
                    _color.Height = _color.Width;
                    _color.BorderStyle = BorderStyle.FixedSingle;
                    _color.BackColor = color;
                    _color.Cursor = Cursors.Hand;
                    //_color.Controls.Add(new Label() { Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, ForeColor = System.Drawing.Color.Transparent, Text = (_loadedPalette.IndexOf(color) + 1).ToString() });
                    toolTipColor.SetToolTip(_color, Colors.ToHEX(color));
                    _color.Click += _color_Click;

                    object data = new Control[] { _color };
                    (e.Argument as FlowLayoutPanel).Invoke(new AddItemsDelegate(this.FlowLayoutPanel_Invoke), data);
                }
                catch
                { }
            }
        }
    }

    public delegate void AddItemsDelegate(params Control[] data);
    private void FlowLayoutPanel_Invoke(params Control[] data)
    {
        this.flowLayoutPanelColors.SuspendLayout();
        foreach (Control item in data)
        {
            this.flowLayoutPanelColors.Controls.Add((item as Control));
        }
        this.flowLayoutPanelColors.ResumeLayout();
    }
}
