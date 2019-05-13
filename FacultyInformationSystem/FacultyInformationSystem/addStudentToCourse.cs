using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyInformationSystem
{
    public partial class addStudentToCourse : Form
    {
        public addStudentToCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            listBox1.Items.Add(comboBox2.SelectedItem.ToString()+" Course "+comboBox3.SelectedItem.ToString());
        }

        private void addStudentToCourse_Load(object sender, EventArgs e)
        {
            comboBox3.Visible = false;
            comboBox1.Items.Clear();
            foreach (Course course in Department.GetCourses) //https://www.frmtr.com/c-/4643411-listbox-daki-degeri-comboboxa-aktarma-yardim.html
            {
                comboBox1.Items.Add(course.GetDepartment.getName.ToString());
                if (comboBox3.SelectedItem != null)
                {
                    this.Text = comboBox3.SelectedItem.ToString() + " Students";
                }
               
            }
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            comboBox2.Items.Clear();
            foreach (Student student in Department.GetStudents)
            {
                if (comboBox1.SelectedItem.ToString().Contains(student.GetDepartment.getName))
                {
                    comboBox2.Items.Add(student.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DepartmentForm departmentForm = new DepartmentForm();
            departmentForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LessonsForm lessonsForm = new LessonsForm();
            lessonsForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LecturerForm lecturerForm = new LecturerForm();
            lecturerForm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Visible = true;
            comboBox3.Items.Clear();
            foreach (Course course in Department.GetCourses) //https://www.frmtr.com/c-/4643411-listbox-daki-degeri-comboboxa-aktarma-yardim.html
            {
                if(comboBox1.SelectedItem.ToString().Contains(course.GetDepartment.getName))
                comboBox3.Items.Add(course.getName);
            }
        }
    }
}
