using System;
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
        /// <summary>
        /// Отправляет вебхук
        /// </summary>
        public void Send()
        {
            if (!Uri.IsWellFormedUriString(_hookURL, UriKind.Absolute))
                MessageBox.Show($"Не удалось распознать ссылку на вебхук:\n{_hookURL}", "Ошибка", MessageBoxButtons.OK);
            NameValueCollection webhookInfo = new NameValueCollection();
            webhookInfo.Add("username", _name);
            webhookInfo.Add("avatar_url", _imageURL);
            webhookInfo.Add("content", _text);

            try 
            {
                new WebClient().UploadValues(_hookURL, webhookInfo);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show($"Некорректная ссылка на вебхук:\n{e.Message}", "Ошибка", MessageBoxButtons.OK);
            }
            //catch (ArgumentNullException e)
            //{
            //    MessageBox.Show($"Некорректная ссылка на вебхук\n{e.Message}", "Ошибка", MessageBoxButtons.OK);
            //}
            catch(WebException e)
            {
                if(Uri.IsWellFormedUriString(_imageURL, UriKind.Absolute))
                    MessageBox.Show($"Ошибка на сервере:\n{e.Message}", "Ошибка", MessageBoxButtons.OK);
                else
                    MessageBox.Show($"Кажется эта ссылка на изображение не подходит.\nУказанная ссылка:{_imageURL}", "Ошибка", MessageBoxButtons.OK);
            }
            
        }
    }
}
