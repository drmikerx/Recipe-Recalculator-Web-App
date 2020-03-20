using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeRecalculator.Models;

namespace RecipeRecalculator.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CurrentIngredientsController : ControllerBase
    {
        [HttpPost]
        public void PostIngredients([FromForm] List<Ingredient> fields)
        {
            // Add the ingredients from the form to the recipe object's ingredient list
            for (int i = 0; i < fields.Count; i++)
            {
                BasicInfoController.recipes[0].IngredientsList.Add(fields[i]);
            }

            // adjustment factor = old number of people / desired number of people
            // need to prevent integer division so convert one element to double
            double adjustmentFactor = Convert.ToDouble(BasicInfoController.recipes[0].NumPeopleCurrent) / BasicInfoController.recipes[0].NumPeopleNew;

            foreach (var item in BasicInfoController.recipes[0].IngredientsList)
            {
                // new quantity = original quantity / adjustment factor
                item.AmountAfterConversion = item.AmountBeforeConversion / adjustmentFactor;
            }

            Response.Redirect("/Results");
        }
    }
}