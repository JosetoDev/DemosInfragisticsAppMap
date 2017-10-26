using AppMapTabbedCarousel.ViewModels;
using AppMapTabbedCarousel.Views;
using Prism.Unity;
using Xamarin.Forms;

namespace AppMapTabbedCarousel
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
            Container.RegisterTypeForNavigation<ReportesPage, ReportesPageViewModel>();
            Container.RegisterTypeForNavigation<VentasPage, VentasPageViewModel>();
            Container.RegisterTypeForNavigation<RendimientoPage, RendimientoPageViewModel>();
            Container.RegisterTypeForNavigation<ConsolidadoPage, ConsolidadoPageViewModel>();
            Container.RegisterTypeForNavigation<Carousel, CarouselViewModel>();
            Container.RegisterTypeForNavigation<CarouselChild, CarouselChildViewModel>();
            Container.RegisterTypeForNavigation<CarouselChild1, CarouselChild1ViewModel>();
            Container.RegisterTypeForNavigation<CarouselChild2, CarouselChild2ViewModel>();
        }
    }
}
