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
    public partial class Perfil : ContentPage
    {
        public Perfil()
        {
            InitializeComponent();
        }
        public async void Enviadas(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Receita.Auxiliar());
        }
    }
}