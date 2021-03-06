﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLCookingBook;
using BLCookingBook.Controller;
using BLCookingBook.Model;
using BLCookingBook.SendEmail;

namespace Opening_The_Program
{
    public partial class CookingBookForm : Form
    {
        public CookingBookForm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region движение формы без рамки

        private Point mouseOffset;
        private bool isMouseDown = false;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            // Changes the isMouseDown field so that the form does
            // not move unless the user is pressing the left mouse button.
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        #endregion


        private void btn_listOfRecipes_Click(object sender, EventArgs e)
        {
            /*
            //TODO: убрать (подумать как получить email пользователя и в случае ошибки отправлять себе лог ошибки на почту)
            //считываем конфиг данные из файла 
            Dictionary<string, string> setting = Settigs.getSettingsInFile();

            //TODO
            MailAddress from = new MailAddress(setting["mailFrom"], setting["nameFrom"]);
            MailAddress to = new MailAddress(setting["mailTo"], setting["nameTo"]);
            SendEmail sendEmail = new SendEmail(from, to);
            sendEmail.sendNewMail("Тест Заголовок", "Тест Текст");*/

            panel_Note.Visible = false;
            panel_AddRecipe.Visible = false;
            listRecipes.Visible = true;

            SaveFile saveFile = new SaveFile();
            List<Recipe> data = saveFile.GetListRecipe();

            listRecipes.addButton(data);
        }

        private void btn_addRacipe_Click(object sender, EventArgs e)
        {
            panel_Note.Visible = false;
            panel_AddRecipe.Visible = true;
            listRecipes.Visible = false;
        }

        private void btb_note_Click(object sender, EventArgs e)
        {
            panel_Note.Visible = true;
            panel_AddRecipe.Visible = false;
            listRecipes.Visible = false;

            panel_Note.LoadNode();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
