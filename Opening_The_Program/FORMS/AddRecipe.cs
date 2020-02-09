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
using NLog;

namespace Opening_The_Program
{
    public partial class Panel_AddRecipe : UserControl
    {
        ControllerIngredient controllerIngredient;
        ControllerRecipe controllerRecipe;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Panel_AddRecipe()
        {
            InitializeComponent();
            controllerIngredient = new ControllerIngredient();
            controllerRecipe = new ControllerRecipe(); 

            SetUpList();
        }

        private void btn_AddIngrid_Click(object sender, EventArgs e)
        {
            //TODO: Добавить проверку на null + вывести в лог ошибк
            controllerIngredient.AddIngridient(tb_NameIngrid.Text, tb_CountIngrid.Text);

            tb_NameIngrid.Text = "";
            tb_CountIngrid.Text = "";

            //обновляем комбобокс
            rewriteCombobox();
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
            //проверяем что комбобокс не пустой
            if (cbx_NameIngr.Text != null && cbx_NameIngr.Text != "")
            {
                controllerIngredient.DeleteIngredient(cbx_NameIngr.Text);

                //обновляем комбобокс
                rewriteCombobox();
            }

            tb_nameIngr.Text = "";
            tb_countIngr.Text = "";
        }

        private void btn_EditRecipe_Click(object sender, EventArgs e)
        {
            //проверяем что комбобокс не пустой
            if (cbx_NameIngr.Text != null && cbx_NameIngr.Text != "")
            {
                //TODO: проверить все на null.
                controllerIngredient.EditIngredient(cbx_NameIngr.Text, tb_nameIngr.Text, tb_countIngr.Text);

                //обновляем комбобокс
                rewriteCombobox();
            }
        }

        private void rewriteCombobox()
        {
            cbx_NameIngr.Items.Clear();
            int count = 0;

            if(controllerIngredient.ingredients.Count == 0)
            {
                logger.Warn("SetUpList | Лист ингридиентов пуст.");
            }

            foreach (var i in controllerIngredient.ingredients)
            {
                cbx_NameIngr.Items.Add(controllerIngredient.ingredients[count].NameIngredient);
                count++;
            }
            tb_nameIngr.Text = "";
            tb_countIngr.Text = "";

        }

        private void SetUpList()
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
            logger.Info("SetUpList | Инициализирован начальный лист ингридиентов.");
        }

        private void btn_SaveRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_TitleRecipe.Text == null || tb_TitleRecipe.Text == "")
                {
                    ErrorMessage("Не заполено название рецепта.");
                    logger.Error("btn_SaveRecipe_Click | Не заполено название рецепта.");
                }

                if (controllerIngredient.ingredients == null)
                {
                    ErrorMessage("Список ингридиентов пуст.");
                    logger.Error("btn_SaveRecipe_Click | Список ингридиентов пуст.");
                }

                if (rtb_DescriptionRecie.Text == null || rtb_DescriptionRecie.Text == "")
                {
                    ErrorMessage("Незаполнено описание рецепта.");
                    logger.Error("btn_SaveRecipe_Click | Незаполнено описание рецепта.");
                }

                Recipe recipe = new Recipe(
                    tb_TitleRecipe.Text,
                    rtb_DescriptionRecie.Text,
                    new List<Ingredient>(controllerIngredient.ingredients) 
                    );

                SaveFile saveFile = new SaveFile();
                saveFile.WriteInFile(recipe);

                //очищяем форму
                cbx_NameIngr.Items.Clear();
                tb_TitleRecipe.Text = "";
                rtb_DescriptionRecie.Text = "";

                MessageBox.Show("Добавлен новый рецепт");
                logger.Info("btn_SaveRecipe_Click | Добавлен новый рецепт.");
            }
            catch(Exception exp)
            {
                ErrorMessage("Заполните форму снова.");
                logger.Error("btn_SaveRecipe_Click | Заполните форму снова. Ошибка: " + exp);
            }  
        }

        /// <summary>
        /// Mетод выводит сообщение об ошибке.
        /// </summary>
        /// <param name="ErrorText"></param>
        public void ErrorMessage(string ErrorText)
        {
            tb_TitleRecipe.Text = "";
            rtb_DescriptionRecie.Text = "";
            controllerIngredient.ingredients = new List<Ingredient>();
            MessageBox.Show("Ошибка, " + ErrorText);
        }

        private void Panel_AddRecipe_Load(object sender, EventArgs e)
        {

        }
    }
}
