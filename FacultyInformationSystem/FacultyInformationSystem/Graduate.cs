using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class Graduate:Student
    {
        
        public Graduate()
        {

        }
        public Graduate(string name):base(name)
        {

        }
        public Graduate(string id, string name, Department department) : base(id, name,department)
        {

        }
        Department d = new Department();
        public override string ToString()
        {
            return $"S Id:{id} S Name:{name} Department:{GetDepartment.getName}";
        }
        

    }
}
