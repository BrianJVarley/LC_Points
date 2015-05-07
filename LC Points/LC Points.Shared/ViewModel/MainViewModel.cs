using GalaSoft.MvvmLight;
using LC_Points.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
            GetSubjectTypes();
            GetOrdinaryGradePairs();
            GetHigherGradePairs();
        }


        public List<Score> Subjects { get; set; }
        public List<StringKeyValue> HigherGradePointKV { get; set; }
        public List<StringKeyValue> OrdinaryGradePointKV { get; set; }

        //public List<StringKeyValue> GradePointKV { get { return IsOrdinaryToggled ? OrdinaryGradePointKV : HigherGradePointKV; } }


        //ordinary toggle button bool
        private bool _isOrdinaryToggled;
        public bool IsOrdinaryToggled
        {
            get
            {
                return _isOrdinaryToggled;
            }
            set
            {
                _isOrdinaryToggled = value;
                RaisePropertyChanged("IsOrdinaryToggled");
                //RaisePropertyChanged("GradePointKV");
            }
        }

        //Higher toggle button bool property
        private bool _isHigherToggled;
        public bool IsHigherToggled
        {
            get
            {
                return _isHigherToggled;
            }
            set
            {
                _isHigherToggled = value;
                RaisePropertyChanged("IsHigherToggled");
                //RaisePropertyChanged("GradePointKV");
            }
        }




        public class StringKeyValue
        {
            public string Key { get; set; }
            public int Value { get; set; }
        }


        public void GetOrdinaryGradePairs()
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


        public void GetHigherGradePairs()
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



        public void GetSubjectTypes()
        {
            List<Score> subjectList = new List<Score>();

            // Adding Subjects to List
            subjectList.Add(new Score { Subject = "Accounting" });
            subjectList.Add(new Score { Subject = "Agricultural Economics" });
            subjectList.Add(new Score { Subject = "Agricultural Science" });
            subjectList.Add(new Score { Subject = "Ancient Greek" });
            subjectList.Add(new Score { Subject = "Applied Math" });
            subjectList.Add(new Score { Subject = "Arabic" });
            subjectList.Add(new Score { Subject = "Art" });
            subjectList.Add(new Score { Subject = "Artistic & Creative Group" });
            subjectList.Add(new Score { Subject = "Biology" });
            subjectList.Add(new Score { Subject = "Business" });
            subjectList.Add(new Score { Subject = "Business Group" });
            subjectList.Add(new Score { Subject = "Chemistry" });
            subjectList.Add(new Score { Subject = "Classical Studies" });
            subjectList.Add(new Score { Subject = "Construction Studies" });
            subjectList.Add(new Score { Subject = "Design & Comm Graphics" });
            subjectList.Add(new Score { Subject = "Economics" });
            subjectList.Add(new Score { Subject = "Engineering" });
            subjectList.Add(new Score { Subject = "English" });
            subjectList.Add(new Score { Subject = "French" });
            subjectList.Add(new Score { Subject = "Geography" });
            subjectList.Add(new Score { Subject = "German" });
            subjectList.Add(new Score { Subject = "Hebrew Studies" });
            subjectList.Add(new Score { Subject = "History" });
            subjectList.Add(new Score { Subject = "Home Economics" });
            subjectList.Add(new Score { Subject = "Irish" });
            subjectList.Add(new Score { Subject = "Italian" });
            subjectList.Add(new Score { Subject = "Japanese" });
            subjectList.Add(new Score { Subject = "Languages & Humanities" });
            subjectList.Add(new Score { Subject = "Latin" });
            subjectList.Add(new Score { Subject = "Link Modules" });
            subjectList.Add(new Score { Subject = "Mathematics" });
            subjectList.Add(new Score { Subject = "Music" });
            subjectList.Add(new Score { Subject = "Other Language" });
            subjectList.Add(new Score { Subject = "Physics" });
            subjectList.Add(new Score { Subject = "Physics & Chemistry" });
            subjectList.Add(new Score { Subject = "Practical Group" });
            subjectList.Add(new Score { Subject = "Religious Education" });
            subjectList.Add(new Score { Subject = "Russian" });
            subjectList.Add(new Score { Subject = "Science Group" });
            subjectList.Add(new Score { Subject = "Social Group" });
            subjectList.Add(new Score { Subject = "Spanish" });
            subjectList.Add(new Score { Subject = "Technology" });

            Subjects = subjectList;

        }

    }
}