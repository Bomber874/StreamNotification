using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebhookSenderForOBS
{
    public partial class SendWebhookForm : Form
    {
        public SendWebhookForm()
        {
            InitializeComponent();
        }

        private void sendTestWH_Click(object sender, EventArgs e)
        {
            string url = Clipboard.GetText();
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("StreamNotification/config.ini");
            Webhook webhook = new Webhook(url, data["Settings"]["name"], data["Settings"]["icon"], data["Settings"]["text"]);
            webhook.Send();
        }
    }
}
