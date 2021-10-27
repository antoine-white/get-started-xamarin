using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace App.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private const string PROPERTY_NAME = "ButtonStr";
        private static readonly string TITLE = "Home";

        private int _count;

        public string ButtonStr {private set;get;}

        public HomeViewModel()
        {
            _count = 0;
            Title = TITLE;
            UpdateButtonStr();
            AddCount = new Command(() => {
                _count++;
                UpdateButtonStr();
            });
        }

        private void UpdateButtonStr()
        {
            ButtonStr = $"Button has been clicked {_count} times!";
            OnPropertyChanged(PROPERTY_NAME);
        }

        public ICommand AddCount { get; }
    }
}