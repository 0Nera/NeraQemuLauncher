
namespace NeraQemuLauncher
{
    partial class SettingsForm
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
            this.button_check_update = new System.Windows.Forms.Button();
            this.button_install_qemu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_check_update
            // 
            this.button_check_update.Location = new System.Drawing.Point(13, 13);
            this.button_check_update.Name = "button_check_update";
            this.button_check_update.Size = new System.Drawing.Size(128, 24);
            this.button_check_update.TabIndex = 0;
            this.button_check_update.Text = "Check version";
            this.button_check_update.UseVisualStyleBackColor = true;
            this.button_check_update.Click += new System.EventHandler(this.button_check_update_Click);
            // 
            // button_install_qemu
            // 
            this.button_install_qemu.Location = new System.Drawing.Point(147, 13);
            this.button_install_qemu.Name = "button_install_qemu";
            this.button_install_qemu.Size = new System.Drawing.Size(128, 24);
            this.button_install_qemu.TabIndex = 1;
            this.button_install_qemu.Text = "Install Qemu";
            this.button_install_qemu.UseVisualStyleBackColor = true;
            this.button_install_qemu.Click += new System.EventHandler(this.button_install_qemu_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.button_install_qemu);
            this.Controls.Add(this.button_check_update);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_check_update;
        private System.Windows.Forms.Button button_install_qemu;
    }
}