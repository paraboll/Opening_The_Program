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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel_ListRecipe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rtb_TitleRecipe_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtb_DescriptionRecipe_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_ingridTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_SearchResipe_TextChanged(object sender, EventArgs e)
        {
            var found = Search(dataRecipe);
            Console.WriteLine(dataRecipe);
            //var found = dataRecipe.FindAll(p => p.NameRecipe == tb_SearchResipe.Text);
            Console.WriteLine("Всего найдено: {0}", found.Count);

        }

        /// <summary>
        /// Метод,позволяющий организовать поиск в listBox.
        /// Автор: Umnick
        /// </summary>
        /// <param name="listBox">ListBox в котором осуществляется поиск.</param>
        public void Search(List<Recipe> dataRecipe)
        {
            //Объявление переменных и заполнение их для поиска
            List<int> c = new List<int>();    //Колличество совпадений
            int n = 0; //Сюда запишем наибольшее кол-во совпадений
            int index = 0; //Сюда запишем индекс элемента в listbox,в котором найдено наибольшее кол-во совпадений
            List<string> s = new List<string>();//будем переписывать все items из listbox сюда
            /*for (int i = 0; i < listBox1.Items.Count; i++)  //цикл,в нем заполним наши списки
            {
                s.Add(listBox.Items[i].ToString());//заполняем items
                c.Add(0);//заполняем наш счетчик нулями
            }*/
            //Основные циклы по работке с поиском
            for (int i = 0; i < tb_SearchResipe.Text.Length; i++)//Цикл,им проходимся по каждому символу в строке поиска
            {
                for (int j = 0; j < s.Count; j++)//Цикл,проходимся по каждому item в нашей коллекции,ранее мы переписали туда все items
                {
                    for (int k = 0; k < s[j].Length; k++)//Цикл,посимвольно перебираем значение каждого items и ищем совпадения.
                    {
                        if (s[j][k] == tb_SearchResipe.Text[i])//Проверка на совпадение.Если один из символов items`а совпал с одним из символов строки поиска,увеличиваем наш счетчик
                        {
                            c[j] = ++c[j];//Увеличиваем счетчик,каждый индекс которого,соответствует каждому items в listBox1.
                        }
                    }
                    if (c[j] > n)//Поиск найбольшего счетчика,тоесть items,в котором было обнаружено наибольшее кол-во совпадений.
                    {
                        n = c[j];//...
                        index = j;//Записываем в переменную,индекс,как и говорилось ранее.
                    }
                }
            }
            if (n > 2)//Если совпадений больше двух(глупо конечно,но все таки),то:
            {
                //listBox1.SetSelected(index, true);//Выделяем найденный индекс.
            }
        }
    }
}
