using System.Net;
using System.Windows.Forms;

namespace WebhookSenderForOBS
{
    internal class Update
    {
        protected static string GetLatestVersion()
        {
            string contents;

            try
            {
                using (var wc = new System.Net.WebClient())
                    contents = wc.DownloadString("https://raw.githubusercontent.com/Bomber874/StreamNotification/master/version.txt");
            }
            catch (WebException ex)
            {
                System.Console.WriteLine(ex.Message);
                contents = "0";
            }
            return contents.Trim();
        }
        public static void CheckUpdate()
        {
            switch (Update.GetLatestVersion())
            {
                case Program.VERSION:
                    MessageBox.Show("У вас последняя версия программы", "Обновление", MessageBoxButtons.OK);
                    break;
                case "0":
                    MessageBox.Show("Не удалось проверить наличие обновлений\nРекомендуется вручную проверить обновления\nhttps://github.com/Bomber874/StreamNotification", "Обновление", MessageBoxButtons.OK);
                    break;
                default:
                    MessageBox.Show("Обнаружена новая версия программы.\nРекомендуется выполнить обновление", "Обновление", MessageBoxButtons.OK);
                    break;
            }
        }
    }
    
}
