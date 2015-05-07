using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LC_Points.Model
{
    public class Score : INotifyPropertyChanged
    {

        // The name of the subject.
        public string Subject { get; set; }

        // The type of Grade, eg, A, B2 etc..
        public string Grade { get; set; }

        // The points paired with each grade type.
        public int Points { get; set; }

        private int _count;

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                this._count = value;
                this.RaisePropertyChanged("Count");
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
