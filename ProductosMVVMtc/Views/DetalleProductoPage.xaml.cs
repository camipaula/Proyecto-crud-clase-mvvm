using ProductosMVVMtc.Models;
using ProductosMVVMtc.ViewModels;

namespace ProductosMVVMtc.Views;

public partial class DetalleProductoPage : ContentPage
{

    private readonly DetalleProductoViewModel _vModel;
    public DetalleProductoPage(Producto Producto)
	{
        InitializeComponent();
        _vModel = new DetalleProductoViewModel(Producto);
        BindingContext = _vModel;
    }

    protected override async void OnAppearing() //se actualizan los datos
    {
        base.OnAppearing();
        _vModel.MostrarProductos();
    }



}