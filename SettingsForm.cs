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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace NeraQemuLauncher
{
    public partial class SettingsForm : Form
    {
        

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button_install_qemu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Open website?",
                "https://www.qemu.org/download/",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.qemu.org/download/");
            }
        }

        private void button_check_update_Click(object sender, EventArgs e)
        {
            try
            {
                string sURL= "https://0Nera.github.io/NeraQemuLauncher/last.ini";
                string InstallerURL = "https://0Nera.github.io/NeraQemuLauncher/installer.exe";
                const int LocalVersion = 100;
                int LastVersion;


                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

                using (var client = new WebClient())
                {
                    client.DownloadFile(new Uri(sURL), "last.ini");
                }

                INIManager manager = new INIManager(Path.GetFullPath("last.ini"));

                LastVersion = int.Parse(manager.GetPrivateString("main", "version"));
                InstallerURL = manager.GetPrivateString("main", "installer");

                if (LocalVersion == LastVersion)
                {
                    MessageBox.Show(
                        "You have last version",
                        "Last version info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                } else
                {
                    DialogResult result = MessageBox.Show(
                        "Install last version?",
                        "New version avaible",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(InstallerURL);
                    }
                }
                
            } catch (Exception E) {
                DialogResult result = MessageBox.Show(
                    "Send error log to developer?",
                    "Error",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("mailto:email@example.com?subject=Error&amp;body=" + E.ToString());
                } else
                {
                    MessageBox.Show(
                        E.ToString(),
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            
        }
        public static bool AcceptAllCertificatePolicy(object sender, X509Certificate certificate, X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
