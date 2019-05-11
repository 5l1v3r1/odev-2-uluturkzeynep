using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace FacultyInformationSystem
{
    abstract class Student
    {
        public string id,name;
        private Department department;
        public Department GetDepartment
        {
            get { return department; }
        }

        public string getId
        {
            get { return id; }
        }

        public string getName
        {
            get { return name; }
        }
        
        
        public Student()
        {

        } 
        public Student(string name)
        {
            this.name = name;
        }
        public Student(string id, string name,Department department)
        {
            this.id = id;
            this.name = name;
            this.department = department;
        }

        abstract public string ToString();
        
    }
}
