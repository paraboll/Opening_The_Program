using BLCookingBook.Controller;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opening_The_Program
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
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
            Database.SetInitializer(new DBInitialization());
            Application.Run(new CookingBookForm());
        }
    }
}
