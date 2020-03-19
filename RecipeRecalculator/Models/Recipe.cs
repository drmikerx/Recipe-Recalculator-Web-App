using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RecipeRecalculator.Models;

namespace RecipeRecalculator.Models
{
    public class Recipe
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int NumIngredients { get; set; }
        [Required]
        public int NumPeopleCurrent { get; set; }
        [Required]
        public int NumPeopleNew { get; set; }
        public List<Ingredient> IngredientsList { get; set; }

        /*
        public Recipe(string NameOf, int NumberIngredients, int NumberCurrentPeople, int NumberNewPeople)
        {
            Name = NameOf;
            NumIngredients = NumberIngredients;
            NumPeopleCurrent = NumberCurrentPeople;
            NumPeopleNew = NumberNewPeople;
            IngredientsList = new List<Ingredient>();
        }

        */

        public Recipe() { }
    }
}
