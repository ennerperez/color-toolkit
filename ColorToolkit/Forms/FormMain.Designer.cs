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
            this.labelHEX = new System.Windows.Forms.LinkLabel();
            this.textBoxHEX = new System.Windows.Forms.TextBox();
            this.labelRGB = new System.Windows.Forms.LinkLabel();
            this.textBoxR = new System.Windows.Forms.NumericUpDown();
            this.textBoxG = new System.Windows.Forms.NumericUpDown();
            this.textBoxB = new System.Windows.Forms.NumericUpDown();
            this.colorDialogPicker = new System.Windows.Forms.ColorDialog();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.labelHSB = new System.Windows.Forms.LinkLabel();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonQSwatch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonHistory = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTopMost = new System.Windows.Forms.ToolStripButton();
            this.textBoxS = new System.Windows.Forms.NumericUpDown();
            this.textBoxV = new System.Windows.Forms.NumericUpDown();
            this.textBoxH = new System.Windows.Forms.NumericUpDown();
            this.toolStripButtonUpdates = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxB)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxH)).BeginInit();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panelColor, "panelColor");
            this.panelColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelColor.Name = "panelColor";
            this.toolTipMain.SetToolTip(this.panelColor, resources.GetString("panelColor.ToolTip"));
            this.panelColor.DoubleClick += new System.EventHandler(this.PanelColor_DoubleClick);
            this.panelColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseClick);
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            this.panelColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseMove);
            this.panelColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseUp);
            // 
            // labelHEX
            // 
            this.labelHEX.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.labelHEX.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.labelHEX, "labelHEX");
            this.labelHEX.Name = "labelHEX";
            this.labelHEX.TabStop = true;
            this.toolTipMain.SetToolTip(this.labelHEX, resources.GetString("labelHEX.ToolTip"));
            this.labelHEX.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelHEX_LinkClicked);
            // 
            // textBoxHEX
            // 
            resources.ApplyResources(this.textBoxHEX, "textBoxHEX");
            this.textBoxHEX.Name = "textBoxHEX";
            this.textBoxHEX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxHEX_KeyDown);
            this.textBoxHEX.Leave += new System.EventHandler(this.TextBoxHEX_Leave);
            // 
            // labelRGB
            // 
            this.labelRGB.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.labelRGB.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.labelRGB, "labelRGB");
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.TabStop = true;
            this.toolTipMain.SetToolTip(this.labelRGB, resources.GetString("labelRGB.ToolTip"));
            this.labelRGB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelRGB_LinkClicked);
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
            this.textBoxR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.textBoxR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxRGB_KeyDown);
            this.textBoxR.Leave += new System.EventHandler(this.TextBoxRGB_Leave);
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
            this.textBoxG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.textBoxG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxRGB_KeyDown);
            this.textBoxG.Leave += new System.EventHandler(this.TextBoxRGB_Leave);
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
            this.textBoxB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.textBoxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxRGB_KeyDown);
            this.textBoxB.Leave += new System.EventHandler(this.TextBoxRGB_Leave);
            // 
            // colorDialogPicker
            // 
            this.colorDialogPicker.AnyColor = true;
            this.colorDialogPicker.FullOpen = true;
            // 
            // openFileDialogMain
            // 
            resources.ApplyResources(this.openFileDialogMain, "openFileDialogMain");
            this.openFileDialogMain.Multiselect = true;
            this.openFileDialogMain.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogMain_FileOk);
            // 
            // labelHSB
            // 
            resources.ApplyResources(this.labelHSB, "labelHSB");
            this.labelHSB.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.labelHSB.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelHSB.Name = "labelHSB";
            this.labelHSB.TabStop = true;
            this.toolTipMain.SetToolTip(this.labelHSB, resources.GetString("labelHSB.ToolTip"));
            this.labelHSB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelHSB_LinkClicked);
            // 
            // toolStripMenu
            // 
            resources.ApplyResources(this.toolStripMenu, "toolStripMenu");
            this.toolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.toolStripMenu.CanOverflow = false;
            this.toolStripMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClose,
            this.toolStripButtonAbout,
            this.toolStripButtonQSwatch,
            this.toolStripButtonOpen,
            this.toolStripSeparator1,
            this.toolStripButtonHistory,
            this.toolStripButtonTopMost,
            this.toolStripButtonUpdates});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonClose, "toolStripButtonClose");
            this.toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Click += new System.EventHandler(this.ToolStripButtonClose_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonAbout, "toolStripButtonAbout");
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.ToolStripButtonAbout_Click);
            // 
            // toolStripButtonQSwatch
            // 
            resources.ApplyResources(this.toolStripButtonQSwatch, "toolStripButtonQSwatch");
            this.toolStripButtonQSwatch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonQSwatch.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonQSwatch.Name = "toolStripButtonQSwatch";
            this.toolStripButtonQSwatch.Click += new System.EventHandler(this.ToolStripButtonQSwatch_Click);
            // 
            // toolStripButtonOpen
            // 
            resources.ApplyResources(this.toolStripButtonOpen, "toolStripButtonOpen");
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.ToolStripButtonOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripButtonHistory
            // 
            resources.ApplyResources(this.toolStripButtonHistory, "toolStripButtonHistory");
            this.toolStripButtonHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHistory.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonHistory.Name = "toolStripButtonHistory";
            this.toolStripButtonHistory.Click += new System.EventHandler(this.ToolStripButtonHistory_Click);
            // 
            // toolStripButtonTopMost
            // 
            this.toolStripButtonTopMost.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonTopMost, "toolStripButtonTopMost");
            this.toolStripButtonTopMost.Checked = global::Toolkit.Properties.Settings.Default.TopMost;
            this.toolStripButtonTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonTopMost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTopMost.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonTopMost.Name = "toolStripButtonTopMost";
            this.toolStripButtonTopMost.Click += new System.EventHandler(this.ToolStripButtonTopMost_Click);
            // 
            // textBoxS
            // 
            this.textBoxS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxS, "textBoxS");
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textBoxS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxHSB_KeyDown);
            this.textBoxS.Leave += new System.EventHandler(this.TextBoxHSB_Leave);
            // 
            // textBoxV
            // 
            this.textBoxV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxV, "textBoxV");
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textBoxV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxHSB_KeyDown);
            this.textBoxV.Leave += new System.EventHandler(this.TextBoxHSB_Leave);
            // 
            // textBoxH
            // 
            this.textBoxH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxH, "textBoxH");
            this.textBoxH.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.textBoxH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxHSB_KeyDown);
            this.textBoxH.Leave += new System.EventHandler(this.TextBoxHSB_Leave);
            // 
            // toolStripButtonUpdates
            // 
            this.toolStripButtonUpdates.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonUpdates, "toolStripButtonUpdates");
            this.toolStripButtonUpdates.Checked = global::Toolkit.Properties.Settings.Default.CheckForUpdates;
            this.toolStripButtonUpdates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonUpdates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdates.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonUpdates.Name = "toolStripButtonUpdates";
            this.toolStripButtonUpdates.Click += new System.EventHandler(this.ToolStripButtonUpdates_Click);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxHEX);
            this.Controls.Add(this.labelHSB);
            this.Controls.Add(this.labelRGB);
            this.Controls.Add(this.labelHEX);
            this.DataBindings.Add(new System.Windows.Forms.Binding("TopMost", global::Toolkit.Properties.Settings.Default, "TopMost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.TopMost = global::Toolkit.Properties.Settings.Default.TopMost;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxB)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.LinkLabel labelHEX;
        private System.Windows.Forms.TextBox textBoxHEX;
        private System.Windows.Forms.LinkLabel labelRGB;
        private System.Windows.Forms.NumericUpDown textBoxR;
        private System.Windows.Forms.NumericUpDown textBoxG;
        private System.Windows.Forms.NumericUpDown textBoxB;
        private System.Windows.Forms.ColorDialog colorDialogPicker;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripButton toolStripButtonQSwatch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonHistory;
        private System.Windows.Forms.ToolStripButton toolStripButtonTopMost;
        private System.Windows.Forms.LinkLabel labelHSB;
        private System.Windows.Forms.NumericUpDown textBoxS;
        private System.Windows.Forms.NumericUpDown textBoxV;
        private System.Windows.Forms.NumericUpDown textBoxH;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdates;
    }
}

