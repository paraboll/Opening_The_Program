using BLCookingBook.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace BLCookingBook.Controller
{
    public static class SerializationOnJson
    {
        /// <summary>
        /// Метод сереализует рецепты в Json
        /// </summary>
        /// <param name="resipes"></param>
        public static void RecipeSerializationJson(List<Recipe> resipes)
        {
            if (!File.Exists("Recipe.json"))
                File.Create("Recipe.json").Close();

            //Сохранение данных
            using (StreamWriter fs = new StreamWriter("Recipe.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(fs,resipes);
                Console.WriteLine("Data has been saved to file");
            }
        }

        /// <summary>
        /// Метод десереализует рецепты из Json
        /// </summary>
        /// <returns>Возвращяет лист рецептов</returns>
        public static List<Recipe> RecipeDeserializationJson()
        {
            if (!File.Exists("Recipe.json"))
                File.Create("Recipe.json").Close();

            var deserializer = new JsonSerializer();
            //Загрузка данных
            using (var fs = new StreamReader("Recipe.json"))
            {
                using (var reader = new JsonTextReader(fs))
                {
                    if (reader.Value != null)
                        return deserializer.Deserialize<List<Recipe>>(reader);
                    else return new List<Recipe>();
                }
            }
        }
    }
}
