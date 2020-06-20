using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Reactive.Bindings;

namespace BlankApp5.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            
            Message = new ReactiveProperty<string>();

            InputValue = new ReactiveProperty<string>();
            InputValue.Subscribe(x => Message.Value = x == null ? "" : $"InputValue changed({x})");
        }

        public ReactiveProperty<string> Message { get; set; }
        public ReactiveProperty<string> InputValue { get; set; }
    }
}
