using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class Department
    {

        private string faculty;
        public string getFaculty
        {
            get { return faculty; }
        }

        private static List<Course> courses = new List<Course>();
        public static List<Course> getCourses
        {
            get { return courses; }
        }
        private static List<Undergraduate> undergraduates = new List<Undergraduate>();
        public static List<Undergraduate> GetUndergraduates
        {
            get { return undergraduates; }
        }

        private static List<Graduate> graduates = new List<Graduate>();
        public static List<Graduate> GetGraduates
        {
            get { return graduates; }
        }

        private static List<PhD> phDs = new List<PhD>();
        public static List<PhD> GetPhDs
        {
            get { return phDs; }
        }
        private static List<Lecturer> lecturers = new List<Lecturer>();
        public static List<Lecturer> GetLecturers
        {
            get { return lecturers; }
        }

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
        University u=new University();
        public Department(string id,string name,string faculty)
        {
            this.id = id;
            this.name = name;
            this.faculty = faculty;
        }

        public Department(string id)
        {
            this.id = id;
        }

        public void addCourse(Course c)
        {
            try
            {
                
                courses.Add(c);
                
            }
            catch (ArgumentException a)
            {

                throw new ArgumentException("You can't add this faculty, it is already exists.");
            }
        }

        public void deleteCourse(Course c)
        {
            try
            {
                courses.Remove(c);
            }
            catch (ArgumentException a)
            {

                throw new ArgumentException("You can't delete this faculty, it doesnt exists.");
            }
        }

        public void addLecturer(Lecturer lecturer)
        {
            try
            {
                lecturers.Add(lecturer);
            }
            catch (ArgumentException a)
            {

                throw new ArgumentException("You can't add this faculty, it is already exists.");
            }
        }

        public void deleteLecturer(Lecturer lecturer)
        {
            try
            {
                lecturers.Add(lecturer);
            }
            catch (ArgumentException a)
            {

                throw new ArgumentException("You can't delete this faculty, it doesnt exists.");
            }
        }

        public string toString()
        {
            return $"Department Name:{name} Department Id:{id} Faculty:{faculty}";
        }

    }
}
