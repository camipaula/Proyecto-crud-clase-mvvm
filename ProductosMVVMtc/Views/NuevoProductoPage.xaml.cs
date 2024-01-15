using ProductosMVVMtc.ViewModels;

namespace ProductosMVVMtc.Views;

public partial class NuevoProductoPage : ContentPage
{
	public NuevoProductoPage()
	{
		InitializeComponent();
        BindingContext = new NuevoProductoViewModel();
    }
}