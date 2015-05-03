using GalaSoft.MvvmLight;
using LC_Points.Model;
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

            
            public ObservableCollection<Grade> Grades { get; set; }

       
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}

            public void GetDefaultAccomplishments()
            {
                ObservableCollection<Grade> gradeObj = new ObservableCollection<Grade>();

                // Subjects
                gradeObj.Add(new Grade() { Name = "Accounting", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Agricultural Economics", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Agricultural Science", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Ancient Greek", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Applied Math", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Arabic", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Art", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Artistic & Creative Group", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Biology", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Business", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Business Group", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Chemistry", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Classical Studies", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Construction Studies", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Design & Comm Graphics", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Economics", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Engineering", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "English", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "French", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Geography", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "German", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Hebrew Studies", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "History", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Home Economics", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Irish", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Italian", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Japanese", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Languages & Humanities", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Latin", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Link Modules", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Mathematics", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Music", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Other Language", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Physics", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Physics & Chemistry", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Practical Group", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Religious Education", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Russian", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Science Group", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Social Group", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Spanish", Type = "Subject" });
                gradeObj.Add(new Grade() { Name = "Technology", Type = "Subject" });


                // Grades to 
                gradeObj.Add(new Grade() { Name = "A", Type = "Grade" });
                gradeObj.Add(new Grade() { Name = "A", Type = "Grade" });
                gradeObj.Add(new Grade() { Name = "B", Type = "Grade" });
                gradeObj.Add(new Grade() { Name = "B", Type = "Grade" });
                gradeObj.Add(new Grade() { Name = "B", Type = "Grade" });
                gradeObj.Add(new Grade() { Name = "C", Type = "Grade" });
                gradeObj.Add(new Grade() { Name = "C", Type = "Grade" });
                gradeObj.Add(new Grade() { Name = "C", Type = "Grade" });
                gradeObj.Add(new Grade() { Name = "D", Type = "Grade" });
                gradeObj.Add(new Grade() { Name = "D", Type = "Grade" });
                gradeObj.Add(new Grade() { Name = "D", Type = "Grade" });
                gradeObj.Add(new Grade() { Name = "E,F,NG", Type = "Grade" });
                gradeObj.Add(new Grade() { Name = "Pass", Type = "Grade" });
                gradeObj.Add(new Grade() { Name = "Merit", Type = "Grade" });
                gradeObj.Add(new Grade() { Name = "Distinction", Type = "Grade" });


                Grades = gradeObj;
                
            }

    
        }
    }
}