﻿using System;
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
using BLCookingBook.SendEmail;
using System.Net.Mail;

namespace Opening_The_Program
{
    /// <summary>
    /// Класс описывает интерфейс(форму) который отвечает за создание рецепта.
    /// </summary>
    public partial class Panel_AddRecipe : UserControl
    {
        //private ControllerIngredient controllerIngredient;
        private ControllerRecipe controllerRecipe;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Конструктор без параметор.
        /// </summary>
        public Panel_AddRecipe()
        {
            InitializeComponent();
            controllerRecipe = new ControllerRecipe();
            controllerRecipe.recipes = SerializationOnJson.RecipeDeserializationJson(); 

            SetUpList();
        }

        private void btn_AddIngrid_Click(object sender, EventArgs e)
        {
            //проверка на пустые поля в тексбоксе
            bool flagTb_NameIngrid =    false;
            bool flagTb_CountIngrid =   false;

            if (tb_NameIngrid.Text.Length <= 0) flagTb_NameIngrid =     true;
            if (tb_CountIngrid.Text.Length <= 0) flagTb_CountIngrid =   true;


            //Хранит все незаполненые поля и предупреждения
            //Словарь позволит вылить зеленым все заполненые элементы и красным незаполненые.
            var messageError = new Dictionary<object, string>();
            if (flagTb_NameIngrid) messageError.Add(tb_NameIngrid, "Вы не ввели ингридиент. \n");
            if (flagTb_CountIngrid) messageError.Add(tb_CountIngrid, "Вы не ввели количество ингридиентов. \n");

            if (flagTb_NameIngrid || flagTb_CountIngrid)
            {
                ErrorMessage(messageError);
            }
            else
            {
                controllerRecipe.controllerIngredient.AddIngridient(tb_NameIngrid.Text, tb_CountIngrid.Text);

                tb_NameIngrid.Text = "";
                tb_CountIngrid.Text = "";

                //обновляем комбобокс
                rewriteCombobox();
                MessageBox.Show("Ингридиент успешно добавлен.");
            }
        }

        private void SetTextBoxBackColor(TextBox _tb, Color _color)
        {
            _tb.BackColor = _color;
        }

        private void cbx_NameIngr_SelectedIndexChanged(object sender, EventArgs e)
        {
            //находим выбраный элемент в комбобокс
            var item = controllerRecipe.controllerIngredient.ingredients.Find(n => n.NameIngredient == cbx_NameIngr.Text);
   
            //выводим о нем данные
            tb_nameIngr.Text = item.NameIngredient;
            tb_countIngr.Text = item.Сount;
        }

        private void btn_DeleteRecipe_Click(object sender, EventArgs e)
        {
            //проверяем что комбобокс не пустой
            if (cbx_NameIngr.Text != null && cbx_NameIngr.Text != "")
            {
                controllerRecipe.controllerIngredient.DeleteIngredient(cbx_NameIngr.Text);
               
                //обновляем комбобокс
                rewriteCombobox();

                tb_nameIngr.Text = "";
                tb_countIngr.Text = "";

                MessageBox.Show("Ингридиент удален");
            }
            else
            {
                MessageBox.Show("Не выбран ингридиент");
            }
            
        }

        private void btn_EditRecipe_Click(object sender, EventArgs e)
        {
            //проверяем что комбобокс не пустой
            if (cbx_NameIngr.Text != null && cbx_NameIngr.Text != "")
            {
                //проверка на пустые поля в тексбоксе
                bool flagTb_nameIngr = false;
                bool flagTb_countIngr = false;

                if (tb_nameIngr.Text.Length <= 0) flagTb_nameIngr = true;
                if (tb_countIngr.Text.Length <= 0) flagTb_countIngr = true;

                //Хранит все незаполненые поля и предупреждения
                //Словарь позволит вылить зеленым все заполненые элементы и красным незаполненые.
                var messageError = new Dictionary<object, string>();
                if (flagTb_nameIngr) messageError.Add(tb_nameIngr, "Вы не ввели ингридиент. \n");
                if (flagTb_countIngr) messageError.Add(tb_countIngr, "Вы не ввели количество ингридиентов. \n");

                if (flagTb_nameIngr || flagTb_countIngr)
                {
                    ErrorMessage(messageError);
                }
                else
                {
                    //TODO: проверить все на null.
                    controllerRecipe.controllerIngredient.EditIngredient(cbx_NameIngr.Text, tb_nameIngr.Text, tb_countIngr.Text);

                    //обновляем комбобокс
                    rewriteCombobox();
                    MessageBox.Show("Ингридиент изменен");
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали ингридиент");
            }
        }

        private void rewriteCombobox()
        {
            cbx_NameIngr.Items.Clear();
            int count = 0;

            if (controllerRecipe.controllerIngredient.ingredients.Count == 0)
            {
                logger.Warn("SetUpList | Лист ингридиентов пуст.");
            }

            foreach (var i in controllerRecipe.controllerIngredient.ingredients)
            {
                cbx_NameIngr.Items.Add(controllerRecipe.controllerIngredient.ingredients[count].NameIngredient);
                count++;
            }
            tb_nameIngr.Text = "";
            tb_countIngr.Text = "";

        }

        /// <summary>
        /// Тестовый лист ингридиентов.
        /// </summary>
        private void SetUpList()
        {
            ///***инициализируем для тестов начальный лист***///
            controllerRecipe.controllerIngredient.ingredients.Add(new Ingredient("морковь", "2 штуки"));
            controllerRecipe.controllerIngredient.ingredients.Add(new Ingredient("картошка", "2 кг"));
            controllerRecipe.controllerIngredient.ingredients.Add(new Ingredient("перец болгарский", "1 кг"));
            controllerRecipe.controllerIngredient.ingredients.Add(new Ingredient("лук", "1 шт"));

            ///***Добавляем в комбобокс***///
            int count = 0;
            foreach (var item in controllerRecipe.controllerIngredient.ingredients)
            {
                cbx_NameIngr.Items.Add(controllerRecipe.controllerIngredient.ingredients[count].NameIngredient);
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
                    return;
                }

                if (controllerRecipe.controllerIngredient.ingredients == null)
                {
                    ErrorMessage("Список ингридиентов пуст.");
                    logger.Error("btn_SaveRecipe_Click | Список ингридиентов пуст.");
                    return;
                }

                if (rtb_DescriptionRecie.Text == null || rtb_DescriptionRecie.Text == "")
                {
                    ErrorMessage("Незаполнено описание рецепта.");
                    logger.Error("btn_SaveRecipe_Click | Незаполнено описание рецепта.");
                    return;
                }

                Recipe recipe = new Recipe(
                    tb_TitleRecipe.Text,
                    rtb_DescriptionRecie.Text,
                    new List<Ingredient>(controllerRecipe.controllerIngredient.ingredients) 
                    );

                controllerRecipe.recipes.Add(recipe);
                SerializationOnJson.RecipeSerializationJson(controllerRecipe.recipes);

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
        private void ErrorMessage(string ErrorText)
        {
            tb_TitleRecipe.Text = "";
            rtb_DescriptionRecie.Text = "";
            controllerRecipe.controllerIngredient.ingredients = new List<Ingredient>();
            MessageBox.Show("Ошибка, " + ErrorText);
        }

        /// <summary>
        /// Метод выведит предупреждение о незаполненых полях на форме.
        /// </summary>
        /// <param name="_messageError">Словарь незополененых полей</param>
        private void ErrorMessage(Dictionary<object, string> _messageError)
        {
            string messageError = "";
            foreach (var item in _messageError)
            {
                TextBox temp = (TextBox)item.Key;

                //TODO: переписать через вызов метода SetTextBoxBackColor
                temp.BackColor = Color.Red;
                messageError += item.Value;
            }

            MessageBox.Show(messageError);
            return;
        }

        # region пока незнаю как получить обьект по клику по нему и записать в 1 метод
        //TODO: пока незнаю как получить обьект по клику по нему и записать в 1 метод
        private void tb_NameIngrid_Click(object sender, EventArgs e)
        {
            tb_NameIngrid.BackColor = Color.White;
        }

        private void tb_CountIngrid_Click(object sender, EventArgs e)
        {
            tb_CountIngrid.BackColor = Color.White;
        }

        private void tb_nameIngr_Click(object sender, EventArgs e)
        {
            tb_nameIngr.BackColor = Color.White;
        }

        private void tb_countIngr_Click(object sender, EventArgs e)
        {
            tb_countIngr.BackColor = Color.White;
        }

        private void tb_TitleRecipe_Click(object sender, EventArgs e)
        {
            tb_TitleRecipe.BackColor = Color.White;
        }

        private void rtb_DescriptionRecie_Click(object sender, EventArgs e)
        {
            rtb_DescriptionRecie.BackColor = Color.White;
        }
        #endregion
    }
}
