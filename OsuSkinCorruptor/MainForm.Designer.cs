using System;

namespace OsuSkinCorruptor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.goButton = new System.Windows.Forms.Button();
            this.seedTextBox = new System.Windows.Forms.TextBox();
            this.seedLabel = new System.Windows.Forms.Label();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.folderLabel = new System.Windows.Forms.Label();
            this.texturesCheckBox = new System.Windows.Forms.CheckBox();
            this.soundsCheckBox = new System.Windows.Forms.CheckBox();
            this.fileCheckBox = new System.Windows.Forms.CheckBox();
            this.cursorCheckBox = new System.Windows.Forms.CheckBox();
            this.bigTexturesCheckBox = new System.Windows.Forms.CheckBox();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.powerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.LocalApplicationData;
            this.folderBrowserDialog.SelectedPath = "%localappdata%\\osu!\\Skins";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(538, 470);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(100, 71);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Go !";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(538, 443);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(100, 20);
            this.seedTextBox.TabIndex = 1;
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(535, 427);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(38, 13);
            this.seedLabel.TabIndex = 2;
            this.seedLabel.Text = "Seed: ";
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(12, 25);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(319, 20);
            this.folderTextBox.TabIndex = 3;
            this.folderTextBox.Click += new System.EventHandler(this.folderTextBox_Click);
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(9, 9);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(70, 13);
            this.folderLabel.TabIndex = 4;
            this.folderLabel.Text = "Skin\'s folder: ";
            // 
            // texturesCheckBox
            // 
            this.texturesCheckBox.AutoSize = true;
            this.texturesCheckBox.Checked = true;
            this.texturesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.texturesCheckBox.Location = new System.Drawing.Point(12, 78);
            this.texturesCheckBox.Name = "texturesCheckBox";
            this.texturesCheckBox.Size = new System.Drawing.Size(104, 17);
            this.texturesCheckBox.TabIndex = 5;
            this.texturesCheckBox.Text = "Corrupt Textures";
            this.texturesCheckBox.UseVisualStyleBackColor = true;
            // 
            // soundsCheckBox
            // 
            this.soundsCheckBox.AutoSize = true;
            this.soundsCheckBox.Checked = true;
            this.soundsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soundsCheckBox.Location = new System.Drawing.Point(12, 101);
            this.soundsCheckBox.Name = "soundsCheckBox";
            this.soundsCheckBox.Size = new System.Drawing.Size(99, 17);
            this.soundsCheckBox.TabIndex = 6;
            this.soundsCheckBox.Text = "Corrupt Sounds";
            this.soundsCheckBox.UseVisualStyleBackColor = true;
            // 
            // fileCheckBox
            // 
            this.fileCheckBox.AutoSize = true;
            this.fileCheckBox.Checked = true;
            this.fileCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileCheckBox.Location = new System.Drawing.Point(12, 124);
            this.fileCheckBox.Name = "fileCheckBox";
            this.fileCheckBox.Size = new System.Drawing.Size(97, 17);
            this.fileCheckBox.TabIndex = 7;
            this.fileCheckBox.Text = "Corrupt Skin.ini";
            this.fileCheckBox.UseVisualStyleBackColor = true;
            // 
            // cursorCheckBox
            // 
            this.cursorCheckBox.AutoSize = true;
            this.cursorCheckBox.Location = new System.Drawing.Point(147, 78);
            this.cursorCheckBox.Name = "cursorCheckBox";
            this.cursorCheckBox.Size = new System.Drawing.Size(133, 17);
            this.cursorCheckBox.TabIndex = 8;
            this.cursorCheckBox.Text = "Reset to default cursor";
            this.cursorCheckBox.UseVisualStyleBackColor = true;
            // 
            // bigTexturesCheckBox
            // 
            this.bigTexturesCheckBox.AutoSize = true;
            this.bigTexturesCheckBox.Location = new System.Drawing.Point(286, 78);
            this.bigTexturesCheckBox.Name = "bigTexturesCheckBox";
            this.bigTexturesCheckBox.Size = new System.Drawing.Size(170, 17);
            this.bigTexturesCheckBox.TabIndex = 9;
            this.bigTexturesCheckBox.Text = "Prevent corrupting big textures";
            this.bigTexturesCheckBox.UseVisualStyleBackColor = true;
            // 
            // powerTextBox
            // 
            this.powerTextBox.Location = new System.Drawing.Point(438, 443);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.Size = new System.Drawing.Size(94, 20);
            this.powerTextBox.TabIndex = 10;
            this.powerTextBox.Text = "100";
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Location = new System.Drawing.Point(435, 427);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(76, 13);
            this.powerLabel.TabIndex = 11;
            this.powerLabel.Text = "Power: (0-100)";
            // 
            // MainForm
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 541);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.powerTextBox);
            this.Controls.Add(this.bigTexturesCheckBox);
            this.Controls.Add(this.cursorCheckBox);
            this.Controls.Add(this.fileCheckBox);
            this.Controls.Add(this.soundsCheckBox);
            this.Controls.Add(this.texturesCheckBox);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.seedTextBox);
            this.Controls.Add(this.goButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "osu!SkinCorruptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox seedTextBox;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.CheckBox texturesCheckBox;
        private System.Windows.Forms.CheckBox soundsCheckBox;
        private System.Windows.Forms.CheckBox fileCheckBox;
        private System.Windows.Forms.CheckBox cursorCheckBox;
        private System.Windows.Forms.CheckBox bigTexturesCheckBox;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.Label powerLabel;
    }
}