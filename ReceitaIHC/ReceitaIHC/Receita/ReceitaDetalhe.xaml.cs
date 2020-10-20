using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReceitaIHC.Receita
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReceitaDetalhe : ContentPage
    {
        ObservableCollection<FileImageSource> imageSources = new ObservableCollection<FileImageSource>();
        int cont = 0;
        public ReceitaDetalhe()
        {
            InitializeComponent();
            Like.Text = "Curtidas: " + cont;
            imageSources.Add("quibe.jpg");
            imageSources.Add("quibe1.jpg");
            imageSources.Add("quibe2.jpg");
            imageSources.Add("quibe3.jpg");


            imgSlider.Images = imageSources;
        }
        public async void SomarLike(object Sender, EventArgs args)
        {
            cont++;
            Like.Text = "Curtidas: " + cont;
        }
    }
}