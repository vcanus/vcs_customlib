using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLib.Model.Repository
{
    public class CustomObjectCollection {
        // Singleton pattern 
        ////////////////////////////////////////////////////////////////////////////
        private static readonly Lazy<CustomObjectCollection> lazy =
            new Lazy<CustomObjectCollection>(() => new CustomObjectCollection());
        public static CustomObjectCollection Instance { get { return lazy.Value; } }
        ////////////////////////////////////////////////////////////////////////////

        public CustomObjectCollection()
        {
            ObjectList = new ObservableCollection<CustomObject>();
            // example
            AddObject(new CustomObject("defaultName", "defaultAddress"));
        }

        public ObservableCollection<CustomObject> ObjectList { get; }

        public void AddObject(CustomObject item)
        {
            ObjectList.Add(item);
        }

        public bool RemoveObject(CustomObject item)
        {
            return ObjectList.Remove(item);
        }
    }
}
