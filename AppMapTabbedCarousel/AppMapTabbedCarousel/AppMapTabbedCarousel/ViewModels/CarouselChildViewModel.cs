using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using AppMapTabbedCarousel.Infrastructure;

namespace AppMapTabbedCarousel.ViewModels
{
    public class CarouselChildViewModel : AppMapViewModelBase, IActiveAware
    {

#pragma warning disable 67
        public event EventHandler IsActiveChanged;
#pragma warning restore 67

        public bool IsActive { get; set; }

        public CarouselChildViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
