using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class Undergraduate:Student
    {
        private Department department;
        public Department GetDepartment
        {
            get { return department; }
        }

        public Undergraduate()
        {

        }
        public Undergraduate(string id, string name,Department department) : base(id,name,department)
        {

        }
        Department d = new Department();
        public override string ToString()
        {
            return $"Name:{name} Id:{id}";
        }
       
    }
}
