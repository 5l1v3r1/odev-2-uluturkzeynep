using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class Department
    {
        private string id, name;
        private Faculty faculty;
        public Faculty GetFaculty
        {
            get { return faculty; }
        }

        private Course course;
        public Course GetCourse
        {
            get { return course; }
        }
        private Student student;
        public Student GetStudent
        {
            get { return student; }
        }
        private Lecturer lecturer;
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

        public Department(string name)
        {
            this.name = name;
        }

        public Department(string id,string name)
        {
            this.id = id;
            this.name = name;
        }

        public Department(string id,string name,Faculty faculty)
        {
            this.id = id;
            this.name = name;
            this.faculty = faculty;
        }


        public Department(Course course)
        {
            
        }

        private static List<Course> courses = new List<Course>();
        public static List<Course> GetCourses
        {
            get
            {
                return courses;
            }
        }

        public void addCourse(Course c)
        {
            try
            {
                courses.Add(c);
            }
            catch (ArgumentException a)
            {

                throw new ArgumentException("You can't add this course, it is already exists.");
            }
            
        }

        private static List<Student> students = new List<Student>();
        public static List<Student> GetStudents
        {
            get
            {
                return students;
            }
        }

        public void addStudent(Student s)
        {
            try
            {
                students.Add(s);
            }
            catch (ArgumentException a)
            {

                throw new ArgumentException("You can't add this student, it is already exists.");
            }
           
        }

        private static List<Lecturer> lecturers = new List<Lecturer>();
        public static List<Lecturer> GetLecturers
        {
            get
            {
                return lecturers;
            }
        }

        public void addLecturer(Lecturer l)
        {
            try
            {
                lecturers.Add(l);
            }
            catch (ArgumentException a)
            {

                throw new ArgumentException("You can't add this course, it is already exists.");
            }
            
        }

        public void deleteLecturer(Lecturer l)
        {
            try
            {
                lecturers.Remove(l);
            }
            catch (ArgumentException a)
            {

                throw new ArgumentException("You can't delete this course, it doesnt exists.");
            }
        }

        public string ToString()
        {
            return $"D Name:{name} D Id:{id} Faculty:{faculty.getName}"; 
        }

        public string toString()
        {
            return $"D Name:{name}";
        }

    }
}
