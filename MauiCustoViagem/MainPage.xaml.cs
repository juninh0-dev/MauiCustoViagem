using MauiCustoViagem.Models;

namespace MauiCustoViagem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        public static Viagem via = new Viagem();

        private async void btn_calcular_Clicked(object sender, EventArgs e)
        {
            via.Origem = txt_origem.Text;
            via.Destino = txt_destino.Text;
            via.Distancia = Convert.ToDouble(txt_distancia.Text);
            via.Rendimento = Convert.ToDouble(txt_rendimento.Text);
            via.Preco = Convert.ToDouble(txt_gas.Text);
            
            await Navigation.PushAsync(new Views.CalcularViagem());
        }

        private async void btn_AddPed_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.AddPedagio());
        }

        private async void btn_ListaPed_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.ListaPedagio());
        }
    }

}
