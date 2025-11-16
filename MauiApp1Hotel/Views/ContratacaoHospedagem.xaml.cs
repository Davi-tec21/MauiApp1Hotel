namespace MauiApp1Hotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    private async void OnSobreButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}