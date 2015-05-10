using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LC_Points.Model
{
    class AboutModel : INotifyPropertyChanged
    {




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
