using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLCookingBook.Model;
using BLCookingBook.Controller;

namespace Opening_The_Program
{
    public partial class ListRecipes : UserControl
    {
        List<Recipe> dataRecipe;
        public ListRecipes()
        {
            InitializeComponent();
            rtb_TitleRecipe.Font = new Font("Verdana", 9.75F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 204);
            rtb_DescriptionRecipe.Font = new Font("Verdana", 9.75F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 204);
            dgv_ingridTable.Font = new Font("Verdana", 9.75F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 204);
            dgv_ingridTable.Columns[0].Width = 150;
            dgv_ingridTable.Columns[1].Width = 150;
        }

        public void addButton(List<Recipe> recipes)
        {
            dataRecipe = new List<Recipe>(recipes);

            //TODO: вынести в отдельный метод
            panel_ListRecipe.Controls.Clear();
            for (int i = 0; i < dataRecipe.Count; i++)
            {
                Button button = new Button();
                button.Dock = DockStyle.Top;
                button.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Verdana", 9.75F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 204);
                button.ForeColor = SystemColors.ButtonFace;
                button.Image = Properties.Resources.recipe;
                button.ImageAlign = ContentAlignment.MiddleLeft;
                button.Location = new Point(0, 76);
                button.Name = "button" + i.ToString();
                button.Size = new Size(200, 76);
                button.TabIndex = 11;
                button.Text = dataRecipe[i].NameRecipe;
                button.TextAlign = ContentAlignment.MiddleRight;
                button.UseVisualStyleBackColor = true;
                button.Click += ButtonOnClick;
                panel_ListRecipe.Controls.Add(button);
            }
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                Recipe recipe = dataRecipe.Find(u => u.NameRecipe == button.Text);
                rtb_TitleRecipe.Text = recipe.NameRecipe;
                rtb_DescriptionRecipe.Text = recipe.DescriptionOfRecipes;

                dgv_ingridTable.Rows.Clear();
                //dgv_ingridTable.Rows.Add(recipe.Ingredients.Count);
                foreach (var item in recipe.Ingredients)
                {
                    //Добавляем строку, указывая значения колонок поочереди слева направо
                    dgv_ingridTable.Rows.Add(item.NameIngredient, item.Сount);
                }
            }
        }

        private void dgv_ingridTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_SearchResipe_TextChanged(object sender, EventArgs e)
        {
            List<Recipe> TempListRecipe = new List<Recipe>();
            string str = tb_SearchResipe.Text;
            foreach (var item in dataRecipe)
            {
                if (item.NameRecipe.Contains(str))
                {
                    TempListRecipe.Add(item);
                }
            }

            //TODO: вынести в отдельный метод
            panel_ListRecipe.Controls.Clear();
            for (int i = 0; i < TempListRecipe.Count; i++)
            {
                Button button = new Button();
                button.Dock = DockStyle.Top;
                button.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Verdana", 9.75F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 204);
                button.ForeColor = SystemColors.ButtonFace;
                button.Image = Properties.Resources.recipe;
                button.ImageAlign = ContentAlignment.MiddleLeft;
                button.Location = new Point(0, 76);
                button.Name = "button" + i.ToString();
                button.Size = new Size(200, 76);
                button.TabIndex = 11;
                button.Text = TempListRecipe[i].NameRecipe;
                button.TextAlign = ContentAlignment.MiddleRight;
                button.UseVisualStyleBackColor = true;
                button.Click += ButtonOnClick;
                panel_ListRecipe.Controls.Add(button);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Recipe> TempListRecipe = new List<Recipe>();

            var obj = (dataRecipe.FirstOrDefault(o => o.NameRecipe == rtb_TitleRecipe.Text));
            if (obj != null)
            {
                int index = dataRecipe.IndexOf(obj);
                dataRecipe.RemoveAt(index);
            }
            foreach (var item in dataRecipe)
            {
                TempListRecipe.Add(item);
            }

            SaveFile saveFile = new SaveFile();
            saveFile.WriteInFile(TempListRecipe);

            //TODO: вынести в отдельный метод
            panel_ListRecipe.Controls.Clear();
            for (int i = 0; i < TempListRecipe.Count; i++)
            {
                Button button = new Button();
                button.Dock = DockStyle.Top;
                button.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Verdana", 9.75F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 204);
                button.ForeColor = SystemColors.ButtonFace;
                button.Image = Properties.Resources.recipe;
                button.ImageAlign = ContentAlignment.MiddleLeft;
                button.Location = new Point(0, 76);
                button.Name = "button" + i.ToString();
                button.Size = new Size(200, 76);
                button.TabIndex = 11;
                button.Text = TempListRecipe[i].NameRecipe;
                button.TextAlign = ContentAlignment.MiddleRight;
                button.UseVisualStyleBackColor = true;
                button.Click += ButtonOnClick;
                panel_ListRecipe.Controls.Add(button);
            }

        }
    }
}
