using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismXamlNavigationBugRepro.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public List<MyModel> MyModels { get; } = new List<MyModel>
        {
            new MyModel(),
            new MyModel(),
            new MyModel()
        };

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}
