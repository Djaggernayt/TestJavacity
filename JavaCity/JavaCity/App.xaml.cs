using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JavaCity
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "JavaCity.db";
        public static Repos database;
        public static Repos Database
        {
            get
            {
                if (database == null)
                {
                    database = new Repos(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
