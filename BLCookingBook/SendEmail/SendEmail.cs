using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLCookingBook.SendEmail
{
    /// <summary>
    /// Класс позволяет реа
    /// </summary>
    public class SendEmail
    {
        private MailAddress from;   
        private MailAddress to;

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="_from">устанавливаем адрес отправителя и отображаемое в письме имя ["somemail@gmail.com", "Tom"]</param>
        /// <param name="_to">устанавливаем адрес получателя и отображаемое в письме имя ["somemail@yandex.ru"]</param>
        public SendEmail(MailAddress _from, MailAddress _to)
        {
            from = _from;
            to = _to;
        }

        /// <summary>
        /// Отправка сообщения
        /// </summary>
        /// <param name="titleMail">Заголовок сообщения.</param>
        /// <param name="bodyMail">Текст сообщения.</param>
        public void sendNewMail(string titleMail, string bodyMail)
        {
            try
            {
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                m.Subject = titleMail;
                m.Body = bodyMail;

                // письмо представляет код html
                m.IsBodyHtml = true;

                //адрес smtp-сервера и порт, с которого будем отправлять письмо (указаны в App.config)
                SmtpClient smtp = new SmtpClient(
                    ConfigurationManager.AppSettings.Get("SMTPServer"),
                    Convert.ToInt32(ConfigurationManager.AppSettings.Get("SMTPPort"))
                );


                //считываем конфиг данные из файла 
                Dictionary<string, string> setting = Settigs.getSettingsInFile();
                // логин и пароль
                smtp.Credentials = new NetworkCredential(setting["myLogin"], setting["myPassword"]);
                smtp.EnableSsl = true;
                smtp.Send(m);

                Console.WriteLine("Сообщение успешно отправленно!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка отправки сообщения: " + ex);
            } 
        }
    }
}
