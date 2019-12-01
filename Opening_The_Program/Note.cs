using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Opening_The_Program
{
    public partial class Note : UserControl
    {
        public Note()
        {
            InitializeComponent();

            string dir = "Data";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            gb_Notes.Font = new Font("Verdana", 9.75F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 204);

            //TODO: Что делать при загрузке если файла Notes.txt нет.
            //using (FileStream fstream = new FileStream($"{dir}\\Notes.txt", FileMode.OpenOrCreate)){}
        }

        private void btn_SaveNote_Click(object sender, EventArgs e)
        {
            rtb_Notes.SaveFile("Data//Notes.txt", RichTextBoxStreamType.PlainText);
            MessageBox.Show("Заметка изменена");
        }

        public void LoadNode()
        {
            string dir = "Data";
            if (!Directory.Exists(dir)) 
            {
                Directory.CreateDirectory(dir);
            }

            using (FileStream fstream = File.OpenRead($"{dir}\\Notes.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                rtb_Notes.Text = System.Text.Encoding.Default.GetString(array);
            }
        }
    }
}
