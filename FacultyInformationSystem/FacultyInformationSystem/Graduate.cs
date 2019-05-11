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
        public Graduate(string id, string name, Department department) : base(id, name,department)
        {

        }
        Department d = new Department();
        public override string ToString()
        {
            return $"Id:{id} Name:{name}";
        }
        

    }
}
