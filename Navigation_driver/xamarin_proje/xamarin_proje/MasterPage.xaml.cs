using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_proje
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {

        List<MenuItems> menu;

        public MasterPage()
        {
            InitializeComponent();

            menu = new List<MenuItems>();

            menu.Add(new MenuItems { OptionName = "Fimler" });
            menu.Add(new MenuItems { OptionName = "Kitaplar" });
            menu.Add(new MenuItems { OptionName = "Profilim" });
            menu.Add(new MenuItems { OptionName = "Ayarlar" });
         
            navigationList.ItemsSource = menu;
            Detail = new NavigationPage(new Movies());
        }

        private void Item_Tapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                var item = e.Item as MenuItems;

                switch (item.OptionName)
                {
                    case "Fimler":
                        {
                            Detail = new NavigationPage(new Movies());
                            IsPresented = false;
                        }
                        break;
                    case "Kitaplar":
                        {
                            Detail = new NavigationPage(new Books());
                            IsPresented = false;
                        }
                        break;
                    case "Profilim":
                        {
                            Detail.Navigation.PushAsync(new Profile());
                            IsPresented = false;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }


    public class MenuItems
    {
        public string OptionName { get; set; }
    }
}
