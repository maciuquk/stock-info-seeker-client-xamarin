using StockInfoXamarin.Model;
using StockInfoXamarin.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StockInfoXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Words : ContentPage
    {
        public ObservableCollection<Word> ListOfWords { get; set; }

        public Words()
        {
            InitializeComponent();
            ListOfWords = APIServices.GetWordsList();
            listka.ItemsSource = ListOfWords;
           
        }

        private void addButton_Clicked(object sender, EventArgs e)
        {
            APIServices.AddNewWord(inputWord.Text);
            ListOfWords = APIServices.GetWordsList();
            listka.ItemsSource = ListOfWords;
        }

        private void refreshButton_Clicked(object sender, EventArgs e)
        {
            ListOfWords = APIServices.GetWordsList();
            listka.ItemsSource = ListOfWords;
        }

        private void listka_Refreshing(object sender, EventArgs e)
        {
            ListOfWords = APIServices.GetWordsList();
            listka.ItemsSource = ListOfWords;
            listka.EndRefresh();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Word;
            //APIServices.RemoveWord(button.id);
        }

        private void listka_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            
        }

        private void listka_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var word = e.SelectedItem as Word;
            DisplayAlert("Usunięto słowo:", word.word, "OK");
            APIServices.RemoveWord(word.id);
            ListOfWords = APIServices.GetWordsList();
            listka.ItemsSource = ListOfWords;

        }
    }
}