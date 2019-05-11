using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class Department
    {
        public string id, name;
        public string getID
        {
            get { return id; }
        }
        public string getName
        {
            get { return name; }
        }

        public Department()
        {

        }

        public Department(string id,string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
