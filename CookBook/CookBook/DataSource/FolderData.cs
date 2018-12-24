using CookBook.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CookBook.DataSource
{
    public class FolderData
    {
        public List<Folder> folders()
        {
            ApiCall apiCall = new ApiCall { };
            List<Folder> folders = new List<Folder> { };
            List<string> folderseses = new List<string> { };
            folderseses = apiCall.GetFolders();
            foreach(string folder in folderseses)
            {
                string[] fileName = folder.Split('\\');

                Folder fold = new Folder();
                fold.path = folder;
                fold.Name = (fileName[fileName.Length-1]);
                
                folders.Add(fold);
            }
            return folders;
        }

        public List<RecipeListItem> recipes(string path)
        {
            ApiCall apiCall = new ApiCall { };
            List<RecipeListItem> folders = new List<RecipeListItem> { };
            List<string> folderseses = new List<string> { };
            folderseses = apiCall.GetRecipesInFolder(path);
            foreach (string recipe in folderseses)
            {
                string[] fileName = recipe.Split('\\');

                RecipeListItem fold = new RecipeListItem();
                fold.path = path +"\\"+ recipe;
                fold.Name = (fileName[fileName.Length - 1]).Replace(".xml","");
                
                folders.Add(fold);
            }
            return folders;
        }

        public Recipe GetRecipe(string path)
        {
            ApiCall apiCall = new ApiCall();
            Recipe recipe = new Recipe();
            recipe = apiCall.GetRecipe(path);
            return recipe;
        }


    }
}
