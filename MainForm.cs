using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices; 

namespace NeraQemuLauncher
{
    public partial class MainForm : Form
    {
        Boolean HaveCD = true;

        String QemuSystem = "qemu-system-i386";
        String cdroom = "SynapseOS.iso";
        String args = "";

        string[] filePaths = Directory.GetFiles(Path.GetFullPath(Directory.GetCurrentDirectory() + "/Projects/"), "*.ini");

        int Memory = 512;


        public MainForm()
        {
            InitializeComponent();
        }

        private void runQemuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HaveCD)
            {
                cdroom = textBox_CDROM.Text;
            }
            
            args = textBox_args.Text;
            Memory = int.Parse(textBox_ram.Text);


            System.Diagnostics.Process.Start(
                "CMD.exe", 
                string.Format(
                    "/C echo new log>log.txt" +
                    " & {0} -m {1} -cdrom \".\\OS\\{2}\" -monitor stdio -serial file:log.txt" +
                    " {3} & pause", 
                    
                    QemuSystem, Memory, cdroom, args
                    ));
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "NeraQemuLauncher 1.0.0\nBy Aren Elchinyan 2021\n\nOpen website?",
                "About",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://0Nera.github.io/NeraQemuLauncher");
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm newForm = new SettingsForm();
            newForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            comboBox_system.Items.AddRange(new string[] { 
                "qemu-system-arm", 
                "qemu-system-armw",
                "qemu-system-i386",
                "qemu-system-i386w",
                "qemu-system-x86_64",
                "qemu-system-x86_64w"
            });
            //label_ram.Text = "Total RAM: " + (new ComputerInfo().TotalPhysicalMemory / 1024 / 1024).ToString();

            foreach (String n in filePaths)
            {
                listBox_configs.Items.Add(Path.GetFileName(n));
            }
        }

        private void comboBox_system_SelectedIndexChanged(object sender, EventArgs e)
        {
            QemuSystem = comboBox_system.Text.ToString();
        }

        private void listBox_configs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                INIManager manager = new INIManager(Path.GetFullPath("./Projects/"+listBox_configs.SelectedItem.ToString()));
                textBox_name.Text = manager.GetPrivateString("main", "Name");
                textBox_CDROM.Text = manager.GetPrivateString("main", "Cdroom");
                textBox_ram.Text = manager.GetPrivateString("main", "RAM");
                textBox_args.Text = manager.GetPrivateString("main", "Args");
                comboBox_system.Text = manager.GetPrivateString("main", "System");
            } catch
            {

            }
            
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Open website?",
                "Online help",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://0Nera.github.io/NeraQemuLauncher#Docs");
            }
        }

        private void offlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Open PDF?",
                "Offline help",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Path.GetFullPath("./docs.html"));
            }
        }
    }
}
