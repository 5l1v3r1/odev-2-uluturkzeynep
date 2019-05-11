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

        

        public Department(string id,string name)
        {
            this.id = id;
            this.name = name;
        }

        public Department(string id)
        {
            this.id = id;
        }

        public void addCourse()
        {

        }

        public void deleteCourse()
        {

        }

        public void addLecturer()
        {

        }

        public void deleteLecturer()
        {

        }

        public string ToString()
        {
            return $"Name:{name} Id:{id}";
        }

    }
}
