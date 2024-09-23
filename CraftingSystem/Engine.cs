using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static CraftingSystem.Library;

namespace CraftingSystem
{
    public class Engine
    {
        private string applicationName = "Crafting System";
        private List<Recipe> recipes = new List<Recipe>();
        Person Player = new Person("Player Name");
        Person Vendor = new Person();

        public void Start()
        {
            //temporary data for testing
            recipes.Add(
                new Recipe()
                {
                    RecipeAmount = 1,
                    RecipeName = "Test Recipe",
                    RecipeRequirements = new List<Item>()
                    {
                    new Item() {ItemName = "Water" },
                    new Item() {ItemName = "Sugar" },
                    new Item() {ItemName = "Flour" }
                    },
                    RecipeValue = 10,

                });

            Title = applicationName;
            Print($"Welcome {Player.PersonName} to {applicationName}");
            SetPlayerName();
            Print(Player.About());
            Print(Player.ShowInventory());
            Print(ShowRecipes());

        }
        private void SetPlayerName()
        {
            Print("Want change your name? Enter y for yes, n for no:");

            if (GetInput(ReadLine()).ToLower() == "y")
            {
                Print("Enter your name:");
                Player.ChangeName(GetInput(ReadLine()));
            }
        }
        private string ShowRecipes()
        {
            string output = "Recipes: \n";
            foreach (Recipe recipe in recipes)
            {
                output += $"{recipe.RecipeName}\n";
            }

            return output;
        }

    }
}