using ProductosMVVMtc.Models;
using ProductosMVVMtc.Utils;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductosMVVMtc.Services
{
    public class ProductoRepository
    {
        SQLiteConnection connection;

        public ProductoRepository()
        {
            connection = new SQLiteConnection(Util.DataBasePath, Util.Flags);
            connection.CreateTable<Producto>();
        }


        public List<Producto> GetAll()
        {
            List<Producto> ListaProductos = new List<Producto>();
            try
            {
                ListaProductos = connection.Table<Producto>().ToList();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ListaProductos;
        }

        public Producto Get(int IdProducto)
        {
            Producto Producto = null;
            try
            {

                Producto = connection.Table<Producto>()
                    .FirstOrDefault(x => x.IdProducto==IdProducto);

            }catch(Exception ex)
            {
                Console.WriteLine($"Producto: {ex.Message}");
            }
            return Producto;
        }

        public void Delete(int IdProducto)
        {


            try
            {
                Producto producto=Get(IdProducto);
                connection.Delete(producto);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void Update(Producto  producto) 
        {
            try
            {
                if(producto.IdProducto != 0)
                {
                    Producto productoE = Get(producto.IdProducto);
                    connection.Update(producto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public void Add(Producto producto)
        {
            try
            {

                connection.Insert(producto);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
