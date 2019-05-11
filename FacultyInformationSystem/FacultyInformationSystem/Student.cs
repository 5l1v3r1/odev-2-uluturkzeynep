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
        public Student(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
