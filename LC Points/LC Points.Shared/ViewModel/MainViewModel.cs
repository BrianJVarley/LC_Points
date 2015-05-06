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
        public List<KeyValuePair<string, int>> higherGradePointPair { get; set; }
        public List<KeyValuePair<string, int>> ordinaryGradePointPair { get; set; }

        
        


        public void GetOrdinaryGradePairs()
        {
            List<KeyValuePair<string, int>> ordinaryGradePointPairList = new List<KeyValuePair<string, int>>();

            ordinaryGradePointPairList.Add(new KeyValuePair<string, int>("A1", 60));
            ordinaryGradePointPairList.Add(new KeyValuePair<string, int>("A2", 50));
            ordinaryGradePointPairList.Add(new KeyValuePair<string, int>("B1", 45));
            ordinaryGradePointPairList.Add(new KeyValuePair<string, int>("B2", 40));
            ordinaryGradePointPairList.Add(new KeyValuePair<string, int>("B3", 35));
            ordinaryGradePointPairList.Add(new KeyValuePair<string, int>("C1", 30));
            ordinaryGradePointPairList.Add(new KeyValuePair<string, int>("C2", 25));
            ordinaryGradePointPairList.Add(new KeyValuePair<string, int>("C3", 20));
            ordinaryGradePointPairList.Add(new KeyValuePair<string, int>("D1", 15));
            ordinaryGradePointPairList.Add(new KeyValuePair<string, int>("D2", 10));
            ordinaryGradePointPairList.Add(new KeyValuePair<string, int>("D3", 5));
            ordinaryGradePointPairList.Add(new KeyValuePair<string, int>("E,F,NG", 0));
            ordinaryGradePointPairList.Add(new KeyValuePair<string, int>("Pass", 30));
            ordinaryGradePointPairList.Add(new KeyValuePair<string, int>("Merit", 50));
            ordinaryGradePointPairList.Add(new KeyValuePair<string, int>("Distinction", 70));

            ordinaryGradePointPair = ordinaryGradePointPairList;
        }


        public void GetHigherGradePairs()
        {
            List<KeyValuePair<string, int>> higherGradePointPairList = new List<KeyValuePair<string, int>>();

            higherGradePointPairList.Add(new KeyValuePair<string, int>("A1", 100));
            higherGradePointPairList.Add(new KeyValuePair<string, int>("A2", 90));
            higherGradePointPairList.Add(new KeyValuePair<string, int>("B1", 85));
            higherGradePointPairList.Add(new KeyValuePair<string, int>("B2", 80));
            higherGradePointPairList.Add(new KeyValuePair<string, int>("B3", 75));
            higherGradePointPairList.Add(new KeyValuePair<string, int>("C1", 70));
            higherGradePointPairList.Add(new KeyValuePair<string, int>("C2", 65));
            higherGradePointPairList.Add(new KeyValuePair<string, int>("C3", 60));
            higherGradePointPairList.Add(new KeyValuePair<string, int>("D1", 55));
            higherGradePointPairList.Add(new KeyValuePair<string, int>("D2", 50));
            higherGradePointPairList.Add(new KeyValuePair<string, int>("D3", 45));
            higherGradePointPairList.Add(new KeyValuePair<string, int>("E,F,NG", 0));
            higherGradePointPairList.Add(new KeyValuePair<string, int>("Pass", 30));
            higherGradePointPairList.Add(new KeyValuePair<string, int>("Merit", 50));
            higherGradePointPairList.Add(new KeyValuePair<string, int>("Distinction", 70));

            higherGradePointPair = higherGradePointPairList;
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