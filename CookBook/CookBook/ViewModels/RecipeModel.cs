using CookBook.DataSource;
using CookBook.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CookBook.ViewModels
{
    class RecipeModel
    {
        private ObservableCollection<Recipe> recipe;
        public ObservableCollection<Recipe> TheRecipe
        {
            get { return recipe; }
            set
            {
                recipe = value;
            }
        }
        private ObservableCollection<Ingredient> ingredients;
        public ObservableCollection<Ingredient> Ingredients
        {
            get { return ingredients; }
            set
            {
                ingredients = value;
            }
        }
        private string directions;
        public  string Directions
        {
            get { return directions; }
            set
            {
                directions = value;
            }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
            }
        }
        public RecipeModel(string path)
        {
            TheRecipe = new ObservableCollection<Recipe>();
            Ingredients = new ObservableCollection<Ingredient>();
            Directions = "";
            Title = "";
            Recipe theRecipe = new Recipe();
            FolderData _context = new FolderData();
           
            theRecipe = _context.GetRecipe(path);
            TheRecipe.Add(theRecipe);
            foreach (Ingredient ing in theRecipe.Ingredients.Ingredient)
            {
                Ingredients.Add(ing);
            }
            //Directions direction = new Directions();
            //direction.Direction = theRecipe.Directions;
            Directions = theRecipe.Directions;
            Title = theRecipe.Title;
        }
    }
}
