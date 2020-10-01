using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConnexionFormView : ContentView
    {
        private ITwitterService twitterService = new TwitterService();
        public ConnexionFormView()
        {
            InitializeComponent();
            this.btn_connect.Clicked += Connection_Clicked;
        }


        private bool ConnectivityTest()
        {
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                return true;
            }

            return false;
        }


        public void Connection_Clicked(object sender, EventArgs e)
        {
            string id = this.id.Text;
            string password = this.password.Text;
            bool isValidId = false;
            bool isValidPassword = false;

            if (id == null || id.Length < 3)
            {
                this.error_id.Text = "L'identifiant doit comporter au moins 3 caractères";
                this.error_id.IsVisible = true;
            }
            else
            {
                isValidId = true;
                this.error_id.IsVisible = false;
            }

            if (password == null || password.Length < 6)
            {
                this.error_pwd.Text = "Le mot de passe doit comporter au moins 6 caractères";
                this.error_pwd.IsVisible = true;
            }
            else
            {
                isValidPassword = true;
                this.error_pwd.IsVisible = false;
            }

            if (isValidId && isValidPassword)
            {
                if (!ConnectivityTest())
                {
                    this.error_CNX.IsVisible = true;
                    this.error_CNX.Text = "Pas d'accès internet";
                }
                else
                {
                    if (this.twitterService.Authenticate(id, password))
                    {
                        Navigation.PushAsync(new TweetPage());
                    }
                    else
                    {
                        this.error_CNX.IsVisible = true;
                        this.error_CNX.Text = "Identifiants incorrects";
                    }
                }

            }
        }
    }
}