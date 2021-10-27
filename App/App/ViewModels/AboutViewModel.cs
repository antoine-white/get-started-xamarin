using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private static readonly string TITLE = "About";

        public AboutViewModel()
        {
            Title = TITLE;
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}