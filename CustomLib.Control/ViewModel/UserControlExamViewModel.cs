using CustomLib.Model;
using CustomLib.Model.Repository;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CustomLib.Controls.ViewModel
{
    public class UserControlExamViewModel : ObservableObject 
    {
        public UserControlExamViewModel()
        {
            AddCustomObjectCommand = new RelayCommand(AddCustomObject);
        }
        public ObservableCollection<CustomObject> CustomObjects
        {
            get
            {
                return CustomObjectCollection.Instance.ObjectList;
            }
        }

        public ICommand AddCustomObjectCommand { get; }

        private string _name;
        private string _address;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string Address
        {
            get => _address;
            set => SetProperty(ref _address, value);
        }

        private void AddCustomObject()
        {
            CustomObjectCollection.Instance.AddObject(new CustomObject(Name, Address));
        }
    }
}
