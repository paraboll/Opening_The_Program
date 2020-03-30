using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLCookingBook.Model;

namespace BLCookingBook.Controller
{
    public class ControllerRecipe
    {
        /// <summary>
        /// Содержит лист ингридиентов.
        /// </summary>
        public ControllerIngredient controllerIngredient;

        /// <summary>
        /// Содержит список рецептов.
        /// </summary>
        public List<Recipe> recipes;

        /// <summary>
        /// Пустой список рецептов
        /// </summary>
        public ControllerRecipe()
        {
            recipes = new List<Recipe>();
            controllerIngredient = new ControllerIngredient();
        }

        public ControllerRecipe(List<Recipe> recipes, ControllerIngredient controllerIngredient)
        {
            this.recipes = recipes;
            this.controllerIngredient = controllerIngredient;
        }


    }
}
