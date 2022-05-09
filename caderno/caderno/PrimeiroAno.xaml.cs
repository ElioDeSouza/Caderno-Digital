using caderno.NovaPasta1; //Essa linha indica ao app que pasta estão as ContentPages de cada materia
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace caderno
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeiroAno : ContentPage
    {
        public PrimeiroAno()
        {
            InitializeComponent();
        }

        //Abaixo os mesmos comandos usados e comentados na "MainPage.xaml.cs" são utiliazados,
        //apenas com a diferenca de quais são os botões e para quais paginas cada botão leva
        //dentro de cada uma das paginas de cada uma das materrias a baixo existe um outro 
        //"<Label Text=" explicadno, de maneira bem rasa, o que nos foi ensinado em cada materia no primeiro ano
        private void LPL_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LPL1());
        }

        private void Mat_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Mat1());
        }

        private void Hist_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Hist1());
        }

        private void Geo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Geo1());
        }

        private void EF_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EF1());
        }

        private void Ing_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ing1());
        }

        private void Fis_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fis1());
        }

        private void Qui_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Qui1());
        }

        private void Bio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bio1());
        }

        private void Filo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Filo1());
        }

        private void Arte_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Arte());
        }

        private void APS_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new APS());
        }

        private void Des_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Des());
        }

        private void FunInfo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FunInfo());
        }

        private void WEB_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WEB1());
        }

        private void LPA_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LPA());
        }

        private void BD_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BD1());
        }
    }
}
// Esse mesmo processo deve ser repitido para o segundo e terceiro ano, porem não consigo fazelo a tempo