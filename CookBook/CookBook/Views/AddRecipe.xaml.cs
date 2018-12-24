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
	public partial class AddRecipe : ContentPage
	{
		public AddRecipe ()
		{
			InitializeComponent ();
            webView.Source = @"http://cookbookapi-test.us-east-2.elasticbeanstalk.com/RecipeCreate";

        }
	}
}