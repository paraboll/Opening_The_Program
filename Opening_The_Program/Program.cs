using BLCookingBook.Controller;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace Opening_The_Program
{
    static class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Точка входа приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                LoadingForm first = new LoadingForm();
                DateTime end = DateTime.Now + TimeSpan.FromSeconds(5);
                first.Show();

                while (end > DateTime.Now) Application.DoEvents();

                first.Close();
                first.Dispose();

                //инициализируем БД при запускепрограммы
                //Database.SetInitializer(new DBInitialization());
                Application.Run(new CookingBookForm());
                logger.Info("Main | Приложение успешно запущено.");
            }
            catch(Exception exp)
            {
                logger.Fatal("Main | Ошибка запуска: " + exp);
            }
            
        }
    }
}
