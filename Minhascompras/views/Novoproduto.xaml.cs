namespace Minhascompras.views;
using Minhascompras.Models;
public partial class Novoproduto : ContentPage
{
	public Novoproduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        try
        {
            Produto p = new Produto
            {
                Descri��o = txt_descri��o.Text,
                Quantidade = Convert.ToDouble(txt_quantidade.Text),
                Pre�o = Convert.ToDouble(txt_pre�o.Text)
            };

            await App.db.Insert(p);
            await DisplayAlert("Sucesso!", "Registro Inserido", "OK");

        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}