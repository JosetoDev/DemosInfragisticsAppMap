using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using AppMapUnityXamarinForms.Infrastructure;

namespace AppMapUnityXamarinForms.ViewModels
{
    public class nuevaViewModel : AppMapViewModelBase
    {
        //TOOD:  Developer add constructor with required arguments for your view model base class.
        public nuevaViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
           
        }
    }
}
