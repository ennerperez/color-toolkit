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
            this.backgroundWorkerLoadColor = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // flowLayoutPanelColors
            // 
            resources.ApplyResources(this.flowLayoutPanelColors, "flowLayoutPanelColors");
            this.flowLayoutPanelColors.Name = "flowLayoutPanelColors";
            // 
            // backgroundWorkerLoadColor
            // 
            this.backgroundWorkerLoadColor.WorkerReportsProgress = true;
            this.backgroundWorkerLoadColor.WorkerSupportsCancellation = true;
            this.backgroundWorkerLoadColor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerLoadColor_DoWork);
            // 
            // FormSwatch
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.flowLayoutPanelColors);
            this.DoubleBuffered = true;
            this.Name = "FormSwatch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSwatch_FormClosed);
            this.Load += new System.EventHandler(this.FormSwatch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColors;
        private System.Windows.Forms.ToolTip toolTipColor;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadColor;
    }

}