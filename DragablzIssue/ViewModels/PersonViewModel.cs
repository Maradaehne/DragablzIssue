using Dragablz;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DragablzIssue
{
    public class PersonViewModel : BindableBase
    {
        private IInterTabClient interTabClient;

        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        private uint age;
        public uint Age
        {
            get { return age; }
            set { SetProperty(ref age, value); }
        }

        public IInterTabClient InterTabClient
        {
            get
            {
                return interTabClient;
            }

            set
            {
                SetProperty(ref interTabClient, value);
            }
        }

        public PersonViewModel(string name, uint age)
        {
            Name = name;
            Age = age;
        }
    }
}
