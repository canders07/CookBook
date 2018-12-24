using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace CookBook.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("http://cookbookapi-test.us-east-2.elasticbeanstalk.com/RecipeCreate")));
        }

        public ICommand OpenWebCommand { get; }
    }
}