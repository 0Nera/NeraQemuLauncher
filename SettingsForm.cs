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
                string sURL;
                sURL = "https://0Nera.github.io/NeraQemuLauncher/last.ini";
                WebRequest wrGETURL;
                wrGETURL = WebRequest.Create(sURL);
                WebProxy myProxy = new WebProxy("localhost", 80);
                myProxy.BypassProxyOnLocal = true;

                wrGETURL.Proxy = WebProxy.GetDefaultProxy();

                Stream objStream;
                objStream = wrGETURL.GetResponse().GetResponseStream();

                StreamReader objReader = new StreamReader(objStream);

                string sLine = "";
                string LastVersion = "1.0.0";
                string LocalVersion = "1.0.0";
                string InstallerURL = "https://0Nera.github.io/NeraQemuLauncher/installer.exe";
                string FullResponse = "Last version: ";
                int i = 0;

                WebRequest reqGET = System.Net.WebRequest.Create(@"https://0Nera.github.io/NeraQemuLauncher/last.ini");
                WebResponse resp = reqGET.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new System.IO.StreamReader(stream);
                string s = sr.ReadToEnd();
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
    }
}
