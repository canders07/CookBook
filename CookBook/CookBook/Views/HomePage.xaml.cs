using CookBook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBook.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;

namespace CookBook.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            BindingContext = new HomeFolders();
            ListViewMenuFolders.ItemTapped += ListViewMenuFolders_ItemTapped;
            addBtn.Clicked += AddBtn_Clicked;
            //ListViewMenuFolders.ItemSelected += async (sender, e) =>
            //{
            //    if (e.SelectedItem == null)
            //        return;

            //    var id = (string)((Folder)e.SelectedItem).path;
            //    //await RootPage.NavigateFromMenu(id);
            //};

        }
        
        public async void AddBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddRecipe());
        }
        
        private async void ListViewMenuFolders_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Folder tappedFolder= (Folder)((ListView)sender).SelectedItem;
            await Navigation.PushAsync(new RecipeList(tappedFolder.path, tappedFolder.Name));
        }
    }
}