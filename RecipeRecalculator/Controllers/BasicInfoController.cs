using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeRecalculator.Models;
using System.Web;


namespace RecipeRecalculator.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BasicInfoController : ControllerBase
    {
        public static Dictionary<int, Recipe> recipes = new Dictionary<int, Recipe>();
        

        [HttpPost]
        public void PostRecipe([FromForm] Recipe recipe)
        {

            if(ModelState.IsValid && recipe != null)
            {
                // Fill recipe object with form data

                recipe.Name = HttpUtility.HtmlEncode(recipe.Name);
                recipe.NumIngredients = Int32.Parse(HttpUtility.HtmlEncode(recipe.NumIngredients));
                recipe.NumPeopleCurrent = Int32.Parse(HttpUtility.HtmlEncode(recipe.NumPeopleCurrent));
                recipe.NumPeopleNew = Int32.Parse(HttpUtility.HtmlEncode(recipe.NumPeopleNew));

                // Create a blank ingredient list for the recipe (to be filled out later)

                recipe.IngredientsList = new List<Ingredient>();

                // Assign the recipe object an ID
                //var id = Guid.NewGuid();
                recipes[0] = recipe;        // There's only going to be one recipe object

                // Redirect to the next form page
                Response.Redirect("/CurrentIngredients");

            }

            else
            {
                System.Diagnostics.Debug.WriteLine("Post Recipe Failed!");
            }
        }
    }
}