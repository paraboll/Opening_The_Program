using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLCookingBook.Model;

namespace BLCookingBook.Controller
{
    public class ControllerIngredient
    {
        //список ингридиентов.
        public List<Ingredient> ingredients;

        public ControllerIngredient()
        {
            //если списка ингридиентов нет, создаем его.
            ingredients = new List<Ingredient>();
        }

        public ControllerIngredient(List<Ingredient> ingredients)
        {
            //если список есть просто перезаписываем его.
            this.ingredients = ingredients;
        }

        //добавляем новый элемент в лист
        public void AddIngridient(string name, string count)
        {
            if (string.IsNullOrEmpty(name)) { Console.WriteLine("name пустая"); }
            if (string.IsNullOrEmpty(count)) { Console.WriteLine("count пустая"); }

            ingredients.Add(new Ingredient(name, count));
        }

        //принимает: 1 - имя ингридиента который необходимо отредактировать
        //2 - новое/старое имя
        //3 - пракви по количеству ингридиента
        public void EditIngredient(string NameIng, string newName, string newCount)
        {
            //TODO: Реализовать проверку значений на Null или глупость; (В моем случае проверка в форме(в БМ неправильно)

            //находим элемент который нужно отредактировать и обновляем его
            var item = ingredients.Find(n => n.NameIngredient == NameIng);
            item.NameIngredient = newName;
            item.Сount = newCount;
        }

        public void DeleteIngredient(string delName)
        {
            //находим и удаляем элемент
            var itemToDelete = ingredients.Where(x => x.NameIngredient == delName).Select(x => x).First();
            ingredients.Remove(itemToDelete);
        }
    }
}
