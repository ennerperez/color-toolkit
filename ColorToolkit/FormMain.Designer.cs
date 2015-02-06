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
            this.labelHSV = new System.Windows.Forms.Label();
            this.buttonCopyHSV = new System.Windows.Forms.Button();
            this.tableLayoutPanelHSV = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxH = new System.Windows.Forms.NumericUpDown();
            this.textBoxV = new System.Windows.Forms.NumericUpDown();
            this.textBoxS = new System.Windows.Forms.NumericUpDown();
            this.colorDialogPicker = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxB)).BeginInit();
            this.tableLayoutPanelRGB.SuspendLayout();
            this.tableLayoutPanelHSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelColor.BackgroundImage")));
            this.panelColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColor.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelColor.Location = new System.Drawing.Point(12, 12);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(87, 87);
            this.panelColor.TabIndex = 0;
            this.panelColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseClick);
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseMove);
            this.panelColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseUp);
            // 
            // labelHEX
            // 
            this.labelHEX.Location = new System.Drawing.Point(105, 12);
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
            this.textBoxHEX.Location = new System.Drawing.Point(146, 12);
            this.textBoxHEX.MaxLength = 7;
            this.textBoxHEX.Name = "textBoxHEX";
            this.textBoxHEX.Size = new System.Drawing.Size(208, 25);
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
            this.buttonCopyHEX.Location = new System.Drawing.Point(360, 12);
            this.buttonCopyHEX.Name = "buttonCopyHEX";
            this.buttonCopyHEX.Size = new System.Drawing.Size(25, 25);
            this.buttonCopyHEX.TabIndex = 3;
            this.buttonCopyHEX.UseVisualStyleBackColor = true;
            this.buttonCopyHEX.Click += new System.EventHandler(this.buttonCopiarHEX_Click);
            // 
            // labelRGB
            // 
            this.labelRGB.Location = new System.Drawing.Point(105, 43);
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.Size = new System.Drawing.Size(35, 25);
            this.labelRGB.TabIndex = 4;
            this.labelRGB.Text = "R&GB:";
            this.labelRGB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxR
            // 
            this.textBoxR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxR.Location = new System.Drawing.Point(0, 0);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.textBoxR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(66, 25);
            this.textBoxR.TabIndex = 0;
            this.textBoxR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRGB_KeyDown);
            this.textBoxR.Leave += new System.EventHandler(this.textBoxRGB_Leave);
            // 
            // textBoxG
            // 
            this.textBoxG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxG.Location = new System.Drawing.Point(72, 0);
            this.textBoxG.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(63, 25);
            this.textBoxG.TabIndex = 1;
            this.textBoxG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRGB_KeyDown);
            this.textBoxG.Leave += new System.EventHandler(this.textBoxRGB_Leave);
            // 
            // textBoxB
            // 
            this.textBoxB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxB.Location = new System.Drawing.Point(141, 0);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.textBoxB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(67, 25);
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
            this.tableLayoutPanelRGB.Location = new System.Drawing.Point(146, 43);
            this.tableLayoutPanelRGB.Name = "tableLayoutPanelRGB";
            this.tableLayoutPanelRGB.RowCount = 1;
            this.tableLayoutPanelRGB.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRGB.Size = new System.Drawing.Size(208, 25);
            this.tableLayoutPanelRGB.TabIndex = 5;
            // 
            // buttonCopyRGB
            // 
            this.buttonCopyRGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyRGB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCopyRGB.BackgroundImage")));
            this.buttonCopyRGB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCopyRGB.Location = new System.Drawing.Point(360, 43);
            this.buttonCopyRGB.Name = "buttonCopyRGB";
            this.buttonCopyRGB.Size = new System.Drawing.Size(25, 25);
            this.buttonCopyRGB.TabIndex = 6;
            this.buttonCopyRGB.UseVisualStyleBackColor = true;
            this.buttonCopyRGB.Click += new System.EventHandler(this.buttonCopiarRGB_Click);
            // 
            // labelHSV
            // 
            this.labelHSV.Enabled = false;
            this.labelHSV.Location = new System.Drawing.Point(105, 74);
            this.labelHSV.Name = "labelHSV";
            this.labelHSV.Size = new System.Drawing.Size(35, 25);
            this.labelHSV.TabIndex = 7;
            this.labelHSV.Text = "HS&V:";
            this.labelHSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCopyHSV
            // 
            this.buttonCopyHSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyHSV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCopyHSV.BackgroundImage")));
            this.buttonCopyHSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCopyHSV.Enabled = false;
            this.buttonCopyHSV.Location = new System.Drawing.Point(360, 74);
            this.buttonCopyHSV.Name = "buttonCopyHSV";
            this.buttonCopyHSV.Size = new System.Drawing.Size(25, 25);
            this.buttonCopyHSV.TabIndex = 9;
            this.buttonCopyHSV.UseVisualStyleBackColor = true;
            this.buttonCopyHSV.Click += new System.EventHandler(this.buttonCopiarHSV_Click);
            // 
            // tableLayoutPanelHSV
            // 
            this.tableLayoutPanelHSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHSV.ColumnCount = 3;
            this.tableLayoutPanelHSV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelHSV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelHSV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelHSV.Controls.Add(this.textBoxH, 0, 0);
            this.tableLayoutPanelHSV.Controls.Add(this.textBoxV, 2, 0);
            this.tableLayoutPanelHSV.Controls.Add(this.textBoxS, 1, 0);
            this.tableLayoutPanelHSV.Enabled = false;
            this.tableLayoutPanelHSV.Location = new System.Drawing.Point(146, 74);
            this.tableLayoutPanelHSV.Name = "tableLayoutPanelHSV";
            this.tableLayoutPanelHSV.RowCount = 1;
            this.tableLayoutPanelHSV.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelHSV.Size = new System.Drawing.Size(208, 25);
            this.tableLayoutPanelHSV.TabIndex = 8;
            // 
            // textBoxH
            // 
            this.textBoxH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxH.Location = new System.Drawing.Point(0, 0);
            this.textBoxH.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.textBoxH.Maximum = new decimal(new int[] {
            239,
            0,
            0,
            0});
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(66, 25);
            this.textBoxH.TabIndex = 0;
            this.textBoxH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHSV_KeyDown);
            this.textBoxH.Leave += new System.EventHandler(this.textBoxHSV_Leave);
            // 
            // textBoxV
            // 
            this.textBoxV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxV.Location = new System.Drawing.Point(141, 0);
            this.textBoxV.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.textBoxV.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(67, 25);
            this.textBoxV.TabIndex = 2;
            this.textBoxV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHSV_KeyDown);
            this.textBoxV.Leave += new System.EventHandler(this.textBoxHSV_Leave);
            // 
            // textBoxS
            // 
            this.textBoxS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxS.Location = new System.Drawing.Point(72, 0);
            this.textBoxS.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxS.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(63, 25);
            this.textBoxS.TabIndex = 1;
            this.textBoxS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHSV_KeyDown);
            this.textBoxS.Leave += new System.EventHandler(this.textBoxHSV_Leave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(394, 111);
            this.Controls.Add(this.labelHSV);
            this.Controls.Add(this.tableLayoutPanelHSV);
            this.Controls.Add(this.buttonCopyHSV);
            this.Controls.Add(this.tableLayoutPanelRGB);
            this.Controls.Add(this.buttonCopyRGB);
            this.Controls.Add(this.buttonCopyHEX);
            this.Controls.Add(this.textBoxHEX);
            this.Controls.Add(this.labelRGB);
            this.Controls.Add(this.labelHEX);
            this.Controls.Add(this.panelColor);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Color Toolkit";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.textBoxR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxB)).EndInit();
            this.tableLayoutPanelRGB.ResumeLayout(false);
            this.tableLayoutPanelHSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxS)).EndInit();
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
        private System.Windows.Forms.Label labelHSV;
        private System.Windows.Forms.Button buttonCopyHSV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHSV;
        private System.Windows.Forms.NumericUpDown textBoxH;
        private System.Windows.Forms.NumericUpDown textBoxV;
        private System.Windows.Forms.NumericUpDown textBoxS;
        private System.Windows.Forms.ColorDialog colorDialogPicker;
    }
}

