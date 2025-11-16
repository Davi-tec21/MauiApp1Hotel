using Microsoft.Maui.Controls;
using MauiApp1Hotel.Views;  
namespace MauiApp1Hotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;
    public ContratacaoHospedagem()
    {
        InitializeComponent();
        PropriedadesApp = (App)Application.Current;
        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
        dtpck_Checkin.MinimumDate = DateTime.Now;
        dtpck_Checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_Checkout.MinimumDate = dtpck_Checkin.Date.AddDays(1);
        dtpck_Checkout.MaximumDate = dtpck_Checkin.Date.AddMonths(6);
    }


    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ocorreu um Problema", ex.Message, "OK");
        }

    }

    private void Dtpck_Checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;
        DateTime data_selecionada_Checkin = elemento.Date;
        dtpck_Checkout.MinimumDate = data_selecionada_Checkin.AddDays(1);
        dtpck_Checkout.MaximumDate = data_selecionada_Checkin.AddMonths(6);
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Sobre());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ocorreu um Problema", ex.Message, "OK");
        }

    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Contato());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ocorreu um Problema", ex.Message, "OK");
        }

    }

}
