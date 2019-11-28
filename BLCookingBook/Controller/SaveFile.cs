using BLCookingBook.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BLCookingBook.Controller
{
    /// <summary>
    /// Класс позволяет сохранять и загружать данные из List в форме XLM и обратно.
    /// </summary>
    public class SaveFile
    {
        /// <summary>
        /// Сохранение данных из list в файл в формате XML.
        /// </summary>
        /// <param name="recipes">list который необходимо сохранить</param>
        public void SaveInFileListXML(List<Recipe> recipes)
        {
            var xmlFormatted = new XmlSerializer(typeof(List<Recipe>));

            using (var file = new FileStream("Recipe.xml", FileMode.OpenOrCreate, FileAccess.Write))
            {
                xmlFormatted.Serialize(file, recipes);
            }
        }

        public void SaveInFileXML(Recipe recipe)
        {
            //Create our own namespaces for the output
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

            //Add an empty namespace and empty value
            ns.Add("", "");

            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "Recipe";
            xRoot.IsNullable = true;

            var xmlFormatted = new XmlSerializer(typeof(Recipe), xRoot);

            using (var file = new FileStream("Recipe.xml", FileMode.Open, FileAccess.Write))
            {
                xmlFormatted.Serialize(file, recipe, ns);
            }
        }

        /// <summary>
        /// Загружает данные в List.
        /// </summary>
        /// <returns></returns>
        public List<Recipe> LoadFileXML()
        {
            List<Recipe> gg;
            var xmlFormatted = new XmlSerializer(typeof(List<Recipe>));

            using (var file = new FileStream("Recipe.xml", FileMode.Open, FileAccess.Read))
            {
                gg =  xmlFormatted.Deserialize(file) as List<Recipe>;
            }

            return gg;
        }
    }
}
