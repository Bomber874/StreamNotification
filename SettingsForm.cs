using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WebhookSenderForOBS
{
    public partial class SettingsForm : Form
    {
        string _type; // Хранится start или stop, чтобы понять настройки для какого действия редактировать
        public SettingsForm(string type)
        {
            _type = type;
            InitializeComponent();
            var data = Settings.Get(_type);
            urlText.Text = data["url"];
            nameText.Text = data["name"];
            iconText.Text = data["icon"];
            textText.Text = data["text"].Replace("\\n", Environment.NewLine);
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

            Dictionary<string, string> data = new Dictionary<string, string>();
            data["url"] = urlText.Text;
            data["name"] = nameText.Text;
            data["icon"] = iconText.Text;
            data["text"] = textText.Text;
            Settings.Save(_type, data);
            Close();
        }
    }
}
