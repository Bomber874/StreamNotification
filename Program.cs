using IniParser.Model;
using IniParser;
using System;
using System.Security.Policy;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace WebhookSenderForOBS
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                KeyDataCollection settings;
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
