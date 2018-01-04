namespace Toolkit.Controls
{
    partial class ColorSpaceHEX
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
            this.labelTitle = new System.Windows.Forms.LinkLabel();
            this.textBoxHEX = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelCS = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelCS.SuspendLayout();
            this.SuspendLayout();
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
            this.labelTitle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelHEX_LinkClicked);
            // 
            // textBoxHEX
            // 
            this.textBoxHEX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHEX.Location = new System.Drawing.Point(0, 3);
            this.textBoxHEX.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.textBoxHEX.MaxLength = 7;
            this.textBoxHEX.Name = "textBoxHEX";
            this.textBoxHEX.Size = new System.Drawing.Size(160, 20);
            this.textBoxHEX.TabIndex = 1;
            this.textBoxHEX.Text = "#000000";
            this.textBoxHEX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHEX_KeyDown);
            this.textBoxHEX.Leave += new System.EventHandler(this.textBoxHEX_TextChanged);
            // 
            // tableLayoutPanelCS
            // 
            this.tableLayoutPanelCS.ColumnCount = 1;
            this.tableLayoutPanelCS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCS.Controls.Add(this.textBoxHEX, 0, 0);
            this.tableLayoutPanelCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCS.Location = new System.Drawing.Point(0, 16);
            this.tableLayoutPanelCS.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelCS.Name = "tableLayoutPanelCS";
            this.tableLayoutPanelCS.RowCount = 1;
            this.tableLayoutPanelCS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCS.Size = new System.Drawing.Size(160, 32);
            this.tableLayoutPanelCS.TabIndex = 2;
            // 
            // ColorSpaceHEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelCS);
            this.Controls.Add(this.labelTitle);
            this.Name = "ColorSpaceHEX";
            this.Size = new System.Drawing.Size(160, 48);
            this.tableLayoutPanelCS.ResumeLayout(false);
            this.tableLayoutPanelCS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel labelTitle;
        private System.Windows.Forms.TextBox textBoxHEX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCS;
    }
}
