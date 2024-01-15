using ProductosMVVMtc.Models;
using ProductosMVVMtc.Views;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductosMVVMtc.ViewModels

     
{
    [AddINotifyPropertyChangedInterface]
    public  class ProductoViewModel
    {
       
        public ObservableCollection<Producto> ListaProductos { get; set; }

        public ProductoViewModel() 
        
        {
            
             ListaProductos = new ObservableCollection<Producto>(App.ProductoRepository.GetAll());
        }

        public ICommand CrearProducto =>
            new Command(() =>
            {
                App.Current.MainPage.Navigation.PushAsync(new NuevoProductoPage());
            });

        public async void MostrarProductos()
        {
            ListaProductos = new ObservableCollection<Producto>(App.ProductoRepository.GetAll());
        }

    }
}
