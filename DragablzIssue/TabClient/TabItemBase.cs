using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragablzIssue.TabClient
{
    public class TabItemBase: BindableBase
    {
        public TabItemBase(string header, object content)
        {
            TabHeader = header;
            TabContent = content;
        }

        private string tabHeader;
        public string TabHeader
        {
            get { return tabHeader; }
            set { SetProperty(ref tabHeader, value); }
        }

        private object tabContent;
        public object TabContent
        {
            get { return tabContent; }
            set { SetProperty(ref tabContent, value); }
        }
    }
}
