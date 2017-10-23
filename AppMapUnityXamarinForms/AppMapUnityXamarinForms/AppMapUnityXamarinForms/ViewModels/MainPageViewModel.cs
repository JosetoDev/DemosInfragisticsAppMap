using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using AppMapUnityXamarinForms.Infrastructure;

namespace AppMapUnityXamarinForms.ViewModels
{
    public class MainPageViewModel : AppMapViewModelBase
    {


        public MainPageViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
