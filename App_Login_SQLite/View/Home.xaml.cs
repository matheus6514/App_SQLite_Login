﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Login_SQLite.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Login_SQLite.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            txtUsuario.Text = "Seje, bem- vindo(a): " + Menu.usuario.Nome;
        }
    }
}