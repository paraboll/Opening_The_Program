using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCookingBook
{
    public static class Settigs
    {
        /// <summary>
        /// Метод по указаному пути берет, из файла настройки для отправки сообщений
        /// </summary>
        /// <returns>настройки для отправки сообщений</returns>
        public static Dictionary<string, string> getSettingsInFile()
        {
            try
            {
                Dictionary<string, string> settingsDictionary = new Dictionary<string, string>();
                string conString = ConfigurationManager.AppSettings.Get("LoginPath");

                using (FileStream fstream = File.OpenRead(conString))
                {
                    string[] _str = File.ReadAllLines(conString, Encoding.UTF8);
                    for (int i = 0; i < File.ReadLines(conString).Count(); i++)
                    {
                        string[] str = _str[i].Split(':');
                        settingsDictionary.Add(str[0].Trim().ToString(), str[1].Trim().ToString());
                    }
                }

                return settingsDictionary;
            }
            catch (Exception ex)
            {
                //TODO: вынести ошибку в лог.
                Console.WriteLine(ex);
                //В случае если фаил необнажен вернем пустой словарь 
                return new Dictionary<string, string>();
            }
        }
    }
}
