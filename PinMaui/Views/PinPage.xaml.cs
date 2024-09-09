using PinMaui.ViewModels;

namespace PinMaui.Views;

public partial class PinPage : ContentPage
{    
    private PinViewModel _viewModel;

    public PinPage()
    {
        InitializeComponent();
        BindingContext = _viewModel = new PinViewModel();
    }
    private void OpenKeyboard(object sender, EventArgs e)
    {
        hiddenEntry.Focus();
        _viewModel.Focus();
    }  

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.OnAppearing();
    }

    private void btnOk_Clicked(object sender, EventArgs e)
    {
        Shell.Current.DisplayAlert(hiddenEntry.Text, null, "Ok");
    }

    //private void hiddenEntry_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    _viewModel.PinsChange(hiddenEntry.Text);        
    //}
}