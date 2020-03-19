using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeRecalculator.Models;

namespace RecipeRecalculator
{
    public class BasicInfoModel : PageModel
    {
        public void OnGet()
        {

        }

        /*
        public void OnPost()
        {
            var request = HttpContext.Request;
            var stream = new StreamReader(request.Body);
            var body = stream.ReadToEndAsync();

            System.Diagnostics.Debug.WriteLine("Where's Waldo");
            System.Diagnostics.Debug.WriteLine(request.Body.ToString());
            
            Response.Redirect("/CurrentIngredients");
        }

        */
        
    }
}