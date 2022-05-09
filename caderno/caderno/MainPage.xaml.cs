using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace caderno
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //O "private void" é uma função que basicamente diz o seguinte:"sempre que o
        //Clicked "PrimeiroAno_Clicked for ativado execute o comando abaixo

        private void PrimeiroAno_Clicked(object sender, EventArgs e)
        {
         //O comando abaixo é uma indicação de pra que pagina o botão "PrimeiroANo_Clicked"
         //deve levar o usuario quando apertado, no caso desse botão,ele leva
         //a pagina de mateira do primeiro ano
        
            Navigation.PushAsync(new PrimeiroAno());
        
        
        }

        private void SegundoAno_Clicked(object sender, EventArgs e)
        {

        }

        private void TerceiroAno_Clicked(object sender, EventArgs e)
        {

        }
    }
}
