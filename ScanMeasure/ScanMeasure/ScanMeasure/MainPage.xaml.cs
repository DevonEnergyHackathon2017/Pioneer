using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScanMeasure
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();
        }

        async void OnAssetTypeButtonClicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new TabbedPages();
            Navigation.InsertPageBefore(new TabbedPages(), this);
            await Navigation.PopAsync();
        }

    }
}
