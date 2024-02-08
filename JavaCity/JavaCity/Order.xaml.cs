using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JavaCity
{
    [Table("Orders")]
    public class Orderes
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Count { get; set; }
        public string Summa { get; set; }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Order : ContentPage
    {

        public class Sale
        {
            public string Title { get; set; }
            public string Count { get; set; }
            public string Price { get; set; }
        }
        public List<Sale> Sales;
        public List<Sale> Sales1;
        public Order(MainPage.Cafe cafe)
        {
            InitializeComponent();
            if(cafe.Title =="Drink")
            {
                Sales = new List<Sale> { 
                    new Sale {Title="Cola",Price="125"},
                    new Sale {Title="Cola",Price="125"},
                    new Sale {Title="Cola",Price="125"},
                    new Sale {Title="Cola",Price="125"}
                };
                this.BindingContext = this;
            }
        }

        

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            var selen = (sender as Xamarin.Forms.Switch);
            if (selen.IsToggled)
            {
                string id = selen.ClassId;
                Sales1.Add(Sales.FirstOrDefault(x => x.Title == id));
            }

        }

        private void buy_Clicked(object sender, EventArgs e)
        {
            
            for (int i = 0;i< Sales1.Count; i++)
            {
                string t = Sales1[i].Title;
                string p = Sales1[i].Title;

                App.database.SaveItem(new List<Orderes>(new Orderes { Name = , Count = }));
            }
        }
    }
}