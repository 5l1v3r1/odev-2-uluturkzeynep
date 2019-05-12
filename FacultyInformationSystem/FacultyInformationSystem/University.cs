using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class University
    {
        private static List<Faculty> faculties = new List<Faculty>();
        public static List<Faculty> GetFaculties{
            get { return faculties; }
            }
        private University()
        {
            faculties = new List<Faculty>();
        }
        private static University university;
        public static University GetUniversity()
        {
            if (university == null)
            {
                university = new University();
            }
            return university;
        }
        
        public void addFaculty(Faculty f)
        {
            try
            {
                faculties.Add(f);
            }
            catch (ArgumentException a)
            {

                throw new ArgumentException("You can't add this faculty, it is already exists.");
            }
            //https://docs.microsoft.com/tr-tr/dotnet/api/system.argumentexception?view=netframework-4.8 abimin yönlendirmesi ile
        }

    }
}
