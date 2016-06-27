using System;
using System.Windows.Forms;

namespace OsuSkinCorruptor
{
    public partial class MainForm : Form
    {
        Random r = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(seedTextBox.Text))
                seedTextBox.Text = r.Next() + "";

            int newSeed = 0;

            if (!int.TryParse(seedTextBox.Text, out newSeed))
                foreach (char ch in folderTextBox.Text)
                {
                    if (char.IsNumber(ch)) continue;

                    newSeed += ch;
                }

            Corruptor c = new Corruptor(folderBrowserDialog.SelectedPath, newSeed, int.Parse(powerTextBox.Text));
            c.corruptSounds = soundsCheckBox.Checked;
            c.corruptTextures = texturesCheckBox.Checked;
            c.corruptSkinFile = fileCheckBox.Checked;
            c.resetCursorFiles = cursorCheckBox.Checked;
            c.keepBigtextures = bigTexturesCheckBox.Checked;
            c.start();
        }

        private void folderTextBox_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            folderTextBox.Text = folderBrowserDialog.SelectedPath;
            goButton.Enabled = true;
        }
    }
}
