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
                addStudentToCourse addStudent = new addStudentToCourse();
                addStudent.Show();
                this.Hide();
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
        addLecturerToCourse add;
        addStudentToCourse addS;
        private void button1_Click(object sender, EventArgs e)
        {//https://www.kodlamamerkezi.com/c-net/c-ile-dosya-okuma-ve-yazma-islemleri/
            FileStream fileStream = new FileStream(@"./AboutCourse.txt",FileMode.OpenOrCreate);
            StreamWriter sW = new StreamWriter(fileStream);
            
            foreach(Course c in Department.GetCourses)
            {
                
                sW.WriteLine("Course->" + c.getName);
                if (c.getName.Contains(add.listBox1.Items.ToString()))
                {
                    foreach (Lecturer l in Department.GetLecturers)
                    {
                        if (l.GetCourse == c.GetCourse)
                            sW.WriteLine("Lecturer->" + l.getId + l.getName);
                    }
                }
                if (c.GetCourse.getName.ToString().Contains(addS.listBox1.Items.ToString()))
                {
                    foreach (Student s in Department.GetStudents)
                    {
                        if (s.GetCourse == c.GetCourse)
                            sW.WriteLine("Student->" + s.getId + s.getName);
                    }
                }
                    
            }
            sW.Close();
            fileStream.Close();
        }
    }
}
