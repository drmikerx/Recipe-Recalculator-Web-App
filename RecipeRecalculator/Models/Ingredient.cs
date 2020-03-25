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


        public Ingredient() { }     // Member variables have their values set via form after object instantiation
    }
}
