using BLCookingBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCookingBook.Controller
{
    public class ViewDataBase
    {
        public DBContext db_DataContext = new DBContext();
        
        public void DataBa()
        { 
            IEnumerable<Recipe> Recipes = db_DataContext.Recipes;
            IEnumerable<Ingredient> Ingredients = db_DataContext.Ingredients;

            foreach (var r in Recipes)
            {
                Console.WriteLine(r.Id + " " + r.NameRecipe + " " + r.DescriptionOfRecipes);
                Console.WriteLine("Ингридиенты");
                foreach (var item in r.Ingredients)
                {
                    Console.WriteLine(item.NameIngredient + " " + item.Сount); 
                }
                Console.WriteLine();
            }
        }
    }
}
