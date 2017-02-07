using DragablzIssue.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DragablzIssue.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        private IRegionManager regionManager;

        public ShellViewModel(IRegionManager regionManager)
        {
            this. regionManager = regionManager;
            regionManager.RegisterViewWithRegion("MainRegion", typeof(PersonsView));
        }
    }
}
