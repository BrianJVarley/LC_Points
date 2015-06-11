using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using LC_Points.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace LC_Points.ViewModel
{
    public class ViewSubjectGradeViewModel : ViewModelBase 
    {

              
         /// <summary>
        /// Initializes a new instance of the ViewSubjectGradeViewModel class.
        /// </summary>
        public ViewSubjectGradeViewModel()
        {

            AddedSubjectGradePairs = new ObservableCollection<ScoreModel>();
     
        }


        private ObservableCollection<ScoreModel> _addedSubjectGradePairs;
        public ObservableCollection<ScoreModel> AddedSubjectGradePairs
        {
            get { return _addedSubjectGradePairs; }
            set
            {
                if (value != _addedSubjectGradePairs)
                {
                    _addedSubjectGradePairs = value;
                    RaisePropertyChanged("AddedSubjectGradePairs");
                    
                }
            }
        }
        
    }
}
