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
        public string id,name,department;
        
        public string getId
        {
            get { return id; }
        }

        public string getName
        {
            get { return name; }
        }
        
        public string getDepartment
        {
            get { return department; }
        }
        
        public Student()
        {

        } 
        public Student(string id, string name,string department)
        {
            this.id = id;
            this.name = name;
            this.department = department;
        }

        abstract public string ToString();
    }
}
