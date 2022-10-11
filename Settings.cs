using IniParser;
using IniParser.Model;
using System.IO;
using System.Text;

namespace WebhookSenderForOBS
{
    public class Settings
    {
        static public KeyDataCollection Get(string settingsType)
        {
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile("StreamNotification/config.ini", Encoding.UTF8);
            return data[settingsType];
        }
        /// <summary>
        /// Создаст файл со стандартными настройками
        /// </summary>
        static public void Setup()
        {
            if(!Directory.Exists("StreamNotification"))
                Directory.CreateDirectory("StreamNotification");

            var parser = new FileIniDataParser();
            IniData data = new IniData();
            data.Sections.AddSection("start");
            data["start"].AddKey("url", "https://discord.com/api/webhooks/***/***");
            data["start"].AddKey("name", "Начало стрима");
            data["start"].AddKey("icon", "https://w7.pngwing.com/pngs/735/931/png-transparent-computer-icons-online-and-offline-others.png");
            data["start"].AddKey("text", "@everyone Подключайтесь");
            data.Sections.AddSection("stop");
            data["stop"].AddKey("url", "https://discord.com/api/webhooks/***/***");
            data["stop"].AddKey("name", "Окончание стрима");
            data["stop"].AddKey("icon", "https://img2.freepng.ru/20180406/roe/kisspng-computer-icons-online-and-offline-curved-line-5ac7236ebbbed6.825135841523000174769.jpg");
            data["stop"].AddKey("text", "До следующего стрима");
            parser.WriteFile("StreamNotification/config.ini", data, System.Text.Encoding.UTF8);
        }
    }
}
