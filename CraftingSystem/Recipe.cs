using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraftingSystem
{
    public class Recipe
    {
        public string RecipeName;
        public double RecipeAmount = 1;
        public double RecipeValue = 1;
        public List<Item> RecipeRequirements = new List<Item>();
    }
}