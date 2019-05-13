using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class Lecturer
    {
        private string id, name;
        public string getId
        {
            get { return id; }
        }

        public string getName
        {
            get { return name; }
        }
        private Department department;
        public Department GetDepartment
        {
            get { return department; }
        }
        private Course course;
        public Course GetCourse
        {
            get { return course; }
        }

        public Lecturer()
        {

        }
        public Lecturer(string id)
        {
            this.id = id;
        }
        public Lecturer(string id, string name,Department department)
        {
            this.id = id;
            this.name = name;
            this.department = department;
        }
        public string ToString()
        {
            return $"L Name:{name} L Id:{id} Department:{department.getName}";
        }
    }
}
