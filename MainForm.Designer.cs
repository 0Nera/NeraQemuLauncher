
namespace NeraQemuLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runQemu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_left_menu = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_args = new System.Windows.Forms.Label();
            this.textBox_args = new System.Windows.Forms.TextBox();
            this.textBox_ram = new System.Windows.Forms.TextBox();
            this.label_memory = new System.Windows.Forms.Label();
            this.textBox_CDROM = new System.Windows.Forms.TextBox();
            this.label_cdrom = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_ram = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panel_left_menu.SuspendLayout();
            this.panel_footer.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(801, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menu";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runQemu});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // runQemu
            // 
            this.runQemu.Name = "runQemu";
            this.runQemu.Size = new System.Drawing.Size(131, 22);
            this.runQemu.Text = "Run Qemu";
            this.runQemu.Click += new System.EventHandler(this.runQemuToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.onlineHelpToolStripMenuItem,
            this.offlineHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.onlineHelpToolStripMenuItem.Text = "Online help";
            // 
            // offlineHelpToolStripMenuItem
            // 
            this.offlineHelpToolStripMenuItem.Name = "offlineHelpToolStripMenuItem";
            this.offlineHelpToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.offlineHelpToolStripMenuItem.Text = "Offline help";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel_left_menu
            // 
            this.panel_left_menu.Controls.Add(this.listView1);
            this.panel_left_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left_menu.Location = new System.Drawing.Point(0, 24);
            this.panel_left_menu.Name = "panel_left_menu";
            this.panel_left_menu.Size = new System.Drawing.Size(125, 489);
            this.panel_left_menu.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(125, 489);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.label_ram);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(125, 483);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(676, 30);
            this.panel_footer.TabIndex = 2;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.label_args);
            this.panel_main.Controls.Add(this.textBox_args);
            this.panel_main.Controls.Add(this.textBox_ram);
            this.panel_main.Controls.Add(this.label_memory);
            this.panel_main.Controls.Add(this.textBox_CDROM);
            this.panel_main.Controls.Add(this.label_cdrom);
            this.panel_main.Controls.Add(this.label_name);
            this.panel_main.Controls.Add(this.textBox_name);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(125, 24);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(676, 459);
            this.panel_main.TabIndex = 3;
            // 
            // label_args
            // 
            this.label_args.AutoSize = true;
            this.label_args.Location = new System.Drawing.Point(7, 87);
            this.label_args.Name = "label_args";
            this.label_args.Size = new System.Drawing.Size(28, 13);
            this.label_args.TabIndex = 7;
            this.label_args.Text = "Args";
            // 
            // textBox_args
            // 
            this.textBox_args.Location = new System.Drawing.Point(61, 84);
            this.textBox_args.Name = "textBox_args";
            this.textBox_args.Size = new System.Drawing.Size(603, 20);
            this.textBox_args.TabIndex = 6;
            // 
            // textBox_ram
            // 
            this.textBox_ram.Location = new System.Drawing.Point(61, 58);
            this.textBox_ram.Name = "textBox_ram";
            this.textBox_ram.Size = new System.Drawing.Size(603, 20);
            this.textBox_ram.TabIndex = 5;
            this.textBox_ram.Text = "4";
            // 
            // label_memory
            // 
            this.label_memory.AutoSize = true;
            this.label_memory.Location = new System.Drawing.Point(7, 61);
            this.label_memory.Name = "label_memory";
            this.label_memory.Size = new System.Drawing.Size(31, 13);
            this.label_memory.TabIndex = 4;
            this.label_memory.Text = "RAM";
            // 
            // textBox_CDROM
            // 
            this.textBox_CDROM.Location = new System.Drawing.Point(61, 32);
            this.textBox_CDROM.Name = "textBox_CDROM";
            this.textBox_CDROM.Size = new System.Drawing.Size(603, 20);
            this.textBox_CDROM.TabIndex = 3;
            this.textBox_CDROM.Text = "SynapseOS.iso";
            // 
            // label_cdrom
            // 
            this.label_cdrom.AutoSize = true;
            this.label_cdrom.Location = new System.Drawing.Point(7, 35);
            this.label_cdrom.Name = "label_cdrom";
            this.label_cdrom.Size = new System.Drawing.Size(47, 13);
            this.label_cdrom.TabIndex = 2;
            this.label_cdrom.Text = "CDROM";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(7, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(61, 6);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(603, 20);
            this.textBox_name.TabIndex = 0;
            this.textBox_name.Text = "SynapseOS";
            // 
            // label_ram
            // 
            this.label_ram.AutoSize = true;
            this.label_ram.Location = new System.Drawing.Point(7, 7);
            this.label_ram.Name = "label_ram";
            this.label_ram.Size = new System.Drawing.Size(31, 13);
            this.label_ram.TabIndex = 0;
            this.label_ram.Text = "RAM";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(801, 513);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_left_menu);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeraQemuLauncher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel_left_menu.ResumeLayout(false);
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offlineHelpToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel_left_menu;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem runQemu;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_cdrom;
        private System.Windows.Forms.TextBox textBox_CDROM;
        private System.Windows.Forms.TextBox textBox_ram;
        private System.Windows.Forms.Label label_memory;
        private System.Windows.Forms.TextBox textBox_args;
        private System.Windows.Forms.Label label_args;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label label_ram;
    }
}

