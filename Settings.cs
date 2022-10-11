using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace WebhookSenderForOBS
{
    public class Settings
    {
        static public Dictionary<string,string> Get(string settingsType)
        {
            string[] data = File.ReadAllLines("StreamNotification/settings");
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            int offset = settingsType == "stop" ? 4 : 0;
            keyValuePairs["url"] = data[0 + offset];
            keyValuePairs["name"] = data[1 + offset];
            keyValuePairs["icon"] = data[2 + offset];
            keyValuePairs["text"] = data[3 + offset];
            return keyValuePairs;
        }
        static public void Save(string settingsType, Dictionary<string, string> keyValuePairs)
        {
            switch(settingsType)
            {
                case ("start"):
                    var stopData = Get("stop");

                    StreamWriter streamStart = File.CreateText("StreamNotification/settings");

                    streamStart.WriteLine(keyValuePairs["url"]);
                    streamStart.WriteLine(keyValuePairs["name"]);
                    streamStart.WriteLine(keyValuePairs["icon"]);
                    streamStart.WriteLine(keyValuePairs["text"].Replace(Environment.NewLine, "\\n"));

                    foreach (KeyValuePair<string, string> keyValue in stopData)
                    {
                        streamStart.WriteLine(keyValue.Value);
                    }

                    streamStart.Close();
                    break;
                case ("stop"):
                    var startData = Get("start");

                    StreamWriter streamStop = File.CreateText("StreamNotification/settings");

                    foreach (KeyValuePair<string, string> keyValue in startData)
                    {
                        streamStop.WriteLine(keyValue.Value);
                    }

                    
                    streamStop.WriteLine(keyValuePairs["url"]);
                    streamStop.WriteLine(keyValuePairs["name"]);
                    streamStop.WriteLine(keyValuePairs["icon"]);
                    streamStop.WriteLine(keyValuePairs["text"].Replace(Environment.NewLine, "\\n"));

                    streamStop.Close();
                    break;
                default:
                    break;
            }
            
        }
        /// <summary>
        /// Создаст файлы со стандартными настройками
        /// </summary>
        static public void Setup()
        {
            if(!Directory.Exists("StreamNotification"))
                Directory.CreateDirectory("StreamNotification");

            StreamWriter file = File.CreateText("StreamNotification/settings");
            file.WriteLine("https://discord.com/api/webhooks/***/***");
            file.WriteLine("Начало стрима");
            file.WriteLine("https://w7.pngwing.com/pngs/735/931/png-transparent-computer-icons-online-and-offline-others.png");
            file.WriteLine("@everyone Подключайтесь");

            file.WriteLine("https://discord.com/api/webhooks/***/***");
            file.WriteLine("Окончание стрима");
            file.WriteLine("https://img2.freepng.ru/20180406/roe/kisspng-computer-icons-online-and-offline-curved-line-5ac7236ebbbed6.825135841523000174769.jpg");
            file.WriteLine("До следующего стрима");
            file.Close();
        }
    }
}
