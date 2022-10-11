using IniParser.Model;
using IniParser;
using System;
using System.Text;
using System.Windows.Forms;


namespace WebhookSenderForOBS
{
    public partial class SettingsForm : Form
    {
        string _type; // Хранится start или stop, чтобы понять настройки для какого действия редактировать
        public SettingsForm(string type)
        {
            _type = type;
            InitializeComponent();
            var parser = new FileIniDataParser();

            IniData data = parser.ReadFile("StreamNotification/config.ini");
            urlText.Text = data[_type]["url"];
            nameText.Text = data[_type]["name"];
            iconText.Text = data[_type]["icon"];
            textText.Text = data[_type]["text"].Replace("\\n", Environment.NewLine);
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
            data[_type]["url"] = urlText.Text;
            data[_type]["name"] = nameText.Text;
            data[_type]["icon"] = iconText.Text;
            // Немного прогадался со способом сохранения текста. ini не поддерживает многострочные значения
            // Из-за этого теперь нельзя использовать \n в тексте оповещения.
            // Однако \n и так наверное нельзя использовать, дискорд бы распознал это как перевод строки
            data[_type]["text"] = textText.Text.Replace(Environment.NewLine, "\\n"); 
            parser.WriteFile("StreamNotification/config.ini", data);
            Close();
        }
    }
}
