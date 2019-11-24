using BLCookingBook.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCookingBook.Controller
{
    public class DBInitialization: DropCreateDatabaseAlways<DBContext>
    {
        protected override void Seed(DBContext db)
        {
            //------------------------Data----------------------------//
            db.Recipes.Add(new Recipe()
            {
                NameRecipe = "яишница",
                Ingredients = new List<Ingredient>()  {
                    new Ingredient() { NameIngredient = "Яйца, шт", Сount = 5 },
                    new Ingredient() { NameIngredient = "Соль, гр", Сount =  10},
                    new Ingredient() { NameIngredient = "оливковое/подсолнечное масло, мл", Сount = 1 },
                },
                DescriptionOfRecipes = "Рецепт: " +
                        "1.Помыть яйцо(яйца) " +
                        "2.Разогреть сковороду " +
                        "3.Смазать маслом " +
                        "4.Разбить яйцо(яйца) " +
                        "5.Ждать, пока они не станут белыми " +
                        "6.Выложить на тарелку " +
                        "Вот такой вкусный и лёгкий рецепт!"
            });
            db.Recipes.Add(new Recipe()
            {
                NameRecipe = "яишница1",
                Ingredients = new List<Ingredient>()  {
                    new Ingredient() { NameIngredient = "Яйца, шт", Сount = 5 },
                    new Ingredient() { NameIngredient = "Соль, гр", Сount =  10},
                    new Ingredient() { NameIngredient = "оливковое/подсолнечное масло, мл", Сount = 1 },
                },
                DescriptionOfRecipes = "Рецепт: " +
                       "1.Помыть яйцо(яйца) " +
                       "2.Разогреть сковороду " +
                       "3.Смазать маслом " +
                       "4.Разбить яйцо(яйца) " +
                       "5.Ждать, пока они не станут белыми " +
                       "6.Выложить на тарелку " +
                       "Вот такой вкусный и лёгкий рецепт!"
            });

            db.Recipes.Add(new Recipe()
            {
                NameRecipe = "яишница2",
                Ingredients = new List<Ingredient>()  {
                    new Ingredient() { NameIngredient = "Яйца, шт", Сount = 5 },
                    new Ingredient() { NameIngredient = "Соль, гр", Сount =  10},
                    new Ingredient() { NameIngredient = "оливковое/подсолнечное масло, мл", Сount = 1 },
                },
                DescriptionOfRecipes = "Рецепт: " +
                       "1.Помыть яйцо(яйца) " +
                       "2.Разогреть сковороду " +
                       "3.Смазать маслом " +
                       "4.Разбить яйцо(яйца) " +
                       "5.Ждать, пока они не станут белыми " +
                       "6.Выложить на тарелку " +
                       "Вот такой вкусный и лёгкий рецепт!"
            });


            base.Seed(db);
        }
    }
}
