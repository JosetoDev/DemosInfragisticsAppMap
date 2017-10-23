using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using AppMapIntro.Infrastructure;

namespace AppMapIntro.Views
{
    public class VentasViewModel : AppMapViewModelBase
    {


        public VentasViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
