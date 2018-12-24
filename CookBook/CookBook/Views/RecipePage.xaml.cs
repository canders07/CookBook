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
	public partial class RecipePage : ContentPage
	{
        
		public RecipePage (string path)
		{
			InitializeComponent();
            RecipeModel recipeModel = new RecipeModel(path);
            BindingContext = recipeModel;
            DirectionTxt.Text = recipeModel.Directions;
            Title = recipeModel.Title;
		}
	}
}