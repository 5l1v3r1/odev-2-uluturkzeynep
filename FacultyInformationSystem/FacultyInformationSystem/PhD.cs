using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyInformationSystem
{
    class PhD:Student
    {
        
        public PhD()
        {

        }
        public PhD(string name) : base(name)
        {

        }
        public PhD(string id, string name,Department department) : base(id,name,department)
        {
            
        }
        
        public override string ToString()
        {
            return $"S Name:{name} S Id:{id} Department:{GetDepartment.getName}";
        }
       
    }
}
