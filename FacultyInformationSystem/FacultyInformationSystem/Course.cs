﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class Course
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

        public Course()
        {

        }

        public Course(string id,string name,Department department)
        {
            this.id = id;
            this.name = name;
            this.department = department;
        }

        public string ToString()
        {
            return $"D Name:{name} D Id:{id} Department:{department.getName}";
        }
    }
}
