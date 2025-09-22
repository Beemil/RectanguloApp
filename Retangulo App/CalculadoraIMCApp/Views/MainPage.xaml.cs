namespace RectanguloApp.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.BindingContext = new ViewModels.RectanguloViewModel();
    }
}
