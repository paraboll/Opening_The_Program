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
        public int Id { get; set; }

        public string NameIngredient { get; set; }

        public string Сount { get; set; }
    }
}
