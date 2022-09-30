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
    public partial class Estoque : ContentPage
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private async void IrSalgados(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ArqEstoque.EstoqueSalgado());
        }

        private void IrDoces(object sender, EventArgs e)
        {

        }

        private void IrBebidas(object sender, EventArgs e)
        {

        }
    }
}