using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LC_Points.ViewModel
{
    class ViewSubjectGradeViewModel 
    {

        //public IEnumerable<MainViewModel> AddedSubjectGradePairsCopy = new ObservableCollection<MainViewModel>();

         /// <summary>
        /// Initializes a new instance of the ViewSubjectGradeViewModel class.
        /// </summary>
        public ViewSubjectGradeViewModel(IEnumerable<MainViewModel> AddedSubjectGradePairs)
        {
            AddedSubjectGradePairsCopy = AddedSubjectGradePairs;
           
        }


        public IEnumerable<MainViewModel> AddedSubjectGradePairsCopy { get; set; }

        



        



        

    }
}
