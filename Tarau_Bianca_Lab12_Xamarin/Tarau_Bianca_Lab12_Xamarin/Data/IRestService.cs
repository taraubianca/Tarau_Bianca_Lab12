using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tarau_Bianca_Lab12_Xamarin.Models;
namespace Tarau_Bianca_Lab12_Xamarin.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
