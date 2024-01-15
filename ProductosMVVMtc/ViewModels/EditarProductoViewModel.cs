using ProductosMVVMtc.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductosMVVMtc.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    class EditarProductoViewModel
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public Producto ProductoActual { get; set; }

        public EditarProductoViewModel(Producto Producto)
        {
            if (Producto != null)
            {
                Nombre = Producto.Nombre;
                Descripcion = Producto.Descripcion;
                Cantidad = Producto.Cantidad;
                ProductoActual = Producto;
            }

        }


        public ICommand EditarProducto =>
            new Command(async () =>
            {
                Producto producto = new Producto
                {
                    Nombre = Nombre,
                    Descripcion = Descripcion,
                    Cantidad = Cantidad,
                    IdProducto = ProductoActual.IdProducto //llama a 1 producto por id para editar 
                };
                App.ProductoRepository.Update(producto);
                await App.Current.MainPage.Navigation.PopAsync();
            });


    }
}
