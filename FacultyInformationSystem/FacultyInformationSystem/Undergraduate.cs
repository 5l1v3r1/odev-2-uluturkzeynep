using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class Undergraduate:Student
    {
        
        public Undergraduate()
        {

        }
        public Undergraduate(string name):base(name)
        {

        }
        public Undergraduate(string id, string name,Department department) : base(id,name,department)
        {

        }
        Department d = new Department();
        public override string ToString()
        {
            return $"S Name:{name} S Id:{id} Department:{GetDepartment.getName}";
        }
       
    }
}
