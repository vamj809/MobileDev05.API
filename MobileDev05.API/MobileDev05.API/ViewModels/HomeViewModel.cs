using MobileDev05.API.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MobileDev05.API.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public string SearchString { get; set; }

        public ICommand SearchCommand;
        private IRecipesApiService _recipeApiService;
        public HomeViewModel()
        {
            SearchCommand = new Command(OnSearchClicked);
            _recipeApiService = new RecipesApiService();
        }

        public async void OnSearchClicked()
        {
            if (string.IsNullOrWhiteSpace(SearchString))
            {
                await App.Current.MainPage.DisplayAlert("Alerta", "Debe especificar al menos un valor de búsqueda", "OK");
            } else if(Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await App.Current.MainPage.DisplayAlert("Advertencia", "Debe estar conectado a internet para acceder a nuestros datos", "OK");
            } else
            {
                await _recipeApiService.GetRecipesAsync(SearchString);
            }
        }
    }
}
