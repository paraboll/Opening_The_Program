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
    /// Класс позволяет сохранять и загружать данные из текстового файла.
    /// </summary>
    public class SaveFile
    {
        /// <summary>
        /// метод вывода данных в фаил по определенному алгоритму.
        /// </summary>
        /// <param name="recipe">Новый рецепт</param>
        public void WriteInFile(Recipe recipe)
        {
            //проверка на создание папка
            CreateIfMissing("data");

            StreamWriter str = new StreamWriter("Data//Recipe.txt", true);
            str.WriteLine("NewRecipe");

            //Задаем имя рецепту
            str.WriteLine(recipe.NameRecipe);

            //Задаем описание рецепта
            str.WriteLine(recipe.DescriptionOfRecipes);

            //для удобства считывания - количество ингридиентов
            str.WriteLine(recipe.Ingredients.Count);

            //Задаем список ингридиентов: имя + количество
            foreach (var item in recipe.Ingredients)
            {
                str.WriteLine(item.NameIngredient);
                str.WriteLine(item.Сount);
            }
            str.WriteLine("------------");

            str.Close();
            Console.WriteLine("Запись в фаил успешна --> Data//Recipe.txt");
            Console.WriteLine();
        }

        // метод проверяет существует ли уже папка с введенным именем и если нет - создает ее
        private void CreateIfMissing(string path)
        {
            bool folderExists = Directory.Exists(path);
            if (!folderExists)
                Directory.CreateDirectory(path);
        }
        
        /// <summary>
        /// Метод распарсивает фаил Рецептов.
        /// </summary>
        /// <returns>Возвращяет лист рецептов из файла.</returns>
        public List<Recipe> GetListRecipe()
        {
            List<Recipe> recipes = new List<Recipe>(); 
            Recipe recipe;
            string newRecipe;

            using (var reader = new StreamReader("Data//Recipe.txt"))
            {
                while (reader.Peek() != -1)
                {
                    newRecipe = reader.ReadLine();
                    if (newRecipe == "NewRecipe")
                    {
                        recipe = new Recipe();

                        recipe.NameRecipe = reader.ReadLine();
                        recipe.DescriptionOfRecipes = reader.ReadLine();
                        int ingLength = Convert.ToInt32(reader.ReadLine());
                        recipe.Ingredients = new List<Ingredient>();

                        for (int i = 0; i < ingLength; i++)
                        {
                            recipe.Ingredients.Add(new Ingredient()
                            {
                                NameIngredient = reader.ReadLine(),
                                Сount = reader.ReadLine()
                            });
                        }

                        string end = reader.ReadLine();
                        if (end == "------------")
                        {
                            recipes.Add(recipe);
                            Console.WriteLine("Рецепт считан успешно");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }


                }
                return recipes;
            }
        }
    }
}
