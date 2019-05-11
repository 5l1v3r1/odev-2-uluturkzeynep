using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class Faculty
    {
        public string id;
        public string name;
        private static List<Department> departments = new List<Department>();
        public static List<Department> getDepartments
        {
            get { return departments; }
        }
        
        public string getId
        {
            get { return id; }
        }

        public string getName
        {
            get { return name; }
        }

        public Faculty()
        {
            //departments = new List<Department>();
        }

        public Faculty(string id,string name)
        {
            this.id = id;
            this.name = name;
            departments = new List<Department>();
        }
        public Faculty(string id)
        {
            this.id = id;
        }
       
        public void addDepartment(Department d)
        {
            try
            {
                departments.Add(d);
            }
            catch (ArgumentException a)
            {

                throw new ArgumentException("You can't add this faculty, it is already exists.");
            }
            //https://docs.microsoft.com/tr-tr/dotnet/api/system.argumentexception?view=netframework-4.8 abimin yönlendirmesi ile
        }

        public void deleteDepartment(Department d)
        {
            try
            {
                departments.Remove(d);
            }
            catch (ArgumentException a)
            {

                throw new ArgumentException("You can't delete this faculty, it doesnt exists.");
            }
        }
    
        public string ToString()
        {
            return $"Name:{name} Id:{id}";
        }

    }
}
