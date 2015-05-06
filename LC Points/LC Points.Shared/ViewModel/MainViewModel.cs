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
            GetGradeTypes();
            GetSubjectTypes();
            GetOrdinaryGradePairs();
        }


        public List<Grade> grades { get; set; }
        public List<Grade> subjects { get; set; }
        public List<StringKeyValue> higherGradePointKV { get; set; }
        public List<StringKeyValue> ordinaryGradePointKV { get; set; }





        public class StringKeyValue
        {
            public string Key { get; set; }
            public int Value { get; set; }
        }


        public void GetOrdinaryGradePairs()
        {

            List<StringKeyValue> ordianryGradePointKVTemp = new List<StringKeyValue>();


            ordianryGradePointKVTemp.Add(new StringKeyValue { Key = "A1", Value = 60 });
            ordianryGradePointKVTemp.Add(new StringKeyValue { Key = "A2", Value = 50 });
            ordianryGradePointKVTemp.Add(new StringKeyValue { Key = "B1", Value = 45 });
            ordianryGradePointKVTemp.Add(new StringKeyValue { Key = "B2", Value = 40 });
            ordianryGradePointKVTemp.Add(new StringKeyValue { Key = "B3", Value = 35 });
            ordianryGradePointKVTemp.Add(new StringKeyValue { Key = "C1", Value = 30 });
            ordianryGradePointKVTemp.Add(new StringKeyValue { Key = "C2", Value = 25 });
            ordianryGradePointKVTemp.Add(new StringKeyValue { Key = "C3", Value = 20 });
            ordianryGradePointKVTemp.Add(new StringKeyValue { Key = "D1", Value = 15 });
            ordianryGradePointKVTemp.Add(new StringKeyValue { Key = "D2", Value = 10 });
            ordianryGradePointKVTemp.Add(new StringKeyValue { Key = "D3", Value = 5 });
            ordianryGradePointKVTemp.Add(new StringKeyValue { Key = "E,F,NG", Value = 0 });
            ordianryGradePointKVTemp.Add(new StringKeyValue { Key = "Pass", Value = 30 });
            ordianryGradePointKVTemp.Add(new StringKeyValue { Key = "Merit", Value = 50 });
            ordianryGradePointKVTemp.Add(new StringKeyValue { Key = "Distinction", Value = 70 });


            ordinaryGradePointKV = ordianryGradePointKVTemp;

        }


        public void GetHigherGradePairs()
        {
           
            List<StringKeyValue> higherGradePointKVTemp = new List<StringKeyValue>();


            higherGradePointKVTemp.Add(new StringKeyValue { Key = "A1", Value = 100 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "A2", Value = 90 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "B1", Value = 85 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "B2", Value = 80 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "B3", Value = 75 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "C1", Value = 70 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "C2", Value = 65 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "C3", Value = 60 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "D1", Value = 55 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "D2", Value = 50 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "D3", Value = 45 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "E,F,NG", Value = 0 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "Pass", Value = 30 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "Merit", Value = 50 });
            higherGradePointKVTemp.Add(new StringKeyValue { Key = "Distinction", Value = 70 });


            higherGradePointKV = higherGradePointKVTemp;
        }
    
        
        public void GetGradeTypes()
        {
            List<Grade> gradeList = new List<Grade>();

            // Adding Grades to List
            gradeList.Add(new Grade { grade = "A1" });
            gradeList.Add(new Grade { grade = "A2" });
            gradeList.Add(new Grade { grade = "B1" });
            gradeList.Add(new Grade { grade = "B2" });
            gradeList.Add(new Grade { grade = "B3" });
            gradeList.Add(new Grade { grade = "C1" });
            gradeList.Add(new Grade { grade = "C2" });
            gradeList.Add(new Grade { grade = "C3" });
            gradeList.Add(new Grade { grade = "D1" });
            gradeList.Add(new Grade { grade = "D2" });
            gradeList.Add(new Grade { grade = "D3" });
            gradeList.Add(new Grade { grade = "E,F,NG" });
            gradeList.Add(new Grade { grade = "Pass" });
            gradeList.Add(new Grade { grade = "Merit" });
            gradeList.Add(new Grade { grade = "Distinction" });


            grades = gradeList;

        }


        public void GetSubjectTypes()
        {
            List<Grade> subjectList = new List<Grade>();

            // Adding Subjects to List
            subjectList.Add(new Grade { subject = "Accounting" });
            subjectList.Add(new Grade { subject = "Agricultural Economics" });
            subjectList.Add(new Grade { subject = "Agricultural Science" });
            subjectList.Add(new Grade { subject = "Ancient Greek" });
            subjectList.Add(new Grade { subject = "Applied Math" });
            subjectList.Add(new Grade { subject = "Arabic" });
            subjectList.Add(new Grade { subject = "Art" });
            subjectList.Add(new Grade { subject = "Artistic & Creative Group" });
            subjectList.Add(new Grade { subject = "Biology" });
            subjectList.Add(new Grade { subject = "Business" });
            subjectList.Add(new Grade { subject = "Business Group" });
            subjectList.Add(new Grade { subject = "Chemistry" });
            subjectList.Add(new Grade { subject = "Classical Studies" });
            subjectList.Add(new Grade { subject = "Construction Studies" });
            subjectList.Add(new Grade { subject = "Design & Comm Graphics" });
            subjectList.Add(new Grade { subject = "Economics" });
            subjectList.Add(new Grade { subject = "Engineering" });
            subjectList.Add(new Grade { subject = "English" });
            subjectList.Add(new Grade { subject = "French" });
            subjectList.Add(new Grade { subject = "Geography" });
            subjectList.Add(new Grade { subject = "German" });
            subjectList.Add(new Grade { subject = "Hebrew Studies" });
            subjectList.Add(new Grade { subject = "History" });
            subjectList.Add(new Grade { subject = "Home Economics" });
            subjectList.Add(new Grade { subject = "Irish" });
            subjectList.Add(new Grade { subject = "Italian" });
            subjectList.Add(new Grade { subject = "Japanese" });
            subjectList.Add(new Grade { subject = "Languages & Humanities" });
            subjectList.Add(new Grade { subject = "Latin" });
            subjectList.Add(new Grade { subject = "Link Modules" });
            subjectList.Add(new Grade { subject = "Mathematics" });
            subjectList.Add(new Grade { subject = "Music" });
            subjectList.Add(new Grade { subject = "Other Language" });
            subjectList.Add(new Grade { subject = "Physics" });
            subjectList.Add(new Grade { subject = "Physics & Chemistry" });
            subjectList.Add(new Grade { subject = "Practical Group" });
            subjectList.Add(new Grade { subject = "Religious Education" });
            subjectList.Add(new Grade { subject = "Russian" });
            subjectList.Add(new Grade { subject = "Science Group" });
            subjectList.Add(new Grade { subject = "Social Group" });
            subjectList.Add(new Grade { subject = "Spanish" });
            subjectList.Add(new Grade { subject = "Technology" });

            subjects = subjectList;

        }

    }
}