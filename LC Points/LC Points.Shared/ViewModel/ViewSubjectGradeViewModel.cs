using GalaSoft.MvvmLight.Ioc;
using LC_Points.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LC_Points.ViewModel
{
    public class ViewSubjectGradeViewModel 
    {

              
         /// <summary>
        /// Initializes a new instance of the ViewSubjectGradeViewModel class.
        /// </summary>
        public ViewSubjectGradeViewModel()
        {

            AddedSubjectGradePairs = new ObservableCollection<ScoreModel>();
     
        }


        public ObservableCollection<ScoreModel> AddedSubjectGradePairs { get; set; }       
        
    }
}
