using ProductosMVVMtc.Services;
using ProductosMVVMtc.Views;

namespace ProductosMVVMtc
{
    public partial class App : Application
    {
        public static ProductoRepository ProductoRepository { get; set; }
        public App()
        {
            InitializeComponent();
            ProductoRepository = new ProductoRepository();
            MainPage = new NavigationPage(new ProductoPage());
        }
    }
}
