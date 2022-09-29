using CidaoLanches2.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CidaoLanches2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PaginaInicial), typeof(PaginaInicial));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
