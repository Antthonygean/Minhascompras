using System.Collections.ObjectModel;
using Minhascompras.Models;

namespace Minhascompras.views;

public partial class Listaproduto : ContentPage
{
    ObservableCollection<Produto> lista = new ObservableCollection<Produto>();
    

    public Listaproduto()
	{
		InitializeComponent();

        lst_produtos.ItemsSource = lista;
    }

    protected async override void OnAppearing()
    {
        List<Produto> tmp = await App.db.GetAll();

        tmp.ForEach(i => lista.Add(i));
    }
    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
            Navigation.PushAsync(new views.Novoproduto());

        }catch (Exception ex)		
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private async void txt_search_TextChanged(object sender, TextChangedEventArgs e)
    {
        string q = e.NewTextValue;
        
        lista.Clear();

        List<Produto> tmp = await App.db.Search(q);

        tmp.ForEach(i => lista.Add(i));
    }

    private void ToolbarItem_Clicked_1(object sender, EventArgs e)
    {
       double soma = lista.Sum(i => i.Total);

        string msg = $"O Total é {soma:c}";

        DisplayAlert("Total de Produtos",msg, "OK"); 
    }

    private void MenuItem_Clicked(object sender, EventArgs e)
    {

    }
}