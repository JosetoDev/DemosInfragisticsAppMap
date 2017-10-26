using AppMapUnityXamarinForms.Services;
using AppMapUnityXamarinForms.ViewModels;
using AppMapUnityXamarinForms.Views;
using Microsoft.Practices.Unity;
using Prism.Unity;
using Xamarin.Forms;

namespace AppMapUnityXamarinForms
{
    public partial class App : PrismApplication
    {

        public App() : this(null) { }

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            //services
           Container.RegisterType<IDataSource, DataSource>();
           Container.RegisterType<ISalesSevice, SalesSevice>();


            //Container.Register<IAuthenticationService, AuthenticationService>(Reuse.Singleton);
            ///Container.RegisterType<IDataSource, DataSource>(new ContainerControlledLifetimeManager());

            //framework
            Container.RegisterTypeForNavigation<NavigationPage>();

            //pages
            Container.RegisterTypeForNavigation<MainPage, MainPageViewModel>();
            Container.RegisterTypeForNavigation<Ventas, VentasViewModel>();
            Container.RegisterTypeForNavigation<nueva, nuevaViewModel>();
        }
    }
}
