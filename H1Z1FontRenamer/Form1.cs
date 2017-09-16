using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H1Z1FontRenamer
{
    public partial class H1Z1FontRenamer : Form
    {
        /* Dialogs */
        OpenFileDialog fontDialog;
        FolderBrowserDialog destFolderDialog;

        /* Basic behaviour */
        String fontFile;
        String destPath;

        /* Advanced behaviour */
        String lightFontFile;
        String mediumFontFile;
        String boldFontFile;
        String advDestPath;

        /* Fonts name */
        String[] boldFont;
        String[] lightFont;
        String[] mediumFont;

        public H1Z1FontRenamer()
        {
            InitializeComponent();
            this.Size = new Size(285, 260);
            fontDialog = new OpenFileDialog
            {
                Filter = "Font files (*.ttf, *.otf)|*.ttf;*.otf"
            };
            destFolderDialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };

            fontFile = "";
            destPath = "";
            lightFontFile = "";
            mediumFontFile = "";
            boldFontFile = "";
            advDestPath = "";

            boldFont = new String[]
            {
                "CaviarDreams_Bold.ttf",
                "NanumBarunGothicBold.ttf",
                "Oswald-Bold_0.ttf",
                "Roboto-Bold.ttf"
            };
            mediumFont = new String[]
            {
                "NotoSansJP-Regular.otf",
                "Oswald-Regular_0.ttf",
                "Roboto-Medium.ttf",
                "Roboto-Regular.ttf",
                "ROSA Verde Normal.ttf",
                "simhei.ttf"
            };
            lightFont = new String[]
            {
                "Oswald-Light_0.ttf",
                "Roboto-Light.ttf"
            };
        }

        private void advancedMenuItem_Click(object sender, EventArgs e)
        {
            advancedMenuItem.Checked = !advancedMenuItem.Checked;
            basicPanel.Visible = !advancedMenuItem.Checked;
            advancedPanel.Visible = advancedMenuItem.Checked;
            if (advancedPanel.Visible)
            {
                this.Size = new Size(285, 330);
            }
            else
            {
                this.Size = new Size(285, 260);
            }
        }

        private void fontFileButton_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog().Equals(DialogResult.OK))
            {
                if (fontDialog.CheckFileExists && fontDialog.CheckPathExists)
                {
                    fontFileText.Text = fontDialog.FileName;
                    fontFile = fontDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Error : file does not exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void destinationFolderButton_Click(object sender, EventArgs e)
        {
            if (destFolderDialog.ShowDialog().Equals(DialogResult.OK))
            {
                destinationText.Text = destFolderDialog.SelectedPath;
                destPath = destFolderDialog.SelectedPath;
            }
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(fontFile) && !String.IsNullOrWhiteSpace(destPath))
            {
                System.IO.FileInfo file = new System.IO.FileInfo(destPath);
                file.Directory.Create();
                String[] allFonts = new String[lightFont.Length + boldFont.Length + mediumFont.Length];
                lightFont.CopyTo(allFonts, 0);
                mediumFont.CopyTo(allFonts, lightFont.Length);
                boldFont.CopyTo(allFonts, lightFont.Length + mediumFont.Length);
                foreach (String font in allFonts)
                {
                    System.IO.File.Copy(fontFile, destPath + "/" + font, true);
                }
                MessageBox.Show("Success : all font files created with success !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error : file or folder does not exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lightFontButton_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog().Equals(DialogResult.OK))
            {
                if (fontDialog.CheckFileExists && fontDialog.CheckPathExists)
                {
                    lightFontText.Text = fontDialog.FileName;
                    lightFontFile = fontDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Error : file does not exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mediumFontButton_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog().Equals(DialogResult.OK))
            {
                if (fontDialog.CheckFileExists && fontDialog.CheckPathExists)
                {
                    mediumFontText.Text = fontDialog.FileName;
                    mediumFontFile = fontDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Error : file does not exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void boldFontButton_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog().Equals(DialogResult.OK))
            {
                if (fontDialog.CheckFileExists && fontDialog.CheckPathExists)
                {
                    boldFontText.Text = fontDialog.FileName;
                    boldFontFile = fontDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Error : file does not exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void advFolderDestButton_Click(object sender, EventArgs e)
        {
            if (destFolderDialog.ShowDialog().Equals(DialogResult.OK))
            {
                advFolderDestText.Text = destFolderDialog.SelectedPath;
                advDestPath = destFolderDialog.SelectedPath;
            }
        }

        private void advRenameButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(lightFontFile) && !String.IsNullOrWhiteSpace(mediumFontFile)
                && !String.IsNullOrWhiteSpace(boldFontFile) && !String.IsNullOrWhiteSpace(advDestPath))
            {
                System.IO.FileInfo file = new System.IO.FileInfo(advDestPath);
                file.Directory.Create();
                foreach (String font in lightFont)
                {
                    System.IO.File.Copy(lightFontFile, advDestPath + "/" + font, true);
                }
                foreach (String font in mediumFont)
                {
                    System.IO.File.Copy(mediumFontFile, advDestPath + "/" + font, true);
                }
                foreach (String font in boldFont)
                {
                    System.IO.File.Copy(boldFontFile, advDestPath + "/" + font, true);
                }
                MessageBox.Show("Success : all font files created with success !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error : file or folder does not exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showCredit(object sender, EventArgs e)
        {
            Console.WriteLine("hello le monde");
            MessageBox.Show("tototo", "");
        }
    }
}
