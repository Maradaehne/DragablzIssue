using Dragablz;
using DragablzIssue.TabClient;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DragablzIssue.ViewModels
{
    public class PersonsViewModel : BindableBase
    {
        private ObservableCollection<TabItemBase> persons;


        public PersonsViewModel()
        {            
            Persons = new ObservableCollection<TabItemBase>
            {
                {new TabItemBase("Person1", new PersonViewModel("Herbert", 32)) },
                {new TabItemBase("Person2",new PersonViewModel("Hugo", 41) )},
                {new TabItemBase("Person3",new PersonViewModel("Walter", 47) )},
                {new TabItemBase("Person4",new PersonViewModel("Norbert", 21) )},
            };
        }

        public ObservableCollection<TabItemBase> Persons
        {
            get
            {
                return persons;
            }

            set
            {
                SetProperty(ref persons, value);
            }
        }
    }
}
