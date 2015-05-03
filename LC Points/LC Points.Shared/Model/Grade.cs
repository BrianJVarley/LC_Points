using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LC_Points.Model
{
    public class Grade : INotifyPropertyChanged
    {

        // The name of the subject.
        public string subject { get; set; }

        // The type of Grade, eg, A, B2 etc..
        public string grade { get; set; }

        // The points paired with each grade type.
        public int points { get; set; }


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
