using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using AppMapTabbedCarousel.Infrastructure;

namespace AppMapTabbedCarousel.ViewModels
{
    public class CarouselViewModel : AppMapViewModelBase
    {


        public CarouselViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
