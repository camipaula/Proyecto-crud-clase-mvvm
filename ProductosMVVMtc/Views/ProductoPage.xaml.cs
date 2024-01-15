using ProductosMVVMtc.Models;
using ProductosMVVMtc.ViewModels;

namespace ProductosMVVMtc.Views;

public partial class ProductoPage : ContentPage
{

    private readonly ProductoViewModel _vModel;
    public ProductoPage()
	{
		InitializeComponent();
        _vModel = new ProductoViewModel();
        BindingContext = _vModel;
    }


    protected override async void OnAppearing() //se actualizan los datos
    {
        base.OnAppearing();
        _vModel.MostrarProductos();
    }


    private async void detalleLista(object sender, SelectedItemChangedEventArgs e)
    {

        Producto producto = e.SelectedItem as Producto;
        await Navigation.PushAsync(new DetalleProductoPage(producto));

    }
}