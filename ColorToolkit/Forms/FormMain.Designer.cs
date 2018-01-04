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
            this.colorDialogPicker = new System.Windows.Forms.ColorDialog();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonQSwatch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHistory = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTopMost = new System.Windows.Forms.ToolStripButton();
            this.bufferedPanelSpaces = new System.Windows.Forms.BufferedPanel();
            this.colorSpaceCMYK = new Toolkit.Controls.ColorSpaceCMYK();
            this.colorSpaceHSB = new Toolkit.Controls.ColorSpaceHSB();
            this.colorSpaceRGB = new Toolkit.Controls.ColorSpaceRGB();
            this.colorSpaceHEX = new Toolkit.Controls.ColorSpaceHEX();
            this.toolStripMenu.SuspendLayout();
            this.bufferedPanelSpaces.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panelColor, "panelColor");
            this.panelColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelColor.Name = "panelColor";
            this.toolTipMain.SetToolTip(this.panelColor, resources.GetString("panelColor.ToolTip"));
            this.panelColor.DoubleClick += new System.EventHandler(this.panelColor_DoubleClick);
            this.panelColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseClick);
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseMove);
            this.panelColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseUp);
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
            this.openFileDialogMain.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogMain_FileOk);
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
            this.toolStripButtonAbout,
            this.toolStripButtonFile,
            this.toolStripSeparator1,
            this.toolStripButtonQSwatch,
            this.toolStripButtonHistory,
            this.toolStripButtonSettings,
            this.toolStripButtonTopMost});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonAbout, "toolStripButtonAbout");
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripButtonFile
            // 
            resources.ApplyResources(this.toolStripButtonFile, "toolStripButtonFile");
            this.toolStripButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.toolStripButtonFile.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonFile.Name = "toolStripButtonFile";
            this.toolStripButtonFile.ShowDropDownArrow = false;
            // 
            // newToolStripMenuItem
            // 
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // saveAsToolStripMenuItem
            // 
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripButtonQSwatch
            // 
            resources.ApplyResources(this.toolStripButtonQSwatch, "toolStripButtonQSwatch");
            this.toolStripButtonQSwatch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonQSwatch.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonQSwatch.Name = "toolStripButtonQSwatch";
            this.toolStripButtonQSwatch.Click += new System.EventHandler(this.toolStripButtonQSwatch_Click);
            // 
            // toolStripButtonHistory
            // 
            resources.ApplyResources(this.toolStripButtonHistory, "toolStripButtonHistory");
            this.toolStripButtonHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHistory.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonHistory.Name = "toolStripButtonHistory";
            this.toolStripButtonHistory.Click += new System.EventHandler(this.toolStripButtonHistory_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonSettings, "toolStripButtonSettings");
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
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
            this.toolStripButtonTopMost.Click += new System.EventHandler(this.toolStripButtonTopMost_Click);
            // 
            // bufferedPanelSpaces
            // 
            this.bufferedPanelSpaces.Controls.Add(this.colorSpaceCMYK);
            this.bufferedPanelSpaces.Controls.Add(this.colorSpaceHSB);
            this.bufferedPanelSpaces.Controls.Add(this.colorSpaceRGB);
            this.bufferedPanelSpaces.Controls.Add(this.colorSpaceHEX);
            resources.ApplyResources(this.bufferedPanelSpaces, "bufferedPanelSpaces");
            this.bufferedPanelSpaces.Name = "bufferedPanelSpaces";
            // 
            // colorSpaceCMYK
            // 
            this.colorSpaceCMYK.Color = System.Drawing.Color.Empty;
            resources.ApplyResources(this.colorSpaceCMYK, "colorSpaceCMYK");
            this.colorSpaceCMYK.Name = "colorSpaceCMYK";
            this.colorSpaceCMYK.ColorChanged += new System.EventHandler(this.colorSpace_ColorChanged);
            // 
            // colorSpaceHSB
            // 
            this.colorSpaceHSB.Color = System.Drawing.Color.Empty;
            resources.ApplyResources(this.colorSpaceHSB, "colorSpaceHSB");
            this.colorSpaceHSB.Name = "colorSpaceHSB";
            this.colorSpaceHSB.ColorChanged += new System.EventHandler(this.colorSpace_ColorChanged);
            // 
            // colorSpaceRGB
            // 
            this.colorSpaceRGB.Color = System.Drawing.Color.Empty;
            resources.ApplyResources(this.colorSpaceRGB, "colorSpaceRGB");
            this.colorSpaceRGB.Name = "colorSpaceRGB";
            this.colorSpaceRGB.ColorChanged += new System.EventHandler(this.colorSpace_ColorChanged);
            // 
            // colorSpaceHEX
            // 
            this.colorSpaceHEX.Color = System.Drawing.Color.Empty;
            resources.ApplyResources(this.colorSpaceHEX, "colorSpaceHEX");
            this.colorSpaceHEX.Name = "colorSpaceHEX";
            this.colorSpaceHEX.ColorChanged += new System.EventHandler(this.colorSpace_ColorChanged);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.bufferedPanelSpaces);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.toolStripMenu);
            this.DataBindings.Add(new System.Windows.Forms.Binding("TopMost", global::Toolkit.Properties.Settings.Default, "TopMost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.TopMost = global::Toolkit.Properties.Settings.Default.TopMost;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.bufferedPanelSpaces.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.ColorDialog colorDialogPicker;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripButton toolStripButtonQSwatch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonHistory;
        private System.Windows.Forms.ToolStripButton toolStripButtonTopMost;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.BufferedPanel bufferedPanelSpaces;
        private Controls.ColorSpaceRGB colorSpaceRGB;
        private Controls.ColorSpaceHEX colorSpaceHEX;
        private Controls.ColorSpaceHSB colorSpaceHSB;
        private Controls.ColorSpaceCMYK colorSpaceCMYK;
    }
}

