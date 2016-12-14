using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                comboBox1.Items.Add(oneFontFamily.Name);
            }
        }

        private void link_ets2mp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://truckersmp.com");
        }

        private void about_tool_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void ets_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png) | *.png";
            dialog.Title = "Please select an UI Skin image";
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                ets_file.Text = dialog.FileName;
            }
        }

        private void ats_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png) | *.png";
            dialog.Title = "Please select an UI Skin image";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                    ats_file.Text = dialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ets_file.Text != "")
                {
                    if (File.Exists(ets_file.Text))
                    {
                        var header = new byte[4];
                        using (var fs = new FileStream(ets_file.Text, FileMode.Open))
                        {
                            fs.Read(header, 0, 4);
                            fs.Close();
                        }

                        var strHeader = Encoding.ASCII.GetString(header);
                        if (strHeader.ToLower().EndsWith("png"))
                        {
                            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ets2\\ui\\ui_skin_backup.png"))
                                File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ets2\\ui\\ui_skin.png", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ets2\\ui\\ui_skin_backup.png");
                            File.Copy(ets_file.Text, Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ets2\\ui\\ui_skin.png", true);
                        }
                        else
                        {
                            MessageBox.Show("ETS2: Image selected is not a png file!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else{
                        MessageBox.Show("ETS2: Image path invalid!\n\nMake path empty to exclude it!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch {
                MessageBox.Show("ETS2: An error occurred patching the image!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (ats_file.Text != "")
                {
                    if (File.Exists(ats_file.Text))
                    {
                        var header = new byte[4];
                        using (var fs = new FileStream(ats_file.Text, FileMode.Open))
                        {
                            fs.Read(header, 0, 4);
                            fs.Close();
                        }

                        var strHeader = Encoding.ASCII.GetString(header);
                        if (strHeader.ToLower().EndsWith("png"))
                        {
                            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ats\\ui\\ui_skin_backup.png"))
                                File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ats\\ui\\ui_skin.png", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ats\\ui\\ui_skin_backup.png");
                            File.Copy(ats_file.Text, Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ats\\ui\\ui_skin.png", true);
                        }
                        else
                        {
                            MessageBox.Show("ATS: Image selected is not a png file!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ATS: Image path invalid!\n\nMake path empty to exclude it!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("ATS: An error occurred patching the image!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Patch complete!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ets2\\ui\\ui_skin_backup.png"))
                {
                    File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ets2\\ui\\ui_skin_backup.png", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ets2\\ui\\ui_skin.png", true);
                }
                else
                {
                    MessageBox.Show("ETS2: No backup found!\n\nThis can also mean you've yet to add a custom skin to ETS2MP", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("ETS2: An error occurred restoring the UI Skin!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ats\\ui\\ui_skin_backup.png"))
                {
                    File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ats\\ui\\ui_skin_backup.png", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ats\\ui\\ui_skin.png", true);
                }
                else
                {
                    MessageBox.Show("ATS: No backup found!\n\nThis can also mean you've yet to add a custom skin to ATSMP", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("ATS: An error occurred restoring the UI Skin!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Restore complete!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ETS2
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image files (*.png) | *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ets2\\ui\\ui_skin_backup.png"))
                    {
                        File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ets2\\ui\\ui_skin_backup.png", dialog.FileName, true);
                    }
                    else
                    {
                        File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ets2\\ui\\ui_skin.png", dialog.FileName, true);
                    }
                }
                catch
                {
                    MessageBox.Show("ETS2: An error occurred extracting the skin!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("ETS2: Skin extracted!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ATS
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image files (*.png) | *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ats\\ui\\ui_skin_backup.png"))
                    {
                        File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ats\\ui\\ui_skin_backup.png", dialog.FileName, true);
                    }
                    else
                    {
                        File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\ats\\ui\\ui_skin.png", dialog.FileName, true);
                    }
                }
                catch
                {
                    MessageBox.Show("ATS: An error occurred extracting the skin!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("ATS: Skin extracted!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Install font
            try
            {
                if (comboBox1.SelectedItem.ToString() != "")
                {
                    
                    if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\shared\\fonts\\OpenSans_backup.ttf"))
                        File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\shared\\fonts\\OpenSans.ttf", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\shared\\fonts\\OpenSans_backup.ttf");

                    var font = getFontFileName(new Font(comboBox1.SelectedItem.ToString(), this.label5.Font.Size));
                    File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), font), Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\shared\\fonts\\OpenSans.ttf", true);
                }
            }
            catch
            {
                MessageBox.Show("An error occurred patching the font!\n\nMight be an incompatible font, try another one!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Font installed!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Font = new Font(comboBox1.SelectedItem.ToString(), this.label5.Font.Size);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Restore font
            try
            {
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\shared\\fonts\\OpenSans_backup.ttf"))
                {
                    File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\shared\\fonts\\OpenSans_backup.ttf", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data\\shared\\fonts\\OpenSans.ttf", true);
                }
                else
                {
                    MessageBox.Show("No backup found!\n\nYou need to reinstall the mod to restore the font!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("An error occurred restoring the font!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Font restored!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static string getFontFileName(Font font)
        {
            RegistryKey fonts = null;
            try
            {
                fonts = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Fonts", false);
                if (fonts == null)
                {
                    fonts = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Fonts", false);
                    if (fonts == null)
                    {
                        throw new Exception("Registery aint feeling so good :/");
                    }
                }
                string[] names = fonts.GetValueNames();
                StringBuilder nameb = new StringBuilder(font.Name);
                if (font.Bold)
                    nameb.Append(" Bold");
                if (font.Italic)
                    nameb.Append(" Italic");
                nameb.Append(" (TrueType)");
                string fullname = nameb.ToString();
                string basename = font.Name + " (TrueType)";
                object file = fonts.GetValue(fullname);
                if (file == null && fullname != basename)
                {
                    file = fonts.GetValue(basename);
                }
                if (file != null) return file.ToString();
                return null;
            }
            finally
            {
                if (fonts != null)
                {
                    fonts.Dispose();
                }
            }
        }
    }
}
