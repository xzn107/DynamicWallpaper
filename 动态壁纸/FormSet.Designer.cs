﻿namespace 动态壁纸
{
    partial class FormSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSet));
            this.labelDefaultPath = new System.Windows.Forms.Label();
            this.buttonDefaultPath = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDefaultPath
            // 
            this.labelDefaultPath.AutoSize = true;
            this.labelDefaultPath.Location = new System.Drawing.Point(12, 17);
            this.labelDefaultPath.Margin = new System.Windows.Forms.Padding(3);
            this.labelDefaultPath.Name = "labelDefaultPath";
            this.labelDefaultPath.Size = new System.Drawing.Size(65, 12);
            this.labelDefaultPath.TabIndex = 0;
            this.labelDefaultPath.Text = "默认路径：";
            // 
            // buttonDefaultPath
            // 
            this.buttonDefaultPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultPath.Location = new System.Drawing.Point(438, 12);
            this.buttonDefaultPath.Name = "buttonDefaultPath";
            this.buttonDefaultPath.Size = new System.Drawing.Size(75, 22);
            this.buttonDefaultPath.TabIndex = 1;
            this.buttonDefaultPath.Text = "默认路径";
            this.buttonDefaultPath.UseVisualStyleBackColor = true;
            this.buttonDefaultPath.Click += new System.EventHandler(this.buttonDefaultPath_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.Location = new System.Drawing.Point(438, 40);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 2;
            this.buttonAbout.Text = "关于";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // FormSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 74);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonDefaultPath);
            this.Controls.Add(this.labelDefaultPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSet";
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSet_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDefaultPath;
        private System.Windows.Forms.Button buttonDefaultPath;
        private System.Windows.Forms.Button buttonAbout;
    }
}