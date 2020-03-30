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

            //создадим фаил если его нет.
            if (!File.Exists("Notes.txt"))
                File.Create("Notes.txt").Close();
            LoadNode();
        }

        private void btn_SaveNote_Click(object sender, EventArgs e)
        {
            rtb_Notes.SaveFile("Notes.txt", RichTextBoxStreamType.PlainText);
            MessageBox.Show("Заметка изменена");
        }

        public void LoadNode()
        {
            rtb_Notes.LoadFile("Notes.txt", RichTextBoxStreamType.PlainText);
        }

        private void rtb_Notes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
