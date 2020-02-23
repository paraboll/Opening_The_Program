using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BLCookingBook.Model
{
    public class Ingredient
    {
        /// <summary>
        /// Id ингридиента.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя ингридиента.
        /// </summary>
        public string NameIngredient { get; set; }

        /// <summary>
        /// Количество ингридиентов.
        /// </summary>
        public string Сount { get; set; }

        /// <summary>
        /// Пустой Конструктор
        /// </summary>
        public Ingredient(){}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameIngredient"></param>
        /// <param name="count"></param>
        public Ingredient(string nameIngredient, string count)
        {
            //TODO: добавть вызов исключения на null и вывод в лог.
            if(string.IsNullOrEmpty(nameIngredient))
            {
                Console.WriteLine("nameIngredient пустая"); 
            }
            if(string.IsNullOrEmpty(count))
            {
                Console.WriteLine("count пустая"); 
            }

            NameIngredient = nameIngredient;
            Сount = count;
        }
    }
}
