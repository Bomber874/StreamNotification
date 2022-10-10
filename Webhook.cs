using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
            NameValueCollection webhookInfo = new NameValueCollection();
            webhookInfo.Add("username", _name);
            webhookInfo.Add("avatar_url", _imageURL);
            webhookInfo.Add("content", _text);

            new WebClient().UploadValues(_hookURL, webhookInfo);
        }
    }
}
