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
            try
            {//textBox'lardan ders id va name'ini  ve combobox1'de seçili olan bölüm adına göre ders ekleme ve listboxa yazdırma
                d.addCourse(new Course(textBox1.Text, textBox2.Text, new Department(comboBox1.SelectedItem.ToString())));

                foreach (Course course in Department.GetCourses)
                {
                    listBox1.Items.Add(course.ToString());
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addLecturerToCourse lecturerForm = new addLecturerToCourse(); //Derse öğretmen ekleme
            lecturerForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                addStudentToCourse addStudent = new addStudentToCourse(); //derse öğrenci ekleme
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
    }
}
