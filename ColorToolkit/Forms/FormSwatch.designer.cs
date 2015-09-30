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
            this.flowLayoutPanelColors.AutoScroll = true;
            this.flowLayoutPanelColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelColors.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelColors.Name = "flowLayoutPanelColors";
            this.flowLayoutPanelColors.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelColors.Size = new System.Drawing.Size(564, 441);
            this.flowLayoutPanelColors.TabIndex = 2;
            // 
            // backgroundWorkerLoadColor
            // 
            this.backgroundWorkerLoadColor.WorkerReportsProgress = true;
            this.backgroundWorkerLoadColor.WorkerSupportsCancellation = true;
            this.backgroundWorkerLoadColor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadColor_DoWork);
            // 
            // FormSwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(564, 441);
            this.Controls.Add(this.flowLayoutPanelColors);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(425, 314);
            this.Name = "FormSwatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Swatch Loader";
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