using ProductosMVVMtc.Models;
using ProductosMVVMtc.Views;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace ProductosMVVMtc.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class DetalleProductoViewModel
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public Producto ProductoActual { get; set; }


        public DetalleProductoViewModel(Producto Producto)
        {
            if (Producto != null)
            {
                Nombre = Producto.Nombre;
                Descripcion = Producto.Descripcion;
                Cantidad = Producto.Cantidad;
                ProductoActual = Producto;
            }

        }


        public async void MostrarProductos()
        {
            Producto proctoeditado = App.ProductoRepository.Get(ProductoActual.IdProducto);
            Nombre = proctoeditado.Nombre;
            Descripcion = proctoeditado.Descripcion;
            Cantidad = proctoeditado.Cantidad;
            ProductoActual = proctoeditado;

        }




        public ICommand Borrar =>
              new Command(async () =>
              {

                  App.ProductoRepository.Delete(ProductoActual.IdProducto);
                  await App.Current.MainPage.Navigation.PopAsync();

              });


        public ICommand EditarProducto =>
            new Command(async () =>
            {

                await App.Current.MainPage.Navigation.PushAsync(new EditarProductoPage(ProductoActual));
            });

    }
}