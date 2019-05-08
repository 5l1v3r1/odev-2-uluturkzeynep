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

        }

        public Faculty(int id,string name)
        {
            this.id = id;
            this.name = name;
            departments = new List<Department>();
        }
       
        public void addDepartment(Department d)
        {
            departments.Add(d);
        }


    }
}
