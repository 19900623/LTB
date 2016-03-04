﻿namespace LentilToolbox
{
    partial class Shaftwin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shaftwin));
            this.ListShower = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.preview = new Preview();
            this.Generate = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.preview.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListShower
            // 
            this.ListShower.BackColor = System.Drawing.SystemColors.Control;
            this.ListShower.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListShower.Location = new System.Drawing.Point(0, 0);
            this.ListShower.Name = "ListShower";
            this.ListShower.Size = new System.Drawing.Size(859, 364);
            this.ListShower.TabIndex = 0;
            this.ListShower.Paint += new System.Windows.Forms.PaintEventHandler(this.ListShower_Paint);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 305);
            this.hScrollBar1.Maximum = 0;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(859, 17);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Visible = false;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ListShower);
            this.splitContainer1.Panel1.Controls.Add(this.hScrollBar1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.preview);
            this.splitContainer1.Size = new System.Drawing.Size(861, 354);
            this.splitContainer1.SplitterDistance = 324;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // preview
            // 
            this.preview.Controls.Add(this.Generate);
            this.preview.Cursor = System.Windows.Forms.Cursors.Default;
            this.preview.Dock = System.Windows.Forms.DockStyle.Top;
            this.preview.Location = new System.Drawing.Point(0, 0);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(859, 384);
            this.preview.TabIndex = 0;
            // 
            // Generate
            // 
            this.Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Generate.Cursor = System.Windows.Forms.Cursors.Default;
            this.Generate.Location = new System.Drawing.Point(785, 0);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 24);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "生成零件";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Shaftwin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 354);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shaftwin";
            this.Text = "传动零件生成插件";
            this.SizeChanged += new System.EventHandler(this.Shaftwin_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.preview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ListShower;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private Preview preview;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button Generate;
    }
}