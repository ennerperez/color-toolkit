namespace Toolkit.Forms
{
    partial class FormHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistory));
            this.comboBoxColorMode = new System.Windows.Forms.ComboBox();
            this.toolTipQSwatch = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxVisible = new System.Windows.Forms.CheckBox();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxColorMode
            // 
            resources.ApplyResources(this.comboBoxColorMode, "comboBoxColorMode");
            this.comboBoxColorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColorMode.FormattingEnabled = true;
            this.comboBoxColorMode.Items.AddRange(new object[] {
            resources.GetString("comboBoxColorMode.Items"),
            resources.GetString("comboBoxColorMode.Items1"),
            resources.GetString("comboBoxColorMode.Items2"),
            resources.GetString("comboBoxColorMode.Items3")});
            this.comboBoxColorMode.Name = "comboBoxColorMode";
            this.comboBoxColorMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorMode_SelectedIndexChanged);
            // 
            // checkBoxVisible
            // 
            resources.ApplyResources(this.checkBoxVisible, "checkBoxVisible");
            this.checkBoxVisible.Name = "checkBoxVisible";
            this.checkBoxVisible.UseVisualStyleBackColor = true;
            this.checkBoxVisible.CheckedChanged += new System.EventHandler(this.checkBoxVisible_CheckedChanged);
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panelOptions.Controls.Add(this.buttonClear);
            this.panelOptions.Controls.Add(this.buttonRefresh);
            this.panelOptions.Controls.Add(this.checkBoxVisible);
            this.panelOptions.Controls.Add(this.comboBoxColorMode);
            resources.ApplyResources(this.panelOptions, "panelOptions");
            this.panelOptions.ForeColor = System.Drawing.SystemColors.Window;
            this.panelOptions.Name = "panelOptions";
            // 
            // buttonClear
            // 
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRefresh
            // 
            resources.ApplyResources(this.buttonRefresh, "buttonRefresh");
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormHistory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelOptions);
            this.DoubleBuffered = true;
            this.Name = "FormHistory";
            this.toolTipQSwatch.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.FormSwatches_Load);
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipQSwatch;
        private System.Windows.Forms.ComboBox comboBoxColorMode;
        private System.Windows.Forms.CheckBox checkBoxVisible;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonClear;
    }
}