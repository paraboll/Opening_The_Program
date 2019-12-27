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
        //Для добавления в фаил рецептов.
        Recipe recipe;

        ControllerIngredient controllerIngredient;

        //содержит список рецептов.
        List<Recipe> recipes;

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
