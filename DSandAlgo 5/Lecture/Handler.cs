using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace DSandAlgo_5.Lecture
{
    internal class Handler
    {
        private ObservableCollection<string> collection;

        public Handler()
        {
            collection = new ObservableCollection<string>();
            collection.CollectionChanged += HandleChange;
        }

        public void Add(string newItem)
        {
            collection.Add(newItem);
        }

        public void Remove(string newItem)
        {
            collection.Remove(newItem);
        }

        private void HandleChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Remove ||
                e.Action == NotifyCollectionChangedAction.Move ||
                e.Action == NotifyCollectionChangedAction.Replace)
            {
                foreach (var y in e.OldItems)
                {
                    // do something
                }
            }

            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                // do something
                foreach (var x in e.NewItems)
                {
                    // do something
                }
            }
        }
    }
}
