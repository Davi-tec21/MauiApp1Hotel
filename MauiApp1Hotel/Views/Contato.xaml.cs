namespace MauiApp1Hotel.Views;

public partial class Contato : ContentPage
{
	public Contato()
	{
		InitializeComponent();
	}


    private void Button_Clicked_1(object sender, EventArgs e)
    {

            try
            {
                Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                DisplayAlert("Ocorreu um Problema", ex.Message, "OK");
            }
        }
    }