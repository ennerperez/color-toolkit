namespace ColorToolkit
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
            this.panelColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelColor.BackgroundImage")));
            this.panelColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelColor.Location = new System.Drawing.Point(12, 12);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(56, 56);
            this.panelColor.TabIndex = 0;
            this.toolTipMain.SetToolTip(this.panelColor, "Press for color picker / Double click for color  picker");
            this.panelColor.DoubleClick += new System.EventHandler(this.panelColor_DoubleClick);
            this.panelColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseClick);
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseMove);
            this.panelColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseUp);
            // 
            // labelHEX
            // 
            this.labelHEX.Location = new System.Drawing.Point(74, 11);
            this.labelHEX.Name = "labelHEX";
            this.labelHEX.Size = new System.Drawing.Size(35, 25);
            this.labelHEX.TabIndex = 1;
            this.labelHEX.Text = "&HEX:";
            this.labelHEX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxHEX
            // 
            this.textBoxHEX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHEX.Location = new System.Drawing.Point(115, 12);
            this.textBoxHEX.MaxLength = 7;
            this.textBoxHEX.Name = "textBoxHEX";
            this.textBoxHEX.Size = new System.Drawing.Size(164, 25);
            this.textBoxHEX.TabIndex = 2;
            this.textBoxHEX.Text = "#000000";
            this.textBoxHEX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHEX_KeyDown);
            this.textBoxHEX.Leave += new System.EventHandler(this.textBoxHEX_Leave);
            // 
            // buttonCopyHEX
            // 
            this.buttonCopyHEX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyHEX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCopyHEX.BackgroundImage")));
            this.buttonCopyHEX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCopyHEX.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCopyHEX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyHEX.Location = new System.Drawing.Point(285, 12);
            this.buttonCopyHEX.Name = "buttonCopyHEX";
            this.buttonCopyHEX.Size = new System.Drawing.Size(25, 25);
            this.buttonCopyHEX.TabIndex = 3;
            this.toolTipMain.SetToolTip(this.buttonCopyHEX, "Copy as HEX");
            this.buttonCopyHEX.UseVisualStyleBackColor = true;
            this.buttonCopyHEX.Click += new System.EventHandler(this.buttonCopiarHEX_Click);
            // 
            // labelRGB
            // 
            this.labelRGB.Location = new System.Drawing.Point(74, 43);
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.Size = new System.Drawing.Size(35, 25);
            this.labelRGB.TabIndex = 6;
            this.labelRGB.Text = "R&GB:";
            this.labelRGB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxR
            // 
            this.textBoxR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxR.Location = new System.Drawing.Point(0, 0);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.textBoxR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(51, 25);
            this.textBoxR.TabIndex = 0;
            this.textBoxR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRGB_KeyDown);
            this.textBoxR.Leave += new System.EventHandler(this.textBoxRGB_Leave);
            // 
            // textBoxG
            // 
            this.textBoxG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxG.Location = new System.Drawing.Point(57, 0);
            this.textBoxG.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(48, 25);
            this.textBoxG.TabIndex = 1;
            this.textBoxG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRGB_KeyDown);
            this.textBoxG.Leave += new System.EventHandler(this.textBoxRGB_Leave);
            // 
            // textBoxB
            // 
            this.textBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxB.Location = new System.Drawing.Point(111, 0);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.textBoxB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(53, 25);
            this.textBoxB.TabIndex = 2;
            this.textBoxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRGB_KeyDown);
            this.textBoxB.Leave += new System.EventHandler(this.textBoxRGB_Leave);
            // 
            // tableLayoutPanelRGB
            // 
            this.tableLayoutPanelRGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelRGB.ColumnCount = 3;
            this.tableLayoutPanelRGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelRGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelRGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelRGB.Controls.Add(this.textBoxR, 0, 0);
            this.tableLayoutPanelRGB.Controls.Add(this.textBoxB, 2, 0);
            this.tableLayoutPanelRGB.Controls.Add(this.textBoxG, 1, 0);
            this.tableLayoutPanelRGB.Location = new System.Drawing.Point(115, 43);
            this.tableLayoutPanelRGB.Name = "tableLayoutPanelRGB";
            this.tableLayoutPanelRGB.RowCount = 1;
            this.tableLayoutPanelRGB.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRGB.Size = new System.Drawing.Size(164, 25);
            this.tableLayoutPanelRGB.TabIndex = 7;
            // 
            // buttonCopyRGB
            // 
            this.buttonCopyRGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyRGB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCopyRGB.BackgroundImage")));
            this.buttonCopyRGB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCopyRGB.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCopyRGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyRGB.Location = new System.Drawing.Point(285, 43);
            this.buttonCopyRGB.Name = "buttonCopyRGB";
            this.buttonCopyRGB.Size = new System.Drawing.Size(25, 25);
            this.buttonCopyRGB.TabIndex = 8;
            this.toolTipMain.SetToolTip(this.buttonCopyRGB, "Copy as RGB");
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
            this.buttonPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPicture.BackgroundImage")));
            this.buttonPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPicture.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPicture.Location = new System.Drawing.Point(347, 12);
            this.buttonPicture.Name = "buttonPicture";
            this.buttonPicture.Size = new System.Drawing.Size(25, 25);
            this.buttonPicture.TabIndex = 5;
            this.toolTipMain.SetToolTip(this.buttonPicture, "Open picture");
            this.buttonPicture.UseVisualStyleBackColor = true;
            this.buttonPicture.Click += new System.EventHandler(this.buttonPicture_Click);
            // 
            // buttonQSwatch
            // 
            this.buttonQSwatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQSwatch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonQSwatch.BackgroundImage")));
            this.buttonQSwatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonQSwatch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonQSwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQSwatch.Location = new System.Drawing.Point(316, 43);
            this.buttonQSwatch.Name = "buttonQSwatch";
            this.buttonQSwatch.Size = new System.Drawing.Size(25, 25);
            this.buttonQSwatch.TabIndex = 9;
            this.toolTipMain.SetToolTip(this.buttonQSwatch, "Generate quick swatch");
            this.buttonQSwatch.UseVisualStyleBackColor = true;
            this.buttonQSwatch.Click += new System.EventHandler(this.buttonQSwatch_Click);
            // 
            // openFileDialogPicture
            // 
            this.openFileDialogPicture.DefaultExt = "*.jpg";
            this.openFileDialogPicture.Filter = "Valid files|*.bmp;*.gif;*.jpeg;*.jpg;*.png|All files|*.*";
            this.openFileDialogPicture.Multiselect = true;
            this.openFileDialogPicture.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogPicture_FileOk);
            // 
            // buttonOpenSwatch
            // 
            this.buttonOpenSwatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenSwatch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenSwatch.BackgroundImage")));
            this.buttonOpenSwatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenSwatch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonOpenSwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSwatch.Location = new System.Drawing.Point(316, 12);
            this.buttonOpenSwatch.Name = "buttonOpenSwatch";
            this.buttonOpenSwatch.Size = new System.Drawing.Size(25, 25);
            this.buttonOpenSwatch.TabIndex = 4;
            this.toolTipMain.SetToolTip(this.buttonOpenSwatch, "Open swatch");
            this.buttonOpenSwatch.UseVisualStyleBackColor = true;
            this.buttonOpenSwatch.Click += new System.EventHandler(this.buttonOpenSwatch_Click);
            // 
            // openFileDialogSwatch
            // 
            this.openFileDialogSwatch.DefaultExt = "*.ase";
            this.openFileDialogSwatch.Filter = "Valid files|*.ase;*.aco|Adobe Swatch Exchange File|*.ase|Adobe Photoshop Color Fi" +
    "le|*.aco|All files|*.*";
            this.openFileDialogSwatch.Multiselect = true;
            this.openFileDialogSwatch.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogSwatch_FileOk);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAbout.BackgroundImage")));
            this.buttonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAbout.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Location = new System.Drawing.Point(347, 43);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(25, 25);
            this.buttonAbout.TabIndex = 10;
            this.toolTipMain.SetToolTip(this.buttonAbout, "About");
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(384, 80);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 119);
            this.MinimumSize = new System.Drawing.Size(400, 119);
            this.Name = "FormMain";
            this.Text = "Color Toolkit";
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

