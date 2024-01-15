using ProductosMVVMtc.Models;
using ProductosMVVMtc.ViewModels;

namespace ProductosMVVMtc.Views;

public partial class EditarProductoPage : ContentPage
{
	public EditarProductoPage(Producto producto)
	{
		InitializeComponent();
        BindingContext = new EditarProductoViewModel(producto);
    }


}