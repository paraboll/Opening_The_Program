﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCookingBook.Model
{
    public class Recipe
    {
        public int Id { get; set; }

        public string NameRecipe { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public string DescriptionOfRecipes { get; set; }
    }
}
