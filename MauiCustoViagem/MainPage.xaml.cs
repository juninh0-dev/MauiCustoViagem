namespace MauiCustoViagem
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

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
            await Navigation.PushAsync(new Views.ListaPedágio());
        }
    }

}
