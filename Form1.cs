using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WebhookSenderForOBS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists("StreamNotification/settings"))
            {
                Settings.Setup();
            }
        }

        private void openStartSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm("start");
            settingsForm.ShowDialog();
        }

        private void testWebhook_Click(object sender, EventArgs e)
        {
            SendWebhookForm webhookForm = new SendWebhookForm("start");
            webhookForm.ShowDialog();
        }

        private void createLuaFile_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists("StreamNotification"))
                Directory.CreateDirectory("StreamNotification");
            string contents;
            using (var wc = new System.Net.WebClient())
                contents = wc.DownloadString("https://raw.githubusercontent.com/Bomber874/StreamNotification/master/WebHookSender.lua");
            
            try
            {
                using (FileStream fs = File.Create("StreamNotification/WebHookSender.lua"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(contents);
                    fs.Write(info, 0, info.Length);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Текст ошибки:\n{ex.ToString()}", "Ошибка", MessageBoxButtons.OK);
            }

        }

        private void openStopSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm("stop");
            settingsForm.ShowDialog();
        }

        private void testStopWebhook_Click(object sender, EventArgs e)
        {
            SendWebhookForm webhookForm = new SendWebhookForm("stop");
            webhookForm.ShowDialog();
        }
    }
}
