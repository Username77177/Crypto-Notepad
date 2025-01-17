﻿namespace Crypto_Notepad
{
    partial class EnterKeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterKeyForm));
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.keyEyeIcon = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lockIcon = new System.Windows.Forms.PictureBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.keyEyeIcon)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(64, 39);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(177, 20);
            this.keyTextBox.TabIndex = 0;
            this.keyTextBox.UseSystemPasswordChar = true;
            this.keyTextBox.TextChanged += new System.EventHandler(this.KeyTextBox_TextChanged);
            this.keyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyTextBox_KeyDown);
            // 
            // okButton
            // 
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(190, 79);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // keyEyeIcon
            // 
            this.keyEyeIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyEyeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyEyeIcon.Image = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.keyEyeIcon.InitialImage = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.keyEyeIcon.Location = new System.Drawing.Point(247, 39);
            this.keyEyeIcon.Name = "keyEyeIcon";
            this.keyEyeIcon.Size = new System.Drawing.Size(18, 20);
            this.keyEyeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.keyEyeIcon.TabIndex = 3;
            this.keyEyeIcon.TabStop = false;
            this.keyEyeIcon.Click += new System.EventHandler(this.KeyEyeIcon_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.lockIcon);
            this.mainPanel.Controls.Add(this.fileNameLabel);
            this.mainPanel.Controls.Add(this.keyTextBox);
            this.mainPanel.Controls.Add(this.keyEyeIcon);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(269, 73);
            this.mainPanel.TabIndex = 5;
            // 
            // lockIcon
            // 
            this.lockIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lockIcon.Image = global::Crypto_Notepad.Properties.Resources.big_lock;
            this.lockIcon.Location = new System.Drawing.Point(8, 12);
            this.lockIcon.Name = "lockIcon";
            this.lockIcon.Size = new System.Drawing.Size(47, 47);
            this.lockIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lockIcon.TabIndex = 6;
            this.lockIcon.TabStop = false;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoEllipsis = true;
            this.fileNameLabel.Location = new System.Drawing.Point(61, 12);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(196, 13);
            this.fileNameLabel.TabIndex = 6;
            this.fileNameLabel.Text = "Enter the encryption key:";
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnterKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 107);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crypto Notepad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterKeyForm_FormClosed);
            this.Load += new System.EventHandler(this.EnterKeyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keyEyeIcon)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.PictureBox keyEyeIcon;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.PictureBox lockIcon;
        public System.Windows.Forms.TextBox keyTextBox;
    }
}