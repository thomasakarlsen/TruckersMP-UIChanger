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
using System.IO.Compression;

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
            dialog.Filter = "ZIP File (*.zip) | *.zip";
            dialog.Title = "Please select a UI Pack ZIP file";
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                uipack_file.Text = dialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string TruckersMPDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data";
            string workDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\UIChanger";
            List<string> TruckersMPFiles = new List<string>();
            List <string> UIPackFiles = new List<string>();

            try
            {
                if (uipack_file.Text != "")
                {
                    if (File.Exists(uipack_file.Text))
                    {
                        try
                        {
                            if (!Directory.Exists(workDirectory))
                                Directory.CreateDirectory(workDirectory);

                            if (Directory.Exists(workDirectory + "\\temp"))
                                Directory.Delete(workDirectory + "\\temp", true);

                            Directory.CreateDirectory(workDirectory + "\\temp");

                            ZipFile.ExtractToDirectory(uipack_file.Text, workDirectory + "\\temp");
                        }
                        catch
                        {
                            MessageBox.Show("An error occured while unpacking UI Pack!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        try
                        {
                            foreach (var file in System.IO.Directory.GetFiles(TruckersMPDirectory, "*.*", System.IO.SearchOption.AllDirectories))
                            {
                                FileInfo info = new FileInfo(file);

                                string key = info.FullName;
                                key = key.Replace(TruckersMPDirectory, "");

                                TruckersMPFiles.Add(key);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("An error occured while mapping TruckersMP!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        try
                        {
                            foreach (var file in System.IO.Directory.GetFiles(workDirectory + "\\temp", "*.*", System.IO.SearchOption.AllDirectories))
                            {
                                FileInfo info = new FileInfo(file);

                                string key = info.FullName;
                                key = key.Replace(workDirectory + "\\temp", "");

                                UIPackFiles.Add(key);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("An error occured while mapping UI Pack!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        try
                        {
                            foreach (var file in TruckersMPFiles)
                            {
                                string clean = ((file.Replace("\\ats_mod", "")).Replace("\\ets2_mod", "")).Replace("\\shared_mod", "");

                                if (UIPackFiles.Contains(clean))
                                {

                                    int index = UIPackFiles.FindIndex(x => x.StartsWith(clean));

                                    string[] s = file.Split('.');
                                    string backupFile = s[0] + "_backup." + s[1];

                                    if (!File.Exists(TruckersMPDirectory + backupFile))
                                        File.Copy(TruckersMPDirectory + file, TruckersMPDirectory + backupFile);

                                    File.Copy(workDirectory + "\\temp" + UIPackFiles[index], TruckersMPDirectory + file, true);
                                }
                                else if (UIPackFiles.Contains(clean.Replace("ui_skin", "ets2mp_ui_skin")))
                                {
                                    int index = UIPackFiles.FindIndex(x => x.StartsWith(clean.Replace("ui_skin", "ets2mp_ui_skin")));

                                    string[] s = file.Split('.');
                                    string backupFile = s[0] + "_backup." + s[1];

                                    if (!File.Exists(TruckersMPDirectory + backupFile))
                                        File.Copy(TruckersMPDirectory + file, TruckersMPDirectory + backupFile);

                                    File.Copy(workDirectory + "\\temp" + UIPackFiles[index], TruckersMPDirectory + file, true);
                                }
                                else if (UIPackFiles.Contains(clean.Replace("ui_skin", "atsmp_ui_skin")))
                                {
                                    int index = UIPackFiles.FindIndex(x => x.StartsWith(clean.Replace("ui_skin", "atsmp_ui_skin")));

                                    string[] s = file.Split('.');
                                    string backupFile = s[0] + "_backup." + s[1];

                                    if (!File.Exists(TruckersMPDirectory + backupFile))
                                        File.Copy(TruckersMPDirectory + file, TruckersMPDirectory + backupFile);

                                    File.Copy(workDirectory + "\\temp" + UIPackFiles[index], TruckersMPDirectory + file, true);
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("An error occured while patching files!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else{
                        MessageBox.Show("Unable to find selected file, please select another one!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (Directory.Exists(workDirectory))
                    Directory.Delete(workDirectory, true);
            }
            catch {
                MessageBox.Show("An error occured while patching UI Pack.\n\nGeneric error", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Install complete.", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TruckersMPDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP\\data";
            List<string> TruckersMPFiles = new List<string>();

            try
            {
                foreach (var file in System.IO.Directory.GetFiles(TruckersMPDirectory, "*.*", System.IO.SearchOption.AllDirectories))
                {
                    FileInfo info = new FileInfo(file);

                    string key = info.FullName;
                    key = key.Replace(TruckersMPDirectory, "");

                    TruckersMPFiles.Add(key);
                }
            }
            catch
            {
                MessageBox.Show("An error occured while mapping TruckersMP!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                foreach (var file in TruckersMPFiles)
                {
                    if (file.Contains("_backup")) {
                        string orig = file.Replace("_backup", "");
                        File.Copy(TruckersMPDirectory + file, TruckersMPDirectory + orig, true);
                        File.Delete(TruckersMPDirectory + file);
                    }
                }
            }
            catch
            {
                MessageBox.Show("An error occured while restoring files!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Restore complete!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Open dir
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
