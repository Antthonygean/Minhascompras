namespace Minhascompras.views;

public partial class Listaproduto : ContentPage
{
	public Listaproduto()
	{
		InitializeComponent();
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
}