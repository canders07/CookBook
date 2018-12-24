using CookBook.DataSource;
using CookBook.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CookBook.ViewModels
{
    public class ListRecipesModel 
    {
        private ObservableCollection<RecipeListItem> recipeLists;
        public ObservableCollection<RecipeListItem> RecipeLists
        {
            get { return recipeLists; }
            set
            {
                recipeLists = value;
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

        public ListRecipesModel(string path, string name)
        {
            Title = name;
            RecipeLists = new ObservableCollection<RecipeListItem>();
            FolderData _context = new FolderData();
            List<RecipeListItem> recipeLists = _context.recipes(path);
            foreach (RecipeListItem recipe in recipeLists)
            {

                RecipeLists.Add(recipe);
            }
        }
    }
}
