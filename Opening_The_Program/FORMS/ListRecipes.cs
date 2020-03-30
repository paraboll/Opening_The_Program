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
using System.IO;

namespace Opening_The_Program
{
    public partial class ListRecipes : UserControl
    {
        protected List<Recipe> dataRecipe;

        public ListRecipes()
        {
            InitializeComponent();

            if (!File.Exists("Recipe.txt"))
                File.Create("Recipe.txt").Close();
        }

        public void addButton(List<Recipe> recipes)
        {
            dataRecipe = new List<Recipe>(recipes);
            updatePanel(dataRecipe);
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            try
            {
                var button = (XButton)sender;
                if (button != null)
                {
                    Recipe recipe = dataRecipe.Find(u => u.NameRecipe == button.FullNameRecipe);
                    rtb_TitleRecipe.Text = recipe.NameRecipe;
                    rtb_DescriptionRecipe.Text = recipe.DescriptionOfRecipes;

                    dgv_ingridTable.Rows.Clear();
                    foreach (var item in recipe.Ingredients)
                    {
                        //Добавляем строку, указывая значения колонок поочереди слева направо
                        dgv_ingridTable.Rows.Add(item.NameIngredient, item.Сount);
                    }
                }
            }
            catch(Exception ex)
            {
                //TODO: вывести в лог
                Console.WriteLine("ошибка ButtonOnClick:" + ex);
            }
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
            updatePanel(TempListRecipe);
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

            updatePanel(TempListRecipe);
        }

        private void updatePanel(List<Recipe> TempListRecipe)
        {
            panel_ListRecipe.Controls.Clear();
            for (int i = 0; i < TempListRecipe.Count; i++)
            {
                XButton button = new XButton();
                button.Dock = DockStyle.Top;
                button.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Verdana", 9.75F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 204);
                button.ForeColor = SystemColors.ButtonFace;
                //button.Image = Properties.Resources.recipe;
                //button.ImageAlign = ContentAlignment.MiddleLeft;
                button.Location = new Point(0, 76);
                button.Name = "button" + i.ToString();
                button.Size = new Size(200, 76);
                button.TabIndex = 11;
                button.Text = TempListRecipe[i].NameRecipe;
                button.TextAlign = ContentAlignment.MiddleRight;
                button.UseVisualStyleBackColor = true;
                button.Click += ButtonOnClick;
                button.СookingTime = TempListRecipe[i].RecipeRatingByСookingTime;
                button.СookingTimeText = "Приготовление:";

                //для поиска по имени
                button.FullNameRecipe = TempListRecipe[i].NameRecipe;
                //для красивого вывода на кновку
                if (TempListRecipe[i].NameRecipe.Length >= 22)
                {
                    button.NameRecipe = TempListRecipe[i].NameRecipe.Substring(0, 21) + "...";
                }
                else { button.NameRecipe = TempListRecipe[i].NameRecipe; }

                button.EvaluationOfTasteText = "Оценка вкуса:";
                button.EvaluationOfTaste = TempListRecipe[i].RecipeRatingByTaste.ToString();

                panel_ListRecipe.Controls.Add(button);  
            }
        }

        private void btn_later_Click(object sender, EventArgs e)
        {
            panel_RaitingRecipe.Visible = false;

            cb_TimeCooking.Text = "";
            cb_Taste.Text = "";
        }

        private void btn_AssessRecipe_Click(object sender, EventArgs e)
        {
            panel_RaitingRecipe.Visible = true;
        }

        private void btn_Rating_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = (dataRecipe.FirstOrDefault(o => o.NameRecipe == rtb_TitleRecipe.Text));
                if (obj != null)
                {
                    RateRecipe(obj);
                }

                panel_RaitingRecipe.Visible = false;

            }
            catch(Exception ex)
            {
                //TODO: вывести ошибку в лог
                Console.WriteLine("ошибка btn_Rating_Click: " + ex);
            }
        }

        private void RateRecipe(Recipe recipe)
        {
            if (cb_Taste.Text != "")
            {
                recipe.RecipeRatingByTaste = Convert.ToInt32(cb_Taste.Text);
            }
            else { Console.WriteLine("оценки вкуса нет"); }

            if (cb_TimeCooking.Text != "")
            {
                recipe.RecipeRatingByСookingTime = cb_TimeCooking.Text;
            }
            else { Console.WriteLine("оценки времеми нет"); }

            //TODO: перезаписать в файле и вывести в кнопку изменения.
        }

        private void labelRatingRecipe_Click(object sender, EventArgs e)
        {

        }
    }
}
