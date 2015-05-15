using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using LC_Points.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using System.Linq;

namespace LC_Points.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
      
  

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            //call methods to initilise list data
            InitSubjectTypes();
            InitOrdinaryGradePairs();
            InitHigherGradePairs();

            AddedSubjectGradePairs = new ObservableCollection<ScoreModel>();

        }


        public ObservableCollection<ScoreModel> AddedSubjectGradePairs { get; set; }

        public List<ScoreModel> Subjects { get; set; }
        public List<StringKeyValue> HigherGradePointKV { get; set; }
        public List<StringKeyValue> OrdinaryGradePointKV { get; set; }

        public ScoreModel SelectedSubject { get; set; }
        public StringKeyValue SelectedOrdinaryGrade { get; set; }
        public StringKeyValue SelectedHigherGrade { get; set; }





        private int _totalPoints;
        public int TotalPoints
        {
            get { return _totalPoints; }
            set
            {
                if (value != _totalPoints)
                {
                    _totalPoints = value;
                    RaisePropertyChanged("TotalPoints");
                }
            }
        }


     
        //ordinary toggle button bool
        private bool _isOrdinary;
        public bool IsOrdinary
        {
            get
            {
                return _isOrdinary;
            }
            set
            {
                _isOrdinary = value;
                RaisePropertyChanged("IsOrdinary");
            }
        }



        //Higher toggle button bool property
        private bool _isHigher;
        public bool IsHigher
        {
            get
            {
                return _isHigher;
            }
            set
            {
                _isHigher = value;
                RaisePropertyChanged("IsHigher");
            }
        }




        //Method to store Subject and Grade from Combo Boxes
        public void AddSubjectAndGrade()
        {

            string SelectedSubjectName = "null data";
            int SelectedPoints = 0;

            SelectedSubjectName = SelectedSubject.Subject;

            SelectedPoints = IsHigher ? SelectedHigherGrade.Value : SelectedOrdinaryGrade.Value;

            AddedSubjectGradePairs.Add(new ScoreModel() { Subject = SelectedSubjectName, Points = SelectedPoints });


            if(AddedSubjectGradePairs.Count == 6)
            {
                CalculateLeavingCertPoints();
            }

            
        }


        //Method to calculate the points result
        private void CalculateLeavingCertPoints()
        {

           //Logic:
            //IF 6 subjects and grades
            //add 6 grade points
            //output result of addition
            TotalPoints = AddedSubjectGradePairs.Sum(x => x.Points);

        }


       
        
        RelayCommand addGradeCommand;
        public RelayCommand AddGradeCommand
        {
            get
            {
                if (addGradeCommand == null)
                {
                    addGradeCommand = new RelayCommand(() =>
                    {
                        AddSubjectAndGrade();

                    });
                }
                return addGradeCommand;
            }
        }





        RelayCommand clearGradesCommand;
        public RelayCommand ClearGradesCommand
        {
            get
            {
                if (clearGradesCommand == null)
                {
                    clearGradesCommand = new RelayCommand(() =>
                    {
                        //call to empty collection items
                        AddedSubjectGradePairs.Clear();
                        TotalPoints = 0;

                    });
                }
                return clearGradesCommand;
            }
        }
         


        public class StringKeyValue
        {
            public string Key { get; set; }
            public int Value { get; set; }
        }


        public void InitOrdinaryGradePairs()
        {

            List<StringKeyValue> ordinaryGradePointKVTemp = new List<StringKeyValue>();


            ordinaryGradePointKVTemp.Add(new StringKeyValue { Key = "A1", Value = 60 });
            ordinaryGradePointKVTemp.Add(new StringKeyValue { Key = "A2", Value = 50 });
            ordinaryGradePointKVTemp.Add(new StringKeyValue { Key = "B1", Value = 45 });
            ordinaryGradePointKVTemp.Add(new StringKeyValue { Key = "B2", Value = 40 });
            ordinaryGradePointKVTemp.Add(new StringKeyValue { Key = "B3", Value = 35 });
            ordinaryGradePointKVTemp.Add(new StringKeyValue { Key = "C1", Value = 30 });
            ordinaryGradePointKVTemp.Add(new StringKeyValue { Key = "C2", Value = 25 });
            ordinaryGradePointKVTemp.Add(new StringKeyValue { Key = "C3", Value = 20 });
            ordinaryGradePointKVTemp.Add(new StringKeyValue { Key = "D1", Value = 15 });
            ordinaryGradePointKVTemp.Add(new StringKeyValue { Key = "D2", Value = 10 });
            ordinaryGradePointKVTemp.Add(new StringKeyValue { Key = "D3", Value = 5 });
            ordinaryGradePointKVTemp.Add(new StringKeyValue { Key = "E,F,NG", Value = 0 });
            ordinaryGradePointKVTemp.Add(new StringKeyValue { Key = "Pass", Value = 30 });
            ordinaryGradePointKVTemp.Add(new StringKeyValue { Key = "Merit", Value = 50 });
            ordinaryGradePointKVTemp.Add(new StringKeyValue { Key = "Distinction", Value = 70 });


            OrdinaryGradePointKV = ordinaryGradePointKVTemp;

        }


        public void InitHigherGradePairs()
        {

            List<StringKeyValue> higherGradePointKVTemp = new List<StringKeyValue>();


            higherGradePointKVTemp.Add(new StringKeyValue { Key = "A1", Value = 100 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "A2", Value = 90 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "B1", Value = 85 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "B2", Value = 80 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "B3", Value = 75 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "!!TestHigherGrades!!", Value = 70 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "C2", Value = 65 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "C3", Value = 60 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "D1", Value = 55 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "D2", Value = 50 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "D3", Value = 45 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "E,F,NG", Value = 0 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "Pass", Value = 30 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "Merit", Value = 50 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "Distinction", Value = 70 });


            HigherGradePointKV = higherGradePointKVTemp;
        }



        public void InitSubjectTypes()
        {
            List<ScoreModel> subjectList = new List<ScoreModel>();

            // Adding Subjects to List
            subjectList.Add(new ScoreModel { Subject = "Accounting" });
            subjectList.Add(new ScoreModel { Subject = "Agricultural Economics" });
            subjectList.Add(new ScoreModel { Subject = "Agricultural Science" });
            subjectList.Add(new ScoreModel { Subject = "Ancient Greek" });
            subjectList.Add(new ScoreModel { Subject = "Applied Math" });
            subjectList.Add(new ScoreModel { Subject = "Arabic" });
            subjectList.Add(new ScoreModel { Subject = "Art" });
            subjectList.Add(new ScoreModel { Subject = "Artistic & Creative Group" });
            subjectList.Add(new ScoreModel { Subject = "Biology" });
            subjectList.Add(new ScoreModel { Subject = "Business" });
            subjectList.Add(new ScoreModel { Subject = "Business Group" });
            subjectList.Add(new ScoreModel { Subject = "Chemistry" });
            subjectList.Add(new ScoreModel { Subject = "Classical Studies" });
            subjectList.Add(new ScoreModel { Subject = "Construction Studies" });
            subjectList.Add(new ScoreModel { Subject = "Design & Comm Graphics" });
            subjectList.Add(new ScoreModel { Subject = "Economics" });
            subjectList.Add(new ScoreModel { Subject = "Engineering" });
            subjectList.Add(new ScoreModel { Subject = "English" });
            subjectList.Add(new ScoreModel { Subject = "French" });
            subjectList.Add(new ScoreModel { Subject = "Geography" });
            subjectList.Add(new ScoreModel { Subject = "German" });
            subjectList.Add(new ScoreModel { Subject = "Hebrew Studies" });
            subjectList.Add(new ScoreModel { Subject = "History" });
            subjectList.Add(new ScoreModel { Subject = "Home Economics" });
            subjectList.Add(new ScoreModel { Subject = "Irish" });
            subjectList.Add(new ScoreModel { Subject = "Italian" });
            subjectList.Add(new ScoreModel { Subject = "Japanese" });
            subjectList.Add(new ScoreModel { Subject = "Languages & Humanities" });
            subjectList.Add(new ScoreModel { Subject = "Latin" });
            subjectList.Add(new ScoreModel { Subject = "Link Modules" });
            subjectList.Add(new ScoreModel { Subject = "Mathematics" });
            subjectList.Add(new ScoreModel { Subject = "Music" });
            subjectList.Add(new ScoreModel { Subject = "Other Language" });
            subjectList.Add(new ScoreModel { Subject = "Physics" });
            subjectList.Add(new ScoreModel { Subject = "Physics & Chemistry" });
            subjectList.Add(new ScoreModel { Subject = "Practical Group" });
            subjectList.Add(new ScoreModel { Subject = "Religious Education" });
            subjectList.Add(new ScoreModel { Subject = "Russian" });
            subjectList.Add(new ScoreModel { Subject = "Science Group" });
            subjectList.Add(new ScoreModel { Subject = "Social Group" });
            subjectList.Add(new ScoreModel { Subject = "Spanish" });
            subjectList.Add(new ScoreModel { Subject = "Technology" });

            Subjects = subjectList;

        }

    }
}