namespace Toolkit.Forms
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.folderBrowserDialogAutoSavePath = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxUI = new System.Windows.Forms.GroupBox();
            this.label1AutoStartDevice = new System.Windows.Forms.Label();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.checkBoxCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.groupBoxUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            resources.ApplyResources(this.buttonAccept, "buttonAccept");
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // groupBoxUI
            // 
            resources.ApplyResources(this.groupBoxUI, "groupBoxUI");
            this.groupBoxUI.Controls.Add(this.trackBarOpacity);
            this.groupBoxUI.Controls.Add(this.label1AutoStartDevice);
            this.groupBoxUI.Name = "groupBoxUI";
            this.groupBoxUI.TabStop = false;
            // 
            // label1AutoStartDevice
            // 
            resources.ApplyResources(this.label1AutoStartDevice, "label1AutoStartDevice");
            this.label1AutoStartDevice.Name = "label1AutoStartDevice";
            // 
            // trackBarOpacity
            // 
            resources.ApplyResources(this.trackBarOpacity, "trackBarOpacity");
            this.trackBarOpacity.Maximum = 100;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarOpacity.Value = 25;
            // 
            // checkBoxCheckForUpdates
            // 
            resources.ApplyResources(this.checkBoxCheckForUpdates, "checkBoxCheckForUpdates");
            this.checkBoxCheckForUpdates.Checked = global::Toolkit.Properties.Settings.Default.CheckForUpdates;
            this.checkBoxCheckForUpdates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCheckForUpdates.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Toolkit.Properties.Settings.Default, "CheckForUpdates", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCheckForUpdates.Name = "checkBoxCheckForUpdates";
            this.checkBoxCheckForUpdates.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonAccept;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonCancel;
            this.Controls.Add(this.groupBoxUI);
            this.Controls.Add(this.checkBoxCheckForUpdates);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBoxUI.ResumeLayout(false);
            this.groupBoxUI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogAutoSavePath;
        private System.Windows.Forms.CheckBox checkBoxCheckForUpdates;
        private System.Windows.Forms.GroupBox groupBoxUI;
        private System.Windows.Forms.TrackBar trackBarOpacity;
        private System.Windows.Forms.Label label1AutoStartDevice;
    }
}