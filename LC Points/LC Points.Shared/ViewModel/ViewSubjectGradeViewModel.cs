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

         
        public ViewSubjectGradeViewModel()
        {
            

        }

         /// <summary>
        /// Initializes a new instance of the ViewSubjectGradeViewModel class.
        /// </summary>
        public ViewSubjectGradeViewModel(IEnumerable<ScoreModel> addedSubjectGradePairs)
        {
            this.AddedSubjectGradePairsCopy = addedSubjectGradePairs;
           
        }


        //Property for collection passed from MainViewModel
        public IEnumerable<ScoreModel> AddedSubjectGradePairsCopy { get; set; }

        
    }
}
