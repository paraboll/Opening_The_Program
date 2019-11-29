using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BLCookingBook.Model
{
    public class Recipe
    {
        public int Id { get; set; }

        public string NameRecipe { get; set; }

        public string DescriptionOfRecipes { get; set; }

        public List<Ingredient> Ingredients { get; set; } 
    }
}
