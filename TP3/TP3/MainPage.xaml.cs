﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Btn_CNX.Clicked += Btn_CNX_Clicked;  
        }

        private void Btn_CNX_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Btn_CNX clicked");

            string id = this.id.Text;
            string password = this.password.Text;
            bool rememberMe = this.remember_me.IsToggled;
            bool isValidId = false;
            bool isValidPwd = false;

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
                this.error_password.Text = "Le mot de passe doit comporter au moins 6 caractères";
                this.error_password.IsVisible = true;
            }
            else
            {
                isValidPwd = true;
                this.error_password.IsVisible = false;
            }

            if (isValidId && isValidPwd)
            {
                this.form_cnx.IsVisible = false;
                this.tweets.IsVisible = true;
            }
            

        }
    }
}
