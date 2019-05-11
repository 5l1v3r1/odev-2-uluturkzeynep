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
        public Undergraduate(string id, string name,string department) : base(id,name,department)
        {

        }
        public override string ToString()
        {
            return $"Name:{name} Id:{id} Department:{department}";
        }
    }
}
