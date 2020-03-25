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

        // Member variables have their values set after object instantiation
        public Recipe() { }
    }
}
