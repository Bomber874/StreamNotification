﻿using IniParser;
using IniParser.Model;
using System;
using System.IO;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace WebhookSenderForOBS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openSettings_Click(object sender, EventArgs e)
        {
            if (!File.Exists("StreamNotification/config.ini"))
            {
                Directory.CreateDirectory("StreamNotification");
                var parser = new FileIniDataParser();
                IniData data = new IniData();
                data.Sections.AddSection("Settings");
                data["Settings"].AddKey("url", "https://discord.com/api/webhooks/***/***");
                data["Settings"].AddKey("name", "Начало стрима");
                data["Settings"].AddKey("icon", "Ссылка на иконку");
                data["Settings"].AddKey("text", "Подключайтесь");
                parser.WriteFile("StreamNotification/config.ini", data, System.Text.Encoding.UTF8);

            }
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void testWebhook_Click(object sender, EventArgs e)
        {
            SendWebhookForm webhookForm = new SendWebhookForm();
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
    }
}
