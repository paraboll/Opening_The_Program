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
        int idCount, idItem;
        public Panel_AddRecipe()
        {
            InitializeComponent();
            ingredients = new List<Ingredient>();
            idItem = 0;
        }

        private void tb_TitleRecipe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddIngrid_Click(object sender, EventArgs e)
        {
            idCount = 0;

            foreach (var i in ingredients)
            {
                Console.WriteLine(i.Id);
            }

            Console.WriteLine("сейчас ID: " + idItem);
            //добавили ингридиент в коллекцию
            ingredients.Add(new Ingredient() {
                NameIngredient = tb_NameIngrid.Text,
                Сount = tb_countIngrid.Text,
                Id = idItem
            });

            //записываем элемент в лист
            cbx_NameIngr.Items.Add(ingredients[idItem].NameIngredient);

            //установили следующий Id с учетом возможных пропусков пропусков
            foreach (var i in ingredients)
            {
                if (i.Id == idCount) idCount++;
                else break;
            }
            idItem = idCount;
            Console.WriteLine("следующий id " + idItem);

            
            //TODO: Сделать проверку 2х одинаковый id...пока незнаю как.
        }

        private void cbx_NameIngr_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ingredients.Find(n => n.NameIngredient == cbx_NameIngr.Text);
            tb_idIngr.Text = item.Id.ToString();
            tb_nameIngr.Text = item.NameIngredient;
            tb_countIngr.Text = item.Сount;
        }

        private void btn_DeleteRecipe_Click(object sender, EventArgs e)
        {
            ingredients.RemoveAt(Convert.ToInt32(tb_idIngr.Text));
            cbx_NameIngr.Items.RemoveAt(Convert.ToInt32(tb_idIngr.Text));

            tb_idIngr.Text = "";
            tb_nameIngr.Text = "";
            tb_countIngr.Text = "";

            idCount = 0;
            foreach (var i in ingredients)
            {
                if (i.Id == idCount) idCount++;
                else break;
            }
            idItem = idCount;
            Console.WriteLine("следующий id " + idItem);

            IDComparer iDComparer = new IDComparer();
            ingredients.Sort(iDComparer);
        }

        private void btn_EditRecipe_Click(object sender, EventArgs e)
        {
            //TODO: сделать редактирование имени и коректный вывод в комбобокс...пока незнаю как.
            var item = ingredients.Find(n => n.NameIngredient == cbx_NameIngr.Text);

            item.NameIngredient = tb_nameIngr.Text;
            cbx_NameIngr.Items[item.Id] = tb_nameIngr.Text;

            item.Сount = tb_countIngr.Text;

        }
    }
}
