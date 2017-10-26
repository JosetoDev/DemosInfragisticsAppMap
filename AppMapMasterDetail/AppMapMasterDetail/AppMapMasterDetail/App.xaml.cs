using AppMapMasterDetail.ViewModels;
using AppMapMasterDetail.Views;
using Prism.Unity;
using Xamarin.Forms;

namespace AppMapMasterDetail
{
    public partial class App : PrismApplication
    {

        public App() : this(null) { }

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("MainPage/NavigationPage/Clientes");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage, MainPageViewModel>();
            Container.RegisterTypeForNavigation<Clientes, ClientesViewModel>();
            Container.RegisterTypeForNavigation<Ventas, VentasViewModel>();
            Container.RegisterTypeForNavigation<Graficos, GraficosViewModel>();
        }
    }
}
