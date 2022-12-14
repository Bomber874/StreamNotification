using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Windows.Forms;

namespace WebhookSenderForOBS
{
    public class Webhook
    {
        string _name;
        string _hookURL;
        string _imageURL;
        string _text;
        /// <summary>
        /// Создаёт вебхук
        /// </summary>
        /// <param name="hookURL">Ссылка на вебхук</param>
        /// <param name="name">Имя вебхука</param>
        /// <param name="profile">Ссылка на изображение для иконки вебхука</param>
        /// <param name="message">Текст сообщения</param>
        public Webhook(string hookURL, string name, string profile, string message)
        {
            _hookURL = hookURL;
            _name = name;
            _imageURL = profile;
            _text = message;
        }
        protected void _Send(string hookURL, string name, string profile, string message)
        {
            if (!Uri.IsWellFormedUriString(hookURL, UriKind.Absolute))
            {
                MessageBox.Show($"Не удалось распознать ссылку на вебхук:\n{hookURL}", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            NameValueCollection webhookInfo = new NameValueCollection();
            webhookInfo.Add("username", name);
            webhookInfo.Add("avatar_url", profile);
            webhookInfo.Add("content", message.Replace("\\n", Environment.NewLine));

            try
            {
                new WebClient().UploadValues(hookURL, webhookInfo);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show($"Некорректная ссылка на вебхук:\n{e.Message}", "Ошибка", MessageBoxButtons.OK);
            }
            //catch (ArgumentNullException e)
            //{
            //    MessageBox.Show($"Некорректная ссылка на вебхук\n{e.Message}", "Ошибка", MessageBoxButtons.OK);
            //}
            catch (WebException e)
            {
                if (Uri.IsWellFormedUriString(profile, UriKind.Absolute))
                    MessageBox.Show($"Ошибка на сервере:\n{e.Message}", "Ошибка", MessageBoxButtons.OK);
                else
                    MessageBox.Show($"Кажется эта ссылка на изображение не подходит.\nУказанная ссылка:{profile}", "Ошибка", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// Отправляет вебхук
        /// </summary>
        public void Send()
        {
            _Send(_hookURL, _name, _imageURL, _text);
        }
        /// <summary>
        /// Отправляет вебхук
        /// </summary>
        /// <param name="settings"></param>
        public void Send(Dictionary<string,string> settings)
        {
            _Send(settings["url"], settings["name"], settings["image"], settings["text"]);
        }
    }
}
