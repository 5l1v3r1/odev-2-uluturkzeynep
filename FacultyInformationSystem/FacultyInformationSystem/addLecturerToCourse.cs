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
    public partial class addLecturerToCourse : Form
    {
        public addLecturerToCourse()
        {
            InitializeComponent();
        }

        private void addLecturerToCourse_Load(object sender, EventArgs e)
        {
            comboBox3.Visible = false;
            comboBox1.Items.Clear();
            foreach (Course course in Department.GetCourses) //ilgili dersin bölümünü comboBox'ta seçenek olarak seçilebilmesi için
            {
                comboBox1.Items.Add(course.GetDepartment.getName.ToString());
                if (comboBox3.SelectedItem != null)
                {
                    this.Text = comboBox3.SelectedItem.ToString() + " Lecturers";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            comboBox2.Items.Clear();
            foreach (Lecturer lecturer in Department.GetLecturers)
            {
                if (comboBox1.SelectedItem.ToString().Contains(lecturer.GetDepartment.getName))
                {
                    comboBox2.Items.Add(lecturer.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(comboBox2.SelectedItem.ToString() + " Course: "+comboBox3.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("You didnt select a lecturer or Course.");
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
                if (comboBox1.SelectedItem.ToString().Contains(course.GetDepartment.getName))
                    comboBox3.Items.Add(course.getName);
            }
        }
    }
}
