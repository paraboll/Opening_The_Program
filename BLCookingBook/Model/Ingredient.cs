using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BLCookingBook.Model
{
    [Serializable]
    public class Ingredient
    {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement(ElementName = "NameIngredient")]
        public string NameIngredient { get; set; }

        [XmlElement(ElementName = "Сount")]
        public string Сount { get; set; }
    }
}
