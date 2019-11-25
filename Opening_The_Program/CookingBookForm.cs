using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLCookingBook.Controller;

namespace Opening_The_Program
{
    public partial class CookingBookForm : Form
    {
        public CookingBookForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void listRecipes1_Load(object sender, EventArgs e)
        {

        }

        private void btn_listOfRecipes_Click(object sender, EventArgs e)
        {
            panel_Note.Visible = false;
            panel_AddRecipe.Visible = false;
            listRecipes.Visible = true;
            //ViewDataBase viewDataBase = new ViewDataBase();
            //viewDataBase.DataBa();
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
        }

        private void panel_AddRecipe_Load(object sender, EventArgs e)
        {
            
        }
    }
}
