using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Login
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        async void OnClicked(object o, EventArgs args)
        {
            await Navigation.PushModalAsync(new Anasayfa());

        }



    }
}
