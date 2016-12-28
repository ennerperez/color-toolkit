﻿using Platform.Support.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Toolkit.Forms
{
    public partial class FormHistory : Form
    {

        public FormHistory()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetEntryAssembly().Location);
        }

        private void FormSwatches_Load(object sender, EventArgs e)
        {
            foreach (var item in Properties.Settings.Default.History)
            {
                var color = Color.FromArgb(int.Parse(item));

                var panelItem = new System.Windows.Forms.Panel();
                var labelColor = new System.Windows.Forms.Label();

                // 
                // labelColor
                // 
                labelColor.ForeColor = System.Drawing.Color.Black;
                labelColor.Dock = DockStyle.Right;
                labelColor.AutoSize = true;
                labelColor.MouseClick += new System.Windows.Forms.MouseEventHandler(panel_MouseClick);
                labelColor.Text = color.ToHEX().ToUpper();
                labelColor.ForeColor = color.Invert();

                // 
                // panelItem
                // 
                panelItem.Controls.Add(labelColor);
                panelItem.Cursor = System.Windows.Forms.Cursors.Hand;
                panelItem.Tag = "panelItem";
                panelItem.Dock = DockStyle.Top;
                panelItem.Padding = new Padding(6);
                panelItem.Size = new Size(192, 32);
                panelItem.MouseClick += new System.Windows.Forms.MouseEventHandler(panel_MouseClick);
                panelItem.BackColor = color;

                this.Controls.Add(panelItem);

            }

            panelOptions.SendToBack();

            // Resolution fix
            if (Height > FormHelpers.GetWorkingArea().Height)
            {
                Height = MinimumSize.Height;
            }

            comboBoxColorMode.SelectedIndex = 0;
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender.GetType() != typeof(Label))
            {
                switch (comboBoxColorMode.SelectedIndex)
                {
                    case 1:
                        Clipboard.SetText(ColorHelpers.RGB((sender as Panel).BackColor));
                        break;
                    case 2:
                        Clipboard.SetText(ColorHelpers.HSB((sender as Panel).BackColor.ToHSB()));
                        break;
                    default:
                        Clipboard.SetText((sender as Panel).BackColor.ToHEX());
                        break;
                }
            }
            else
            {
                switch (comboBoxColorMode.SelectedIndex)
                {
                    case 1:
                        Clipboard.SetText(ColorHelpers.RGB((sender as Label).Parent.BackColor));
                        break;
                    case 2:
                        Clipboard.SetText(ColorHelpers.HSB((sender as Label).Parent.BackColor.ToHSB()));
                        break;
                    default:
                        Clipboard.SetText((sender as Label).Parent.BackColor.ToHEX());
                        break;
                }
            }
        }

        private void comboBoxColorMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in this.Controls.OfType<Panel>().Where(x => x.Tag == "panelItem"))
            {
                var label = item.Controls.OfType<Label>().First();
                switch (comboBoxColorMode.SelectedIndex)
                {
                    case 1:
                        label.Text = ColorHelpers.RGB(item.BackColor).ToUpper();
                        break;
                    case 2:
                        label.Text = ColorHelpers.HSB(item.BackColor.ToHSB());
                        break;
                    default:
                        label.Text = item.BackColor.ToHEX().ToUpper();
                        break;
                }
            }
        }

        private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBoxVisible.Checked;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.Controls.OfType<Panel>().Where(x => x != panelOptions).All(c =>
            {
                c.Dispose();
                c = null;
                return true;
            });
            this.Controls.Clear();
            this.Controls.Add(panelOptions);
            
            FormSwatches_Load(sender, e);
            this.ResumeLayout();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.History.Clear();
            Properties.Settings.Default.Save();
            buttonRefresh.PerformClick();
        }
    }
}
