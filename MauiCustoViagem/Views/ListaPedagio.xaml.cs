using MauiCustoViagem.Models;
using System.Collections.ObjectModel;
namespace MauiCustoViagem.Views;

public partial class ListaPedagio : ContentPage
{
    ObservableCollection<Pedagio> lista_pedagio =
    new ObservableCollection<Pedagio>();
    public ListaPedagio()
	{
		InitializeComponent();
		lst_pedagio.ItemsSource = lista_pedagio;
	}

    protected async override void OnAppearing()
    {
        if (lista_pedagio.Count == 0)
        {

            List<Pedagio> tmp = await App.Db.GetAll();
            foreach (Pedagio p in tmp)
            {
                lista_pedagio.Add(p);
            }
        } // Fecha if
    } // Fecha classe
}