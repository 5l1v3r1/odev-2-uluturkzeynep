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
    public partial class LecturerForm : Form
    {
        public LecturerForm()
        {
            InitializeComponent();
        }

        Department d = new Department();
        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {
            foreach (Department department in Faculty.GetDepartments)
            {
                comboBox1.Items.Add(department.getName.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d.addLecturer(new Lecturer(textBox1.Text, textBox2.Text, new Department(comboBox1.SelectedItem.ToString())));
            listBox1.Items.Clear();
            foreach (Lecturer lecturer in Department.GetLecturers)
            {
                listBox1.Items.Add(lecturer.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d.deleteLecturer(new Lecturer(textBox2.Text));
            listBox1.Items.Clear();
            foreach (Lecturer lecturer in Department.GetLecturers)
            {
                listBox1.Items.Remove(lecturer.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.Show(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DepartmentForm departmentForm = new DepartmentForm();
            departmentForm.Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LessonsForm lessonsForm = new LessonsForm();
            lessonsForm.Show(); this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show(); this.Hide();
        }
    }
}
