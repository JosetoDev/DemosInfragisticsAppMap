using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using AppMapUnityXamarinForms.Infrastructure;
using AppMapUnityXamarinForms.Services;

namespace AppMapUnityXamarinForms.ViewModels
{
    public class VentasViewModel : AppMapViewModelBase
    {
        readonly ISalesSevice _salesService;

        public VentasViewModel(INavigationService navigationService, ISalesSevice salesService) 
            : base (navigationService)
        {
            if (salesService == null)
                throw new ArgumentException(nameof(salesService));

            _salesService = salesService;
        }

        //public override void OnNavigatedTo(NavigationParameters parameters)
        //{
           
        //}

        //public override void OnNavigatingTo(NavigationParameters parameters)
        //{
        //    var data = _salesService.GetData("http://mydatasource");
        //}
    }
}
