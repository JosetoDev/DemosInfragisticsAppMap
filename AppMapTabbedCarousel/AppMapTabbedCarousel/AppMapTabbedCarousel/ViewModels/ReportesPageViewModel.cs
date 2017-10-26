using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using AppMapTabbedCarousel.Infrastructure;

namespace AppMapTabbedCarousel.ViewModels
{
    public class ReportesPageViewModel : AppMapViewModelBase
    {


        public ReportesPageViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
