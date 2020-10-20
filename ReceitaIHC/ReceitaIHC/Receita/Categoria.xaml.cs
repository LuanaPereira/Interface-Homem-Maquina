using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReceitaIHC.Receita
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Categoria : ContentPage
    {
        public Categoria()
        {
            InitializeComponent();
        }
        public async void Bolos(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Receita.Bolos());
        }
    }
}