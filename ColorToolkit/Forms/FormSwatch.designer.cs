namespace Toolkit.Forms
{
    partial class FormSwatch
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSwatch));
            this.flowLayoutPanelColors = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTipColor = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripColor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogPicker = new System.Windows.Forms.ColorDialog();
            this.saveFileDialogSave = new System.Windows.Forms.SaveFileDialog();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.checkBoxVisible = new System.Windows.Forms.CheckBox();
            this.comboBoxTileSize = new System.Windows.Forms.ComboBox();
            this.contextMenuStripColor.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelColors
            // 
            resources.ApplyResources(this.flowLayoutPanelColors, "flowLayoutPanelColors");
            this.flowLayoutPanelColors.Name = "flowLayoutPanelColors";
            // 
            // contextMenuStripColor
            // 
            this.contextMenuStripColor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStripColor.Name = "contextMenuStripColor";
            resources.ApplyResources(this.contextMenuStripColor, "contextMenuStripColor");
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            resources.ApplyResources(this.removeToolStripMenuItem, "removeToolStripMenuItem");
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // colorDialogPicker
            // 
            this.colorDialogPicker.AnyColor = true;
            this.colorDialogPicker.FullOpen = true;
            // 
            // saveFileDialogSave
            // 
            this.saveFileDialogSave.DefaultExt = "json";
            resources.ApplyResources(this.saveFileDialogSave, "saveFileDialogSave");
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panelOptions.Controls.Add(this.checkBoxVisible);
            this.panelOptions.Controls.Add(this.comboBoxTileSize);
            resources.ApplyResources(this.panelOptions, "panelOptions");
            this.panelOptions.ForeColor = System.Drawing.SystemColors.Window;
            this.panelOptions.Name = "panelOptions";
            // 
            // checkBoxVisible
            // 
            resources.ApplyResources(this.checkBoxVisible, "checkBoxVisible");
            this.checkBoxVisible.Name = "checkBoxVisible";
            this.checkBoxVisible.UseVisualStyleBackColor = true;
            this.checkBoxVisible.CheckedChanged += new System.EventHandler(this.checkBoxVisible_CheckedChanged);
            // 
            // comboBoxTileSize
            // 
            resources.ApplyResources(this.comboBoxTileSize, "comboBoxTileSize");
            this.comboBoxTileSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTileSize.FormattingEnabled = true;
            this.comboBoxTileSize.Items.AddRange(new object[] {
            resources.GetString("comboBoxTileSize.Items"),
            resources.GetString("comboBoxTileSize.Items1"),
            resources.GetString("comboBoxTileSize.Items2"),
            resources.GetString("comboBoxTileSize.Items3"),
            resources.GetString("comboBoxTileSize.Items4")});
            this.comboBoxTileSize.Name = "comboBoxTileSize";
            this.comboBoxTileSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxTileSize_SelectedIndexChanged);
            // 
            // FormSwatch
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.flowLayoutPanelColors);
            this.Controls.Add(this.panelOptions);
            this.DoubleBuffered = true;
            this.Name = "FormSwatch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSwatch_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSwatch_FormClosed);
            this.Load += new System.EventHandler(this.FormSwatch_Load);
            this.Shown += new System.EventHandler(this.FormSwatch_Shown);
            this.contextMenuStripColor.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColors;
        private System.Windows.Forms.ToolTip toolTipColor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripColor;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialogPicker;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSave;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.CheckBox checkBoxVisible;
        private System.Windows.Forms.ComboBox comboBoxTileSize;
    }

}