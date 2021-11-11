using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLib.Model
{
    public class CustomObject : ObservableObject
    {
        public CustomObject(string name, string address) 
        {
            Name = name;
            Address = address;
        }
        private string _name;
        private string _address;

        public string Name { 
            get => _name; 
            set => SetProperty(ref _name, value); }
        public string Address { 
            get => _address;
            set => SetProperty(ref _address, value); 
        }
    }
}
