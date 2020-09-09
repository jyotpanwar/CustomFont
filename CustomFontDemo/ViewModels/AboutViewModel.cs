using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using CustomFontDemo.Services;
using Xamarin.Essentials;

namespace CustomFontDemo.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            //OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
            OpenWebCommand = new Command(LearnMore);
        }

        public ICommand OpenWebCommand { get; }

        public async void LearnMore()
        {
            var dialogService = new DialogService();
            //var action = new Action(async () => await Browser.OpenAsync("https://xamarin.com"));
            dialogService.ShowMessage("Alert", "Test Message.", "Ok", null);
        }
    }
}