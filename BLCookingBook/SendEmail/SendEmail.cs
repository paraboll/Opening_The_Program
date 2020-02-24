using System;
using System.Collections.Generic;
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
        public void sendMailAsync(string titleMail, string bodyMail)
        {
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            m.Subject = titleMail;
            m.Body = bodyMail;

            // письмо представляет код html
            m.IsBodyHtml = true;

            //TODO: вынести параметры в конфиг фаил.
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            
            // логин и пароль
            smtp.Credentials = new NetworkCredential("somemail@gmail.com", "mypassword");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}
