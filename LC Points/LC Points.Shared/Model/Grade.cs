using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LC_Points.Model
{
    class Grade : INotifyPropertyChanged
    {

        // The name of the accomplishment.
        public string Name { get; set; }

        // The type of the accomplishment, Item or Level.
        public string Type { get; set; }


        // The number of each item that has been collected.
        private int _count;
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                RaisePropertyChanged("Count");
            }
        }





        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
