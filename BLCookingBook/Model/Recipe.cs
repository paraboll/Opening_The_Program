using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BLCookingBook.Model
{
    [Serializable]
    public class Recipe
    {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement(ElementName = "NameRecipe")]
        public string NameRecipe { get; set; }

        [XmlElement(ElementName = "DescriptionOfRecipes")]
        public string DescriptionOfRecipes { get; set; }

        [XmlArray("Ingredients"), XmlArrayItem("Ingredient")]
        public List<Ingredient> Ingredients { get; set; } 
    }
}
