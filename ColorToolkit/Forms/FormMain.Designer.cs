namespace Toolkit.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelHEX = new System.Windows.Forms.Label();
            this.textBoxHEX = new System.Windows.Forms.TextBox();
            this.buttonCopyHEX = new System.Windows.Forms.Button();
            this.labelRGB = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.NumericUpDown();
            this.textBoxG = new System.Windows.Forms.NumericUpDown();
            this.textBoxB = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanelRGB = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCopyRGB = new System.Windows.Forms.Button();
            this.colorDialogPicker = new System.Windows.Forms.ColorDialog();
            this.buttonPicture = new System.Windows.Forms.Button();
            this.buttonQSwatch = new System.Windows.Forms.Button();
            this.openFileDialogPicture = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenSwatch = new System.Windows.Forms.Button();
            this.openFileDialogSwatch = new System.Windows.Forms.OpenFileDialog();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxB)).BeginInit();
            this.tableLayoutPanelRGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            resources.ApplyResources(this.panelColor, "panelColor");
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelColor.Name = "panelColor";
            this.toolTipMain.SetToolTip(this.panelColor, resources.GetString("panelColor.ToolTip"));
            this.panelColor.DoubleClick += new System.EventHandler(this.panelColor_DoubleClick);
            this.panelColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseClick);
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseMove);
            this.panelColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseUp);
            // 
            // labelHEX
            // 
            resources.ApplyResources(this.labelHEX, "labelHEX");
            this.labelHEX.Name = "labelHEX";
            // 
            // textBoxHEX
            // 
            resources.ApplyResources(this.textBoxHEX, "textBoxHEX");
            this.textBoxHEX.Name = "textBoxHEX";
            this.textBoxHEX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHEX_KeyDown);
            this.textBoxHEX.Leave += new System.EventHandler(this.textBoxHEX_Leave);
            // 
            // buttonCopyHEX
            // 
            resources.ApplyResources(this.buttonCopyHEX, "buttonCopyHEX");
            this.buttonCopyHEX.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCopyHEX.Name = "buttonCopyHEX";
            this.toolTipMain.SetToolTip(this.buttonCopyHEX, resources.GetString("buttonCopyHEX.ToolTip"));
            this.buttonCopyHEX.UseVisualStyleBackColor = true;
            this.buttonCopyHEX.Click += new System.EventHandler(this.buttonCopiarHEX_Click);
            // 
            // labelRGB
            // 
            resources.ApplyResources(this.labelRGB, "labelRGB");
            this.labelRGB.Name = "labelRGB";
            // 
            // textBoxR
            // 
            this.textBoxR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxR, "textBoxR");
            this.textBoxR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRGB_KeyDown);
            this.textBoxR.Leave += new System.EventHandler(this.textBoxRGB_Leave);
            // 
            // textBoxG
            // 
            this.textBoxG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxG, "textBoxG");
            this.textBoxG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRGB_KeyDown);
            this.textBoxG.Leave += new System.EventHandler(this.textBoxRGB_Leave);
            // 
            // textBoxB
            // 
            this.textBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxB, "textBoxB");
            this.textBoxB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRGB_KeyDown);
            this.textBoxB.Leave += new System.EventHandler(this.textBoxRGB_Leave);
            // 
            // tableLayoutPanelRGB
            // 
            resources.ApplyResources(this.tableLayoutPanelRGB, "tableLayoutPanelRGB");
            this.tableLayoutPanelRGB.Controls.Add(this.textBoxR, 0, 0);
            this.tableLayoutPanelRGB.Controls.Add(this.textBoxB, 2, 0);
            this.tableLayoutPanelRGB.Controls.Add(this.textBoxG, 1, 0);
            this.tableLayoutPanelRGB.Name = "tableLayoutPanelRGB";
            // 
            // buttonCopyRGB
            // 
            resources.ApplyResources(this.buttonCopyRGB, "buttonCopyRGB");
            this.buttonCopyRGB.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCopyRGB.Name = "buttonCopyRGB";
            this.toolTipMain.SetToolTip(this.buttonCopyRGB, resources.GetString("buttonCopyRGB.ToolTip"));
            this.buttonCopyRGB.UseVisualStyleBackColor = true;
            this.buttonCopyRGB.Click += new System.EventHandler(this.buttonCopiarRGB_Click);
            // 
            // colorDialogPicker
            // 
            this.colorDialogPicker.AnyColor = true;
            this.colorDialogPicker.FullOpen = true;
            // 
            // buttonPicture
            // 
            resources.ApplyResources(this.buttonPicture, "buttonPicture");
            this.buttonPicture.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPicture.Name = "buttonPicture";
            this.toolTipMain.SetToolTip(this.buttonPicture, resources.GetString("buttonPicture.ToolTip"));
            this.buttonPicture.UseVisualStyleBackColor = true;
            this.buttonPicture.Click += new System.EventHandler(this.buttonPicture_Click);
            // 
            // buttonQSwatch
            // 
            resources.ApplyResources(this.buttonQSwatch, "buttonQSwatch");
            this.buttonQSwatch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonQSwatch.Name = "buttonQSwatch";
            this.toolTipMain.SetToolTip(this.buttonQSwatch, resources.GetString("buttonQSwatch.ToolTip"));
            this.buttonQSwatch.UseVisualStyleBackColor = true;
            this.buttonQSwatch.Click += new System.EventHandler(this.buttonQSwatch_Click);
            // 
            // openFileDialogPicture
            // 
            this.openFileDialogPicture.DefaultExt = "*.jpg";
            resources.ApplyResources(this.openFileDialogPicture, "openFileDialogPicture");
            this.openFileDialogPicture.Multiselect = true;
            this.openFileDialogPicture.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogPicture_FileOk);
            // 
            // buttonOpenSwatch
            // 
            resources.ApplyResources(this.buttonOpenSwatch, "buttonOpenSwatch");
            this.buttonOpenSwatch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonOpenSwatch.Name = "buttonOpenSwatch";
            this.toolTipMain.SetToolTip(this.buttonOpenSwatch, resources.GetString("buttonOpenSwatch.ToolTip"));
            this.buttonOpenSwatch.UseVisualStyleBackColor = true;
            this.buttonOpenSwatch.Click += new System.EventHandler(this.buttonOpenSwatch_Click);
            // 
            // openFileDialogSwatch
            // 
            this.openFileDialogSwatch.DefaultExt = "*.ase";
            resources.ApplyResources(this.openFileDialogSwatch, "openFileDialogSwatch");
            this.openFileDialogSwatch.Multiselect = true;
            this.openFileDialogSwatch.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogSwatch_FileOk);
            // 
            // buttonAbout
            // 
            resources.ApplyResources(this.buttonAbout, "buttonAbout");
            this.buttonAbout.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAbout.Name = "buttonAbout";
            this.toolTipMain.SetToolTip(this.buttonAbout, resources.GetString("buttonAbout.ToolTip"));
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonOpenSwatch);
            this.Controls.Add(this.buttonQSwatch);
            this.Controls.Add(this.buttonPicture);
            this.Controls.Add(this.tableLayoutPanelRGB);
            this.Controls.Add(this.buttonCopyRGB);
            this.Controls.Add(this.buttonCopyHEX);
            this.Controls.Add(this.textBoxHEX);
            this.Controls.Add(this.labelRGB);
            this.Controls.Add(this.labelHEX);
            this.Controls.Add(this.panelColor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.textBoxR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxB)).EndInit();
            this.tableLayoutPanelRGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label labelHEX;
        private System.Windows.Forms.TextBox textBoxHEX;
        private System.Windows.Forms.Button buttonCopyHEX;
        private System.Windows.Forms.Label labelRGB;
        private System.Windows.Forms.NumericUpDown textBoxR;
        private System.Windows.Forms.NumericUpDown textBoxG;
        private System.Windows.Forms.NumericUpDown textBoxB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRGB;
        private System.Windows.Forms.Button buttonCopyRGB;
        private System.Windows.Forms.ColorDialog colorDialogPicker;
        private System.Windows.Forms.Button buttonPicture;
        private System.Windows.Forms.Button buttonQSwatch;
        private System.Windows.Forms.OpenFileDialog openFileDialogPicture;
        private System.Windows.Forms.Button buttonOpenSwatch;
        private System.Windows.Forms.OpenFileDialog openFileDialogSwatch;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.ToolTip toolTipMain;
    }
}

