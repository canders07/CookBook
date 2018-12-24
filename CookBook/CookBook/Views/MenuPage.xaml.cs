using CookBook.DataSource;
using CookBook.Models;
using CookBook.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<Folder> menuItems;
        public MenuPage()
        {
            InitializeComponent();
            FolderData folderData = new FolderData();
            menuItems = folderData.folders();
            menuItems = new List<Folder>
            {
                new Folder {Id = MenuItemType.Browse, Title="Browse" },
                new Folder {Id = MenuItemType.About, Title="About" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((Folder)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}