using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tarau_Bianca_Lab12_Xamarin.Data;

namespace Tarau_Bianca_Lab12_Xamarin
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
