using GalaSoft.MvvmLight.Ioc;
using LC_Points.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using LC_Points.Services;

namespace LC_Points.ViewModel
{
    public class ViewSubjectGradeViewModel
    {
        private readonly IRepository<ScoreModel> _repository = App.ScoresRepository;

        /// <summary>
        /// Initializes a new instance of the ViewSubjectGradeViewModel class.
        /// </summary>
        public ViewSubjectGradeViewModel()
        {

        }


        public ObservableCollection<ScoreModel> AddedSubjectGradePairs
        {
            get { return _repository.Collection; }
        }
    }
}
