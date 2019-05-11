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
        public Graduate(string id, string name,string department) : base(id, name,department)
        {

        }

        public override string ToString()
        {
            return $"Name:{name} Id:{id} Department:{department}";
        }
    }
}
