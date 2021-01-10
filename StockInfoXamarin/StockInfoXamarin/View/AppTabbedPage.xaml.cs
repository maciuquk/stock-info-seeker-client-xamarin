using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StockInfoXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppTabbedPage : TabbedPage
    {
        public AppTabbedPage()
        {
            InitializeComponent();

            //this.Children.Add(new ContentPage());
            //this.Children.Add(new MainPage());
            //this.Children.Add(new ContentPage());
        }
    }
}