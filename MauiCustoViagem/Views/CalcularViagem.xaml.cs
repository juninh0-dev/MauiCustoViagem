using MauiCustoViagem.Models;
using System.Security.Cryptography.X509Certificates;

namespace MauiCustoViagem.Views;

public partial class CalcularViagem : ContentPage
{
	public CalcularViagem()
	{
		InitializeComponent();
	}

    private async void btn_novo_Clicked(object sender, EventArgs e)
    {
        List<Pedagio> pedagios = await App.Db.GetAll();
        foreach (Pedagio p in pedagios)
        {
            await App.Db.Delete(p.Id);
        }

        MainPage.via.Distancia = -1;
        MainPage.via.Rendimento = -1;
        MainPage.via.Origem = " ";
        MainPage.via.Preco = -1;
        MainPage.via.Destino = " ";

        await Navigation.PushAsync(new MainPage());
    }

    private async void btn_calc_Clicked(object sender, EventArgs e)
    {
        double consumo_carro = ((MainPage.via.Distancia / MainPage.via.Rendimento) * MainPage.via.Preco);
        double valor_pedagio = 0;
        double total = 0;


        List<Pedagio> pedagios = await App.Db.GetAll();
        foreach (Pedagio p in pedagios)
        {
            valor_pedagio += p.Valor;
        }

        total = consumo_carro + valor_pedagio;
        await DisplayAlert("Soma total:", $"Pedagio: {valor_pedagio.ToString("C")}\n" +
            $"Consumo: {consumo_carro.ToString("C")}\n---------\nTotal: {total.ToString("C")}", "Ok");
        lbl_valor.Text = "Valor: " + total.ToString("C");
        lbl_valor.IsVisible = true;

        lbl_origem.Text = MainPage.via.Origem;
        lbl_destino.Text = MainPage.via.Destino;
        lbl_valor.Text = total.ToString("C");
    }
}