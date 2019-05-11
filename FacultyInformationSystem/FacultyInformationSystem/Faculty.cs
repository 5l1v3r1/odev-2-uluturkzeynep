using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class Faculty
    {
        public int id;
        public string name;
        public List<Department> departments;
        public int getId
        {
            get { return id; }
        }

        public string getName
        {
            get { return name; }
        }

        public Faculty()
        {
            departments = new List<Department>();
        }

        public Faculty(int id,string name)
        {
            this.id = id;
            this.name = name;
            departments = new List<Department>();
        }
        public Faculty(int id)
        {
            this.id = id;
        }
       
        public void addDepartment(Department d)
        {
            try
            {
                departments.Add(d);
            }
            catch (ArgumentException)
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
            catch (ArgumentException)
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
