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
        /// метод вывода листа в фаил по определенному алгоритму. Перезаписывает фаил.
        /// </summary>
        /// <param name="recipe"></param>
        public void WriteInFile(List<Recipe> recipe)
        {
            //сохранение в фаил.
            using (StreamWriter str = new StreamWriter("Recipe.txt", false))
            {
                foreach (var r in recipe)
                {
                    str.WriteLine("NewRecipe");

                    //Задаем имя рецепту
                    str.WriteLine(r.NameRecipe);

                    //Задаем описание рецепта
                    str.WriteLine("startDescription");
                    str.WriteLine(r.DescriptionOfRecipes);
                    str.WriteLine("endDescription");

                    str.WriteLine(r.RecipeRatingByTaste);
                    str.WriteLine(r.RecipeRatingByСookingTime);

                    //для удобства считывания - количество ингридиентов
                    str.WriteLine(r.Ingredients.Count);

                    //Задаем список ингридиентов: имя + количество
                    foreach (var item in r.Ingredients)
                    {
                        str.WriteLine(item.NameIngredient);
                        str.WriteLine(item.Сount);
                    }
                    str.WriteLine("------------");

                    //Console.WriteLine("Запись в фаил успешна --> Recipe.txt");
                    //Console.WriteLine();

                }
            }
        }

        /// <summary>
        /// метод вывода данных в фаил по определенному алгоритму. Добавляет элемент в конце файла.
        /// </summary>
        /// <param name="recipe">Новый рецепт</param>
        public void WriteInFile(Recipe recipe)
        {
            StreamWriter str = new StreamWriter("Recipe.txt", true);
            str.WriteLine("NewRecipe");

            //Задаем имя рецепту
            str.WriteLine(recipe.NameRecipe);

            //Задаем описание рецепта
            str.WriteLine("startDescription");
            str.WriteLine(recipe.DescriptionOfRecipes);
            str.WriteLine("endDescription");

            str.WriteLine(recipe.RecipeRatingByTaste);
            str.WriteLine(recipe.RecipeRatingByСookingTime);

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
            //Console.WriteLine("Запись в фаил успешна --> Recipe.txt");
            //Console.WriteLine();
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

            using (var reader = new StreamReader("Recipe.txt"))
            {
                while (reader.Peek() != -1)
                {
                    newRecipe = reader.ReadLine();
                    if (newRecipe == "NewRecipe")
                    {
                        recipe = new Recipe();

                        recipe.NameRecipe = reader.ReadLine();
                        string TextDescription = reader.ReadLine();
                        if(TextDescription == "startDescription")
                        {
                            TextDescription = reader.ReadLine();
                            while (TextDescription!= "endDescription")
                            {
                                recipe.DescriptionOfRecipes += TextDescription + "\n";
                                TextDescription = reader.ReadLine();
                            }
                        }

                        recipe.RecipeRatingByTaste = Convert.ToInt32(reader.ReadLine());
                        recipe.RecipeRatingByСookingTime = reader.ReadLine();

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
                            //Console.WriteLine("Рецепт считан успешно");
                        }
                    }
                    else
                    {
                       // Console.WriteLine("Ошибка");
                    }


                }
                return recipes;
            }
        }
    }
}
