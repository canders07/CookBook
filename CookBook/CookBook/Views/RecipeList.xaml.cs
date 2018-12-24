using CookBook.Models;
using CookBook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookBook.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipeList : ContentPage
	{
		public RecipeList (string path, string name)
		{
            InitializeComponent();
            BindingContext = new ListRecipesModel(path, name);
            ListViewRecipes.ItemTapped += ListViewRecipes_ItemTapped;
            Title = name;
            
        }

        private async void ListViewRecipes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            RecipeListItem tappedRecipe = (RecipeListItem)((ListView)sender).SelectedItem;
            await Navigation.PushAsync(new RecipePage(tappedRecipe.path));
        }
    }
}