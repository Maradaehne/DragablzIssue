using Dragablz;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DragablzIssue.TabClient
{
    public class MyInterTabViewModel : BindableBase
    {
        private IInterTabClient interTabClient;
        public IInterTabClient InterTabClient
        {
            get { return interTabClient; }
            set { SetProperty(ref interTabClient, value); }
        }

        private object partition;
        //private ObservableCollection<PersonViewModel> _items;

        public object Partition
        {
            get { return partition; }
            set { SetProperty(ref partition, value); }
        }

        //public ObservableCollection<PersonViewModel> Items
        //{
        //    get
        //    {
        //        return _items;
        //    }

        //    set
        //    {
        //        SetProperty(ref _items, value);
        //    }
        //}

        public MyInterTabViewModel(IInterTabClient client, object partition/*, params PersonViewModel[] items*/)
        {
            InterTabClient = client;
            Partition = partition;
            //_items = new ObservableCollection<PersonViewModel>(items);
        }
    }
}
