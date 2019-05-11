using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace FacultyInformationSystem
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        Department d = new Department();
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                d.addStudent(new Graduate(textBox1.Text, textBox2.Text, new Department(comboBox2.SelectedItem.ToString())));
                foreach (Graduate student in Department.GetStudents)
                {
                    listBox1.Items.Add(student.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                d.addStudent(new Undergraduate(textBox1.Text, textBox2.Text, new Department(comboBox2.SelectedItem.ToString())));
                foreach (Undergraduate student in Department.GetStudents)
                {
                    listBox2.Items.Add(student.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                d.addStudent(new PhD(textBox1.Text, textBox2.Text, new Department(comboBox2.SelectedItem.ToString())));
                foreach (PhD student in Department.GetStudents)
                {
                    listBox3.Items.Add(student.ToString());
                }
            }
            LessonsForm lessonsForm = new LessonsForm();
            lessonsForm.Show();
           
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            foreach (Department department in Faculty.GetDepartments) //https://www.frmtr.com/c-/4643411-listbox-daki-degeri-comboboxa-aktarma-yardim.html
            {
                comboBox2.Items.Add(department.getName.ToString());
            }
        }
    }
}
