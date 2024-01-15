using ProductosMVVMtc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductosMVVMtc.ViewModels
{
   

    public class NuevoProductoViewModel
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }


        public ICommand GuardarProducto =>
            new Command( async () =>
            {
                Producto producto = new Producto
                {
                    Nombre = Nombre,
                    Descripcion = Descripcion,
                    Cantidad = Cantidad

                };
                App.ProductoRepository.Add(producto);
                await App.Current.MainPage.Navigation.PopAsync();
            });
    }
}   
