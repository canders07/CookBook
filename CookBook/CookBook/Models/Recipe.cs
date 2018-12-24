using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook.Models
{
    public class Ingredient
    {
        public string Name { get; set; }
        public string Amount { get; set; }
    }

    public class Ingredients
    {
        public List<Ingredient> Ingredient { get; set; }
    }



    public class AddlIngredients
    {
        public List<Ingredient> Ingredient { get; set; }
    }

    

    public class Sub
    {
        public Ingredient Ingredient { get; set; }
    }


    public class Replace
    {
        public Ingredient Ingredient { get; set; }
    }

    public class Grp
    {
        public Sub Sub { get; set; }
        public Replace Replace { get; set; }
    }

    public class SubstIngredients
    {
        public List<Grp> Grp { get; set; }
    }

    public class Variation
    {
        public string Name { get; set; }
        public AddlIngredients Addl_ingredients { get; set; }
        public SubstIngredients Subst_ingredients { get; set; }
        public string Addl_directions { get; set; }
    }

    public class Variations
    {
        public List<Variation> Variation { get; set; }
    }

    public class Recipe
    {
        public string Title { get; set; }
        public Ingredients Ingredients { get; set; }
        public string Directions { get; set; }
        public Variations Variations { get; set; }
    }
}
