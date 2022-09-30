using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CidaoLanches2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaInicial : ContentPage
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void CadastroItem(object sender, EventArgs e)
        {

        }

        private void Relatorio(object sender, EventArgs e)
        {

        }

        private void Vendas(object sender, EventArgs e)
        {

        }

        private async void Estoque(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Estoque());
        }
    }
}