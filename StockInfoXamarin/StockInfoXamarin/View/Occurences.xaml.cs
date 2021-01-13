using RestSharp;
using RestSharp.Serializers.Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using StockInfoXamarin.Services;
using StockInfoXamarin.Model;
using System.Collections.ObjectModel;

namespace StockInfoXamarin.View
{
   

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Occurences : ContentPage
    {
        public ObservableCollection<Occurence> ListOfEvents { get; set; }

        public Occurences()
        {
            InitializeComponent();
            ListOfEvents = APIServices.GetOcurrencesList();
            listka.ItemsSource = ListOfEvents;
        }

        public void refreshButton_Clicked(object sender, EventArgs e)
        {
            ListOfEvents = APIServices.GetOcurrencesList();
            listka.ItemsSource = ListOfEvents;
        }

        private void listka_Refreshing(object sender, EventArgs e)
        {
            ListOfEvents = APIServices.GetOcurrencesList();
            listka.ItemsSource = ListOfEvents;
            listka.EndRefresh();
        }
    }
    
}