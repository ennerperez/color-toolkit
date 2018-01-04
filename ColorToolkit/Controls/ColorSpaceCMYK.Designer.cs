namespace Toolkit.Controls
{
    partial class ColorSpaceCMYK
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.labelTitle = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanelCS = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownK = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            this.tableLayoutPanelCS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownC.Location = new System.Drawing.Point(0, 3);
            this.numericUpDownC.Margin = new System.Windows.Forms.Padding(0, 3, 6, 3);
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownC.TabIndex = 0;
            this.numericUpDownC.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownC.ValueChanged += new System.EventHandler(this.textBoxC_ValueChanged);
            this.numericUpDownC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxC_KeyDown);
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownY.Location = new System.Drawing.Point(83, 3);
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownY.TabIndex = 2;
            this.numericUpDownY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.textBoxC_ValueChanged);
            this.numericUpDownY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxC_KeyDown);
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownM.Location = new System.Drawing.Point(43, 3);
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownM.TabIndex = 1;
            this.numericUpDownM.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownM.ValueChanged += new System.EventHandler(this.textBoxC_ValueChanged);
            this.numericUpDownM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxC_KeyDown);
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitle.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.labelTitle.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(160, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.TabStop = true;
            this.labelTitle.Text = "TITLE";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelTitle_LinkClicked);
            // 
            // tableLayoutPanelCS
            // 
            this.tableLayoutPanelCS.ColumnCount = 4;
            this.tableLayoutPanelCS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanelCS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanelCS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanelCS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99812F));
            this.tableLayoutPanelCS.Controls.Add(this.numericUpDownK, 3, 0);
            this.tableLayoutPanelCS.Controls.Add(this.numericUpDownC, 0, 0);
            this.tableLayoutPanelCS.Controls.Add(this.numericUpDownY, 2, 0);
            this.tableLayoutPanelCS.Controls.Add(this.numericUpDownM, 1, 0);
            this.tableLayoutPanelCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCS.Location = new System.Drawing.Point(0, 16);
            this.tableLayoutPanelCS.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelCS.Name = "tableLayoutPanelCS";
            this.tableLayoutPanelCS.RowCount = 1;
            this.tableLayoutPanelCS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCS.Size = new System.Drawing.Size(160, 32);
            this.tableLayoutPanelCS.TabIndex = 1;
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownK.Location = new System.Drawing.Point(126, 3);
            this.numericUpDownK.Margin = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownK.TabIndex = 3;
            this.numericUpDownK.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownK.ValueChanged += new System.EventHandler(this.textBoxC_ValueChanged);
            // 
            // ColorSpaceCMYK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelCS);
            this.Controls.Add(this.labelTitle);
            this.Name = "ColorSpaceCMYK";
            this.Size = new System.Drawing.Size(160, 48);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            this.tableLayoutPanelCS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.LinkLabel labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCS;
        private System.Windows.Forms.NumericUpDown numericUpDownK;
    }
}
