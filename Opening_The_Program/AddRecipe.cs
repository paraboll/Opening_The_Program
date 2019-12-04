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
        List<Ingredient> ingredients;

        public Panel_AddRecipe()
        {
            InitializeComponent();
            ingredients = new List<Ingredient>();

            //SetUpList();
        }

        private void btn_AddIngrid_Click(object sender, EventArgs e)
        {
            //добавляем новый элемент в лист
            ingredients.Add(new Ingredient()
            {
                NameIngredient = tb_NameIngrid.Text,
                Сount = tb_CountIngrid.Text
            });

            tb_NameIngrid.Text = "";
            tb_CountIngrid.Text = "";

            //обновляем комбобокс
            clearCombobox();
        }

        private void cbx_NameIngr_SelectedIndexChanged(object sender, EventArgs e)
        {
            //находим выбраный элемент в комбобокс
            var item = ingredients.Find(n => n.NameIngredient == cbx_NameIngr.Text);
   
            //выводим о нем данные
            tb_nameIngr.Text = item.NameIngredient;
            tb_countIngr.Text = item.Сount;
        }

        private void btn_DeleteRecipe_Click(object sender, EventArgs e)
        {
            //проверяем что лист не пустой
            if (cbx_NameIngr.Text != null && cbx_NameIngr.Text != "")
            {

                //находим и удаляем элемент
                var itemToDelete = ingredients.Where(x => x.NameIngredient == cbx_NameIngr.Text).Select(x => x).First();
                ingredients.Remove(itemToDelete);

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
                //находим элемент который нужно отредактировать и обновляем его
                var item = ingredients.Find(n => n.NameIngredient == cbx_NameIngr.Text);
                item.NameIngredient = tb_nameIngr.Text;
                item.Сount = tb_countIngr.Text;

                //обновляем комбобокс
                clearCombobox();
            }    
        }

        public void clearCombobox()
        {
            cbx_NameIngr.Items.Clear();
            int count = 0;
            foreach (var i in ingredients)
            {
                cbx_NameIngr.Items.Add(ingredients[count].NameIngredient);
                count++;
            }
            tb_nameIngr.Text = "";
            tb_countIngr.Text = "";
        }

        public void SetUpList()
        {
            ///***инициализируем для тестов начальный лист***///
            ingredients.Add(new Ingredient()
            {
                NameIngredient = "морковь",
                Сount = "2 штуки",
            });
            ingredients.Add(new Ingredient()
            {
                NameIngredient = "картошка",
                Сount = "2 кг",
            });
            ingredients.Add(new Ingredient()
            {
                NameIngredient = "перец болгарский",
                Сount = "1 кг",
            });
            ingredients.Add(new Ingredient()
            {
                NameIngredient = "лук",
                Сount = "1 шт",
            });

            ///***Добавляем в комбобокс***///
            int count = 0;
            foreach (var item in ingredients)
            {
                cbx_NameIngr.Items.Add(ingredients[count].NameIngredient);
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

                if (ingredients == null)
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
                recipe.Ingredients = new List<Ingredient>(ingredients);
                recipe.DescriptionOfRecipes = rtb_DescriptionRecie.Text;

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
            ingredients = null;
            ingredients = new List<Ingredient>();
            MessageBox.Show("Ошибка, " + ErrorText);
        }

        private void Panel_AddRecipe_Load(object sender, EventArgs e)
        {

        }
    }
}
