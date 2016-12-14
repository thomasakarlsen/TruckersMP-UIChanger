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
                MessageBox.Show("ETS2: An error occured patching the image!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ATS: An error occured patching the image!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ETS2: An error occured restoring the UI Skin!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ATS: An error occured restoring the UI Skin!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("ETS2: An error occured extracting the skin!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("ATS: An error occured extracting the skin!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("ATS: Skin extracted!", "TruckersMP UI Changer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
