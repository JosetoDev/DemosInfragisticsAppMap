using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using AppMapMasterDetail.Infrastructure;

namespace AppMapMasterDetail.ViewModels
{
    public class ClientesViewModel : AppMapViewModelBase
    {


        public ClientesViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
