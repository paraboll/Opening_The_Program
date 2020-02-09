using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLCookingBook.Model;

namespace BLCookingBook.Controller
{
    /// <summary>
    /// Класс-контроллер реализует все функции листа ингридиентов.
    /// </summary>
    public class ControllerIngredient
    {
        /// <summary>
        /// список ингридиентов.
        /// </summary>
        public List<Ingredient> ingredients;

        /// <summary>
        /// Конструктор создает новый лист ингридиентов.
        /// </summary>
        public ControllerIngredient()
        {
            ingredients = new List<Ingredient>();
        }

        /// <summary>
        /// Контроллер принимает уже существующий лист игридиентов для работы с ним
        /// </summary>
        /// <param name="ingredients">Существующий лист игридиентов</param>
        public ControllerIngredient(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }

        /// <summary>
        /// Метод добавляет новый элемент в лист
        /// </summary>
        /// <param name="name"></param>
        /// <param name="count"></param>
        public void AddIngridient(string name, string count)
        {
            //TODO: Добавить вывод ошибки "name пустая" и "count пустая" в лог
            if (string.IsNullOrEmpty(name)) { Console.WriteLine("name пустая"); }
            if (string.IsNullOrEmpty(count)) { Console.WriteLine("count пустая"); }

            ingredients.Add(new Ingredient(name, count));
        }

        /// <summary>
        /// Метод позволяет редактировать ингридиент из списка по имени.
        /// </summary>
        /// <param name="NameIng">имя ингридиента который необходимо отредактировать</param>
        /// <param name="newName">новое/старое имя</param>
        /// <param name="newCount">пракви по количеству ингридиента</param>
        public void EditIngredient(string NameIng, string newName, string newCount)
        {
            //TODO: Реализовать проверку значений на Null или глупость; (В моем случае проверка в форме(в БМ неправильно) + лог

            //находим элемент который нужно отредактировать и обновляем его
            var item = ingredients.Find(n => n.NameIngredient == NameIng);
            item.NameIngredient = newName;
            item.Сount = newCount;
        }

        /// <summary>
        /// метод по имени удаляет ингридиент из листа
        /// </summary>
        /// <param name="delName">Имя ингрмдмента</param>
        public void DeleteIngredient(string delName)
        {
            if(delName != "" && delName != null)
            {
                //находим и удаляем элемент
                var itemToDelete = ingredients.Where(x => x.NameIngredient == delName).Select(x => x).First();
                ingredients.Remove(itemToDelete);
            }
            //TODO: вывести в лог предупрежение что  delName пустое.
        }
    }
}
