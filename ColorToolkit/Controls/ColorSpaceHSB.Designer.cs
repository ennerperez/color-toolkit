namespace Toolkit.Controls
{
    partial class ColorSpaceHSB
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
            this.numericUpDownH = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownS = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.labelTitle = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanelCS = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            this.tableLayoutPanelCS.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownH
            // 
            this.numericUpDownH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownH.Location = new System.Drawing.Point(0, 3);
            this.numericUpDownH.Margin = new System.Windows.Forms.Padding(0, 3, 6, 3);
            this.numericUpDownH.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownH.Name = "numericUpDownH";
            this.numericUpDownH.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownH.TabIndex = 0;
            this.numericUpDownH.ValueChanged += new System.EventHandler(this.textBoxC_ValueChanged);
            this.numericUpDownH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxC_KeyDown);
            // 
            // numericUpDownS
            // 
            this.numericUpDownS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownS.Location = new System.Drawing.Point(56, 3);
            this.numericUpDownS.Name = "numericUpDownS";
            this.numericUpDownS.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownS.TabIndex = 1;
            this.numericUpDownS.ValueChanged += new System.EventHandler(this.textBoxC_ValueChanged);
            this.numericUpDownS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxC_KeyDown);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownB.Location = new System.Drawing.Point(112, 3);
            this.numericUpDownB.Margin = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownB.TabIndex = 2;
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.textBoxC_ValueChanged);
            this.numericUpDownB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxC_KeyDown);
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
            this.tableLayoutPanelCS.ColumnCount = 3;
            this.tableLayoutPanelCS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelCS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelCS.Controls.Add(this.numericUpDownH, 0, 0);
            this.tableLayoutPanelCS.Controls.Add(this.numericUpDownS, 1, 0);
            this.tableLayoutPanelCS.Controls.Add(this.numericUpDownB, 2, 0);
            this.tableLayoutPanelCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCS.Location = new System.Drawing.Point(0, 16);
            this.tableLayoutPanelCS.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelCS.Name = "tableLayoutPanelCS";
            this.tableLayoutPanelCS.RowCount = 1;
            this.tableLayoutPanelCS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCS.Size = new System.Drawing.Size(160, 32);
            this.tableLayoutPanelCS.TabIndex = 1;
            // 
            // ColorSpaceHSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelCS);
            this.Controls.Add(this.labelTitle);
            this.Name = "ColorSpaceHSB";
            this.Size = new System.Drawing.Size(160, 48);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            this.tableLayoutPanelCS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownH;
        private System.Windows.Forms.NumericUpDown numericUpDownS;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.LinkLabel labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCS;
    }
}
