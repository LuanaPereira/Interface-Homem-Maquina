using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReceitaIHC.Receita
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            
        }

        public async void onTapped(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Receita.ReceitaDetalhe());
        }
    }
}