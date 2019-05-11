using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class Course
    {
        public string id, name;
        public string getId
        {
            get { return id; }
        }

        public string getName
        {
            get { return name; }
        }
        public Course()
        {

        }

        public Course(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
