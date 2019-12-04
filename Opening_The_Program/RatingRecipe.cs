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

namespace Opening_The_Program
{
    public partial class RatingRecipe : UserControl
    {
        public RatingRecipe()
        {
            InitializeComponent();
        }

        private void btn_later_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            cb_TimeCooking.Text = "";
            cb_Taste.Text = "";
            cb_DifficultlyRecipe.Text = "";
        }

        private void btn_Rating_Click(object sender, EventArgs e)
        {/*
            var obj = (dataRecipe.FirstOrDefault(o => o.NameRecipe == rtb_TitleRecipe.Text));
            if (obj != null)
            {
                int index = dataRecipe.IndexOf(obj);
                dataRecipe.RemoveAt(index);
            }
            RateRecipe(recipe);*/

            this.Visible = false;
        }

        private void RateRecipe(Recipe recipe)
        {
            if (cb_DifficultlyRecipe.Text != "")
            {
                recipe.RecipeRatingByScore = cb_DifficultlyRecipe.Text;
            }
            else { Console.WriteLine("оценки сложности нет"); }

            if (cb_Taste.Text != "")
            {
                recipe.RecipeRatingByTaste = cb_Taste.Text;
            }
            else { Console.WriteLine("оценки вкуса нет"); }

            if (cb_TimeCooking.Text != "")
            {
                recipe.RecipeRatingByСookingTime = cb_TimeCooking.Text;
            }
            else { Console.WriteLine("оценки времеми нет"); }
        }
    }
}
