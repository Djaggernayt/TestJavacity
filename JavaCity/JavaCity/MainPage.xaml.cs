using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JavaCity
{
    public partial class MainPage : ContentPage
    {
        public class Cafe
        {
            public string ImagePath { get; set; }
            public string Title { get; set; }
            public string About { get; set; }
        }

        public List<Cafe> Cafes;

        public MainPage()
        {
            InitializeComponent();
            Cafes = new List<Cafe>
            {
                new Cafe{ImagePath="sdfjg.png", About = "some",Title="Drink" },
                new Cafe{ImagePath="sdfjg.png", About = "some",Title="Drink" },
                new Cafe{ImagePath="sdfjg.png", About = "some",Title="Drink" },
                new Cafe{ImagePath="sdfjg.png", About = "some",Title="Drink" },
                new Cafe{ImagePath="sdfjg.png", About = "some",Title="Drink" }
            };
            this.BindingContext = this;
        }


        private async void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Cafe cafe = e.SelectedItem as Cafe;
            if (cafe != null)
            {
                await Navigation.PushAsync(new Order(cafe));
            }
        }
    }
}
