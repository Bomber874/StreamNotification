using IniParser.Model;
using IniParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WebhookSenderForOBS
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("StreamNotification/config.ini");
            urlText.Text = data["Settings"]["url"];
            nameText.Text = data["Settings"]["name"];
            iconText.Text = data["Settings"]["icon"];
            textText.Text = data["Settings"]["text"];
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            urlText.Text = Clipboard.GetText();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if(urlText.PasswordChar == 0)
            {
                urlText.PasswordChar = '*';
                showButton.Text = "Показать";
            }
            else
            {
                urlText.PasswordChar = (char)0;
                showButton.Text = "Скрыть";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("StreamNotification/config.ini", Encoding.UTF8);
            data["Settings"]["url"] = urlText.Text;
            data["Settings"]["name"] = nameText.Text;
            data["Settings"]["icon"] = iconText.Text;
            data["Settings"]["text"] = textText.Text;
            parser.WriteFile("StreamNotification/config.ini", data);
            Close();
        }
    }
}
