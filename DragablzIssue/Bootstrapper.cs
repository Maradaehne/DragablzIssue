using Microsoft.Practices.ServiceLocation;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Dragablz;
using DragablzIssue.TabClient;
using DragablzIssue.Views;
using Prism.Modularity;

namespace DragablzIssue
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<Shell>();
        }
        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            // When using MEF, the existing Prism ModuleCatalog is still
            // the place to configure modules via configuration files.
            return new ConfigurationModuleCatalog();
        }
    }

    public static class TabInfrastructure
    {
        static TabInfrastructure()
        {
            TabClient = new MyInterTabClient();
        }

        public static IInterTabClient TabClient { get; }
    }
}
