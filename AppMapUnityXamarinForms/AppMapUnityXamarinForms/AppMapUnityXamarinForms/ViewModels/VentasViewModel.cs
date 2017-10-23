using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using AppMapUnityXamarinForms.Infrastructure;

namespace AppMapUnityXamarinForms.ViewModels
{
    public class VentasViewModel : AppMapViewModelBase
    {


        public VentasViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
