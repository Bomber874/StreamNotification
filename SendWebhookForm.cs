using System;
using System.Windows.Forms;

namespace WebhookSenderForOBS
{
    public partial class SendWebhookForm : Form
    {
        protected string _type;
        public SendWebhookForm(string type)
        {
            _type = type;
            InitializeComponent();
        }

        private void sendTestWH_Click(object sender, EventArgs e)
        {
            string url = Clipboard.GetText();
            var settings = Settings.Get(_type);
            Webhook webhook = new Webhook(url, settings["name"], settings["icon"], settings["text"]);
            webhook.Send();
        }
    }
}
