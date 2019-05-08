using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class University
    {

        public List<Faculty> faculties=new List<Faculty>();
        //public List<Faculty> Faculties
        //{
        //    get
        //    {
        //        return faculties;
        //    }
        //    set
        //    {
        //        faculties = value;
        //    }
        //}

        public University()
        {
            faculties = new List<Faculty>(); //Lab9 ve http://gokalpsnotes.blogspot.com/2016/01/cda-list-kullanm.html
        }

        public void addFaculty(Faculty f)
        {
            try
            {
                faculties.Add(f);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("You can't add this faculty, it is already exists.");
            }
             //https://docs.microsoft.com/tr-tr/dotnet/api/system.argumentexception?view=netframework-4.8 abimin yönlendirmesi ile
        }

        public void deleteFaculty(Faculty f)
        {
            try
            {
                faculties.Remove(f);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("You can't delete this faculty, it doesnt exists.");
            }
        }
    }
}
