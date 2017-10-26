using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using AppMapMasterDetail.Infrastructure;

namespace AppMapMasterDetail.ViewModels
{
    public class VentasViewModel : AppMapViewModelBase
    {


        public VentasViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
