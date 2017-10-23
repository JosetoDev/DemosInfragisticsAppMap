using AppMapUnityXamarinForms.ViewModels;
using AppMapUnityXamarinForms.Views;
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
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage, MainPageViewModel>();
            Container.RegisterTypeForNavigation<Ventas, VentasViewModel>();
        }
    }
}
