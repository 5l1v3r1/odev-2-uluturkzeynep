using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyInformationSystem
{
    public partial class LessonsForm : Form
    {
        public LessonsForm()
        {
            InitializeComponent();
        }

        private void LessonsForm_Load(object sender, EventArgs e)
        {
            foreach (Department department in Faculty.GetDepartments) 
            {
                comboBox1.Items.Add(department.getName.ToString());
            }
        }
        Department d = new Department();
        private void button2_Click(object sender, EventArgs e)
        {
            d.addCourse(new Course(textBox1.Text, textBox2.Text,new Department(comboBox1.SelectedItem.ToString())));
            
            foreach (Course course in Department.GetCourses)
            {
                listBox1.Items.Add(course.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addLecturerToCourse lecturerForm = new addLecturerToCourse();
            lecturerForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                addStudentToCourse addStudent = new addStudentToCourse();
                addStudent.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You didnt pick a Course from list.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DepartmentForm departmentForm = new DepartmentForm();
            departmentForm.Show(); this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {//https://www.kodlamamerkezi.com/c-net/c-ile-dosya-okuma-ve-yazma-islemleri/
            FileStream fileStream = new FileStream(@"./AboutCourse.txt",FileMode.OpenOrCreate);
            StreamWriter sW = new StreamWriter(fileStream);
            
            foreach(Course c in Department.GetCourses)
            {
                sW.WriteLine("Course->" + c.getName);
                foreach(Lecturer l in Department.GetLecturers)
                {
                    if(l.GetDepartment.GetCourse==c.GetDepartment.GetCourse)
                    sW.WriteLine("Lecturer->" +l.getId + l.getName);
                }
                foreach(Student s in Department.GetStudents)
                {
                    if(s.GetDepartment.GetCourse==c.GetDepartment.GetCourse)
                    sW.WriteLine("Student->" + s.getId + s.getName);
                }
            }
            sW.Close();
            fileStream.Close();
        }
    }
}
