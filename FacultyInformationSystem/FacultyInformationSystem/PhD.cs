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
        private Department department;
        public Department GetDepartment
        {
            get { return department; }
        }
        public PhD()
        {

        }
        public PhD(string id, string name,Department department) : base(id,name,department)
        {
            
        }
        Department d = new Department();
        public override string ToString()
        {
            return $"Name:{name} Id:{id}";
        }
       
    }
}
