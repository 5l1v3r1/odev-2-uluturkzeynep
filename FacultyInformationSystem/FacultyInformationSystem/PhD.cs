using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class PhD:Student
    {
        public PhD()
        {

        }
        public PhD(string id, string name,string department) : base(id,name,department)
        {
            
        }

        public override string ToString()
        {
            return $"Name:{name} Id:{id} Department{department}";
        }
    }
}
