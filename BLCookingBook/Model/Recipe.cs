using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BLCookingBook.Model
{
    /// <summary>
    /// Класс хранить информацию рецепта
    /// </summary>
    public class Recipe
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="_NameRecipe">Название рецепта</param>
        /// <param name="_DescriptionOfRecipes">Описание рецепта</param>
        /// <param name="_Ingredients">Набор ингридиентов</param>
        /// <param name="_RecipeRatingByTaste">Оценка вкусности рецепта</param>
        /// <param name="_RecipeRatingByСookingTime">Время приготовления рецепта</param>
        public Recipe(
            string _NameRecipe, 
            string _DescriptionOfRecipes, 
            List<Ingredient> _Ingredients,
            int _RecipeRatingByTaste = 0,
            string _RecipeRatingByСookingTime = "без оценки"
            )
        {
            NameRecipe = _NameRecipe ?? throw new ArgumentNullException("Имя рецепта не может быть равно null");
            DescriptionOfRecipes = _DescriptionOfRecipes ?? throw new ArgumentNullException("Описание рецепта не может быть равно null");
            Ingredients = _Ingredients ?? throw new ArgumentNullException("Лист ингридиентов не может быть равен null");
            RecipeRatingByTaste = _RecipeRatingByTaste;
            RecipeRatingByСookingTime = _RecipeRatingByСookingTime;
        }

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Recipe() { }

        /// <summary>
        /// Название рецепта.
        /// </summary>
        public string NameRecipe { get; set; }

        /// <summary>
        /// Описание рецепта.
        /// </summary>
        public string DescriptionOfRecipes { get; set; }

        /// <summary>
        /// Лист инградиентов рецепта.
        /// </summary>
        public List<Ingredient> Ingredients { get; set; } 

        /// <summary>
        /// Оценка рецепта по вкусу.
        /// </summary>
        public int RecipeRatingByTaste { get; set; }

        /// <summary>
        /// Время приготовления.
        /// </summary>
        public string RecipeRatingByСookingTime { get; set; }
    }
}
