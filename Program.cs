using IniParser.Model;
using IniParser;
using System;
using System.Security.Policy;
using System.Windows.Forms;

namespace WebhookSenderForOBS
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile("StreamNotification/config.ini");
                Webhook webhook = new Webhook(data["Settings"]["url"], data["Settings"]["name"], data["Settings"]["icon"], data["Settings"]["text"]);
                webhook.Send();
            }
        }
    }
}
