using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class Faculty
    {
        private string id, name;
        public string getID
        {
            get { return id; }
        }
        public string getName
        {
            get { return name; }
        }

        private static List<Department> departments = new List<Department>();
        public static List<Department> GetDepartments
        {
            get
            {
                return departments;
            }
        }
        public Faculty()
        {

        }
        
        public Faculty(string name)
        {
            this.name = name;
        }
        public Faculty(string id,string name)
        {
            this.id = id;
            this.name = name;
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
        public string ToString()
        {
            return $"F Name:{name} F Id:{id}";
        }
        
       
    }
}
