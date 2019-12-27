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
    public partial class Panel_AddRecipe : UserControl
    {
        ControllerIngredient controllerIngredient;
        ControllerRecipe controllerRecipe;

        public Panel_AddRecipe()
        {
            InitializeComponent();
            controllerIngredient = new ControllerIngredient();
            controllerRecipe = new ControllerRecipe(); 

            SetUpList();
        }

        private void btn_AddIngrid_Click(object sender, EventArgs e)
        {
            controllerIngredient.AddIngridient(tb_NameIngrid.Text, tb_CountIngrid.Text);

            tb_NameIngrid.Text = "";
            tb_CountIngrid.Text = "";

            //обновляем комбобокс
            clearCombobox();
        }

        private void cbx_NameIngr_SelectedIndexChanged(object sender, EventArgs e)
        {
            //находим выбраный элемент в комбобокс
            var item = controllerIngredient.ingredients.Find(n => n.NameIngredient == cbx_NameIngr.Text);
   
            //выводим о нем данные
            tb_nameIngr.Text = item.NameIngredient;
            tb_countIngr.Text = item.Сount;
        }

        private void btn_DeleteRecipe_Click(object sender, EventArgs e)
        {
            //проверяем что лист не пустой
            if (cbx_NameIngr.Text != null && cbx_NameIngr.Text != "")
            {
                controllerIngredient.DeleteIngredient(cbx_NameIngr.Text);

                //обновляем комбобокс
                clearCombobox();
            }
            //cbx_NameIngr.Text = tb_nameIngr.Text;
            tb_nameIngr.Text = "";
            tb_countIngr.Text = "";
        }

        private void btn_EditRecipe_Click(object sender, EventArgs e)
        {
            //проверяем что лист не пустой
            if (cbx_NameIngr.Text != null && cbx_NameIngr.Text != "")
            {
                controllerIngredient.EditIngredient(cbx_NameIngr.Text, tb_nameIngr.Text, tb_countIngr.Text);

                //обновляем комбобокс
                clearCombobox();
            }    
        }

        public void clearCombobox()
        {
            cbx_NameIngr.Items.Clear();
            int count = 0;
            foreach (var i in controllerIngredient.ingredients)
            {
                cbx_NameIngr.Items.Add(controllerIngredient.ingredients[count].NameIngredient);
                count++;
            }
            tb_nameIngr.Text = "";
            tb_countIngr.Text = "";
        }

        public void SetUpList()
        {
            ///***инициализируем для тестов начальный лист***///
            controllerIngredient.ingredients.Add(new Ingredient("морковь", "2 штуки"));
            controllerIngredient.ingredients.Add(new Ingredient("картошка", "2 кг"));
            controllerIngredient.ingredients.Add(new Ingredient("перец болгарский", "1 кг"));
            controllerIngredient.ingredients.Add(new Ingredient("лук", "1 шт"));

            ///***Добавляем в комбобокс***///
            int count = 0;
            foreach (var item in controllerIngredient.ingredients)
            {
                cbx_NameIngr.Items.Add(controllerIngredient.ingredients[count].NameIngredient);
                count++;
            }
        }

        private void btn_SaveRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_TitleRecipe.Text == null || tb_TitleRecipe.Text == "")
                {
                    ErrorMessage("Не заполено название рецепта.");
                }

                if (controllerIngredient.ingredients == null)
                {
                    ErrorMessage("Список ингридиентов пуст.");
                }

                if (rtb_DescriptionRecie.Text == null || rtb_DescriptionRecie.Text == "")
                {
                    ErrorMessage("Незаполнено описание рецепта.");
                }

                Recipe recipe = new Recipe();
                recipe.NameRecipe = tb_TitleRecipe.Text;

                ///recipe.Ingredients.Clear();
                recipe.Ingredients = new List<Ingredient>(controllerIngredient.ingredients);
                recipe.DescriptionOfRecipes = rtb_DescriptionRecie.Text;
                recipe.RecipeRatingByTaste = 0;
                recipe.RecipeRatingByСookingTime = "долго";

                //dBContext.Recipes.Add(recipe);
                //dBContext.SaveChanges();

                SaveFile saveFile = new SaveFile();
                saveFile.WriteInFile(recipe);

                //очищяем форму
                cbx_NameIngr.Items.Clear();
                tb_TitleRecipe.Text = "";
                rtb_DescriptionRecie.Text = "";

                MessageBox.Show("Добавлен новый рецепт");
            }
            catch
            {
                ErrorMessage("Заполните форму снова.");
            }  
        }

        public void ErrorMessage(string ErrorText)
        {
            tb_TitleRecipe.Text = "";
            rtb_DescriptionRecie.Text = "";
            controllerIngredient.ingredients = null;
            controllerIngredient.ingredients = new List<Ingredient>();
            MessageBox.Show("Ошибка, " + ErrorText);
        }

        private void Panel_AddRecipe_Load(object sender, EventArgs e)
        {

        }
    }
}
