using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using AppMapMasterDetail.Infrastructure;

namespace AppMapMasterDetail.ViewModels
{
    public class GraficosViewModel : AppMapViewModelBase
    {


        public GraficosViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
