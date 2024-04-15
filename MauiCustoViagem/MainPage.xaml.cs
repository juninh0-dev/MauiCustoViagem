namespace MauiCustoViagem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void btn_calcular_Clicked(object sender, EventArgs e)
        {

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
