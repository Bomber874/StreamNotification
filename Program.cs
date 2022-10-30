using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WebhookSenderForOBS
{
    internal static class Program
    {
        public const string VERSION = "1.1";
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Update.CheckUpdate();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                Dictionary<string, string> settings;
                try
                {
                    settings = Settings.Get(args[0]); // Если нет такой секции, должно вернуться null
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString(), "Ошибка", MessageBoxButtons.OK);
                    return;
                }
                
                Webhook webhook = new Webhook(settings["url"], settings["name"], settings["icon"], settings["text"]);
                webhook.Send();
            }
        }
    }
}
