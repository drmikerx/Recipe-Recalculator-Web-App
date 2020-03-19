using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeRecalculator.Models
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double AmountBeforeConversion { get; set; }
        public double AmountAfterConversion { get; set; }
        public string Unit { get; set; }


        /*
        public Ingredient(string NameOf, double AmountBefore, string UnitOfMeasure)
        {
            Name = NameOf;
            AmountBeforeConversion = AmountBefore;
            AmountAfterConversion = 0;     // Will be assigned later
            Unit = UnitOfMeasure;
        }

        */

        public Ingredient() { }
    }
}
