using MobileDev05.API.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace MobileDev05.API.Services
{
    public interface IRecipesApiService
    {
        Task<ObservableCollection<RecipeHits>> GetRecipesAsync(string query);
    }
}
