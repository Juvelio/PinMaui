using PinMaui.ViewModels;

namespace PinMaui.Views;

public partial class PinPage : ContentPage
{
    //public PinPage()
    //{
    //	InitializeComponent();
    //}
    private PinViewModel _viewModel;

    public PinPage()
    {
        InitializeComponent();
        BindingContext = _viewModel = new PinViewModel();
    }
    private void OpenKeyboard(object sender, EventArgs e)
    {
        //hiddenEntry.Focus();
        _viewModel.Focus();
    }

    //private void OnButtonClicked(object sender, EventArgs e)
    //{
    //    OpenKeyboard();
    //}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.OnAppearing();
    }


    //private void hiddenEntry_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    _viewModel.PinsChange(hiddenEntry.Text);        
    //}
}